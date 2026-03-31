CREATE TABLE Items (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Weight FLOAT,
    ParentId INT NULL
);

INSERT INTO Items (Name, Weight, ParentId) VALUES ('Item1', 100, NULL);
INSERT INTO Items (Name, Weight, ParentId) VALUES ('Item2', 200, 1);
