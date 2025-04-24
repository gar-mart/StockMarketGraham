using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace StockMarketSQL.Controllers
{
    public class VisualizeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly AlphaVantageService _service;

        public VisualizeController(IConfiguration configuration, AlphaVantageService service)
        {
            _configuration = configuration;
            _service = service;
        }

        public async Task<IActionResult> StockSearch()
        {
            string apiKey = _service._apiKey;
            ViewBag.ApiKey = apiKey;
            return View();
        }

        public async Task<IActionResult> SearchAndPopulateStockBySymbol(string symbol)
        {
            int stockId = GetStockIdBySymbol(symbol);

            if (stockId == -1)
            {
                string stockName = AlphaVantageService.GetStockNameBySymbol(symbol);
                await CRUDService.InsertNewStock("", symbol, stockName);
                stockId = GetStockIdBySymbol(symbol);
            }

            await CRUDService.PopulateDatabaseForStockAsync("", symbol, stockId, _service);
            return RedirectToAction("BalanceSheet", new { symbol });
        }

        public int GetStockIdBySymbol(string symbol)
        {
            int stockId = -1;
            string connectionString = _configuration.GetConnectionString("StockMarketDb");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT dbo.GetIdByTicker(@symbol)", connection))
                {
                    command.Parameters.AddWithValue("@symbol", symbol ?? string.Empty);
                    object result = command.ExecuteScalar();
                    stockId = result != DBNull.Value ? Convert.ToInt32(result) : -1;
                }
            }

            return stockId;
        }
    }
}
