-- --------------------------------------------------------------------------------
--  Table: UtilityStream
--  File : UtilityStream.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Utility Stream entity for HEN Studio. 
--    Parent entity is Profile. Leaf entity.
--    UtilityStream contains utility stream data used for Pinch & Hen engines.
--    UtilityStream includes fields for ...
--      + PK (GUID)
--      + FK to Profile (GUID)
--      + Stream Category [Process|Utility]
-- 	    + Stream Heat [Sensible|Latent]
--      + Stream ID [e.g., CW01]
--      + Stream Name [e.g., Naptha Top Condenser]
--      + Stream Type [Refrig|Cold Water|LP Steam|MP Steam|HP Steam]
--	    + Stream Isothermal Temperature (Internal Units)
--	    + Stream Supply Pressure (Internal Units)
--	    + Stream Target Pressure (Internal Units)
--	    + Stream Enthalpy Flow Rate - [H - Duty] (Internal Units)
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

CREATE TABLE [dbo].[UtilityStream]
(
	[Id] INT NOT NULL PRIMARY KEY
)
