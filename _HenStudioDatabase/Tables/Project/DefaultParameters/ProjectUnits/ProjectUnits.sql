-- ============================================================================
--  Table: ProjectUnits
--  File : ProjectUnits.sql
-- ============================================================================
--
--  Description:
--    Contains zero or more Project Units parameters.
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
--    01/01/26 .. AJP Engineering .. Version 1.0
-- ============================================================================
CREATE TABLE [dbo].[ProjectUnits]
(
    [Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [ProjectId] UNIQUEIDENTIFIER NOT NULL,
    [DefaultSystemUnits] NVARCHAR(24) NOT NULL DEFAULT N'Metric - SI',
    [DefaultMagnitudeUnits] NVARCHAR(16) NOT NULL DEFAULT N'Base',
    [DefaultTemperatureUnits] NVARCHAR(8) NOT NULL DEFAULT N'K',
    [DefaultPressureUnits] NVARCHAR(16) NOT NULL DEFAULT N'Pa',

    CONSTRAINT [PK_ProjectUnits] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_ProjectUnits_Project] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Project]([Id]),

    CONSTRAINT [CK_ProjectUnits_DefaultSystemUnits] CHECK ([DefaultSystemUnits] IN (N'Metric - SI', N'English - Imperial')),
    CONSTRAINT [CK_ProjectUnits_DefaultMagnitudeUnits] CHECK ([DefaultMagnitudeUnits] IN (N'Base', N'Kilo', N'Mega')),
    CONSTRAINT [CK_ProjectUnits_DefaultTemperatureUnits] CHECK ([DefaultTemperatureUnits] IN (N'°C', N'°F', N'K', N'°R')),
    CONSTRAINT [CK_ProjectUnits_DefaultPressureUnits] CHECK ([DefaultPressureUnits] IN (N'Pa', N'kPa', N'MPa', N'bar', N'kBar', N'MBar', N'psia', N'psig', N'psf', N'atm', N'inHg', N'inH2O'))
);
