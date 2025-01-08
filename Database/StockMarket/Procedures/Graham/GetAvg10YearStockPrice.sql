
CREATE PROCEDURE GetAvg10YearStockPrice(@StockId INT)
AS

DECLARE @Dates TABLE (Date DATETIME);

-- Insert data from the procedure into the temporary table
INSERT INTO @Dates (Date)
EXEC GetDateRange10Years;


SELECT AVG(AdjClose) FROM DATA.StockData

WHERE StockId = @StockId
AND DATE IN (SELECT Date FROM @Dates)

