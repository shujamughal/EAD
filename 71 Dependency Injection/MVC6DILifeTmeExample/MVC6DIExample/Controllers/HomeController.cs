using Microsoft.AspNetCore.Mvc;
using MVC6DIExample.Models;
using MVC6DIExample.Models.Interfaces;
using System.Diagnostics;

namespace MVC6DIExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployee empRepo;
        public HomeController(ILogger<HomeController> logger, IEmployee e)
        {
            empRepo = e;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(empRepo.GetAllEmployee());
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