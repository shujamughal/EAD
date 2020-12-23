using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture48_mvc.Models
{
  static  public class StudentRepository
    {
        public static List<Student> students = new List<Student>();

        static StudentRepository()
        {
            students.Add(new Student { Id = 1, CGPA=3.5f, Name ="Ali", Age=22, Semester="1st"});
            students.Add(new Student { Id = 2, CGPA=3.6f, Name = "Shuja", Age = 23, Semester="2nd" });
            students.Add(new Student { Id = 3, CGPA=2.78f, Name = "Alishba", Age = 24, Semester="3rd" });
            students.Add(new Student { Id = 4, CGPA=3.01f, Name = "Ibrahim", Age = 25, Semester="4th" });
        }
        public static void AddStudent(Student s) {
            students.Add(s);
        }
    }
}
