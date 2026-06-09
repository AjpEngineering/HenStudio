-- --------------------------------------------------------------------------------
--  Table: FiredHeaterCapitalCost
--  File : FiredHeaterCapitalCost.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Fired Heater Capital Cost entity for HEN Studio. 
--    Parent entity is Project. Leaf entity.
--    FiredHeaterCapitalCost contains Fired Heater capital cost parameter
--    data used by Pinch & Hen engines.
--    
--    Conceptual Cost Configuration Fired Heater capital cost includes ...
--      Fired Heater Capital Cost alpha Parameter ... 200000.00 | 74924.31
--      Fired Heater Capital Cost beta Parameter .................... 0.80
--      Fired Heater Capital Cost Efficiency Parameter .............. 0.85
--      Fired Heater Capital Cost Duty Units ................. MWh | MMBtu
--
--    FiredHeaterCapitalCost includes fields for ...
--      + Id         PK (GUID)
--      + Project Id FK to Project (GUID)
--      + Parameter  alpha Metric  (e.g., 200000.00)
--      + Parameter  alpha English (e.g.,  74924.31)
--      + Parameter  beta		   (e.g.,      0.80)
--      + Parameter  Efficiency    (e.g.,      0.85)
--      + Duty Units Metric        (e.g.,       MWh) ... EXTERNAL Units
--      + Duty Units English       (e.g.,     MMBtu) ... EXTERNAL Units
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
--    01/01/26 .. AJP Engineering .. Version 1.0 : SQL Server Version
--    06/01/26 .. AJP Engineering .. Version 1.1 : SQLite Version
-- ================================================================================

CREATE TABLE FiredHeaterCapitalCost (
    Id                      TEXT NOT NULL,
	ProjectId               TEXT NOT NULL,
	ParameterAlpha_Metric   REAL NOT NULL DEFAULT 200000.00,
	ParameterAlpha_English  REAL NOT NULL DEFAULT 74924.31,
	ParameterBeta           REAL NOT NULL DEFAULT 0.80,
	Efficiency              REAL NOT NULL DEFAULT 0.85,
	DutyUnits_Metric        TEXT NOT NULL DEFAULT 'MWh',
	DutyUnits_English       TEXT NOT NULL DEFAULT 'MMBtu',

	PRIMARY KEY(Id),
	FOREIGN KEY (ProjectId) REFERENCES Project(Id)
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
