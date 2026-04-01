-- --------------------------------------------------------------------------------
--  Table: Project
--  File : Project.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Root entity for HEN Studio. Contains zero or more Profile entities.
--    Project includes fields for ...
--      + PK (GUID)
--      + Project Name
--      + Project Description
--      + Default Exchanger Heat Transfer Coefficient (U)
--      + Default HEN Optimizer [Genetic|Greedy|MILP]
--      + Default System Units [SI|Imperial]
--      + Default Magnitude Units [Base|Kilo|Mega]
--      + Default Temperature Units [C|F|K|R]
--    	+ Default Pressure Units [Pa|bar|psia|psig|psf|atm|inHg|inH2O]
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
--    01/01/26 .. AJP Engineering .. Version 1.0
-- ================================================================================

CREATE TABLE [dbo].[Project]
(
	[Id]                              UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[Name]                            NVARCHAR(256)    NOT NULL,
	[Description]                     NVARCHAR(1024)   NULL,
	[DefaultHeatTransferCoefficient]  FLOAT            NOT NULL DEFAULT 0.0,
	[DefaultHenOptimizer]             NVARCHAR(48)     NOT NULL DEFAULT N'Genetic',
	[DefaultSystemUnits]              NVARCHAR(48)     NOT NULL DEFAULT N'SI',
	[DefaultMagnitudeUnits]           NVARCHAR(48)     NOT NULL DEFAULT N'Base',
	[DefaultTemperatureUnits]         NVARCHAR(8)      NOT NULL DEFAULT N'K',
	[DefaultPressureUnits]            NVARCHAR(8)      NOT NULL DEFAULT N'Pa',

	CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED ([Id]),

	CONSTRAINT [CK_Project_DefaultHenOptimizer]  CHECK ([DefaultHenOptimizer]  IN (N'Genetic', N'Greedy', N'MILP')),
	CONSTRAINT [CK_Project_DefaultSystemUnits]   CHECK ([DefaultSystemUnits]   IN (N'SI', N'Imperial')),
	CONSTRAINT [CK_Project_DefaultMagnitudeUnits] CHECK ([DefaultMagnitudeUnits] IN (N'Base', N'Kilo', N'Mega')),
	CONSTRAINT [CK_Project_DefaultTemperatureUnits] CHECK ([DefaultTemperatureUnits] IN (N'C', N'F', N'K', N'R')),
	CONSTRAINT [CK_Project_DefaultPressureUnits] CHECK ([DefaultPressureUnits] IN (N'Pa', N'bar', N'psia', N'psig', N'psf', N'atm', N'inHg', N'inH2O'))
)
