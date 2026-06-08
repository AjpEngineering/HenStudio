-- --------------------------------------------------------------------------------
--  Table: CompositeCurvePointID
--  File : CompositeCurvePointID.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Composite Curve Point entity for HEN Studio. 
--    Parent entity is CompositeCurve. Leaf entity.
--    CompositeCurvePointID contains individual T-H composite curve data points used
--    to visualize the composite Temp-Enthalpy relationship.
--    CompositeCurvePointID includes fields for ...
--      + PK (GUID)
--      + FK to CompositeCurve (GUID)
--      + Point Curve Type Hot|Cold
--      + Point Sequence Number
--      + Point Enthalpy Value (External Units)
--      + Point Temperature Value (External Units)
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
--    01/01/26 .. AJP Engineering .. Version 1.0
-- ================================================================================

CREATE TABLE (
    Id               TEXT NOT NULL ,
	CompositeCurveId TEXT NOT NULL,
	PointCurveType   TEXT      NOT NULL DEFAULT N'Hot',
	PointSequence    INTEGER              NOT NULL,
	EnthalpyValue    REAL            NOT NULL DEFAULT 0.0,
	TemperatureValue REAL            NOT NULL DEFAULT 0.0,

	PRIMARY KEY(Id)
	FOREIGN KEY (CompositeCurveId) REFERENCES CompositeCurve(Id)
	CONSTRAINT CK_CompositeCurvePointID_PointCurveType CHECK (PointCurveType IN (N'Hot', N'Cold')),
	CONSTRAINT UQ_CompositeCurvePointID_CompositeCurveId_PointCurveType_PointSequence UNIQUE (CompositeCurveId, PointCurveType, PointSequence)
)
