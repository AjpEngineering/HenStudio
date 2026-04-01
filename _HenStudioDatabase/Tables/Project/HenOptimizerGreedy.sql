-- --------------------------------------------------------------------------------
--  Table: HenOptimizerGreedy
--  File : HenOptimizerGreedy.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Greedy Optimizer subtype entity for HEN Studio.
--    Parent entity is HenOptimizer. Leaf table.
--    HenOptimizerGreedy includes fields for ...
--      + PK/FK to HenOptimizer (GUID)
--      + Greedy specific optimizer fields (TBD)
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

CREATE TABLE [dbo].[HenOptimizerGreedy]
(
	[HenOptimizerId] UNIQUEIDENTIFIER NOT NULL,

	CONSTRAINT [PK_HenOptimizerGreedy] PRIMARY KEY CLUSTERED ([HenOptimizerId]),
	CONSTRAINT [FK_HenOptimizerGreedy_HenOptimizer] FOREIGN KEY ([HenOptimizerId]) REFERENCES [dbo].[HenOptimizer]([Id])
)
