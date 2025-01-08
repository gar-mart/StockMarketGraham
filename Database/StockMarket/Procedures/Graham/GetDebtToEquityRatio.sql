
CREATE PROCEDURE GetDebtToEquityRatio
AS
SET NOCOUNT ON

SELECT TOP 1 
    TotalLiabilities / TotalShareholderEquity AS DebtToEquityRatio
FROM Financial.BalanceSheet
ORDER BY FiscalDateEnding DESC

