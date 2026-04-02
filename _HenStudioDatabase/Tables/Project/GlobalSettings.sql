-- --------------------------------------------------------------------------------
--  Table: GlobalSettings
--  File : GlobalSettings.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Global Settings entity for HEN Studio.
--    Root configuration table for database-wide application settings.
--    GlobalSettings includes fields for ...
--      + Setting Key (PK)
--      + Setting Value
--      + Value Type [e.g., int|string|bool|double]
--      + Setting Description
--      + Updated On
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

CREATE TABLE [dbo].[GlobalSettings]
(
	[SettingKey]   NVARCHAR(128)   NOT NULL,
	[SettingValue] NVARCHAR(1024)  NULL,
	[ValueType]    NVARCHAR(48)    NOT NULL,
	[Description]  NVARCHAR(1024)  NULL,
	[UpdatedOn]    DATETIME2(7)    NOT NULL DEFAULT SYSUTCDATETIME(),

	CONSTRAINT [PK_GlobalSettings] PRIMARY KEY CLUSTERED ([SettingKey])
)
