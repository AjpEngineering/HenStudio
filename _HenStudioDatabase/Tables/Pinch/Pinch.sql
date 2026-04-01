-- --------------------------------------------------------------------------------
--  Table: Pinch
--  File : Pinch.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Pinch entity for HEN Studio. 
--    Parent entity is Profile. Contains zero or more Hen child entities.
--    Pinch contains the Delta Tmin value and Pinch Targets engine results.
--    Pinch includes fields for ...
--      + PK (GUID)
--      + FK to Profile (GUID)
--      + Pinch Name
--      + Pinch Description
-- 	    + Pinch Delta Tmin (Internal Units)
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

CREATE TABLE [dbo].[Pinch]
(
    [Id]            UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[ProfileId]     UNIQUEIDENTIFIER NOT NULL,
	[Name]          NVARCHAR(256)    NOT NULL,
	[Description]   NVARCHAR(1024)   NULL,
    [DeltaTmin]     FLOAT            NOT NULL DEFAULT 10.0,

	CONSTRAINT [PK_Pinch] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_Pinch_Profile] FOREIGN KEY ([ProfileId]) REFERENCES [dbo].[Profile]([Id])
)
