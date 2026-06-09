-- --------------------------------------------------------------------------------
--  Table: HeatReleaseCurvePointID
--  File : HeatReleaseCurvePointID.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Heat Release Curve Point entity for HEN Studio. 
--    Parent entity is HeatReleaseCurve. Leaf entity.
--    HeatReleaseCurvePointID contains individual Duty-Temperature curve data points
--    used to visualize the Exchanger Duty - Temp relationship.
--    HeatReleaseCurvePointID includes fields for ...
--      + PK (GUID)
--      + FK to HeatReleaseCurve (GUID)
--      + Point Sequence Number
--      + Point Duty Value (EXTERNAL Units)
--      + Point Temperature Value (EXTERNAL Units)
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

CREATE TABLE HeatReleaseCurvePointID (
    Id                 TEXT    NOT NULL,
	HeatReleaseCurveId TEXT    NOT NULL,
	PointSequence      INTEGER NOT NULL,
	DutyValue          REAL    NOT NULL DEFAULT 0.0,
	TemperatureValue   REAL    NOT NULL DEFAULT 0.0,

	PRIMARY KEY(Id),
	FOREIGN KEY (HeatReleaseCurveId) REFERENCES HeatReleaseCurve(Id),

	CONSTRAINT UQ_HeatReleaseCurvePointID_HeatReleaseCurveId_PointSequence UNIQUE (HeatReleaseCurveId, PointSequence)
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
