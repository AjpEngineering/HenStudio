-- --------------------------------------------------------------------------------
--  Table: GridDiagram
--  File : GridDiagram.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    GridDiagram Data entity for HEN Studio. 
--    Parent entity is Hen. Contains zero or more GridDiagramPointID child entities.
--    GridDiagram contains Grid Diagram data used to visualize Hen Design
--    (stream matches).
--    GridDiagram includes fields for ...
--      + PK (GUID)
--      + FK to Hen (GUID)
--      + Diagram Title (e.g., "Grid Diagram")
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

CREATE TABLE [dbo].[GridDiagram]
(
    [Id]         UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[HenId]      UNIQUEIDENTIFIER NOT NULL,
	[Title]      NVARCHAR(256)    NOT NULL,

	CONSTRAINT [PK_GridDiagram] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_GridDiagram_Hen] FOREIGN KEY ([HenId]) REFERENCES [dbo].[Hen]([Id])
)
