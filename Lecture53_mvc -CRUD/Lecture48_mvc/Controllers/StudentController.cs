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
        public ViewResult Remove(int xyz)
        {
            Student s = StudentRepository.students.Find(s => s.Id == id);
            StudentRepository.students.Remove(s);
            return View("ListStudents", StudentRepository.students);
        }

        public ViewResult Details(int id) {
            Student s = StudentRepository.students.Find(s => s.Id == id);
            return View("Thanks", s);
        }

        public ViewResult Edit(int id) {
            Student s = StudentRepository.students.Find(s => s.Id == id);
            return View("Edit", s);

        }
        [HttpPost]
        public ViewResult Edit(Student s)
        {
            if (ModelState.IsValid)
            {
                foreach (Student std in StudentRepository.students) {
                    if (std.Id == s.Id) {
                        std.Name = s.Name;
                        std.Semester = s.Semester;
                        std.Age = s.Age;
                        std.CGPA = s.CGPA;
                        break;
                    }
                }

                return View("ListStudents", StudentRepository.students);
            }
            else
            {
                ModelState.AddModelError(String.Empty, "Please enter correct data");
                return View();
            }

        }

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
