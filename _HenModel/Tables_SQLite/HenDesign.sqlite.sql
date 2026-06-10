-- --------------------------------------------------------------------------------
--  Table: HenDesign
--  File : HenDesign.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Hen design data for HEN Studio. 
--    Parent entity is Results [under Study]. Leaf entity.
--    HenDesign contains the Hen engine results.
--    HenDesign includes fields for ...
--      + PK (GUID)
--      + FK to Study (GUID)
--      + HenDesign Name
--      + HenDesign Description
--      + Feasible Design Flag (INTEGER ... [0=false ; 1=true] )
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

CREATE TABLE HenDesign (
    Id                 TEXT NOT NULL,
	ResultsId          TEXT NOT NULL,
	Name               TEXT NOT NULL,
	Description        TEXT NULL,
	FeasibleDesignFlag INTEGER NOT NULL DEFAULT 0 CHECK (FeasibleDesignFlag IN (0,1)),

	PRIMARY KEY(Id),
	FOREIGN KEY (ResultsId) REFERENCES Results(Id)
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
