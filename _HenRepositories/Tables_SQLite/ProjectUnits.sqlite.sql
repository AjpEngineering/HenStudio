-- ============================================================================
--  Table: ProjectUnits
--  File : ProjectUnits.sqlite.sql
-- ============================================================================
--
--  Description:
--    Contains EXTERNAL Project Units parameters.
--    Parent entity is Project. Leaf entity.
--    ProjectUnits contains default EXTERNAL units for the project.
--    
--    ProjectUnits includes fields for ...
--      + PK (GUID)
--      + Project ID (FK) GUID
--      + Default System Units (SI|Imperial)
--      + Default Magnitude Units (Base|Kilo|Mega)
--      + Default Temperature Units (C|F|K|R)
--      + Default Pressure Units (Pa|kPa|MPa|bar|kBar|MBar|psia|psig|psf|atm|inHg|inH2O) 
--
-- ============================================================================
--  (c)Copyright 2026 AJP Engineering
--  All rights reserved.
-- ============================================================================
--  HISTORY:
--    01/01/26 .. AJP Engineering .. Version 1.0 : SQL Server Version
--    06/01/26 .. AJP Engineering .. Version 1.1 : SQLite Version
-- ================================================================================

CREATE TABLE ProjectUnits (
    Id                      TEXT NOT NULL,
    ProjectId               TEXT NOT NULL,
    DefaultSystemUnits      TEXT NOT NULL DEFAULT 'Metric - SI',
    DefaultMagnitudeUnits   TEXT NOT NULL DEFAULT 'Base',
    DefaultTemperatureUnits TEXT NOT NULL DEFAULT 'K',
    DefaultPressureUnits    TEXT NOT NULL DEFAULT 'Pa',

    PRIMARY KEY(Id),
	FOREIGN KEY (ProjectId) REFERENCES Project(Id),

    CONSTRAINT CK_ProjectUnits_DefaultSystemUnits CHECK (DefaultSystemUnits IN ('Metric - SI', 'English - Imperial')),
    CONSTRAINT CK_ProjectUnits_DefaultMagnitudeUnits CHECK (DefaultMagnitudeUnits IN ('Base', 'Kilo', 'Mega')),
    CONSTRAINT CK_ProjectUnits_DefaultTemperatureUnits CHECK (DefaultTemperatureUnits IN ('°C', '°F', 'K', '°R')),
    CONSTRAINT CK_ProjectUnits_DefaultPressureUnits CHECK (DefaultPressureUnits IN ('Pa', 'kPa', 'MPa', 'bar', 'kBar', 'MBar', 'psia', 'psig', 'psf', 'atm', 'inHg', 'inH2O'))
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
