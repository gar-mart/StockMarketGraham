CREATE TABLE Financial.Cashflow
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    StockId INT NOT NULL,
    FiscalDateEnding DATE NOT NULL,
    ReportedCurrency VARCHAR(10) NOT NULL,
    OperatingCashflow DECIMAL(15,2) NULL,
    PaymentsForOperatingActivities DECIMAL(15,2) NULL,
    ProceedsFromOperatingActivities DECIMAL(15,2) NULL,
    ChangeInOperatingLiabilities DECIMAL(15,2) NULL,
    ChangeInOperatingAssets DECIMAL(15,2) NULL,
    DepreciationDepletionAndAmortization DECIMAL(15,2) NULL,
    CapitalExpenditures DECIMAL(15,2) NULL,
    ChangeInReceivables DECIMAL(15,2) NULL,
    ChangeInInventory DECIMAL(15,2) NULL,
    ProfitLoss DECIMAL(15,2) NULL,
    CashflowFromInvestment DECIMAL(15,2) NULL,
    CashflowFromFinancing DECIMAL(15,2) NULL,
    ProceedsFromRepaymentsOfShortTermDebt DECIMAL(15,2) NULL,
    PaymentsForRepurchaseOfCommonStock DECIMAL(15,2) NULL,
    PaymentsForRepurchaseOfEquity DECIMAL(15,2) NULL,
    PaymentsForRepurchaseOfPreferredStock DECIMAL(15,2) NULL,
    DividendPayout DECIMAL(15,2) NULL,
    DividendPayoutCommonStock DECIMAL(15,2) NULL,
    DividendPayoutPreferredStock DECIMAL(15,2) NULL,
    ProceedsFromIssuanceOfCommonStock DECIMAL(15,2) NULL,
    ProceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet DECIMAL(15,2) NULL,
    ProceedsFromIssuanceOfPreferredStock DECIMAL(15,2) NULL,
    ProceedsFromRepurchaseOfEquity DECIMAL(15,2) NULL,
    ProceedsFromSaleOfTreasuryStock DECIMAL(15,2) NULL,
    ChangeInCashAndCashEquivalents DECIMAL(15,2) NULL,
    ChangeInExchangeRate DECIMAL(15,2) NULL,
    NetIncome DECIMAL(15,2) NULL,
    
    Constraint FK_Cashflow_Stock FOREIGN KEY (StockId) 
    REFERENCES Entity.Stock(Id)
    
)
