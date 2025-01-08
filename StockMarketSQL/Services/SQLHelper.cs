using System.Data;

namespace StockMarketSQL.Services
{
	public class SQLHelper
	{
		public static DataTable ToDataTable<T>(IEnumerable<T> data)
		{
			var dataTable = new DataTable();
			var properties = typeof(T).GetProperties();

			foreach (var prop in properties)
			{
				dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
			}

			foreach (var item in data)
			{
				var row = dataTable.NewRow();
				foreach (var prop in properties)
				{
					row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
				}
				dataTable.Rows.Add(row);
			}

			return dataTable;
		}
	}
}
