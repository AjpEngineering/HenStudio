-- --------------------------------------------------------------------------------
--  Table: Targets
--  File : Targets.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Targets entity for HEN Studio. 
--    Parent entity is Pinch. Leaf entity.
--    Targets contains the Pinch Targets engine results.
--    Pinch includes fields for ...
--      + PK (GUID)
--      + FK to Pinch (GUID)
--      + Minimum Hot Utility Load (Internal Units)
--      + Minimum Cold Utility Load (Internal Units)
-- 	    + Minimum Number of Heat Exchangers (Integer)
--      + Hot Pinch Target Temperature (Internal Units)
--	    + Cold Pinch Target Temperature (Internal Units)
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

CREATE TABLE [dbo].[Targets]
(
	[Id] INT NOT NULL PRIMARY KEY
)
