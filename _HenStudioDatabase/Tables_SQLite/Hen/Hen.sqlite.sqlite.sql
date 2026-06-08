-- Converted for SQLite: Hen table
CREATE TABLE (
    Id TEXT NOT NULL PRIMARY KEY,         -- store GUID as TEXT (app should set NEW GUID)
    PinchId TEXT NOT NULL,
    Name TEXT NOT NULL,
    Description TEXT NULL,
    FOREIGN KEY (PinchId) REFERENCES Pinch(Id)
);
-- Note: enable foreign keys at runtime: PRAGMA foreign_keys = ON;