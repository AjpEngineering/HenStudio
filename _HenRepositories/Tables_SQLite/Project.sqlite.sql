-- ============================================================================
--  Table: Project
--  File : Project.sqlite.sql
-- ============================================================================
--
--  Description:
--    Root entity for HEN Studio.
--    Project includes fields for ...
--      + PK (GUID)
--      + Project Name
--      + Project Description
--      + Default HEN Optimizer (Gurobi|CPLEX|GLPK)
--      + Creation Date 
--      + Last Modifed Date
--
-- ============================================================================
--  (c)Copyright 2026 AJP Engineering
--  All rights reserved.
-- ============================================================================
--  HISTORY:
--    01/01/26 .. AJP Engineering .. Version 1.0 : SQL Server Version
--    06/01/26 .. AJP Engineering .. Version 1.1 : SQLite Version
-- ================================================================================

CREATE TABLE Project (
    Id               TEXT    NOT NULL,
    Name             TEXT    NOT NULL,
    Description      TEXT    NULL,
    DefaultOptimizer TEXT    NOT NULL DEFAULT 'Gurobi',
    CreationDate     TEXT    NOT NULL,
    ModifiedDate     TEXT    NOT NULL,

    PRIMARY KEY (Id),

    CONSTRAINT CK_Project_DefaultOptimizer CHECK (DefaultOptimizer IN ('Gurobi', 'CPLEX', 'GLPK'))
);

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
