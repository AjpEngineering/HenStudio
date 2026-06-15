-- --------------------------------------------------------------------------------
--  Table: AppSettings.sqlite.sql
--  File : 003_AppSettings.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Application Settings entity for HEN Studio -> HenStudio.db [Database file].
--    Contains AJP HEN Studio Application Factory Settings.
-- --------------------------------------------------------------------------------
--    Table is seeded at Creation (EXPECTED VALUES) as follows.
-- --------------------------------------------------------------------------------
--   01 ... DefaultApproachTemperature .......... 10.00
--   02 ... DefaultEnglishU ..................... 35.20
--   03 ... DefaultMetricU ...................... 720.00
--   04 ... DefaultOptimizer	.................... Gurobi
--   05 ... ExternalMagnitudeUnits .............. Mega
--   06 ... ExternalPressUnits .................. psia
--   07 ... ExternalSystemUnits ................. English - Imperial
--   08 ... ExternalTempUnits ................... °F
--   09 ... ExternalUnitsA ...................... ft2
--   10 ... ExternalUnitsEnergy ................. MMBtu/hr
--   11 ... ExternalUnitsHeatCapacityFlowRate ... MMBtu/(hr-°F)
--   12 ... ExternalUnitsMassFlowrate ........... lbs/hr
--   13 ... ExternalUnitsSpecificHeatCapacity ... MMBTU/( Ibs -°F)
--   14 ... ExternalUnitsU ...................... MMBtu/(hr-ft2-°F)
--   15 ... InternalMagnitudeUnits .............. Kilo
--   16 ... InternalPressUnits .................. Pa
--   17 ... InternalSystemUnits ................. Metric - SI
--   18 ... InternalTempUnits ................... °C
--   19 ... InternalUnitsA ...................... m2
--   20 ... InternalUnitsEnergy ................. kW
--   21 ... InternalUnitsHeatCapacityFlowRate ... kW/K
--   22 ... InternalUnitsMassFlowrate ........... kg/s
--   23 ... InternalUnitsSpecificHeatCapacity ... kJ/kg-K
--   24 ... InternalUnitsU ...................... kW/(m2-K)
--   25 ... LastMigrationApplied ................ InitialCreate
--   26 ... ReportDefaultFont ................... Segoe Ul
--   27 ... ReportDefaultFontSize ............... 11
--   28 ... SchemaVersion ....................... 1.0.0
-- --------------------------------------------------------------------------------
--    AppSettings includes fields for ...
--      + App Setting Id (PK)
--      + App Setting Name
--      + App Setting Value
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
--    06/01/26 .. AJP Engineering .. Version 1.1 : SQLite Version
-- ================================================================================

CREATE TABLE AppSettings (
    AppSettingId     INTEGER NOT NULL,
	AppSettingName   TEXT NOT NULL,
	AppSettingValue  TEXT NULL,

	PRIMARY KEY(AppSettingsId),
) STRICT;

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
