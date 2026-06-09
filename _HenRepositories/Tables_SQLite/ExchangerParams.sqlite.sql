-- ============================================================================
--  Table: ExchangerParams
--  File : ExchangerParams.sqlite.sql
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
--    01/01/26 .. AJP Engineering .. Version 1.0 : SQL Server Version
--    06/01/26 .. AJP Engineering .. Version 1.1 : SQLite Version
-- ================================================================================

CREATE TABLE ExchangerParams (
    Id                             TEXT NOT NULL,
    ProjectId                      TEXT NOT NULL,
    DefaultHeatTransferCoefficient REAL NOT NULL DEFAULT 0.0,
    DefaultCorrectionFactor        REAL NOT NULL DEFAULT 0.85,

    PRIMARY KEY(Id),
	FOREIGN KEY (ProjectId) REFERENCES Project(Id)
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
