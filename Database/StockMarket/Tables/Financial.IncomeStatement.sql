CREATE TABLE Financial.IncomeStatement (
    Id INT IDENTITY(1,1) PRIMARY KEY, 
    StockId INT  NULL,
    FiscalDateEnding DATE  NULL,
    ReportedCurrency NVARCHAR(10)  NULL,
    GrossProfit DECIMAL(15,2)  NULL,
    TotalRevenue DECIMAL(15,2)  NULL,
    CostOfRevenue DECIMAL(15,2)  NULL,
    CostOfGoodsAndServicesSold DECIMAL(15,2)  NULL,
    OperatingIncome DECIMAL(15,2)  NULL,
    SellingGeneralAndAdministrative DECIMAL(15,2)  NULL,
    ResearchAndDevelopment DECIMAL(15,2)  NULL,
    OperatingExpenses DECIMAL(15,2)  NULL,
    InvestmentIncomeNet DECIMAL(15,2)  NULL,
    NetInterestIncome DECIMAL(15,2)  NULL,
    InterestIncome DECIMAL(15,2)  NULL,
    InterestExpense DECIMAL(15,2)  NULL,
    NonInterestIncome DECIMAL(15,2)  NULL,
    OtherNonOperatingIncome DECIMAL(15,2)  NULL,
    Depreciation DECIMAL(15,2)  NULL,
    DepreciationAndAmortization DECIMAL(15,2)  NULL,
    IncomeBeforeTax DECIMAL(15,2)  NULL,
    IncomeTaxExpense DECIMAL(15,2)  NULL,
    InterestAndDebtExpense DECIMAL(15,2)  NULL,
    NetIncomeFromContinuingOperations DECIMAL(15,2)  NULL,
    ComprehensiveIncomeNetOfTax DECIMAL(15,2)  NULL,
    Ebit DECIMAL(15,2)  NULL,
    Ebitda DECIMAL(15,2)  NULL,
    NetIncome DECIMAL(15,2)  NULL

    Constraint FK_IncomeStatement_Stock FOREIGN KEY (StockId) 
    REFERENCES Entity.Stock(Id)
)



