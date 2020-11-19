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
            new Student { ID=1, Name="Ibrahim", Age=2}
            };
        }
        public void AddStudent(Student s) {
            studentList.Add(s);
        }
        public ObservableCollection<Student> GetAllStudents() {
            return studentList;
        }
    }
}
