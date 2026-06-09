-- --------------------------------------------------------------------------------
--  Table: Profile
--  File : Profile.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Input Profile entity for HEN Studio. 
--    Parent entity is Project. Contains zero or more Pinch child entities.
--    Profile contains input parameters for the HEN Studio Pinch Targets engine.
--    Profile includes fields for ...
--      + PK (GUID)
--      + FK to Project (GUID)
--      + Profile Name
--      + Profile Description
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

CREATE TABLE Profile (
    Id            TEXT NOT NULL,
	ProjectId     TEXT NOT NULL,
	Name          TEXT NOT NULL,
	Description   TEXT NULL,

	PRIMARY KEY(Id),
	FOREIGN KEY (ProjectId) REFERENCES Project(Id)
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
