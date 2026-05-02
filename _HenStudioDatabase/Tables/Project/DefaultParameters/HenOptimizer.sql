-- --------------------------------------------------------------------------------
--  Table: HenOptimizer
--  File : HenOptimizer.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Hen Optimizer entity for HEN Studio. Parent table.
--    HenOptimizer includes fields for ...
--      + PK (GUID)
--      + FK to Project (GUID)
--      + Optimizer Name
--      + Optimizer Description
--      + Optimizer Type [Genetic|Greedy|MILP]
--      + Default HEN Optimizer Objective [Total Annual Cost|Total Energy Consumption]
--      + Default Max Number of HEN Optimizer Iterations
--      + Default HEN Optimizer Convergence Tolerance
--      + Genetic specific fields in HenOptimizerGenetic
--      + Greedy specific fields in HenOptimizerGreedy
--      + MILP specific fields in HenOptimizerMILP
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
CREATE TABLE [dbo].[HenOptimizer]
(
   [Id]                          UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[ProjectId]                   UNIQUEIDENTIFIER NOT NULL,
	[Name]                        NVARCHAR(256)    NOT NULL,
	[Description]                 NVARCHAR(1024)   NULL,
	[OptimizerType]               NVARCHAR(48)     NOT NULL DEFAULT N'Genetic',
	[DefaultObjective]            NVARCHAR(48)     NOT NULL DEFAULT N'Total Annual Cost',
	[DefaultMaxIterations]        INT              NOT NULL DEFAULT 1000,
	[DefaultConvergenceTolerance] FLOAT            NOT NULL DEFAULT 0.001,

	CONSTRAINT [PK_HenOptimizer] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_HenOptimizer_Project] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Project]([Id]),
	CONSTRAINT [CK_HenOptimizer_OptimizerType] CHECK ([OptimizerType] IN (N'Genetic', N'Greedy', N'MILP')),
	CONSTRAINT [CK_HenOptimizer_DefaultObjective] CHECK ([DefaultObjective] IN (N'Total Annual Cost', N'Total Energy Consumption'))
)
