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
CREATE TABLE [dbo].[Project]
(
    [Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    [Name] NVARCHAR(256) NOT NULL,
    [Description] NVARCHAR(1024) NULL,
    [DefaultOptimizer] NVARCHAR(16) NOT NULL DEFAULT N'Genetic',
    [CreationDate] DATETIME NOT NULL DEFAULT GETDATE(),
    [ModifiedDate] DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED ([Id]),

    CONSTRAINT [CK_Project_DefaultOptimizer] CHECK ([DefaultOptimizer] IN (N'Genetic', N'Greedy', N'MILP'))
);
