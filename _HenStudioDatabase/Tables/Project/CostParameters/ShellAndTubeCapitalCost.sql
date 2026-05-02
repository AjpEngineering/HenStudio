-- --------------------------------------------------------------------------------
--  Table: ShellAndTubeCapitalCost
--  File : ShellAndTubeCapitalCost.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Shell and Tube Capital Cost entity for HEN Studio. 
--    Parent entity is Project. Leaf entity.
--    ShellAndTubeCapitalCost contains Shell & Tube Exchanger capital cost parameter
--    data used by Pinch & Hen engines.
--    Conceptual Cost Configuration Shell & Tube Exchanger capital cost includes ...
--      Shell & Tube Capital Cost a Parameter ... [10000.00]
--      Shell & Tube Capital Cost b Parameter ..... [800.00 | 170.73]
--      Shell & Tube Capital Cost n Parameter ....... [0.65]
--      Shell & Tube Capital Cost Material Factor ... [1.00]
--      Shell & Tube Capital Cost Area Units ......... [m2 | ft2]
--
--    ShellAndTubeCapitalCost includes fields for ...
--      + Id [PK] (GUID)
--      + Project Id [FK] to Project (GUID)
--      + Parameter a          (e.g., 10000.00)
--      + Parameter b Metric   (e.g.,   800.00)
--      + Parameter b English  (e.g.,   170.73)
--      + Parameter n          (e.g.,     0.65)
--      + Material Factor      (e.g.,     1.00)
--      + Area Units Metric    (e.g.,       m2)
--      + Area Units English   (e.g.,      ft2)
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

CREATE TABLE [dbo].ShellAndTubeCapitalCost
(
    [Id]                  UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[ProjectId]           UNIQUEIDENTIFIER NOT NULL,
	[ParameterA]          FLOAT            NOT NULL DEFAULT 10000.00,
	[ParameterB_Metric]   FLOAT            NOT NULL DEFAULT 800.00,
	[ParameterB_English]  FLOAT            NOT NULL DEFAULT 170.73,
	[ParameterN]          FLOAT            NOT NULL DEFAULT 0.65,
	[MaterialFactor]      FLOAT            NOT NULL DEFAULT 1.00,
	[AreaUnits_Metric]    NVARCHAR(4)      NOT NULL DEFAULT N'm2',
	[AreaUnits_English]   NVARCHAR(4)      NOT NULL DEFAULT N'ft2',

	CONSTRAINT [PK_ShellAndTubeCapitalCost] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_ShellAndTubeCapitalCost_Project] FOREIGN KEY ([ProjectId]) REFERENCES [dbo].[Project]([Id])
)
