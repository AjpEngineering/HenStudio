PRINT 'Seeding GlobalSettings...';

MERGE INTO dbo.GlobalSettings AS Target
USING (VALUES
    ('SchemaVersion', '1.0.0', 'string', 'Current HenStudio DB schema version'),
    ('DatabaseCreatedOn', CONVERT(NVARCHAR(50), SYSUTCDATETIME(), 126), 'datetime', 'Database creation timestamp'),
    ('LastMigrationApplied', 'InitialCreate', 'string', 'Last applied migration'),

    ('InternalSystemUnits', 'Metric - SI', 'string', 'INTERNAL System Units'),
    ('InternalMagnitudeUnits', 'Kilo', 'string', 'INTERNAL Magnitude Units'),
    ('InternalTempUnits', '°C', 'string', 'INTERNAL Temperature Units'),
    ('InternalPressUnits', 'Pa', 'string', 'INTERNAL Pressure Units'),
    ('InternalUnitsA', 'm²', 'string', 'INTERNAL Heat Exchanger Area Units'),
    ('InternalUnitsEnergy', 'kW', 'string', 'INTERNAL Energy Units'),
    ('InternalUnitsMassFlowrate', 'kg/s', 'string', 'INTERNAL Mass Flow Units'),
    ('InternalUnitsSpecificHeatCapacity', 'kJ/kg-K', 'string', 'INTERNAL Cp Units'),
    ('InternalUnitsHeatCapacityFlowRate', 'kW/K', 'string', 'INTERNAL CP Units'),
    ('InternalUnitsU', 'kW/(m²·K)', 'string', 'INTERNAL Default Heat Transfer Coefficient Units'),

    ('ExternalSystemUnits', 'English - Imperial', 'string', 'EXTERNAL Default System Units'),
    ('ExternalMagnitudeUnits', 'Mega', 'string', 'EXTERNAL Default Magnitude Units'),
    ('ExternalTempUnits', '°F', 'string', 'EXTERNAL Default Temperature Units'),
    ('ExternalPressUnits', 'psia', 'string', 'EXTERNAL Default Pressure Units'),
    ('ExternalUnitsA', 'ft²', 'string', 'EXTERNAL Default Heat Exchanger Area Units'),
    ('ExternalUnitsEnergy', 'MMBtu/hr', 'string', 'EXTERNAL Default Energy Units'),
    ('ExternalUnitsMassFlowrate', 'lbs/hr', 'string', 'EXTERNAL Default Mass Flow Units'),
    ('ExternalUnitsSpecificHeatCapacity', 'kJ/kg-K', 'string', 'EXTERNAL Default Cp Units'),
    ('ExternalUnitsHeatCapacityFlowRate', 'MMBtu/(hr·°F)', 'string', 'EXTERNAL Default CP Units'),
    ('ExternalUnitsU', 'MMBtu/(hr·ft²·°F)', 'string', 'EXTERNAL Default Heat Transfer Coefficient Units'),

    ('ReportDefaultFont', 'Segoe UI', 'string', 'Default report font'),
    ('ReportIncludeAuditSection', 'true', 'bool', 'Include audit metadata'),
    ('ReportUnitsProfile', 'Default', 'string', 'Default report units profile'),

    ('DefaultApproachTemperature', '10.0', 'double', 'Default ΔTmin'),
    ('DefaultEnglishU', '35.2', 'double', 'Default English Heat Transfer Coefficient - Btu/(hr·ft²·°F) value'),
    ('DefaultMetricU', '720.0', 'double', 'Default Metric Heat Transfer Coefficient - kJ/(hr·m²·°C) value'),
    ('DefaultOptimizer', 'Genetic', 'string', 'Default HEN Optimizer'),
    ('EnableAreaEstimation', 'true', 'bool', 'Toggle area estimation')
) AS Source (SettingKey, SettingValue, ValueType, Description)
ON Target.SettingKey = Source.SettingKey
WHEN MATCHED THEN
    UPDATE SET 
        SettingValue = Source.SettingValue,
        ValueType = Source.ValueType,
        Description = Source.Description,
        UpdatedOn = SYSUTCDATETIME()
WHEN NOT MATCHED THEN
    INSERT (SettingKey, SettingValue, ValueType, Description)
    VALUES (Source.SettingKey, Source.SettingValue, Source.ValueType, Source.Description);

