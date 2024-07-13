using JqueryGetExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace JqueryGetExample.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public JsonResult GetProducts(string searchTerm)
		{
			var products = new List<Product>
		{
			new Product { Id = 1, Name = "Laptop", Price = 999.99 },
			new Product { Id = 2, Name = "Smartphone", Price = 699.99 },
			new Product { Id = 3, Name = "Tablet", Price = 399.99 },
            new Product { Id = 3, Name = searchTerm, Price = 399.99 }
        };
			return Json(products);
		}
	}
}
