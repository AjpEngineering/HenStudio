-- --------------------------------------------------------------------------------
--  Table: THDiagram
--  File : THDiagram.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Temperature-Enthalpy Diagram Data entity for HEN Studio. 
--    Parent entity is Profile. Contains zero or more THDiagramPoint child entities.
--    THDiagram contains T-H diagram data used to visualize 
--    Temp-Enthapy relationship.
--    THDiagram includes fields for ...
--      + PK (GUID)
--      + FK to Profile (GUID)
--      + Diagram Type Hot|Cold
--      + Diagram Title (e.g. "Hot T-H Diagram")
--	    + Diagram X-Axis Label (e.g.,"Enthalpy (MMBtu/hr)") ... EXTERNAL Units
--      + Diagram Y-Axis Label (e.g.,"Temperature (°F)") ...... EXTERNAL Units
--      + Zero or more THDiagramPoint child entities containing T-H data points
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

CREATE TABLE THDiagram (
    Id             TEXT NOT NULL,
	ProfileId      TEXT NOT NULL,
	DiagramType    TEXT NOT NULL DEFAULT 'Hot',
	Title          TEXT NOT NULL,
	XAxisLabel     TEXT NOT NULL DEFAULT 'Duty',
	YAxisLabel     TEXT NOT NULL DEFAULT 'Temperature',

	PRIMARY KEY(Id),
	FOREIGN KEY (ProfileId) REFERENCES Profile(Id),
	CONSTRAINT CK_THDiagram_DiagramType CHECK (DiagramType IN ('Hot', 'Cold'))
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
