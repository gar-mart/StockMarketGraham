CREATE PROCEDURE GetPERatio(@StockId INT)
AS
BEGIN
	
	DECLARE @StockPrice INT = GetAvg10YearStockPrice

	SELECT @StockPrice / AVG(EPS) FROM
	Financial.EarningsPerShare
	
	WHERE FiscalDateEnding >= DATEADD(YEAR, -10, GETDATE())
		  AND StockId = @StockId
	 
END
