CREATE PROCEDURE InsertCashflow
(
    @Cashflows Financial.CashflowTVP READONLY,
    @stockId INT
)
AS
BEGIN
    SET NOCOUNT ON

    INSERT INTO Financial.Cashflow 
    (
        StockId,
        FiscalDateEnding,
        ReportedCurrency,
        OperatingCashflow,
        PaymentsForOperatingActivities,
        ProceedsFromOperatingActivities,
        ChangeInOperatingLiabilities,
        ChangeInOperatingAssets,
        DepreciationDepletionAndAmortization,
        CapitalExpenditures,
        ChangeInReceivables,
        ChangeInInventory,
        ProfitLoss,
        CashflowFromInvestment,
        CashflowFromFinancing,
        ProceedsFromRepaymentsOfShortTermDebt,
        PaymentsForRepurchaseOfCommonStock,
        PaymentsForRepurchaseOfEquity,
        PaymentsForRepurchaseOfPreferredStock,
        DividendPayout,
        DividendPayoutCommonStock,
        DividendPayoutPreferredStock,
        ProceedsFromIssuanceOfCommonStock,
        ProceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet,
        ProceedsFromIssuanceOfPreferredStock,
        ProceedsFromRepurchaseOfEquity,
        ProceedsFromSaleOfTreasuryStock,
        ChangeInCashAndCashEquivalents,
        ChangeInExchangeRate,
        NetIncome
    )
    SELECT 
        @stockId,
        FiscalDateEnding,
        ReportedCurrency,
        OperatingCashflow,
        PaymentsForOperatingActivities,
        ProceedsFromOperatingActivities,
        ChangeInOperatingLiabilities,
        ChangeInOperatingAssets,
        DepreciationDepletionAndAmortization,
        CapitalExpenditures,
        ChangeInReceivables,
        ChangeInInventory,
        ProfitLoss,
        CashflowFromInvestment,
        CashflowFromFinancing,
        ProceedsFromRepaymentsOfShortTermDebt,
        PaymentsForRepurchaseOfCommonStock,
        PaymentsForRepurchaseOfEquity,
        PaymentsForRepurchaseOfPreferredStock,
        DividendPayout,
        DividendPayoutCommonStock,
        DividendPayoutPreferredStock,
        ProceedsFromIssuanceOfCommonStock,
        ProceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet,
        ProceedsFromIssuanceOfPreferredStock,
        ProceedsFromRepurchaseOfEquity,
        ProceedsFromSaleOfTreasuryStock,
        ChangeInCashAndCashEquivalents,
        ChangeInExchangeRate,
        NetIncome
    FROM @Cashflows
END
