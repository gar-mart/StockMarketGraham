CREATE VIEW ComprehensiveBalanceSheetAnalysis AS
SELECT
    StockId,
    FiscalDateEnding,
    TotalAssets,
    TotalLiabilities,
    TotalCurrentAssets,
    TotalCurrentLiabilities,
    TotalShareholderEquity,

    -- Current Ratio
    (TotalCurrentAssets / TotalCurrentLiabilities) AS CurrentRatio,

    -- Quick Ratio (Acid-Test Ratio)
    ((TotalCurrentAssets - Inventory) / TotalCurrentLiabilities) AS QuickRatio,

    -- Cash Ratio
    (CashAndCashEquivalentsAtCarryingValue / TotalCurrentLiabilities) AS CashRatio,

    -- Debt-to-Equity Ratio
    (TotalLiabilities / TotalShareholderEquity) AS DebtToEquityRatio,

    -- Equity Ratio
    (TotalShareholderEquity / TotalAssets) AS EquityRatio,

    -- Debt Ratio
    (TotalLiabilities / TotalAssets) AS DebtRatio

FROM
    Financial.BalanceSheet 






