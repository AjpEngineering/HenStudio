-- --------------------------------------------------------------------------------
--  Table: ProcessStreams
--  File : ProcessStreams.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Process Streams entity for HEN Studio. 
--    Parent entity is Profile. Leaf entity.
--    Process Streams contains process stream data used for Pinch & Hen engines.
--    
--    ProcessStreams includes fields for ...
--      + PK (GUID)
--      + FK to Profile (GUID)
--      + Stream Category Process|Utility
-- 	    + Stream Heat Sensible|Latent
--      + Stream ID e.g., H01
--      + Stream Name e.g., Naptha Feed
--      + Stream Type Hot|Cold
--      + Stream Subtype Liquid|Vapor|Mixed
--	    + Stream Supply Temperature (INTERNAL Units)
--	    + Stream Supply Pressure (INTERNAL Units)
--	    + Stream Target Temperature (INTERNAL Units)
--	    + Stream Target Pressure (INTERNAL Units)
--	    + Stream Heat Capacity Flow Rate - CP (INTERNAL Units)
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

CREATE TABLE ProcessStreams (
    Id                    TEXT NOT NULL,
	ProfileId             TEXT NOT NULL,
	StreamCategory        TEXT NOT NULL DEFAULT 'Process',
	StreamHeat            TEXT NOT NULL DEFAULT 'Sensible',
	StreamId              TEXT NOT NULL,
	Name                  TEXT NOT NULL,
	StreamType            TEXT NOT NULL DEFAULT 'Hot',
	StreamSubtype         TEXT NOT NULL DEFAULT 'Liquid',
	SupplyTemperature     REAL NOT NULL DEFAULT 0.0,
	SupplyPressure        REAL NOT NULL DEFAULT 0.0,
	TargetTemperature     REAL NOT NULL DEFAULT 0.0,
	TargetPressure        REAL NOT NULL DEFAULT 0.0,
	HeatCapacityFlowRate  REAL NOT NULL DEFAULT 0.0,

	PRIMARY KEY(Id),
	FOREIGN KEY (ProfileId) REFERENCES Profile(Id),

	CONSTRAINT CK_ProcessStreams_StreamCategory CHECK (StreamCategory IN ('Process', 'Utility')),
	CONSTRAINT CK_ProcessStreams_StreamHeat CHECK (StreamHeat IN ('Sensible', 'Latent')),
	CONSTRAINT CK_ProcessStreams_StreamType CHECK (StreamType IN ('Hot', 'Cold')),
	CONSTRAINT CK_ProcessStreams_StreamSubtype CHECK (StreamSubtype IN ('Liquid', 'Vapor', 'Mixed'))
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
