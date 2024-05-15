using Generic_repostory_mvc_example.Models;
using Generic_repostory_mvc_example.Models.Interfaces;
using Generic_repostory_mvc_example.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Generic_repostory_mvc_example.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRepository<Product> productRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            productRepository = new GenericRepository<Product>("Data Source=(localdb)\\ProjectModels;Initial Catalog=MyDB;Integrated Security=True");
        }

        public IActionResult Index()
        {
            var newProduct = new Product
            {
                Name = "New Product",
                Price = 99.99m
               
            };
            productRepository.Add(newProduct);
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
    }
}
