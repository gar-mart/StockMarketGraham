CREATE PROCEDURE Financial.GetCashflowByStockId
    @stockId INT
AS
BEGIN
    SELECT top 3 * 
    FROM Financial.Cashflow
    WHERE StockId = @stockId
END
