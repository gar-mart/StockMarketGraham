using Microsoft.AspNetCore.Mvc;
using Models.StockMarket.Financials;
using StockMarketSQL.Models;
using StockMarketSQL.Models.StockMarket.Financials;
using StockMarketSQL.Services;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace StockMarketSQL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly AlphaVantageService _service;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _service = new AlphaVantageService(_configuration["AlphaVantageApiKey"]);
        }

       // public async Task<IActionResult> Index()
        public IActionResult Index()
        {
           // CRUDService.PopulateDatabaseForStockAsync("AAPL", 11, service);





			return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
  

        [HttpGet]
        public async Task<IActionResult> GetFinancialData(string financialType)
        {
            try
            {
                // Validate input
                if (string.IsNullOrEmpty(financialType))
                {
                    return BadRequest("Financial type is required.");
                }

                int stockId = 11; // Example stock ID; dynamically determine this as needed
                string connectionString = _configuration.GetConnectionString("StockMarketDb");

                using var connection = new SqlConnection(connectionString);

                // Map financialType to stored procedure
                string procedureName = financialType.ToLower() switch
                {
                    "balancesheet" => "Financial.GetBalanceSheetByStockId",
                    "incomestatement" => "Financial.GetIncomeStatementByStockId",
                    "cashflow" => "Financial.GetCashFlowByStockId",
                    "history" => "Financial.GetStockHistoryById",
                    _ => throw new ArgumentException("Invalid financial type")
                };

                // Execute stored procedure
                var data = await connection.QueryAsync(procedureName, new { StockId = stockId }, commandType: CommandType.StoredProcedure);

                // Return the data as JSON
                return Json(data);
            }
            catch (Exception ex)
            {
                // Log the error (optional: add logging)
                _logger.LogError($"Error fetching financial data: {ex.Message}");
                return StatusCode(500, "An error occurred while fetching financial data.");
            }
        }


		[HttpGet]
		public async Task<IActionResult> GetStockHistory(int stockId)
		{
			try
			{
                string connectionString = _configuration.GetConnectionString("StockMarketDb");

                using var connection = new SqlConnection(connectionString);

				// Execute the stored procedure
				var data = await connection.QueryAsync("Financial.GetStockHistoryById",
					new { StockId = stockId },
					commandType: CommandType.StoredProcedure);

				// Return data as JSON
				return Json(data);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error fetching stock history.");
				return StatusCode(500, "An error occurred while fetching stock history.");
			}
		}

	}
}
