using JqueryAjaxPostExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JqueryAjaxPostExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateStudent(StudentModel student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Enter required fields");
            //Write your Insert code here;
            return this.Ok($"Form Data received!");
        }
        public IActionResult AddStudent([FromBody] StudentModel student)
        {
            
            if (!ModelState.IsValid)
               // ModelState.AddModelError
                return BadRequest("Enter required fields");
            //Insert code;
            return this.Ok($"Form Data received!");
        }
        public IActionResult CreateStudent()
        {
            return View();
        }
        public IActionResult CreateStudent1()
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