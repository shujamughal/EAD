using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture48_mvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GetAllStudents()
        {
            return View();
        }
    }
}
