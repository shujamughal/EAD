using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lecture48_mvc.Models;
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
        public ViewResult StudentForm(Student s)
        {
           
            if (ModelState.IsValid)
            {
                StudentRepository.AddStudent(s);
                return View("Thanks", s);
            }
            else {
                ModelState.AddModelError(String.Empty, "Please enter correct data");
                return View();
            }
        }

        public ViewResult ListStudents() {
            return View(StudentRepository.students);
        }
    }
}
