-- --------------------------------------------------------------------------------
--  Table: THDiagram
--  File : THDiagram.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Temperature-Enthalpy Diagram Data entity for HEN Studio. 
--    Parent entity is Profile. Contains zero or more THDiagramPoint child entities.
--    THDiagram contains T-H diagram data used to visualize 
--    Temp-Enthapy relationship.
--    THDiagram includes fields for ...
--      + PK (GUID)
--      + FK to Profile (GUID)
--      + Diagram Type [Hot|Cold]
--      + Diagram Title (e.g. "Hot T-H Diagram")
--	    + Diagram X-Axis Label (e.g.,"Enthalpy (MMBtu/hr)") ... External Units
--      + Diagram Y-Axis Label (e.g.,"Temperature (°F)") ...... External Units
--      + Zero or more THDiagramPoint child entities containing T-H data points
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

CREATE TABLE [dbo].[THDiagram]
(
    [Id]             UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[ProfileId]      UNIQUEIDENTIFIER NOT NULL,
	[DiagramType]    NVARCHAR(8)      NOT NULL DEFAULT N'Hot',
	[Title]          NVARCHAR(256)    NOT NULL,
	[XAxisLabel]     NVARCHAR(256)    NOT NULL,
	[YAxisLabel]     NVARCHAR(256)    NOT NULL,

	CONSTRAINT [PK_THDiagram] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [FK_THDiagram_Profile] FOREIGN KEY ([ProfileId]) REFERENCES [dbo].[Profile]([Id]),
	CONSTRAINT [CK_THDiagram_DiagramType] CHECK ([DiagramType] IN (N'Hot', N'Cold'))
)
