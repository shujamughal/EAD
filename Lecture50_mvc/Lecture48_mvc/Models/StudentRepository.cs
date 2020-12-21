using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture48_mvc.Models
{
    public class StudentRepository
    {
        public static List<Student> students = new List<Student>();

        public static void AddStudent(Student s) {
            students.Add(s);
        }
    }
}
