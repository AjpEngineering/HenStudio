<#
-- --------------------------------------------------------------------------------
--  SCRIPT: CombineHenStudioScripts
--  File  : CombineHenStudioScripts.ps1
-- --------------------------------------------------------------------------------
--  Description: 
--    Script to combine HensStudio SQL files into single CREATE 
--    and SEED scripts for embedding.
-- ================================================================================
-- 
-- !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
--                                                                               !!
--           A        JJJJJJJJ  PPPPPPP         EEEEEEE  NN     NN   GGGGGG      !!
--          AAA          JJ     PP    PP        EE       NNN    NN  GG    GG     !!
--         AA AA         JJ     PP    PP        EE       NNNN   NN  GG           !!
--        AA   AA        JJ     PPPPPP          EEEEEEE  NN NN  NN  GG   GGGG    !!
--       AAAAAAAA   JJ   JJ     PP              EE       NN  NN NN  GG    GG     !!
--      AA      AA  JJ   JJ     PP              EE       NN    NNN  GG    GG     !!
--     AA        AA  JJJJJJ     PP              EEEEEEE  NN     NN   GGGGGG      !!
--                                                                               !!
-- !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
--    (c)Copyright 2026 AJP Engineering
--    All rights reserved.
-- ================================================================================
--  HISTORY:
--    06/01/26 .. AJP Engineering .. Version 1.0 : SQLite Version
-- ================================================================================
#>

<#
.SYNOPSIS
	Combine HenStudio SQL files into single CREATE and SEED scripts for embedding.

.DESCRIPTION
	Scans sibling Create/Seed folders (sorted by filename), concatenates files
	into two outputs: 00_create_all_henstudio.sql and 01_seed_all_henstudio.sql
	under the Build\Output folder. Adds simple headers and wraps each output
	with PRAGMA foreign_keys = ON; BEGIN TRANSACTION; ... COMMIT;

.USAGE
	From the repository root (PowerShell):
	  & ".\_HenModel\Database\HenStudio\Scripts\Build\CombineHenStudioScripts.ps1"

	Or run with explicit PowerShell:
	  powershell -ExecutionPolicy Bypass -File ".\_HenModel\Database\HenStudio\Scripts\Build\CombineHenStudioScripts.ps1"
#>

param()

try {
	$createDir = Join-Path $PSScriptRoot '..\Create'
	$seedDir   = Join-Path $PSScriptRoot '..\Seed'
	$outputDir = Join-Path $PSScriptRoot 'Output'

	if (-not (Test-Path $createDir)) { Write-Host "Create folder not found: $createDir"; exit 0 }
	if (-not (Test-Path $seedDir))   { Write-Host "Seed folder not found:   $seedDir"; exit 0 }

	New-Item -ItemType Directory -Force -Path $outputDir | Out-Null

	$createFiles = Get-ChildItem -Path $createDir -Filter '*.sql' -File | Sort-Object Name
	$seedFiles   = Get-ChildItem -Path $seedDir   -Filter '*.sql' -File | Sort-Object Name

	$outCreate = Join-Path $outputDir '00_create_all_henstudio.sql'
	$outSeed   = Join-Path $outputDir '01_seed_all_henstudio.sql'

	function Write-Header($path, $title) {
		$header = @(
			"-- -----------------------------------------------------------------------------",
			"-- $title",
			"-- Generated: $(Get-Date -Format u)",
			"-- Source folder: $PSScriptRoot",
			"-- -----------------------------------------------------------------------------",
			""
		) -join "`r`n"
		$header | Out-File -FilePath $path -Encoding UTF8 -Force
	}

	# Function: Trim leading/trailing comment blocks (/* ... */) and single-line headers/footers (--)
	function Trim-CommentHeaderFooter([string]$txt) {
		if (-not $txt) { return $txt }
		# Normalize newlines
		$txt = $txt -replace "\r\n", "`n"
		$lines = $txt -split "`n"
		# Remove leading block comment /* ... */ if present
		if ($lines.Count -gt 0 -and $lines[0] -match "^\s*/\*") {
			$startIdx = 0
			for ($i = 0; $i -lt $lines.Count; $i++) {
				if ($lines[$i] -match "\*/") { $startIdx = $i + 1; break }
			}
			if ($startIdx -lt $lines.Count) { $lines = $lines[$startIdx..($lines.Count - 1)] } else { $lines = @() }
		} else {
			# Remove leading single-line comments (--) and blank lines
			while ($lines.Count -gt 0 -and $lines[0] -match "^\s*(--|$)") {
				$lines = $lines[1..($lines.Count - 1)]
			}
		}
		# Remove trailing block comment /* ... */ if present
		if ($lines.Count -gt 0 -and $lines[-1] -match "\*/\s*$") {
			$endIdx = $lines.Count - 1
			for ($i = $lines.Count - 1; $i -ge 0; $i--) {
				if ($lines[$i] -match "^\s*/\*") { $endIdx = $i - 1; break }
			}
			if ($endIdx -ge 0) { $lines = $lines[0..$endIdx] } else { $lines = @() }
		} else {
			# Remove trailing single-line comments (--) and blank lines
			while ($lines.Count -gt 0 -and $lines[-1] -match "^\s*(--|$)") {
				$lines = $lines[0..($lines.Count - 2)]
			}
		}
		# Rejoin using CRLF for output
		return ($lines -join "`r`n")
	}

	# Create combined CREATE script
	Write-Header -path $outCreate -title 'Combined CREATE script for HenStudio'
	if ($createFiles.Count -gt 0) {
		"PRAGMA foreign_keys = ON;`r`nBEGIN TRANSACTION;`r`n" | Out-File -FilePath $outCreate -Encoding UTF8 -Append
		foreach ($f in $createFiles) {
			"`r`n-- Start: $($f.Name)`r`n" | Out-File -FilePath $outCreate -Encoding UTF8 -Append
			# Read and trim header/footer comment blocks from the individual file
			$content = Get-Content -Path $f.FullName -Raw -Encoding UTF8

			$trimmed = Trim-CommentHeaderFooter $content
			$trimmed | Out-File -FilePath $outCreate -Encoding UTF8 -Append
			"`r`n-- End: $($f.Name)`r`n" | Out-File -FilePath $outCreate -Encoding UTF8 -Append
		}
		"`r`nCOMMIT;`r`n" | Out-File -FilePath $outCreate -Encoding UTF8 -Append
	} else {
		Write-Host "No CREATE files found in $createDir"
	}

	# Create combined SEED script
	Write-Header -path $outSeed -title 'Combined SEED script for HenStudio'
	if ($seedFiles.Count -gt 0) {
		"PRAGMA foreign_keys = ON;`r`nBEGIN TRANSACTION;`r`n" | Out-File -FilePath $outSeed -Encoding UTF8 -Append
		foreach ($f in $seedFiles) {
			"`r`n-- Start: $($f.Name)`r`n" | Out-File -FilePath $outSeed -Encoding UTF8 -Append
			# Read and trim header/footer comment blocks from the individual file
			$content = Get-Content -Path $f.FullName -Raw -Encoding UTF8
			$trimmed = Trim-CommentHeaderFooter $content
			$trimmed | Out-File -FilePath $outSeed -Encoding UTF8 -Append
			"`r`n-- End: $($f.Name)`r`n" | Out-File -FilePath $outSeed -Encoding UTF8 -Append
		}
		"`r`nCOMMIT;`r`n" | Out-File -FilePath $outSeed -Encoding UTF8 -Append
	} else {
		Write-Host "No SEED files found in $seedDir"
	}

	Write-Host "Generated files:"; Write-Host "  $outCreate"; Write-Host "  $outSeed"
} catch {
	Write-Error "Failed to build combined scripts: $_"
	exit 1
}

#  ================================================================================
#  ---------------------------  E N D   O F   F I L E  ----------------------------
#  ================================================================================
