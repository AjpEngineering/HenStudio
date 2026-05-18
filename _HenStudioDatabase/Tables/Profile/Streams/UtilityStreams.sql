-- --------------------------------------------------------------------------------
--  Table: UtilityStreams
--  File : UtilityStreams.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Utility Streams entity for HEN Studio. 
--    Parent entity is Profile. Leaf entity.
--    UtilityStreams contains utility stream data used for Pinch & Hen engines.
--    
--    UtilityStreams includes fields for ...
--      + PK (GUID)
--      + FK to Profile (GUID)
--      + Stream Category [Process|Utility]
-- 	    + Stream Heat [Sensible|Latent]
--      + Stream ID [e.g., CU01]
--      + Stream Name [e.g., Naptha Top Condenser]
--      + Utility Type [HP Steam| MP Steam| LP Steam | Cold Water | Chilled Water | Fuel Gas]
--	    + Stream Isothermal Temperature (Internal Units)
--	    + Stream Supply Pressure (Internal Units)
--	    + Stream Target Pressure (Internal Units)
--	    + Stream Enthalpy Flow Rate - [H - Duty] (Internal Units)
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

CREATE TABLE [dbo].[UtilityStreams]
(
    [Id]                    UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[ProfileId]             UNIQUEIDENTIFIER NOT NULL,
	[StreamCategory]        NVARCHAR(16)     NOT NULL DEFAULT N'Utility',
	[StreamHeat]            NVARCHAR(16)     NOT NULL DEFAULT N'Latent',
	[StreamId]              NVARCHAR(16)     NOT NULL,
	[Name]                  NVARCHAR(256)    NOT NULL,
	[UtilityType]           NVARCHAR(16)     NOT NULL DEFAULT N'Cold Water',
	[IsothermalTemperature] FLOAT            NOT NULL DEFAULT 0.0,
	[SupplyPressure]        FLOAT            NOT NULL DEFAULT 0.0,
	[TargetPressure]        FLOAT            NOT NULL DEFAULT 0.0,
	[EnthalpyFlowRate]      FLOAT            NOT NULL DEFAULT 0.0,

	CONSTRAINT [PK_UtilityStreams] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_UtilityStreams_Profile] FOREIGN KEY ([ProfileId]) REFERENCES [dbo].[Profile]([Id]),
	CONSTRAINT [CK_UtilityStreams_StreamCategory] CHECK ([StreamCategory] IN (N'Process', N'Utility')),
	CONSTRAINT [CK_UtilityStreams_StreamHeat] CHECK ([StreamHeat] IN (N'Sensible', N'Latent')),
	CONSTRAINT [CK_UtilityStreams_UtilityType] CHECK ([UtilityType] IN (N'Chilled Water', N'Cold Water', N'Fuel Gas', N'LP Steam', N'MP Steam', N'HP Steam'))
)
