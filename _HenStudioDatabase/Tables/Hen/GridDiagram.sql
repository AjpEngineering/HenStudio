-- --------------------------------------------------------------------------------
--  Table: GridDiagram
--  File : GridDiagram.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    GridDiagram Data entity for HEN Studio. 
--    Parent entity is Hen. Leaf entity.
--    GridDiagram contains Grid Diagram data used to visualize Hen Design
--    (stream matches).
--    GridDiagram includes fields for ...
--      + PK (GUID)
--      + FK to Hen (GUID)
--      + Diagram Title (e.g., "Grid Diagram")
--      + Diagram Data Points (e.g.,JSON or XML string containing Grid data points)
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

CREATE TABLE [dbo].[GridDiagram]
(
	[Id] INT NOT NULL PRIMARY KEY
)
