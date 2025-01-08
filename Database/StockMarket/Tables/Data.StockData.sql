CREATE TABLE Data.StockData(
	StockId INT NOT NULL,
	Date DATE NULL,
	_Open DECIMAL (15, 4) NULL,
	High DECIMAL (15, 4) NULL,
	Low DECIMAL (15, 4) NULL,
	_Close DECIMAL (15, 4) NULL,
	AdjClose DECIMAL (15, 4) NULL,
	Volume bigint NULL,

	
    CONSTRAINT FK_StockData_Stock FOREIGN KEY (StockId) 
    REFERENCES Entity.Stock(Id)
) 
 