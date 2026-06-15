-- --------------------------------------------------------------------------------
--  Table: AppComponents
--  File : 002_AppComponents.sqlite.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Application Components entity for HEN Studio -> HenStudio.db [Database file].
--    Contains AJP HEN Studio Application Components list.
-- --------------------------------------------------------------------------------
--    Table is seeded at Creation (EXPECTED VALUES) as follows.
--    The last field shows EXPECTED vs. ACTUAL result [FOUND | MISSING | NONE]. 
-- --------------------------------------------------------------------------------
--    1 ... _AJP License File ......... dll ...... FOUND
--    2 ... _HenDomainModel ........... dll ...... FOUND
--    3 ... _HenGlobal ................ dll ...... FOUND
--    4 ... _HenModel ................. dll ...... FOUND
--    5 ... _HenViewModel ............. dll ...... FOUND
--    6 ... HenStudio ................. exe ...... FOUND
--    7 ... HenStudio.config .......... config ... FOUND
--    8 ... HenStudio: {Table Name} ... script ... FOUND
--    x ...     :                        :           :  
--    x ... HenStudio: Seed ........... script ... FOUND
--    x ... Project: {Table Name} ..... script ... FOUND
--    x ...     :                        :           :  
--    x ... Project: Seed ............. script ... FOUND
--    x ... Migration:{Name} .......... script ... FOUND
--    x ...     :                        :           :  
-- --------------------------------------------------------------------------------
--    AppComponents includes fields for ...
--      + ComponentId (PK) ............ e.g., 1
--      + ComponentName ............... e.g., _HenModel
--      + ComponentType ............... e.g., dll
--      + ComponentStatus ............. e.g., FOUND
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
--    06/01/26 .. AJP Engineering .. Version 1.0 : SQLite Version
-- ================================================================================

CREATE TABLE AppComponents (
    ComponentId      INTEGER NOT NULL,
	ComponentName    TEXT    NOT NULL,
	ComponentType    TEXT    NOT NULL,
	ComponentStatus  TEXT    NOT NULL,

	PRIMARY KEY(ComponentId),
	CONSTRAINT CK_AppComponents_ComponentType CHECK (ComponentType IN ('dll', 'exe', 'config', 'script')),
	CONSTRAINT CK_AppComponents_ComponentStatus CHECK (ComponentStatus IN ('FOUND', 'MISSING', 'NONE'))
) STRICT;

-- ================================================================================
-- ---------------------------  E N D   O F   F I L E  ----------------------------
-- ================================================================================
