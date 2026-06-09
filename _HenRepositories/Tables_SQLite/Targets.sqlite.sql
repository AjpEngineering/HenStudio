-- --------------------------------------------------------------------------------
--  Table: Targets
--  File : Targets.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Targets entity for HEN Studio. 
--    Parent entity is Pinch. Leaf entity.
--    Targets contains the Pinch Targets engine results.
--    Pinch includes fields for ...
--      + PK (GUID)
--      + FK to Pinch (GUID)
--      + Minimum Hot Utility Load (INTERNAL Units)
--      + Minimum Cold Utility Load (INTERNAL Units)
-- 	    + Minimum Number of Heat Exchangers (Integer)
--      + Hot Pinch Target Temperature (INTERNAL Units)
--	    + Cold Pinch Target Temperature (INTERNAL Units)
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

CREATE TABLE Targets (
    Id                            TEXT NOT NULL ,
	PinchId                       TEXT NOT NULL,
	MinimumHotUtilityLoad         REAL    NOT NULL DEFAULT 0.0,
	MinimumColdUtilityLoad        REAL    NOT NULL DEFAULT 0.0,
	MinimumNumberOfExchangers     INTEGER NOT NULL DEFAULT 1,
	HotPinchTargetTemperature     REAL    NOT NULL DEFAULT 0.0,
	ColdPinchTargetTemperature    REAL    NOT NULL DEFAULT 0.0,

	PRIMARY KEY(Id),
	FOREIGN KEY (PinchId) REFERENCES Pinch(Id)
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
