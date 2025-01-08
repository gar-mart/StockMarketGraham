

CREATE PROCEDURE GetDividendHistory
AS

SELECT FiscalDateEnding, 
	   DividendPayout
FROM Financial.CashFlow
WHERE StockId = @StockId

