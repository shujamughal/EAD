using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
namespace Lecture39_wpf_mvvm.Models
{
    class StudentService
    {
        ObservableCollection<Student> studentList;

        public StudentService()
        {
            studentList = new ObservableCollection<Student>() { 
            new Student { ID=1, Name="Ibrahim", Age=2},
            new Student { ID=2, Name="Alishba", Age=4},
            new Student { ID=3, Name="Saeed", Age=8}
            };
        }
        public void AddStudent(Student s) {
            studentList.Add(s);
        }

        public void Remove(Student s) {
            studentList.Remove(s);
        }

        public Student GetStudentById(int Id) {
            Student s = null;
            for (int i = 0; i < studentList.Count; i++) {
                if (studentList[i].ID == Id) {
                    s = studentList[i];
                    break;
                
                }
            }
            return s;

        
        }

        public void Update(Student s) {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].ID == s.ID)
                {
                    studentList[i].Name = s.Name;
                    studentList[i].Age = s.Age;
                    break;
                }
            }

        }
        public ObservableCollection<Student> GetAllStudents() {
            return studentList;
        }
    }
}
