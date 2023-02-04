using FileUploadingExampleMVC6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FileUploadingExampleMVC6.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment Environment;

        public HomeController( IWebHostEnvironment
            environment)
        {
            
            Environment = environment;
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
        public IActionResult Index(List<IFormFile> postedFiles) {
            string wwwPath = this.Environment.WebRootPath;
            string path = Path.Combine(wwwPath,"Uploads");
            if (!Directory.Exists(path)) { 
            Directory.CreateDirectory(path);
            }
            
            foreach (var file in postedFiles) {
                var fileName = Path.GetFileName(file.FileName);
                var pathWithFileName= Path.Combine(path, fileName);
                using (FileStream stream = new
                    FileStream(pathWithFileName, 
                    FileMode.Create))
                {
                    file.CopyTo(stream);
                    ViewBag.Message = "file uploaded successfully";
                }
            }
        return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}