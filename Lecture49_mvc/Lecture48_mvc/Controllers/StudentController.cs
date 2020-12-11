using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture48_mvc.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public ViewResult StudentForm() {
            return View();
        }
        [HttpPost]
        public ViewResult StudentForm(string name, string age, string cgpa, string semester)
        {
            return View();
        }
    }
}
