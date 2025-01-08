
CREATE VIEW ComprehensiveIncomeAnalysis AS
SELECT
    i.StockId,
    i.FiscalDateEnding,

    -- Return on Assets (ROA)
    (i.NetIncome / b.TotalAssets) AS ROA,

    -- Return on Equity (ROE)
    (i.NetIncome / b.TotalShareholderEquity) AS ROE,

    -- Inventory Turnover
    (i.CostOfGoodsAndServicesSold / b.Inventory) AS InventoryTurnover,

    -- Receivables Turnover
    (i.TotalRevenue / b.CurrentNetReceivables) AS ReceivablesTurnover

FROM
    Financial.BalanceSheet b
JOIN
    Financial.IncomeStatement i ON b.StockId = i.StockId AND b.FiscalDateEnding = i.FiscalDateEnding;



