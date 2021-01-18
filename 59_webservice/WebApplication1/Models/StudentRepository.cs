using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class StudentRepository
    {
        List<Student> students;
        public StudentRepository()
        {
            students = new List<Student>() {
            new Student { Id=1,Name="Ibrahim", Age=3},
            new Student { Id=2,Name="Alishba", Age=4},
            new Student { Id=3,Name="Waheed", Age=5},
            };
        }
        public List<Student> GetAllStudents()
        {
             
           return students;
        }

        public Student GetStudentById(int id) {

            return students.Find(s=> s.Id==id);
        
        }

        public void AddNewStudent(Student s) {
            students.Add(s);
        }


       
    }

   


}
