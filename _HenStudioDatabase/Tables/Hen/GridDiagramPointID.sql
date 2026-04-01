-- --------------------------------------------------------------------------------
--  Table: GridDiagramPointID
--  File : GridDiagramPointID.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Grid Diagram Point entity for HEN Studio. 
--    Parent entity is GridDiagram. Leaf entity.
--    GridDiagramPointID contains individual Grid Diagram data points used to
--    visualize Hen Design stream matches.
--    GridDiagramPointID includes fields for ...
--      + PK (GUID)
--      + FK to GridDiagram (GUID)
--      + Point Sequence Number
--      + Point X Coordinate
--      + Point Y Coordinate
--      + Point Label
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

CREATE TABLE [dbo].[GridDiagramPointID]
(
    [Id]            UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[GridDiagramId] UNIQUEIDENTIFIER NOT NULL,
	[PointSequence] INT              NOT NULL,
	[XCoordinate]   FLOAT            NOT NULL DEFAULT 0.0,
	[YCoordinate]   FLOAT            NOT NULL DEFAULT 0.0,
	[Label]         NVARCHAR(256)    NULL,

	CONSTRAINT [PK_GridDiagramPointID] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_GridDiagramPointID_GridDiagram] FOREIGN KEY ([GridDiagramId]) REFERENCES [dbo].[GridDiagram]([Id]),
	CONSTRAINT [UQ_GridDiagramPointID_GridDiagramId_PointSequence] UNIQUE ([GridDiagramId], [PointSequence])
)
