CREATE PROCEDURE Financial.GetStockHistoryById 
    @stockId INT
AS
BEGIN
    SELECT Date, AdjClose 
    FROM Data.StockData
    WHERE StockId = @stockId
	ORDER BY Date
END
