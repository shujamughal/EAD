using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        StudentRepository repo;
        public StudentController()
        {
            repo = new StudentRepository();
        }

        [HttpGet]
        [Route("abc")]
        public List<Student> Get()
        {
            return repo.GetAllStudents();
        }

        [HttpGet]
        //[HttpGet("{id}")]
        [Route("find/{id}")]
        public Student GetById(int id)
        {
            return repo.GetStudentById(id);
        }

        [HttpPost]
        [Route("add")]
        public void Add(Student s)
        {
            repo.AddNewStudent(s);
        }

        [HttpPut("{id}")]
        public void Update(Student s, int id)
        {
            //you need to call a method to update student based on id
        }

        [HttpDelete]
        [Route("delStd/{id}")]

        public void DeleteStudent(int id)
        {
            //you need to call a method to delete student based on id
        }
    }
}
