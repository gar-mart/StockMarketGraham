using Microsoft.AspNetCore.Mvc;

namespace StockMarketSQL.Controllers
{
	public class VisualizeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}


		public IActionResult Visualize()
		{
			List<Person> people = new List<Person> {
					new Person { Id = 1, Name = "John Doe", Age = 30 },
					new Person { Id = 2, Name = "Jane Smith", Age = 25 },
					new Person { Id = 3, Name = "Alice Johnson", Age = 35 },
					new Person { Id = 4, Name = "Bob Brown", Age = 45 }
				};

			return View(people);

		}

		public class Person
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public int Age { get; set; }
		}
	}
}


