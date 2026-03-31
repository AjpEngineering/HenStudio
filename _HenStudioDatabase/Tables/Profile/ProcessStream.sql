-- --------------------------------------------------------------------------------
--  Table: ProcessStream
--  File : ProcessStream.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Process Stream entity for HEN Studio. 
--    Parent entity is Profile. Leaf entity.
--    Process Stream contains process stream data used for Pinch & Hen engines.
--    ProcessStream includes fields for ...
--      + PK (GUID)
--      + FK to Profile (GUID)
--      + Stream Category [Process|Utility]
-- 	    + Stream Heat [Sensible|Latent]
--      + Stream ID [e.g., H01]
--      + Stream Segment ID [e.g., H01-1]
--      + Stream Name [e.g., Naptha Feed]
--      + Stream Type [Hot|Cold]
--      + Stream Subtype [Liquid|Vapor|Mixed]
--	    + Stream Supply Temperature (Internal Units)
--	    + Stream Supply Pressure (Internal Units)
--	    + Stream Target Temperature (Internal Units)
--	    + Stream Target Pressure (Internal Units)
--	    + Stream Heat Capacity Flow Rate - [CP] (Internal Units)
--	    + Stream Heat Transfer Coefficient - [U] (Internal Units)
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

CREATE TABLE [dbo].[ProcessStream]
(
	[Id] INT NOT NULL PRIMARY KEY
)
