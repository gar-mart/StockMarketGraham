CREATE PROCEDURE GetNetProfitMargin
AS
SELECT NetIncome / TotalRevenue AS NetProfitMargin
FROM Financial.IncomeStatement

WHERE StockId = @StockId


