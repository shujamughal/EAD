using Lecture39_wpf_mvvm.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Lecture39_wpf_mvvm.Commands;

namespace Lecture39_wpf_mvvm.ViewModels
{
    class StudentViewModel
    {
        public Student NewStudent { get; set; }
        public ObservableCollection<Student>  Students   { get; set; }
        public DelegateCommand AddCommand { get; set; }
        StudentService studentService;
        public StudentViewModel()
        {
            studentService = new StudentService();
            NewStudent = new Student();
            Students = studentService.GetAllStudents();
            AddCommand = new DelegateCommand(Add, canAdd);
        }

        public void Add(object o) {
            studentService.AddStudent(NewStudent);
        }
        public bool canAdd(object o) {

            if (string.IsNullOrEmpty(NewStudent.ID.ToString()) ||
               string.IsNullOrEmpty(NewStudent.Name) ||
               string.IsNullOrEmpty(NewStudent.Age.ToString()))
            {
                return false;
            }
            else {
                return true;
            }
        
        }
    }
}
