﻿CREATE PROCEDURE InsertIncomeStatement(
    @IncomeStatements Financial.IncomeStatementTVP READONLY
    ,@stockId INT
)
AS
BEGIN
    INSERT INTO Financial.IncomeStatement 
    (
        StockId, 
        FiscalDateEnding, 
        ReportedCurrency, 
        GrossProfit, 
        TotalRevenue, 
        CostOfRevenue, 
        CostOfGoodsAndServicesSold, 
        OperatingIncome, 
        SellingGeneralAndAdministrative, 
        ResearchAndDevelopment, 
        OperatingExpenses, 
        InvestmentIncomeNet, 
        NetInterestIncome, 
        InterestIncome, 
        InterestExpense, 
        NonInterestIncome, 
        OtherNonOperatingIncome, 
        Depreciation, 
        DepreciationAndAmortization, 
        IncomeBeforeTax, 
        IncomeTaxExpense, 
        InterestAndDebtExpense, 
        NetIncomeFromContinuingOperations, 
        ComprehensiveIncomeNetOfTax, 
        Ebit, 
        Ebitda, 
        NetIncome
    ) 
    SELECT 
        @stockId, 
        FiscalDateEnding, 
        ReportedCurrency, 
        GrossProfit, 
        TotalRevenue, 
        CostOfRevenue, 
        CostOfGoodsAndServicesSold, 
        OperatingIncome, 
        SellingGeneralAndAdministrative, 
        ResearchAndDevelopment, 
        OperatingExpenses, 
        InvestmentIncomeNet, 
        NetInterestIncome, 
        InterestIncome, 
        InterestExpense, 
        NonInterestIncome, 
        OtherNonOperatingIncome, 
        Depreciation, 
        DepreciationAndAmortization, 
        IncomeBeforeTax, 
        IncomeTaxExpense, 
        InterestAndDebtExpense, 
        NetIncomeFromContinuingOperations, 
        ComprehensiveIncomeNetOfTax, 
        Ebit, 
        Ebitda, 
        NetIncome
    FROM @IncomeStatements
END
