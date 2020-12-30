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
            if (HttpContext.Request.Cookies.ContainsKey("first_request"))
            {
                string firstVisitedDateTime = HttpContext.Request.Cookies["first_request"];
                data = "Welcome back " + firstVisitedDateTime;

            }
            else
            {
                CookieOptions option = new CookieOptions();
                option.Expires = System.DateTime.Now.AddDays(1);
                data = "you visited firs time";
                HttpContext.Response.Cookies.Append("first_request", System.DateTime.Now.ToString(),option);
            }
            return View("index", data);
        }

        public IActionResult Remove()
        {
            HttpContext.Response.Cookies.Delete("first_request");
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
