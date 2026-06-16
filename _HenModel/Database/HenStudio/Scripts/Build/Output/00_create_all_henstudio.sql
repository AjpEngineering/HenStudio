-- -----------------------------------------------------------------------------
-- Combined CREATE script for HenStudio
-- Generated: 2026-06-16 11:15:51Z
-- Source folder: C:\_AJP\git\HenStudio\_HenModel\Database\HenStudio\Scripts\Build
-- -----------------------------------------------------------------------------

PRAGMA foreign_keys = ON;
BEGIN TRANSACTION;


-- Start: 001_AppMetadata.sqlite

CREATE TABLE AppMetadata (
    AppMetadataId     INTEGER NOT NULL,
    AppMetadataName   TEXT    NOT NULL,
    AppMetadataValue  TEXT    NOT NULL,

    PRIMARY KEY(AppMetadataId)
) STRICT;

-- End: 001_AppMetadata.sqlite


-- Start: 002_AppComponents.sqlite

CREATE TABLE AppComponents (
    ComponentId      INTEGER NOT NULL,
	ComponentName    TEXT    NOT NULL,
	ComponentType    TEXT    NOT NULL,

	PRIMARY KEY(ComponentId),
	CONSTRAINT CK_AppComponents_ComponentType CHECK (ComponentType IN ('dll', 'exe', 'config', 'script'))
) STRICT;

-- End: 002_AppComponents.sqlite


-- Start: 003_AppSettings.sqlite

CREATE TABLE AppSettings (
    AppSettingId     INTEGER NOT NULL,
	AppSettingName   TEXT NOT NULL,
	AppSettingValue  TEXT NULL,

	PRIMARY KEY(AppSettingsId)
) STRICT;

-- End: 003_AppSettings.sqlite


COMMIT;

