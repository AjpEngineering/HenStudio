<#
.SYNOPSIS
  Convert SQL Server CREATE TABLE .sql files under _HenStudioDatabase\Tables into SQLite-compatible .sql files,
  preserving folder structure under a target Tables_SQLite folder.

.DESCRIPTION
  - Scans a source directory recursively for *.sql files.
  - Applies conservative token/DDL transformations to convert SQL Server table DDL to SQLite-compatible DDL.
  - Writes converted files keeping the relative path into the output directory and appends ".sqlite.sql" to filenames.
  - Does NOT attempt to convert stored procedures or complex T-SQL. Review outputs before use.
  - Recommended workflow: run against a copy of the Tables folder, inspect results, then refine replacements as needed.

.PARAMETER SourceDir
  Root folder containing SQL Server .sql files (default: ..\_HenStudioDatabase\Tables relative to script location).

.PARAMETER OutDir
  Destination root folder for converted SQLite .sql files (default: ..\_HenStudioDatabase\Tables_SQLite relative to script location).

.PARAMETER WhatIfAction
  When present, script lists actions that would be taken but does not write files.

.EXAMPLE
  # Default run (from repository root or tools folder)
  .\tools\ConvertSqlServerToSqlite.ps1

.EXAMPLE
  .\tools\ConvertSqlServerToSqlite.ps1 -SourceDir 'C:\_AJP\git\HenStudio\_HenStudioDatabase\Tables' -OutDir 'C:\_AJP\git\HenStudio\_HenStudioDatabase\Tables_SQLite'

.NOTES
  - This script is a starting point. Manual review and small edits of the generated files are expected.
  - It is safe to run multiple times; existing files will be overwritten unless using -WhatIfAction.
#>

param(
    [string] $SourceDir = (Join-Path $PSScriptRoot '..\_HenStudioDatabase\Tables' | Resolve-Path -ErrorAction SilentlyContinue).ProviderPath,
    [string] $OutDir    = (Join-Path $PSScriptRoot '..\_HenStudioDatabase\Tables_SQLite' | Resolve-Path -ErrorAction SilentlyContinue).ProviderPath,
    [switch] $WhatIfAction
)

if (-not $SourceDir) {
    Write-Error "SourceDir not provided and default path not resolvable. Provide -SourceDir explicitly."
    exit 1
}

if (-not (Test-Path $SourceDir)) {
    Write-Error "SourceDir '$SourceDir' does not exist."
    exit 1
}

if (-not $OutDir) {
    $OutDir = Join-Path (Split-Path $SourceDir -Parent) 'Tables_SQLite'
}

# Create output folder if needed
if (-not (Test-Path $OutDir)) {
    if ($WhatIfAction) {
        Write-Host "[WhatIf] Would create output directory: $OutDir"
    } else {
        New-Item -ItemType Directory -Path $OutDir -Force | Out-Null
    }
}

$files = Get-ChildItem -Path $SourceDir -Filter *.sql -Recurse

if ($files.Count -eq 0) {
    Write-Host "No .sql files found under $SourceDir"
    exit 0
}

$converted = 0
$skipped = 0

foreach ($file in $files) {
    $relPath = $file.FullName.Substring($SourceDir.Length).TrimStart('\','/')
    $outPath = Join-Path $OutDir $relPath

    # ensure directory exists
    $outDirPath = Split-Path $outPath -Parent
    if (-not (Test-Path $outDirPath)) {
        if ($WhatIfAction) {
            Write-Host "[WhatIf] Would create folder: $outDirPath"
        } else {
            New-Item -ItemType Directory -Path $outDirPath -Force | Out-Null
        }
    }

    # read SQL
    try {
        $sql = Get-Content -Raw -Encoding UTF8 -Path $file.FullName
    } catch {
        Write-Warning "Failed to read $($file.FullName): $_"
        $skipped++
        continue
    }

    $original = $sql

    # Normalize line endings
    $sql = $sql -replace "`r`n", "`n"

    # Remove SQL Server batch separators
    $sql = [regex]::Replace($sql, '^\s*GO\s*$', '', [System.Text.RegularExpressions.RegexOptions]::IgnoreCase -bor [System.Text.RegularExpressions.RegexOptions]::Multiline)

    # Basic token mappings (case-insensitive)
    $mappings = @(
        @{p='(\[dbo\]\.)'; r=''},                                        # remove schema prefix
        @{p='\[([^\]]+)\]'; r='$1'},                                     # remove square brackets
        @{p='\bUNIQUEIDENTIFIER\b'; r='TEXT'},                           # GUID -> TEXT
        @{p='NVARCHAR\s*\(\s*max\s*\)'; r='TEXT'},                       # NVARCHAR(max) -> TEXT
        @{p='NVARCHAR\s*\(\s*\d+\s*\)'; r='TEXT'},                       # NVARCHAR(n) -> TEXT
        @{p='\bNCHAR\s*\(\s*\d+\s*\)'; r='TEXT'},                         # NCHAR(n) -> TEXT
        @{p='\bVARCHAR\s*\(\s*max\s*\)'; r='TEXT'},
        @{p='\bVARCHAR\s*\(\s*\d+\s*\)'; r='TEXT'},
        @{p='\bINT\b'; r='INTEGER'},
        @{p='\bTINYINT\b'; r='INTEGER'},
        @{p='\bBIGINT\b'; r='INTEGER'},
        @{p='\bSMALLINT\b'; r='INTEGER'},
        @{p='\bBIT\b'; r='INTEGER'},
        @{p='\bFLOAT\b'; r='REAL'},
        @{p='\bREAL\b'; r='REAL'},
        @{p='\bDECIMAL\s*\([^\)]+\)'; r='NUMERIC'},
        @{p='\bNUMERIC\s*\([^\)]+\)'; r='NUMERIC'},
        @{p='\bMONEY\b'; r='NUMERIC'},
        @{p='\bSMALLMONEY\b'; r='NUMERIC'},
        @{p='\bDATETIME2\b'; r='TEXT'},
        @{p='\bDATETIMEOFFSET\b'; r='TEXT'},
        @{p='\bDATETIME\b'; r='TEXT'},
        @{p='\bSMALLDATETIME\b'; r='TEXT'},
        @{p='DEFAULT\s+NEWID\(\)'; r=''},                                 # drop NEWID default (generate GUID in app)
        @{p='DEFAULT\s+GETDATE\(\)'; r=''},                               # drop SQL Server default date
        @{p='\bPRIMARY\s+KEY\s+CLUSTERED\b'; r='PRIMARY KEY'},           # drop clustered
        @{p='\bCLUSTERED\b'; r=''},                                       # remove clustered tokens
        @{p='ON\s+\[PRIMARY\]'; r=''},                                    # remove filegroup hints
        @{p='WITH\s*\(\s*PAD_INDEX[^\)]*\)'; r=''},                       # remove index options
        @{p='WITH\s*\(\s*STATISTICS_NORECOMPUTE[^\)]*\)'; r=''},
        @{p='COLLATE\s+[a-zA-Z0-9_]+'; r=''}                              # remove collations
    )

    foreach ($map in $mappings) {
        $sql = [regex]::Replace($sql, $map.p, $map.r, [System.Text.RegularExpressions.RegexOptions]::IgnoreCase)
    }

    # Handle identity columns -> AUTOINCREMENT heuristic:
    # Replace patterns like: Id INTEGER IDENTITY(1,1) NOT NULL  => Id INTEGER PRIMARY KEY AUTOINCREMENT
    $sql = [regex]::Replace($sql,
        '(?im)^\s*([A-Za-z0-9_]+)\s+INTEGER\s+IDENTITY\s*\(\s*1\s*,\s*1\s*\)\s+NOT\s+NULL\s*,?',
        '$1 INTEGER PRIMARY KEY AUTOINCREMENT,'
    )

    # If table defines ID as INT IDENTITY but PK is declared later separately, try to convert the column and remove the later PK constraint's CLUSTERED text handled earlier.
    # Remove DEFAULT GETUTCDATE/GETDATE occurrences (already removed), remove leftover empty DEFAULTs
    $sql = $sql -replace 'DEFAULT\s+\(\s*\)', ''

    # Convert separate PK constraint lines to SQLite form if simple:
    # CONSTRAINT PK_Name PRIMARY KEY (Id)  -> PRIMARY KEY(Id)
    $sql = [regex]::Replace($sql, '(?im)CONSTRAINT\s+[^\s]+\s+PRIMARY\s+KEY\s*\(([^)]+)\)\s*,?', 'PRIMARY KEY($1)', [System.Text.RegularExpressions.RegexOptions]::IgnoreCase)

    # Convert FK constraint format:
    # CONSTRAINT FK_Name FOREIGN KEY (Col) REFERENCES Table(Col) -> FOREIGN KEY (Col) REFERENCES Table(Col)
    $sql = [regex]::Replace($sql, '(?im)CONSTRAINT\s+[^\s]+\s+FOREIGN\s+KEY\s*\(([^)]+)\)\s+REFERENCES\s+([^\(]+)\s*\(([^)]+)\)\s*,?', 'FOREIGN KEY ($1) REFERENCES $2($3)', [System.Text.RegularExpressions.RegexOptions]::IgnoreCase)

    # Remove schema qualifiers left (dbo.) (should be removed earlier)
    $sql = $sql -replace '\bdbo\.', ''

    # Remove identity leftover tokens and other SQL Server-specific constructs
    $sql = $sql -replace '\bIDENTITY\s*\([^\)]*\)', ''
    $sql = $sql -replace '\bROWGUIDCOL\b', ''

    # Remove "DEFAULT (GETDATE())" or similar left-overs
    $sql = [regex]::Replace($sql, 'DEFAULT\s*\([^\)]*\)', '', [System.Text.RegularExpressions.RegexOptions]::IgnoreCase)

    # Remove trailing commas before closing parenthesis
    $sql = $sql -replace ',\s*\)', "`n)"

    # Tidy up multiple blank lines
    $sql = [regex]::Replace($sql, "(\r?\n){3,}", "`n`n")

    # If the file contains "CREATE TABLE schema.TableName" make sure "CREATE TABLE TableName"
    $sql = [regex]::Replace($sql, '(?im)CREATE\s+TABLE\s+[^\(]+\(', 'CREATE TABLE (', [System.Text.RegularExpressions.RegexOptions]::IgnoreCase)

    # Final safety: replace any occurrences of "PRIMARY KEY ( Id )" spaced oddly
    $sql = $sql -replace '\(\s*([A-Za-z0-9_]+)\s*\)', '($1)'

    # Determine output file name: append .sqlite.sql
    $outFileName = [IO.Path]::ChangeExtension($outPath, ".sqlite.sql")

    if ($WhatIfAction) {
        Write-Host "[WhatIf] Would write converted file: $outFileName"
        $converted++
    } else {
        try {
            # Write UTF8 without BOM
            $bytes = [System.Text.Encoding]::UTF8.GetBytes($sql)
            [System.IO.File]::WriteAllBytes($outFileName, $bytes)
            Write-Host "Converted: $($file.FullName) -> $outFileName"
            $converted++
        } catch {
            Write-Warning "Failed to write $outFileName : $_"
            $skipped++
        }
    }
}

Write-Host "Conversion complete. Files converted: $converted. Files skipped: $skipped."
Write-Host "Review files under: $OutDir"
Write-Host "Important: Manually inspect PK/FK lines, GENERATED GUID defaults, datetime defaults, CHECK constraints and any T-SQL constructs not covered by this script."