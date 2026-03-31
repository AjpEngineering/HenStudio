-- --------------------------------------------------------------------------------
--  Table: Project
--  File : Project.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Root entity for HEN Studio. Contains zero or more Profile entities.
--    Project includes fields for ...
--      + PK (GUID)
--      + Project Name
--      + Project Description
--      + Default Exchanger Heat Transfer Coefficient (U)
--      + Default HEN Optimizer [Genetic|Greedy|MILP]
--      + Default System Units (SI|Imperial)
--      + Default Magnitude Units [Base|Kilo|Mega]
--      + Default Temperature Units [C|F|K|R]
--    	+ Default Pressure Units [Pa|bar|psia|psig|psf|atm|inHg|inH2O]
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

CREATE TABLE [dbo].[Project]
(
	[Id] INT NOT NULL PRIMARY KEY
)
