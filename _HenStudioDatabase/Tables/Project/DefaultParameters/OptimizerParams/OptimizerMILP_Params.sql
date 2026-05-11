-- --------------------------------------------------------------------------------
--  Table: OptimizerMILP_Params
--  File : OptimizerMILP_Params.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    MILP Optimizer subtype entity for HEN Studio.
--    Parent entity is OptimizerParams. Leaf table.
--    OptimizerMILP_Params includes fields for ...
--      + PK to OptimizerMILP_Params (GUID)
--      + FK to OptimizerParams (GUID)
--      + MILP specific optimizer fields (TBD)
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

CREATE TABLE [dbo].[OptimizerMILP_Params]
(
	[Id]                UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[OptimizerParamsId] UNIQUEIDENTIFIER NOT NULL,

	CONSTRAINT [PK_OptimizerMILP_Params] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_OptimizerMILP_Params_OptimizerParams] FOREIGN KEY ([OptimizerParamsId]) REFERENCES [dbo].[OptimizerParams]([Id])
)
