CREATE TABLE Financial.QuarterlyEPS (
    Id INT PRIMARY KEY IDENTITY(1,1),
    StockId INT NOT NULL,
    FiscalDateEnding DATE NOT NULL,
    ReportedDate DATE NOT NULL,
    ReportedEPS DECIMAL(18,6) NOT NULL,
    EstimatedEPS DECIMAL(18,6),
    Surprise DECIMAL(18,6),
    SurprisePercentage DECIMAL(18,6),
    ReportTime NVARCHAR(50),
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (StockId) REFERENCES Entity.Stock(Id)
);
