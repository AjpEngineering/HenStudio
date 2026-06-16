-- -----------------------------------------------------------------------------
-- Combined SEED script for HenStudio
-- Generated: 2026-06-16 10:34:36Z
-- Source folder: C:\_AJP\git\HenStudio\_HenModel\Database\HenStudio\Scripts\Build
-- -----------------------------------------------------------------------------

PRAGMA foreign_keys = ON;
BEGIN TRANSACTION;


-- Start: 003_SeedAppSettings.sqlite

BEGIN TRANSACTION;

-- Reset AppSettings then insert canonical seed values (integer AppSettingId)
DELETE FROM AppSettings;

INSERT INTO AppSettings (AppSettingId, AppSettingName, AppSettingValue) VALUES
  (1, 'DefaultApproachTemperature', '10.00'),
  (2, 'DefaultEnglishU', '35.20'),
  (3, 'DefaultMetricU', '720.00'),
  (4, 'DefaultOptimizer', 'Gurobi'),
  (5, 'ExternalMagnitudeUnits', 'Mega'),
  (6, 'ExternalPressUnits', 'psia'),
  (7, 'ExternalSystemUnits', 'English - Imperial'),
  (8, 'ExternalTempUnits', '°F'),
  (9, 'ExternalUnitsA', 'ft2'),
  (10, 'ExternalUnitsEnergy', 'MMBtu/hr'),
  (11, 'ExternalUnitsHeatCapacityFlowRate', 'MMBtu/(hr-°F)'),
  (12, 'ExternalUnitsMassFlowrate', 'lbs/hr'),
  (13, 'ExternalUnitsSpecificHeatCapacity', 'MMBTU/( Ibs -°F)'),
  (14, 'ExternalUnitsU', 'MMBtu/(hr-ft2-°F)'),
  (15, 'InternalMagnitudeUnits', 'Kilo'),
  (16, 'InternalPressUnits', 'Pa'),
  (17, 'InternalSystemUnits', 'Metric - SI'),
  (18, 'InternalTempUnits', '°C'),
  (19, 'InternalUnitsA', 'm2'),
  (20, 'InternalUnitsEnergy', 'kW'),
  (21, 'InternalUnitsHeatCapacityFlowRate', 'kW/K'),
  (22, 'InternalUnitsMassFlowrate', 'kg/s'),
  (23, 'InternalUnitsSpecificHeatCapacity', 'kJ/kg-K'),
  (24, 'InternalUnitsU', 'kW/(m2-K)'),
  (25, 'LastMigrationApplied', 'InitialCreate'),
  (26, 'ReportDefaultFont', 'Segoe Ul'),
  (27, 'ReportDefaultFontSize', '11'),
  (28, 'SchemaVersion', '1.0.0');

COMMIT;

-- End: 003_SeedAppSettings.sqlite


COMMIT;

