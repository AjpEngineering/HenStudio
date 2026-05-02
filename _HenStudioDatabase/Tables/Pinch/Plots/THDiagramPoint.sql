-- --------------------------------------------------------------------------------
--  Table: THDiagramPoint
--  File : THDiagramPoint.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Temperature-Enthalpy Diagram Point entity for HEN Studio. 
--    Parent entity is THDiagram. Leaf entity.
--    THDiagramPoint contains individual T-H diagram data points used to visualize
--    the Temp-Enthalpy relationship.
--    THDiagramPoint includes fields for ...
--      + PK (GUID)
--      + FK to THDiagram (GUID)
--      + Point Sequence Number
--      + Point Enthalpy Value (External Units)
--      + Point Temperature Value (External Units)
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

CREATE TABLE [dbo].[THDiagramPoint]
(
    [Id]               UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[THDiagramId]      UNIQUEIDENTIFIER NOT NULL,
	[PointSequence]    INT              NOT NULL,
	[EnthalpyValue]    FLOAT            NOT NULL DEFAULT 0.0,
	[TemperatureValue] FLOAT            NOT NULL DEFAULT 0.0,

	CONSTRAINT [PK_THDiagramPoint] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_THDiagramPoint_THDiagram] FOREIGN KEY ([THDiagramId]) REFERENCES [dbo].[THDiagram]([Id]),
	CONSTRAINT [UQ_THDiagramPoint_THDiagramId_PointSequence] UNIQUE ([THDiagramId], [PointSequence])
)
