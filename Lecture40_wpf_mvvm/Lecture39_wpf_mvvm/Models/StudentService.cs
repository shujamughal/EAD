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
        public void RemoveStudent(Student s)
        {
            studentList.Remove(s);
        }
        public bool UpdateStudent(Student s)
        {

            bool isUpdated = false;

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].ID == s.ID)
                {
                    studentList[i].Name = s.Name;
                    studentList[i].Age = s.Age;
                    isUpdated = true;
                    break;
                }
            }

            return isUpdated;
        }
        public Student SearchStudent(int ID)
        {

            Student s = null;
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].ID == ID)
                {
                    s = studentList[i];
                    break;
                }
            }
            return s;
        }
    }
}
