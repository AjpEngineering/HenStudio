-- ============================================================================
--  Table: ExchangerParams
--  File : ExchangerParams.sql
-- ============================================================================
--
--  Description:
--    Root entity for HEN Studio.
--	  ExchangerParams includes default parameters for heat exchanger 
--    design calculations.
--	  Parent entity is Project. Leaf entity.
--   
--    ExchangerParams includes fields for ...
--      + PK (GUID)
--      + Project ID (FK) GUID
--      + Default Exchanger Heat Transfer Coefficient (U)
--      + Default Exchanger Correction Factor (F)
--
-- ============================================================================
--  (c)Copyright 2026 AJP Engineering
--  All rights reserved.
-- ============================================================================
--  HISTORY:
--    01/01/26 .. AJP Engineering .. Version 1.0
-- ============================================================================
CREATE TABLE [dbo].[ExchangerParams]
(
    [Id]                             UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [ProjectId]                      UNIQUEIDENTIFIER NOT NULL,
    [DefaultHeatTransferCoefficient] FLOAT NOT NULL DEFAULT 0.0,
    [DefaultCorrectionFactor]        FLOAT NOT NULL DEFAULT 0.85,

    CONSTRAINT [PK_ExchangerParams] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_ExchangerParams_Project] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Project]([Id])
);
