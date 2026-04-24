-- --------------------------------------------------------------------------------
--  Table: ProcessStream
--  File : ProcessStream.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Process Stream entity for HEN Studio. 
--    Parent entity is Profile. Leaf entity.
--    Process Stream contains process stream data used for Pinch & Hen engines.
--    ProcessStream includes fields for ...
--      + PK (GUID)
--      + FK to Profile (GUID)
--      + Stream Category [Process|Utility]
-- 	    + Stream Heat [Sensible|Latent]
--      + Stream ID [e.g., H01]
--      + Stream Name [e.g., Naptha Feed]
--      + Stream Type [Hot|Cold]
--      + Stream Subtype [Liquid|Vapor|Mixed]
--	    + Stream Supply Temperature (Internal Units)
--	    + Stream Supply Pressure (Internal Units)
--	    + Stream Target Temperature (Internal Units)
--	    + Stream Target Pressure (Internal Units)
--	    + Stream Heat Capacity Flow Rate - [CP] (Internal Units)
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

CREATE TABLE [dbo].[ProcessStream]
(
    [Id]                               UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[ProfileId]                        UNIQUEIDENTIFIER NOT NULL,
	[StreamCategory]                   NVARCHAR(16)     NOT NULL DEFAULT N'Process',
	[StreamHeat]                       NVARCHAR(16)     NOT NULL DEFAULT N'Sensible',
	[StreamId]                         NVARCHAR(16)     NOT NULL,
	[Name]                             NVARCHAR(256)    NOT NULL,
	[StreamType]                       NVARCHAR(8)      NOT NULL DEFAULT N'Hot',
	[StreamSubtype]                    NVARCHAR(8)      NOT NULL DEFAULT N'Liquid',
	[SupplyTemperature]                FLOAT            NOT NULL DEFAULT 0.0,
	[SupplyPressure]                   FLOAT            NOT NULL DEFAULT 0.0,
	[TargetTemperature]                FLOAT            NOT NULL DEFAULT 0.0,
	[TargetPressure]                   FLOAT            NOT NULL DEFAULT 0.0,
	[HeatCapacityFlowRate]             FLOAT            NOT NULL DEFAULT 0.0,

	CONSTRAINT [PK_ProcessStream] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_ProcessStream_Profile] FOREIGN KEY ([ProfileId]) REFERENCES [dbo].[Profile]([Id]),
	CONSTRAINT [CK_ProcessStream_StreamCategory] CHECK ([StreamCategory] IN (N'Process', N'Utility')),
	CONSTRAINT [CK_ProcessStream_StreamHeat] CHECK ([StreamHeat] IN (N'Sensible', N'Latent')),
	CONSTRAINT [CK_ProcessStream_StreamType] CHECK ([StreamType] IN (N'Hot', N'Cold')),
	CONSTRAINT [CK_ProcessStream_StreamSubtype] CHECK ([StreamSubtype] IN (N'Liquid', N'Vapor', N'Mixed'))
)
