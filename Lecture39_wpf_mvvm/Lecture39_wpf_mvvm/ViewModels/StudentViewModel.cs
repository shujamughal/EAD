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
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ObservableCollection<Student>  Students   { get; set; }
        public DelegateCommand AddCommand { get; set; }
        StudentService studentService;
        public StudentViewModel()
        {
            studentService = new StudentService();
            
            Students = studentService.GetAllStudents();
            AddCommand = new DelegateCommand(Add, canAdd);
        }

        public void Add(object o) {
            Student s = new Student();
            s.ID = this.ID;
            s.Name = this.Name;
            s.Age = this.Age;
            studentService.AddStudent(s);
        }
        public bool canAdd(object o) {

            if (string.IsNullOrEmpty(ID.ToString()) ||
               string.IsNullOrEmpty(Name) ||
               string.IsNullOrEmpty(Age.ToString()))
            {
                return false;
            }
            else {
                return true;
            }
        
        }
    }
}
