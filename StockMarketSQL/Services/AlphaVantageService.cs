using Models.StockMarket.Financials;
using Newtonsoft.Json;
using StockMarketSQL.Models.StockMarket.Entity;
using StockMarketSQL.Models.StockMarket.Financials;

namespace StockMarketSQL.Services
{
	public class AlphaVantageService
	{
		private readonly HttpClient? _httpClient;
		private readonly string _apiKey;

		public AlphaVantageService(string apiKey)
		{
			_httpClient = new HttpClient();
			_httpClient.BaseAddress = new Uri("https://www.alphavantage.co/");
			_apiKey = apiKey;
		}




		// Get API response based on url
		private async Task<string> GetApiResponseAsync(string url)
		{
			HttpResponseMessage response = await _httpClient.GetAsync(url);
			if (!response.IsSuccessStatusCode)
			{
				throw new HttpRequestException($"Error fetching data: {response.StatusCode}");
			}
			return await response.Content.ReadAsStringAsync();
		}


		public async Task<List<BalanceSheet>> GetBalanceSheetAsync(string symbol)
		{
			string url = $"query?function=BALANCE_SHEET&symbol={symbol}&apikey={_apiKey}";
			string content = await GetApiResponseAsync(url);

			// Replace "None" with null in the JSON string
			content = content.Replace("\"None\"", "null");

			var responseData = JsonConvert.DeserializeObject<BalanceSheetResponse>(content);
			if (responseData?.AnnualReports == null)
			{
				throw new Exception("Failed to retrieve balance sheet data or data is empty.");
			}

			return responseData.AnnualReports;
		}

		public async Task<List<Cashflow>> GetCashflowAsync(string symbol)
		{
			string url = $"query?function=CASH_FLOW&symbol={symbol}&apikey={_apiKey}";
			string content = await GetApiResponseAsync(url);

			// Replace "None" with null in the JSON string
			content = content.Replace("\"None\"", "null");

			var responseData = JsonConvert.DeserializeObject<CashflowResponse>(content);
			if (responseData?.AnnualReports == null)
			{
				throw new Exception("Failed to retrieve cash flow data or data is empty.");
			}

			return responseData.AnnualReports;
		}
		public static void PrintBalanceSheets(List<BalanceSheet> balanceSheets)
		{
			foreach (var sheet in balanceSheets)
			{
				Console.WriteLine("======================================");
				Console.WriteLine($"FiscalDateEnding: {sheet.FiscalDateEnding}");
				Console.WriteLine($"ReportedCurrency: {sheet.ReportedCurrency}");
				Console.WriteLine($"TotalAssets: {sheet.TotalAssets}");
				Console.WriteLine($"TotalCurrentAssets: {sheet.TotalCurrentAssets}");
				//Console.WriteLine($"CashAndCashEquivalents: {sheet.CashAndCashEquivalents}");
				Console.WriteLine($"CashAndShortTermInvestments: {sheet.CashAndShortTermInvestments}");
				Console.WriteLine($"Inventory: {sheet.Inventory}");
				Console.WriteLine($"CurrentNetReceivables: {sheet.CurrentNetReceivables}");
				Console.WriteLine($"TotalNonCurrentAssets: {sheet.TotalNonCurrentAssets}");
				Console.WriteLine($"PropertyPlantEquipment: {sheet.PropertyPlantEquipment}");
				Console.WriteLine($"AccumulatedDepreciationAmortizationPPE: {sheet.AccumulatedDepreciationAmortizationPPE}");
				Console.WriteLine($"IntangibleAssets: {sheet.IntangibleAssets}");
				Console.WriteLine($"IntangibleAssetsExcludingGoodwill: {sheet.IntangibleAssetsExcludingGoodwill}");
				Console.WriteLine($"Goodwill: {sheet.Goodwill}");
				Console.WriteLine($"Investments: {sheet.Investments}");
				Console.WriteLine($"LongTermInvestments: {sheet.LongTermInvestments}");
				Console.WriteLine($"ShortTermInvestments: {sheet.ShortTermInvestments}");
				Console.WriteLine($"OtherCurrentAssets: {sheet.OtherCurrentAssets}");
				Console.WriteLine($"OtherNonCurrentAssets: {sheet.OtherNonCurrentAssets}");
				Console.WriteLine($"TotalLiabilities: {sheet.TotalLiabilities}");
				Console.WriteLine($"TotalCurrentLiabilities: {sheet.TotalCurrentLiabilities}");
				Console.WriteLine($"CurrentAccountsPayable: {sheet.CurrentAccountsPayable}");
				Console.WriteLine($"DeferredRevenue: {sheet.DeferredRevenue}");
				Console.WriteLine($"CurrentDebt: {sheet.CurrentDebt}");
				Console.WriteLine($"ShortTermDebt: {sheet.ShortTermDebt}");
				Console.WriteLine($"TotalNonCurrentLiabilities: {sheet.TotalNonCurrentLiabilities}");
				Console.WriteLine($"CapitalLeaseObligations: {sheet.CapitalLeaseObligations}");
				Console.WriteLine($"LongTermDebt: {sheet.LongTermDebt}");
				Console.WriteLine($"CurrentLongTermDebt: {sheet.CurrentLongTermDebt}");
				Console.WriteLine($"LongTermDebtNoncurrent: {sheet.LongTermDebtNoncurrent}");
				Console.WriteLine($"ShortLongTermDebtTotal: {sheet.ShortLongTermDebtTotal}");
				Console.WriteLine($"OtherCurrentLiabilities: {sheet.OtherCurrentLiabilities}");
				Console.WriteLine($"OtherNonCurrentLiabilities: {sheet.OtherNonCurrentLiabilities}");
				Console.WriteLine($"TotalShareholderEquity: {sheet.TotalShareholderEquity}");
				Console.WriteLine($"TreasuryStock: {sheet.TreasuryStock}");
				Console.WriteLine($"RetainedEarnings: {sheet.RetainedEarnings}");
				Console.WriteLine($"CommonStock: {sheet.CommonStock}");
				Console.WriteLine($"CommonStockSharesOutstanding: {sheet.CommonStockSharesOutstanding}");
				Console.WriteLine("======================================");
			}
		}
		public async Task<List<IncomeStatement>> GetIncomeStatementAsync(string symbol)
		{
			string url = $"query?function=INCOME_STATEMENT&symbol={symbol}&apikey={_apiKey}";
			string content = await GetApiResponseAsync(url);

			// Replace "None" with null in the JSON string
			content = content.Replace("\"None\"", "null");

			var responseData = JsonConvert.DeserializeObject<IncomeStatementResponse>(content);
			if (responseData?.AnnualReports == null)
			{
				throw new Exception("Failed to retrieve income statement data or data is empty.");
			}

			return responseData.AnnualReports;
		}

		

		//private async Task<StockOverview> GetStockOverviewAsync(string symbol)
		//{
		//	string url = $"query?function=OVERVIEW&symbol={symbol}&apikey={_apiKey}";
		//	string content = await GetApiResponseAsync(url);
		//	var responseData = JsonConvert.DeserializeObject<Stock>(content);
		//	return responseData.StockOverview;
		//}

		public async Task<StockOverview> GetStockOverviewAsync(string symbol)
		{
			string url = $"query?function=OVERVIEW&symbol={symbol}&apikey={_apiKey}";
			string content = await GetApiResponseAsync(url);

			// Replace "None" with null in the JSON string
			content = content.Replace("\"None\"", "null");

			// Deserialize the API response into the StockOverview class
			var stockOverview = JsonConvert.DeserializeObject<StockOverview>(content);

			if (stockOverview == null)
			{
				throw new Exception("Failed to retrieve stock overview data or data is empty.");
			}

			return stockOverview;
		}
		private async Task<List<EarningsPerShare>> GetEarningsPerShareListAsync(string symbol)
		{
			List<EarningsPerShare> EarningsPerShareList = new List<EarningsPerShare>();
			string url = $"query?function=EARNINGS&symbol={symbol}&apikey={_apiKey}";

			string content = await GetApiResponseAsync(url);
			dynamic data = JsonConvert.DeserializeObject(content);

			foreach (var item in data.annualEarnings)
			{
				DateTime fiscalYear = DateTime.Parse((string)item.fiscalDateEnding);
				decimal EarningsPerShareValue = decimal.Parse((string)item.reportedEarningsPerShare);
				EarningsPerShareList.Add(new EarningsPerShare { FiscalDateEnding = fiscalYear, Value = EarningsPerShareValue });
			}

			return EarningsPerShareList;
		}

        public async Task<EarningsResponse> GetEPSDataAsync(string symbol)
        {
            string url = $"query?function=EARNINGS&symbol={symbol}&apikey={_apiKey}";
            string content = await GetApiResponseAsync(url);

            // Replace "None" with null in the JSON string
            content = content.Replace("\"None\"", "null");

            var earningsResponse = JsonConvert.DeserializeObject<EarningsResponse>(content);

            if (earningsResponse == null)
            {
                throw new Exception("Failed to retrieve EPS data or data is empty.");
            }

            return earningsResponse;
        }


    }
}