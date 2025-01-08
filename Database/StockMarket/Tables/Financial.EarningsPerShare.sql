CREATE TABLE Financial.EarningsPerShare
(
    StockId INT NOT NULL,
    FiscalDateEnding DATE NOT NULL,
    Value DECIMAL(5,3) NOT NULL

    Constraint FK_EarningsPerShare_Stock FOREIGN KEY (StockId) 
    REFERENCES Entity.Stock(Id)


)




