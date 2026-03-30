CREATE TABLE Items (
    ItemId INT IDENTITY(1,1) PRIMARY KEY,
    ItemName NVARCHAR(100) NOT NULL,
    Weight FLOAT NOT NULL,
    ParentItemId INT NULL,
    IsProcessed BIT DEFAULT 0,
    FOREIGN KEY (ParentItemId) REFERENCES Items(ItemId)
);
