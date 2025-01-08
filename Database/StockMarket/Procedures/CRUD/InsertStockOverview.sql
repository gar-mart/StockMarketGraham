CREATE PROCEDURE Financial.InsertStockOverview
(
    @StockOverviewData Financial.StockOverviewTVP READONLY,
	@stockId INT
)
AS
BEGIN
    INSERT INTO Financial.StockOverview
    (
        StockId, Symbol, AssetType, Name, Description, CIK, Exchange, Currency, Country, Sector, Industry,
        Address, OfficialSite, FiscalYearEnd, LatestQuarter, MarketCapitalization, EBITDA,
        PERatio, PEGRatio, BookValue, DividendPerShare, DividendYield, EPS, RevenuePerShareTTM,
        ProfitMargin, OperatingMarginTTM, ReturnOnAssetsTTM, ReturnOnEquityTTM, RevenueTTM,
        GrossProfitTTM, DilutedEPSTTM, QuarterlyEarningsGrowthYOY, QuarterlyRevenueGrowthYOY,
        AnalystTargetPrice, Beta, WeekHigh52, WeekLow52, MovingAverage50Day, MovingAverage200Day,
        SharesOutstanding, DividendDate, ExDividendDate
    )
    SELECT 
        @stockId, Symbol, AssetType, Name, Description, CIK, Exchange, Currency, Country, Sector, Industry,
        Address, OfficialSite, FiscalYearEnd, LatestQuarter, MarketCapitalization, EBITDA,
        PERatio, PEGRatio, BookValue, DividendPerShare, DividendYield, EPS, RevenuePerShareTTM,
        ProfitMargin, OperatingMarginTTM, ReturnOnAssetsTTM, ReturnOnEquityTTM, RevenueTTM,
        GrossProfitTTM, DilutedEPSTTM, QuarterlyEarningsGrowthYOY, QuarterlyRevenueGrowthYOY,
        AnalystTargetPrice, Beta, WeekHigh52, WeekLow52, MovingAverage50Day, MovingAverage200Day,
        SharesOutstanding, DividendDate, ExDividendDate
    FROM @StockOverviewData
END
