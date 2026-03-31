CREATE TABLE Items (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Weight FLOAT,
    ParentId INT NULL
);
