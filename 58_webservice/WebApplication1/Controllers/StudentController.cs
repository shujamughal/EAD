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


    }
}
