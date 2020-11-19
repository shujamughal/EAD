using Lecture39_wpf_mvvm.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Lecture39_wpf_mvvm.Commands;
using System.Windows;

namespace Lecture39_wpf_mvvm.ViewModels
{
    class StudentViewModel : DependencyObject
    {
        public Student NewStudent { get; set; }
        public ObservableCollection<Student>  Students   { get; set; }
        public DelegateCommand AddCommand { get; set; }
        public DelegateCommand UpdateCommand { get; set; }
        public DelegateCommand RemoveCommand { get; set; }

        StudentService studentService;
        public StudentViewModel()
        {
            studentService = new StudentService();
            NewStudent = new Student();
            Students = studentService.GetAllStudents();
            AddCommand = new DelegateCommand(Add, canAdd);
            RemoveCommand = new DelegateCommand(Remove, canRemove);
        }

        public void Add(object o) {
            studentService.AddStudent(NewStudent);
        }

        public void Remove(object o) {
            if (o != null)
            {
                studentService.RemoveStudent(o as Student);
            }
        }
        public bool canRemove(object o) {
            return true;
            /*if (o != null)
            {
                return true;
            }
            else {
                return false;
            }*/
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
