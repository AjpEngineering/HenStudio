-- --------------------------------------------------------------------------------
--  Table: GridDiagram
--  File : GridDiagram.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    GridDiagram Data entity for HEN Studio. 
--    Parent entity is Hen. Contains zero or more GridDiagramPointID child entities.
--    GridDiagram contains Grid Diagram data used to visualize Hen Design
--    (stream matches).
--    GridDiagram includes fields for ...
--      + PK (GUID)
--      + FK to HenDesign (GUID)
--      + Diagram Title (e.g., "Grid Diagram")
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

CREATE TABLE GridDiagram (
    Id          TEXT NOT NULL,
	HenDesignId TEXT NOT NULL,
	Title       TEXT NOT NULL DEFAULT 'Grid Diagram',

	PRIMARY KEY(Id),
	FOREIGN KEY (HenDesignId) REFERENCES HenDesign(Id)
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
