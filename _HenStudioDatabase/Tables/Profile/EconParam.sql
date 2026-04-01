-- --------------------------------------------------------------------------------
--  Table: EconParam
--  File : EconParam.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Economic Parameters entity for HEN Studio. 
--    Parent entity is Profile. Leaf entity.
--    EconParam contains Economic Parameters data used for Pinch & Hen engines.
--      Heat Exchanger Capital Cost = [C1 + (C2 * Area)^(C3 * Shells)]
--      Annualization Factor = [((1.0 + RoR/100.0)^PL) / PL]
--    EconParam includes fields for ...
--      + PK (GUID)
--      + FK to Profile (GUID)
--      + Heat Exchanger Capital Cost Index Name
--      + Heat Exchanger Capital Cost Index C1 Value
--  	+ Heat Exchanger Capital Cost Index C2 Value
--      + Heat Exchanger Capital Cost Index C3 Value
--	    + Heat Exchanger Capital Cost Index Configuration (e.g., Heat Exchanger)
--      + Rate of Return [RoR] (%)
--	    + Project Lifetime [PL] (Years)
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

CREATE TABLE [dbo].[EconParam]
(
    [Id]                             UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[ProfileId]                      UNIQUEIDENTIFIER NOT NULL,
	[CapitalCostIndexName]           NVARCHAR(256)    NOT NULL,
	[CapitalCostIndexC1]             FLOAT            NOT NULL DEFAULT 0.0,
	[CapitalCostIndexC2]             FLOAT            NOT NULL DEFAULT 0.0,
	[CapitalCostIndexC3]             FLOAT            NOT NULL DEFAULT 0.0,
    [CapitalCostIndexConfiguration]  NVARCHAR(24)     NOT NULL DEFAULT N'Heat Exchanger',
	[RateOfReturn]                   FLOAT            NOT NULL DEFAULT 0.0,
	[ProjectLifetime]                INT              NOT NULL DEFAULT 1,

	CONSTRAINT [PK_EconParam] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_EconParam_Profile] FOREIGN KEY ([ProfileId]) REFERENCES [dbo].[Profile]([Id])
)
