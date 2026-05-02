-- --------------------------------------------------------------------------------
--  Table: TotalAnnualizedCost
--  File : TotalAnnualizedCost.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Total Annualized Cost (TAC) entity for HEN Studio. 
--    Parent entity is Project. Leaf entity.
--    TotalAnnualizedCost contains total annualized cost parameters including
--    Capital Recover Factor (CRF) parameters used by Pinch & Hen engines.
--    Conceptual Cost Configuration Total Annualized Cost includes ...
--      TAC CRF Interest Rate ......... [ 0.10]
--      TAC CRF Life Years ............ [10.00]
--      TAC CRF Maintenance Fraction ... [0.03] -> 3% of capital cost per year for maintenance
--      TAC CRF Operating Hours ...... [8000.0]
--
--    TotalAnnualizedCost includes fields for ...
--      + Id         [PK] (GUID)
--      + Project Id [FK] to Project (GUID)
--      + Total Annualized Cost Interest Rate        (e.g.,   0.10 )
--      + Total Annualized Cost Life Years           (e.g.,  10.00 )
--      + Total Annualized Cost Maintenance Fraction (e.g.,   0.03 )
--      + Total Annualized Cost Operating Hours      (e.g., 8000.0 )
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

CREATE TABLE [dbo].TotalAnnualizedCost
(
    [Id]                      UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[ProjectId]               UNIQUEIDENTIFIER NOT NULL,
	[TAC_InterestRate]        FLOAT            NOT NULL DEFAULT 0.10,
	[TAC_LifeYears]           FLOAT            NOT NULL DEFAULT 10.00,
	[TAC_MaintenanceFraction] FLOAT            NOT NULL DEFAULT 0.03,
	[TAC_OperatingHours]      FLOAT            NOT NULL DEFAULT 8000.0,

	CONSTRAINT [PK_TotalAnnualizedCost] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_TotalAnnualizedCost_Project] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Project]([Id])
)
