﻿CREATE TABLE Financial.StockOverview(
    StockId INT NOT NULL,
    Symbol NVARCHAR(50) NOT NULL,
    AssetType NVARCHAR(50),
    Name NVARCHAR(255),
    Description NVARCHAR(MAX),
    CIK NVARCHAR(50),
    Exchange NVARCHAR(50),
    Currency NVARCHAR(10),
    Country NVARCHAR(50),
    Sector NVARCHAR(100),
    Industry NVARCHAR(100),
    Address NVARCHAR(255),
    OfficialSite NVARCHAR(255),
    FiscalYearEnd NVARCHAR(50),
    LatestQuarter DATE,
    MarketCapitalization BIGINT,
    EBITDA BIGINT,
    PERatio DECIMAL(18, 6),
    PEGRatio DECIMAL(18, 6),
    BookValue DECIMAL(18, 6),
    DividendPerShare DECIMAL(18, 6),
    DividendYield DECIMAL(18, 6),
    EPS DECIMAL(18, 6),
    RevenuePerShareTTM DECIMAL(18, 6),
    ProfitMargin DECIMAL(18, 6),
    OperatingMarginTTM DECIMAL(18, 6),
    ReturnOnAssetsTTM DECIMAL(18, 6),
    ReturnOnEquityTTM DECIMAL(18, 6),
    RevenueTTM BIGINT,
    GrossProfitTTM BIGINT,
    DilutedEPSTTM DECIMAL(18, 6),
    QuarterlyEarningsGrowthYOY DECIMAL(18, 6),
    QuarterlyRevenueGrowthYOY DECIMAL(18, 6),
    AnalystTargetPrice DECIMAL(18, 6),
    Beta DECIMAL(18, 6),
    WeekHigh52 DECIMAL(18, 6),
    WeekLow52 DECIMAL(18, 6),
    MovingAverage50Day DECIMAL(18, 6),
    MovingAverage200Day DECIMAL(18, 6),
    SharesOutstanding BIGINT,
    DividendDate DATE,
    ExDividendDate DATE,

	Constraint FK_StockOverview_Stock FOREIGN KEY (StockId) 
    REFERENCES Entity.Stock(Id)
)

