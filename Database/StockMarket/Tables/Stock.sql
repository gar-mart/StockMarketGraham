CREATE TABLE Entity.Stock
(
    Id INT PRIMARY KEY IDENTITY(1,1), 
    Name NVARCHAR(100) NOT NULL,
    Symbol NVARCHAR(10) NOT NULL,
    ParentId INT NULL,

    Constraint FK_Stock_Parent FOREIGN KEY (ParentId) 
    REFERENCES Entity.Stock(Id)
)
