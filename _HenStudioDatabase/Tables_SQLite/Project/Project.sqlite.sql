-- ============================================================================
--  Table: Project
--  File : Project.sql
-- ============================================================================
--
--  Description:
--    Root entity for HEN Studio.
--    Project includes fields for ...
--      + PK (GUID)
--      + Project Name
--      + Project Description
--      + Default HEN Optimizer (Genetic|Greedy|MILP)
--      + Creation Date 
--      + Last Modifed Date
--
-- ============================================================================
--  (c)Copyright 2026 AJP Engineering
--  All rights reserved.
-- ============================================================================
--  HISTORY:
--    01/01/26 .. AJP Engineering .. Version 1.0
-- ============================================================================
CREATE TABLE (
    Id TEXT NOT NULL ,
    Name TEXT NOT NULL,
    Description TEXT NULL,
    DefaultOptimizer TEXT NOT NULL DEFAULT N'Genetic',
    CreationDate TEXT NOT NULL ,
    ModifiedDate TEXT NOT NULL ,

    PRIMARY KEY(Id)

    CONSTRAINT CK_Project_DefaultOptimizer CHECK (DefaultOptimizer IN (N'Genetic', N'Greedy', N'MILP'))
);
