-- --------------------------------------------------------------------------------
--  Table: HeatReleaseCurve
--  File : HeatReleaseCurve.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    HeatReleaseCurve Data entity for HEN Studio. 
--    Parent entity is Exchanger. Contains zero or more HeatReleaseCurvePointID child entities.
--    HeatReleaseCurve contains Heat Release curve data used to visualize 
--    Exchanger Duty - Temp relationship.
--    HeatReleaseCurve includes fields for ...
--      + PK (GUID)
--      + FK to Exchanger (GUID)
--      + Curve Title (e.g. "E-101 Heat Release Curve")
--	    + Diagram X-Axis Label (e.g.,"Duty (MMBtu/hr)") .... External Units
--      + Diagram Y-Axis Label (e.g.,"Temperature (°F)") ... External Units
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

CREATE TABLE [dbo].[HeatReleaseCurve]
(
    [Id]           UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[ExchangerId]  UNIQUEIDENTIFIER NOT NULL,
	[Title]        NVARCHAR(256)    NOT NULL,
	[XAxisLabel]   NVARCHAR(256)    NOT NULL,
	[YAxisLabel]   NVARCHAR(256)    NOT NULL,

   CONSTRAINT [PK_HeatReleaseCurve] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_HeatReleaseCurve_Exchanger] FOREIGN KEY ([ExchangerId]) REFERENCES [dbo].[Exchanger]([Id])
)
