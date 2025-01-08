CREATE PROCEDURE Financial.GetIncomeStatementByStockId
    @stockId INT
AS
BEGIN
    SELECT top 3 * 
    FROM Financial.IncomeStatement
    WHERE StockId = @stockId
END
