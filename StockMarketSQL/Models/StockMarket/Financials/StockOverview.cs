using Newtonsoft.Json;

namespace StockMarketSQL.Models.StockMarket.Financials
{
	public class StockOverview
	{
		[JsonProperty("Symbol")]
		public string? Symbol { get; set; }

		[JsonProperty("AssetType")]
		public string? AssetType { get; set; }

		[JsonProperty("Name")]
		public string? Name { get; set; }

		[JsonProperty("Description")]
		public string? Description { get; set; }

		[JsonProperty("CIK")]
		public string? CIK { get; set; }

		[JsonProperty("Exchange")]
		public string? Exchange { get; set; }

		[JsonProperty("Currency")]
		public string? Currency { get; set; }

		[JsonProperty("Country")]
		public string? Country { get; set; }

		[JsonProperty("Sector")]
		public string? Sector { get; set; }

		[JsonProperty("Industry")]
		public string? Industry { get; set; }

		[JsonProperty("Address")]
		public string? Address { get; set; }

		[JsonProperty("OfficialSite")]
		public string? OfficialSite { get; set; }

		[JsonProperty("FiscalYearEnd")]
		public string? FiscalYearEnd { get; set; }

		[JsonProperty("LatestQuarter")]
		public DateTime? LatestQuarter { get; set; }

		[JsonProperty("MarketCapitalization")]
		public long? MarketCapitalization { get; set; }

		[JsonProperty("EBITDA")]
		public long? EBITDA { get; set; }

		[JsonProperty("PERatio")]
		public decimal? PERatio { get; set; }

		[JsonProperty("PEGRatio")]
		public decimal? PEGRatio { get; set; }

		[JsonProperty("BookValue")]
		public decimal? BookValue { get; set; }

		[JsonProperty("DividendPerShare")]
		public decimal? DividendPerShare { get; set; }

		[JsonProperty("DividendYield")]
		public decimal? DividendYield { get; set; }

		[JsonProperty("EPS")]
		public decimal? EPS { get; set; }

		[JsonProperty("RevenuePerShareTTM")]
		public decimal? RevenuePerShareTTM { get; set; }

		[JsonProperty("ProfitMargin")]
		public decimal? ProfitMargin { get; set; }

		[JsonProperty("OperatingMarginTTM")]
		public decimal? OperatingMarginTTM { get; set; }

		[JsonProperty("ReturnOnAssetsTTM")]
		public decimal? ReturnOnAssetsTTM { get; set; }

		[JsonProperty("ReturnOnEquityTTM")]
		public decimal? ReturnOnEquityTTM { get; set; }

		[JsonProperty("RevenueTTM")]
		public long? RevenueTTM { get; set; }

		[JsonProperty("GrossProfitTTM")]
		public long? GrossProfitTTM { get; set; }

		[JsonProperty("DilutedEPSTTM")]
		public decimal? DilutedEPSTTM { get; set; }

		[JsonProperty("QuarterlyEarningsGrowthYOY")]
		public decimal? QuarterlyEarningsGrowthYOY { get; set; }

		[JsonProperty("QuarterlyRevenueGrowthYOY")]
		public decimal? QuarterlyRevenueGrowthYOY { get; set; }

		[JsonProperty("AnalystTargetPrice")]
		public decimal? AnalystTargetPrice { get; set; }

		[JsonProperty("Beta")]
		public decimal? Beta { get; set; }

		[JsonProperty("52WeekHigh")]
		public decimal? WeekHigh52 { get; set; }

		[JsonProperty("52WeekLow")]
		public decimal? WeekLow52 { get; set; }

		[JsonProperty("50DayMovingAverage")]
		public decimal? MovingAverage50Day { get; set; }

		[JsonProperty("200DayMovingAverage")]
		public decimal? MovingAverage200Day { get; set; }

		[JsonProperty("SharesOutstanding")]
		public long? SharesOutstanding { get; set; }

		[JsonProperty("DividendDate")]
		public DateTime? DividendDate { get; set; }

		[JsonProperty("ExDividendDate")]
		public DateTime? ExDividendDate { get; set; }
	}

}
