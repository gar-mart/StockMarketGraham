using Newtonsoft.Json;

namespace Models.StockMarket.Financials
{
    public class EarningsPerShare
    {
        public int StockId { get; set;}
        public DateTime FiscalDateEnding { get; set; }
        public decimal Value { get; set; }
    }
	public class AnnualEarningsPerShare
	{
		public DateTime FiscalDateEnding { get; set; }
		public decimal ReportedEPS { get; set; }
	}

	public class QuarterlyEarningsPerShare
	{
		public DateTime FiscalDateEnding { get; set; }
		public DateTime ReportedDate { get; set; }
		public decimal ReportedEPS { get; set; }
		public decimal? EstimatedEPS { get; set; }
		public decimal? Surprise { get; set; }
		public decimal? SurprisePercentage { get; set; }
		public string? ReportTime { get; set; }
	}

	public class EarningsResponse
	{
		[JsonProperty("annualEarnings")]
		public List<AnnualEarningsPerShare> AnnualEarnings { get; set; }

		[JsonProperty("quarterlyEarnings")]
		public List<QuarterlyEarningsPerShare> QuarterlyEarnings { get; set; }
	}
}
