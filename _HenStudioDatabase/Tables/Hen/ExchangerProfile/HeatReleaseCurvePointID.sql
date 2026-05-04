-- --------------------------------------------------------------------------------
--  Table: HeatReleaseCurvePointID
--  File : HeatReleaseCurvePointID.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Heat Release Curve Point entity for HEN Studio. 
--    Parent entity is HeatReleaseCurve. Leaf entity.
--    HeatReleaseCurvePointID contains individual Duty-Temperature curve data points
--    used to visualize the Exchanger Duty - Temp relationship.
--    HeatReleaseCurvePointID includes fields for ...
--      + PK (GUID)
--      + FK to HeatReleaseCurve (GUID)
--      + Point Sequence Number
--      + Point Duty Value (External Units)
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

CREATE TABLE [dbo].[HeatReleaseCurvePointID]
(
    [Id]                 UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[HeatReleaseCurveId] UNIQUEIDENTIFIER NOT NULL,
	[PointSequence]      INT              NOT NULL,
	[DutyValue]          FLOAT            NOT NULL DEFAULT 0.0,
	[TemperatureValue]   FLOAT            NOT NULL DEFAULT 0.0,

	CONSTRAINT [PK_HeatReleaseCurvePointID] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_HeatReleaseCurvePointID_HeatReleaseCurve] FOREIGN KEY ([HeatReleaseCurveId]) REFERENCES [dbo].[HeatReleaseCurve]([Id]),
	CONSTRAINT [UQ_HeatReleaseCurvePointID_HeatReleaseCurveId_PointSequence] UNIQUE ([HeatReleaseCurveId], [PointSequence])
)
