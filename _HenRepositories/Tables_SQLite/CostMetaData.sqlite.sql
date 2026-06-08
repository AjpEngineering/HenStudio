-- --------------------------------------------------------------------------------
--  Table: CostMetaData
--  File : CostMetaData.sql
-- --------------------------------------------------------------------------------
--  Description: 
--    Cost Metadata entity for HEN Studio. 
--    Parent entity is Project. Leaf entity.
--    CostMetaData contains Cost Metadata data used by Pinch & Hen engines.
--    
--    Conceptual Cost Configuration Metadata includes ...
--      Cost Index Base Year (i.e., year of capital cost index) ... 2026
--      Cost Index Name (e.g., CEPCI, ICIS, etc.) ................ CEPCI
--      Cost Index Value (e.g., for CEPCI = 750) ................ 750.00
--      Cost Currency (e.g., USD, EUR, etc.) ....................... USD
--      Cost Index Installed Cost Factor ........................... 3.0
--
--    CostMetaData includes fields for ...
--      + Id PK (GUID)
--      + Project Id FK to Project (GUID)
--      + Cost Index Base Year              (2026)
--      + Cost Index Name                   (e.g., CEPCI)
--  	+ Cost Index Value                  (e.g.,   820)
--      + Cost Currency                     (e.g.,   USD)
--	    + Cost Index Installed Cost Factor  (e.g.,   3.0)
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
    Id                        TEXT NOT NULL ,
	ProjectId                 TEXT NOT NULL,
	CostIndexBaseYear         TEXT      NOT NULL DEFAULT N'2026',
	CostIndexName				TEXT      NOT NULL DEFAULT N'CEPCI',
	CostIndexValue			REAL            NOT NULL DEFAULT 820.0,
	CostIndexCurrency		    TEXT      NOT NULL DEFAULT N'USD',
    CostIndexInstalledCost	REAL            NOT NULL DEFAULT 3.0,

	PRIMARY KEY(Id)
	FOREIGN KEY (ProjectId) REFERENCES Project(Id))
