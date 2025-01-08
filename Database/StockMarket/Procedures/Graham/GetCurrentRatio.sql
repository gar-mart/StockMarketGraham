
CREATE PROCEDURE GetCurrentRatio
AS
SET NOCOUNT ON


SELECT TOP 1 
    TotalCurrentAssets / TotalCurrentLiabilities AS CurrentRatio
FROM Financial.BalanceSheet
ORDER BY FiscalDateEnding DESC

