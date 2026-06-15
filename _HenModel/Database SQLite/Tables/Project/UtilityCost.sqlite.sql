-- --------------------------------------------------------------------------------
--  Table: UtilityCost
--  File : UtilityCost.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Utility Cost entity for HEN Studio. 
--    Parent entity is Project. Leaf entity.
--    UtilityCost contains utility cost values data used by Pinch & Hen engines.
--    
--    Conceptual Cost Configuration Utility Cost includes ...
--      Utility HP Steam Cost ........ 40.94 | 12.00
--      Utility MP Steam Cost ........ 34.12 | 10.00
--      Utility LP Steam Cost ........ 27.30 |  8.00
--      Utility Cooling Water Cost ...  0.34 |  0.10
--      Utility Chilled Water Cost ... 68.24 | 20.00
--      Utility Fuel Gas Cost ........ 20.47 |  6.00
--      Utility Cost Duty Units ........ MWh | MMBtu  ... [EXTERNAL Units]
--
--    UtilityCost includes fields for ...
--      + Id         PK (GUID)
--      + Project Id FK to Project (GUID)
--      + Utility HP Steam Cost Metric        (e.g., 40.94)
--      + Utility MP Steam Cost Metric        (e.g., 34.12)
--      + Utility LP Steam Cost Metric        (e.g., 27.30)
--      + Utility Cooling Water Cost Metric   (e.g., 0.34)
--      + Utility Chilled Water Cost Metric   (e.g., 68.24)
--      + Utility Fuel Gas Cost Metric        (e.g., 20.47)
--      + Utility HP Steam Cost English       (e.g., 12.00)
--      + Utility MP Steam Cost English       (e.g., 10.00)
--      + Utility LP Steam Cost English       (e.g.,  8.00)
--      + Utility Cooling Water Cost English  (e.g.,  0.10)
--      + Utility Chilled Water Cost English  (e.g., 20.00)
--      + Utility Fuel Gas Cost English       (e.g.,  6.00)
--      + Utility Cost Units Metric           (e.g.,   MWh)
--      + Utility Cost Units English          (e.g., MMBtu)
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

CREATE TABLE UtilityCost (
    Id                       TEXT NOT NULL,
	ProjectId                TEXT NOT NULL,
	HP_SteamCost_Metric      REAL NOT NULL DEFAULT 40.94,
	MP_SteamCost_Metric      REAL NOT NULL DEFAULT 34.12,
	LP_SteamCost_Metric      REAL NOT NULL DEFAULT 27.30,
	CoolingWaterCost_Metric  REAL NOT NULL DEFAULT 0.34,
	ChilledWaterCost_Metric  REAL NOT NULL DEFAULT 68.24,
	FuelGasCost_Metric       REAL NOT NULL DEFAULT 20.47,
	HP_SteamCost_English     REAL NOT NULL DEFAULT 12.00,
	MP_SteamCost_English     REAL NOT NULL DEFAULT 10.00,
	LP_SteamCost_English     REAL NOT NULL DEFAULT 8.00,
	CoolingWaterCost_English REAL NOT NULL DEFAULT 0.10,
	ChilledWaterCost_English REAL NOT NULL DEFAULT 20.00,
	FuelGasCost_English      REAL NOT NULL DEFAULT 6.00,
	DutyUnits_Metric         TEXT NOT NULL DEFAULT 'MWh',
	DutyUnits_English        TEXT NOT NULL DEFAULT 'MMBtu',

	PRIMARY KEY(Id),
	FOREIGN KEY (ProjectId) REFERENCES Project(Id)
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
