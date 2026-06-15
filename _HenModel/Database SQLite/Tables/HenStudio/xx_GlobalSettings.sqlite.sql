-- --------------------------------------------------------------------------------
--  Table: GlobalSettings   [DEPECRATED ... now 03_AppSettings TABLE]
--  File : xx_GlobalSettings.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Global Settings entity for HEN Studio -> HenStudio.db [Database file].
--    Contains AJP HEN Studio application settings.
--    GlobalSettings includes fields for ...
--      + Setting Key (PK)
--      + Setting Value
--      + Value Type e.g., ["INTEGER" | "TEXT" | "REAL"]
--      + Setting Description
--      + Revision e.g, 1.0
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

CREATE TABLE GlobalSettings (
    Id           TEXT NOT NULL,
	SettingKey   TEXT NOT NULL,
	SettingValue TEXT NULL,
	ValueType    TEXT NOT NULL DEFAULT 'TEXT',
	Description  TEXT NULL,
	Revision     REAL NOT NULL DEFAULT 1.0,

	PRIMARY KEY(Id),

	CONSTRAINT CK_GlobalSettings_ValueType CHECK (ValueType IN ('INTEGER', 'TEXT', 'REAL'))

) STRICT;

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
