CREATE PROCEDURE Financial.GetBalanceSheetByStockId
    @stockId INT
AS
BEGIN
    SELECT top 3 * 
    FROM Financial.BalanceSheet
    WHERE StockId = @stockId
END
