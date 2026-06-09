-- --------------------------------------------------------------------------------
--  Table: Pinch
--  File : Pinch.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Pinch entity for HEN Studio. 
--    Parent entity is Profile. Contains zero or more Hen child entities.
--    Pinch contains the Delta Tmin value and Pinch Targets engine results.
--    Pinch includes fields for ...
--      + PK (GUID)
--      + FK to Profile (GUID)
--      + Pinch Name
--      + Pinch Description
-- 	    + Pinch Delta Tmin (INTERNAL Units)
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

CREATE TABLE Pinch (
    Id            TEXT NOT NULL,
	ProfileId     TEXT NOT NULL,
	Name          TEXT NOT NULL,
	Description   TEXT NULL,
    DeltaTmin     REAL NOT NULL DEFAULT 10.0,

	PRIMARY KEY(Id),
	FOREIGN KEY (ProfileId) REFERENCES Profile(Id)
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
