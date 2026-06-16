-- -----------------------------------------------------------------------------
-- Combined SEED script for HenStudio
-- Generated: 2026-06-16 11:15:51Z
-- Source folder: C:\_AJP\git\HenStudio\_HenModel\Database\HenStudio\Scripts\Build
-- -----------------------------------------------------------------------------

PRAGMA foreign_keys = ON;
BEGIN TRANSACTION;


-- Start: 001_SeedAppMetadata.sqlite

BEGIN TRANSACTION;

-- Reset AppMetadata then insert canonical seed values (integer AppMetadataId)
DELETE FROM AppMetadata;

INSERT INTO AppMetadata (AppMetadataId, AppMetadataName, AppMetadataValue) VALUES
  (1, 'PRODUCT FULLNAME', 'AJP HEN Studio 1.0'),
  (2, 'PRODUCT NAME', 'AJP HEN Studio'),
  (3, 'PRODUCT VERSION', '1.0'),
  (4, 'PRODUCT SERIAL NUMBER', '1022-789-1189'),
  (5, 'PRODUCT CODE', '{3D9721BA-003E-4711-B7AF-B579645F0AC9}'),
  (6, 'PRODUCT SUPPLIER NAME', 'AJP Engineering'),
  (7, 'PRODUCT SUPPLIER URLs', 'http://www.AJPEngineering.com'),

COMMIT;

-- End: 001_SeedAppMetadata.sqlite


-- Start: 002_SeedAppComponents..sqlite

BEGIN TRANSACTION;

-- Reset AppComponents then insert canonical seed values (integer ComponentId)
DELETE FROM AppComponents;

INSERT INTO AppComponents (ComponentId, ComponentName, ComponentType) VALUES
  (1, '_AJP License File', 'dll'),
  (2, '_HenDomainModel', 'dll'),
  (3, '_HenGlobal', 'dll'),
  (4, '_HenModel', 'dll'),
  (5, '_HenViewModel', 'dll'),
  (6, 'HenStudio', 'exe'),
  (7, 'HenStudio.config', 'config'),

COMMIT;

-- End: 002_SeedAppComponents..sqlite


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

