-- ============================================================================
--  Table: Project
--  File : Project.sql
-- ============================================================================
--
--  Description:
--    Root entity for HEN Studio. Contains zero or more Profile entities.
--    Project includes fields for ...
--      + PK (GUID)
--      + Project Name
--      + Project Description
--      + Default Exchanger Heat Transfer Coefficient (U)
--      + Default Exchanger Correction Factor (F)
--      + Default HEN Optimizer (Genetic|Greedy|MILP)
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
CREATE TABLE [dbo].[Project]
(
    [Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [Name] NVARCHAR(256) NOT NULL,
    [Description] NVARCHAR(1024) NULL,
    [DefaultHeatTransferCoefficient] FLOAT NOT NULL DEFAULT 0.0,
    [DefaultCorrectionFactor] FLOAT NOT NULL DEFAULT 0.85,
    [DefaultHenOptimizer] NVARCHAR(16) NOT NULL DEFAULT N'Genetic',
    [DefaultSystemUnits] NVARCHAR(24) NOT NULL DEFAULT N'Metric - SI',
    [DefaultMagnitudeUnits] NVARCHAR(16) NOT NULL DEFAULT N'Base',
    [DefaultTemperatureUnits] NVARCHAR(8) NOT NULL DEFAULT N'K',
    [DefaultPressureUnits] NVARCHAR(16) NOT NULL DEFAULT N'Pa',

    CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED ([Id]),

    CONSTRAINT [CK_Project_DefaultHenOptimizer] CHECK ([DefaultHenOptimizer] IN (N'Genetic', N'Greedy', N'MILP')),
    CONSTRAINT [CK_Project_DefaultSystemUnits] CHECK ([DefaultSystemUnits] IN (N'Metric - SI', N'English - Imperial')),
    CONSTRAINT [CK_Project_DefaultMagnitudeUnits] CHECK ([DefaultMagnitudeUnits] IN (N'Base', N'Kilo', N'Mega')),
    CONSTRAINT [CK_Project_DefaultTemperatureUnits] CHECK ([DefaultTemperatureUnits] IN (N'°C', N'°F', N'K', N'°R')),
    CONSTRAINT [CK_Project_DefaultPressureUnits] CHECK ([DefaultPressureUnits] IN (N'Pa', N'kPa', N'MPa', N'bar', N'kBar', N'MBar', N'psia', N'psig', N'psf', N'atm', N'inHg', N'inH2O'))
);
