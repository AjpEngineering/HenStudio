-- --------------------------------------------------------------------------------
--  Table: CompositeCurve
--  File : CompositeCurve.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    CompositeCurve Data entity for HEN Studio. 
--    Parent entity is Pinch. Contains zero or more CompositeCurvePointID child entities.
--    CompositeCurve contains T-H Composite Curve data used to visualize 
--    composite Temp-Enthapy relationship.
--    NOTE: The CompositeCurvePointID child table contains the Hot data points, or the 
--          Cold data points, or both, depending on the Curve Type.
--    CompositeCurve includes fields for ...
--      + PK (GUID)
--      + FK to Pinch (GUID)
--      + Curve Type    [Hot | Cold  |Combined]
--      + Curve Subtype [Raw | Shifted]
--      + Curve Title (e.g., "Hot Composite Curve")
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

CREATE TABLE CompositeCurve (
    Id           TEXT NOT NULL,
	PinchId      TEXT NOT NULL,
	CurveType    TEXT NOT NULL DEFAULT 'Hot',
	CurveSubtype TEXT NOT NULL DEFAULT 'Raw',
	Title        TEXT NOT NULL DEFAULT 'Hot Composite Curve',
	XAxisLabel   TEXT NOT NULL DEFAULT 'Duty',
	YAxisLabel   TEXT NOT NULL DEFAULT 'Temperature',

	PRIMARY KEY(Id),
	FOREIGN KEY (PinchId) REFERENCES Pinch(Id),

	CONSTRAINT CK_CompositeCurve_CurveType CHECK (CurveType IN ('Hot', 'Cold', 'Combined')),
	CONSTRAINT CK_CompositeCurve_CurveSubtype CHECK (CurveSubtype IN ('Raw', 'Shifted'))
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
