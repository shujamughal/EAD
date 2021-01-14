using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture58_webapi.Models
{
    public class StudentRepository
    {
        public List<Student> GetAllStudent() {

            List<Student> students = new List<Student>() { 
            new Student { Id=1,Name="Ibrahim", Age=3},
            new Student { Id=2,Name="Alishba", Age=4},
            new Student { Id=3,Name="Waheed", Age=5},
            };

            return students;
        }
    }
}
