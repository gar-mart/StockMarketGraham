﻿--CREATE TABLE Financial.AnnualEPS (
--    EPSId INT PRIMARY KEY IDENTITY(1,1),
--    StockId INT NOT NULL,
--    FiscalDateEnding DATE NOT NULL,
--    ReportedEPS DECIMAL(18,6) NOT NULL,
--    CreatedAt DATETIME DEFAULT GETDATE(),
--    FOREIGN KEY (StockId) REFERENCES Financial.StockOverview(StockId)
--);
