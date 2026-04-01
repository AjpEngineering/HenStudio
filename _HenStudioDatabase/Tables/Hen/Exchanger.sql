-- --------------------------------------------------------------------------------
--  Table: Exchanger
--  File : Exchanger.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Exchanger entity for HEN Studio. 
--    Parent entity is Hen. Leaf entity.
--    Exchanger contains Exchanger Specification from Hen engine Design.
--    ProcessStream includes fields for ...
--      + PK (GUID)
--      + FK to Hen (GUID)
--      + Exchanger ID [e.g., E-101]
--	    + Exchanger Name [e.g., Naptha Preheater]
--	    + Exchanger Is Utility (Boolean)
--	    + Exchanger Type [e.g., Shell-Tube]
--	    + Exchanger Shells [e.g., 1, 2, 4, 6, 8]
--      + Exchanger Area (Internal Units)
--	    + Exchanger Hot Temperature In (Internal Units)
--	    + Exchanger Hot Temperature Out (Internal Units)
--      + Exchanger Hot Pressure In (Internal Units)
--	    + Exchanger Hot Pressure Out (Internal Units)
--	    + Exchanger Cold Temperature In (Internal Units)
--	    + Exchanger Cold Temperature Out (Internal Units)
--      + Exchanger Cold Pressure In (Internal Units)
--	    + Exchanger Cold Pressure Out (Internal Units)
--      + Exchanger Pressure Drop (Internal Units)
--  	+ Exchanger Heat Duty (Internal Units)
--	    + Exchanger LMTD Correction Factor (Internal Units)
--	    + Exchanger Heat Transfer Coefficient - [U] (Internal Units)
--	    + Exchanger Capital Cost (Internal Units)
--	    + Exchanger Annualized Cost (Internal Units)
--	    + Exchanger Fouling Factor (Internal Units)
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

CREATE TABLE [dbo].[Exchanger]
(
    [Id]                     UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[HenId]                  UNIQUEIDENTIFIER NOT NULL,
	[ExchangerId]            NVARCHAR(24)     NOT NULL,
	[Name]                   NVARCHAR(256)    NOT NULL,
	[IsUtility]              BIT              NOT NULL DEFAULT 0,
	[ExchangerType]          NVARCHAR(48)     NOT NULL DEFAULT N'Shell-Tube',
	[Shells]                 INT              NOT NULL DEFAULT 1,
	[Area]                   FLOAT            NOT NULL DEFAULT 0.0,
	[HotTemperatureIn]       FLOAT            NOT NULL DEFAULT 0.0,
	[HotTemperatureOut]      FLOAT            NOT NULL DEFAULT 0.0,
	[HotPressureIn]          FLOAT            NOT NULL DEFAULT 0.0,
	[HotPressureOut]         FLOAT            NOT NULL DEFAULT 0.0,
	[ColdTemperatureIn]      FLOAT            NOT NULL DEFAULT 0.0,
	[ColdTemperatureOut]     FLOAT            NOT NULL DEFAULT 0.0,
	[ColdPressureIn]         FLOAT            NOT NULL DEFAULT 0.0,
	[ColdPressureOut]        FLOAT            NOT NULL DEFAULT 0.0,
	[PressureDrop]           FLOAT            NOT NULL DEFAULT 0.0,
	[HeatDuty]               FLOAT            NOT NULL DEFAULT 0.0,
	[LmtdCorrectionFactor]   FLOAT            NOT NULL DEFAULT 0.8,
	[HeatTransferCoefficient] FLOAT           NOT NULL DEFAULT 0.0,
	[CapitalCost]            FLOAT            NOT NULL DEFAULT 0.0,
	[AnnualizedCost]         FLOAT            NOT NULL DEFAULT 0.0,
	[FoulingFactor]          FLOAT            NOT NULL DEFAULT 0.0,

	CONSTRAINT [PK_Exchanger] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_Exchanger_Hen] FOREIGN KEY ([HenId]) REFERENCES [dbo].[Hen]([Id])
)
