-- --------------------------------------------------------------------------------
--  Table: GrandCompositeCurve
--  File : GrandCompositeCurve.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    GrandCompositeCurve Data entity for HEN Studio. 
--    Parent entity is Study. 
--    Contains zero or more GrandCompositeCurvePointID child entities.
--    GrandCompositeCurve contains Grand Composite Curve data used to visualize 
--    Pinch Minimum Utility Loads and Pinch Temperatures.
--    GrandCompositeCurve includes fields for ...
--      + PK (GUID)
--      + FK to Study (GUID)
--      + Curve Subtype [Raw | Shifted]
--      + Curve Title (e.g., "Grand Composite Curve")
--	    + Curve X-Axis Label (e.g.,"Enthalpy (MMBtu/hr)") ... EXTERNAL Units
--      + Curve Y-Axis Label (e.g.,"Temperature (°F)") ...... EXTERNAL Units
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

CREATE TABLE GrandCompositeCurve (
    Id           TEXT NOT NULL,
	StudyId      TEXT NOT NULL,
	CurveSubtype TEXT NOT NULL DEFAULT 'Raw',
	Title        TEXT NOT NULL DEFAULT 'Grand Composite Curve',
	XAxisLabel   TEXT NOT NULL DEFAULT 'Duty',
	YAxisLabel   TEXT NOT NULL DEFAULT 'Temperature',

	PRIMARY KEY(Id),
	FOREIGN KEY (StudyId) REFERENCES Study(Id),

	CONSTRAINT CK_GrandCompositeCurve_CurveSubtype CHECK (CurveSubtype IN ('Raw', 'Shifted'))
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
