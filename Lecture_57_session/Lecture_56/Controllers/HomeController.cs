using Lecture_56.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture_56.Controllers
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
            string data = String.Empty;
            if (HttpContext.Session.Keys.Contains("first_request"))
            {
                string firstVisitedDateTime = HttpContext.Session.GetString("first_request");
                data = "Welcome back " + firstVisitedDateTime;

            }
            else
            {
                
                data = "you visited first time";
                HttpContext.Session.SetString("first_request", System.DateTime.Now.ToString());
            }
            return View("index", data);
        }

        public IActionResult Remove()
        {
            HttpContext.Session.Remove("first_request");
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
