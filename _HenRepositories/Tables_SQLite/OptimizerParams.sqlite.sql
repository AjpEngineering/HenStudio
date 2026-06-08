-- --------------------------------------------------------------------------------
--  Table: OptimizerParams
--  File : OptimizerParams.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Optimizer parameters for HEN Studio. Parent table.
--    OptimizerParams includes fields for ...
--      + PK (GUID)
--      + FK to Project (GUID)
--      + Optimizer Name
--      + Optimizer Description
--      + Optimizer Type Genetic|Greedy|MILP
--      + Default Optimizer Objective Total Annual Cost|Total Energy Consumption
--      + Default Max Number of Optimizer Iterations
--      + Default Optimizer Convergence Tolerance
--      + Genetic specific fields in OptimizerGeneticParams
--      + Greedy specific fields in OptimizerGreedyParams
--      + MILP specific fields in OptimizerMILP_Params
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
    Id                          TEXT NOT NULL ,
	ProjectId                   TEXT NOT NULL,
	Name                        TEXT    NOT NULL,
	Description                 TEXT   NULL,
	OptimizerType               TEXT     NOT NULL DEFAULT N'Genetic',
	DefaultObjective            TEXT     NOT NULL DEFAULT N'Total Annual Cost',
	DefaultMaxIterations        INTEGER              NOT NULL DEFAULT 1000,
	DefaultConvergenceTolerance REAL            NOT NULL DEFAULT 0.001,

	PRIMARY KEY(Id)
	FOREIGN KEY (ProjectId) REFERENCES Project(Id)
	CONSTRAINT CK_OptimizerParams_OptimizerType CHECK (OptimizerType IN (N'Genetic', N'Greedy', N'MILP')),
	CONSTRAINT CK_OptimizerParams_DefaultObjective CHECK (DefaultObjective IN (N'Total Annual Cost', N'Total Energy Consumption'))
)
