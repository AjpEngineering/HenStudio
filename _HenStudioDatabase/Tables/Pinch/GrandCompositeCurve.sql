-- --------------------------------------------------------------------------------
--  Table: GrandCompositeCurve
--  File : GrandCompositeCurve.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    GrandCompositeCurve Data entity for HEN Studio. 
--    Parent entity is Pinch. Contains zero or more GrandCompositeCurvePointID child entities.
--    GrandCompositeCurve contains Grand Composite Curve data used to visualize 
--    Pinch Minimum Utility Loads and Pinch Temperatures.
--    GrandCompositeCurve includes fields for ...
--      + PK (GUID)
--      + FK to Pinch (GUID)
--      + Curve Subtype [Raw|Shifted]
--      + Curve Title (e.g., "Grand Composite Curve")
--	    + Curve X-Axis Label (e.g.,"Enthalpy (MMBtu/hr)") ... External Units
--      + Curve Y-Axis Label (e.g.,"Temperature (°F)") ...... External Units
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

CREATE TABLE [dbo].[GrandCompositeCurve]
(
    [Id]           UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[PinchId]      UNIQUEIDENTIFIER NOT NULL,
	[CurveSubtype] NVARCHAR(16)     NOT NULL DEFAULT N'Raw',
	[Title]        NVARCHAR(256)    NOT NULL,
	[XAxisLabel]   NVARCHAR(256)    NOT NULL,
	[YAxisLabel]   NVARCHAR(256)    NOT NULL,

	CONSTRAINT [PK_GrandCompositeCurve] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_GrandCompositeCurve_Pinch] FOREIGN KEY ([PinchId]) REFERENCES [dbo].[Pinch]([Id]),
	CONSTRAINT [CK_GrandCompositeCurve_CurveSubtype] CHECK ([CurveSubtype] IN (N'Raw', N'Shifted'))
)
