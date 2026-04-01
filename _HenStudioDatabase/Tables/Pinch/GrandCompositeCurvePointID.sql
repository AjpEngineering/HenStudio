-- --------------------------------------------------------------------------------
--  Table: GrandCompositeCurvePointID
--  File : GrandCompositeCurvePointID.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Grand Composite Curve Point entity for HEN Studio. 
--    Parent entity is GrandCompositeCurve. Leaf entity.
--    GrandCompositeCurvePointID contains individual Grand Composite Curve data points
--    used to visualize Pinch Minimum Utility Loads and Pinch Temperatures.
--    GrandCompositeCurvePointID includes fields for ...
--      + PK (GUID)
--      + FK to GrandCompositeCurve (GUID)
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

CREATE TABLE [dbo].[GrandCompositeCurvePointID]
(
    [Id]                    UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[GrandCompositeCurveId] UNIQUEIDENTIFIER NOT NULL,
	[PointSequence]         INT              NOT NULL,
	[EnthalpyValue]         FLOAT            NOT NULL DEFAULT 0.0,
	[TemperatureValue]      FLOAT            NOT NULL DEFAULT 0.0,

	CONSTRAINT [PK_GrandCompositeCurvePointID] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_GrandCompositeCurvePointID_GrandCompositeCurve] FOREIGN KEY ([GrandCompositeCurveId]) REFERENCES [dbo].[GrandCompositeCurve]([Id]),
	CONSTRAINT [UQ_GrandCompositeCurvePointID_GrandCompositeCurveId_PointSequence] UNIQUE ([GrandCompositeCurveId], [PointSequence])
)
