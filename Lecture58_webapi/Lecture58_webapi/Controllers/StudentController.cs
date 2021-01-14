using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lecture58_webapi.Models;

namespace Lecture58_webapi.Controllers
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
        public List<Student> Get()
        {
            return repo.GetAllStudent();
        }

        [HttpGet]
        //[Route("[action]")]
        [Route("myStudents")]
        [Route("myStudents2")]
        [Route("api/controller/myStudents")]

        public List<Student> GetAllofStudents()
        {
            return repo.GetAllStudent();
        }
    }
}
