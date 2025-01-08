using Models.StockMarket.Financials;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using StockMarketSQL.Models.StockMarket.Entity;
using StockMarketSQL.Models.StockMarket.Financials;
using Microsoft.Extensions.Configuration;

namespace StockMarketSQL.Services
{
	public class CRUDService
	{
		public CRUDService() { }

		public static async Task InsertBalanceSheetsAsync(string connectionString, List<BalanceSheet> balanceSheets, int stockId)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				await connection.OpenAsync();

				// Convert List<BalanceSheet> to DataTable
				var balanceSheetTable = SQLHelper.ToDataTable(balanceSheets);

				// Add the TVP parameter
				var parameters = new DynamicParameters();
				parameters.Add("@balanceSheetData", balanceSheetTable.AsTableValuedParameter("Financial.BalanceSheetTVP"));
				parameters.Add("@stockId", stockId);
				// Execute the stored procedure
				await connection.ExecuteAsync("Financial.InsertBalanceSheetData", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public static async Task InsertCashflowsAsync(string connectionString, List<Cashflow> Cashflows, int stockId)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				await connection.OpenAsync();

				// Convert List<BalanceSheet> to DataTable
				var CashflowTable = SQLHelper.ToDataTable(Cashflows);

				// Add the TVP parameter
				var parameters = new DynamicParameters();
			
				 parameters.Add("@Cashflows", CashflowTable.AsTableValuedParameter("Financial.CashflowTVP"));
				 parameters.Add("@stockId", stockId);
				// Execute the stored procedure
				await connection.ExecuteAsync("Financial.InsertCashflow", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public static async Task InsertIncomeStatementsAsync(string connectionString, List<IncomeStatement> incomeStatements, int stockId)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				await connection.OpenAsync();

				// Convert List<IncomeStatement> to DataTable
				var incomeStatementTable = SQLHelper.ToDataTable(incomeStatements);

				// Add the TVP parameter
				var parameters = new DynamicParameters();
				parameters.Add("@IncomeStatements", incomeStatementTable.AsTableValuedParameter("Financial.IncomeStatementTVP"));
				parameters.Add("@stockId", stockId);

				// Execute the stored procedure
				await connection.ExecuteAsync("Financial.InsertIncomeStatement", parameters, commandType: CommandType.StoredProcedure);
			}
		}

		//public static async Task InsertStockOverviewAsync(string connectionString, StockOverview stockOverviews)
		//{
		//	using (var connection = new SqlConnection(connectionString))
		//	{
		//		await connection.OpenAsync();
		//
		//		// Convert List<StockOverview> to DataTable
		//		var stockOverviewTable = SQLHelper.ToDataTable(stockOverviews);
		//
		//		// Add the TVP parameter
		//		var parameters = new DynamicParameters();
		//		parameters.Add("@StockOverviews", stockOverviewTable.AsTableValuedParameter("Financial.StockOverviewTVP"));
		//
		//		// Execute the stored procedure
		//		await connection.ExecuteAsync("Financial.InsertStockOverview", parameters, commandType: CommandType.StoredProcedure);
		//	}
		//}


		public static async Task PopulateDatabaseForStockAsync(string connectionString, string stockSymbol, int stockId, AlphaVantageService service)
		{
			// Fetch financial data
			List<BalanceSheet> balanceSheets = await service.GetBalanceSheetAsync(stockSymbol);
			List<Cashflow> cashflows = await service.GetCashflowAsync(stockSymbol);
			List<IncomeStatement> incomeStatements = await service.GetIncomeStatementAsync(stockSymbol);
			//StockOverview stockOverview = await service.GetStockOverviewAsync(stockSymbol);

			// Insert data into the database
			//await CRUDService.InsertStockOverviewAsync(_connectionString, new List<StockOverview> { stockOverview });
			await CRUDService.InsertBalanceSheetsAsync(connectionString, balanceSheets, stockId);
			await CRUDService.InsertCashflowsAsync(connectionString, cashflows, stockId);
			await CRUDService.InsertIncomeStatementsAsync(connectionString, incomeStatements, stockId);
		}

	}
}
