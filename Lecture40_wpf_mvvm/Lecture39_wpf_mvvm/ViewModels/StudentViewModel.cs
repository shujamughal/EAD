using Lecture39_wpf_mvvm.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Lecture39_wpf_mvvm.Commands;
using System.ComponentModel;

namespace Lecture39_wpf_mvvm.ViewModels
{
    class StudentViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public Student SelectedStudent { get; set; }
        public int ID { get => iD; set { iD = value; OnPropertyChanged("ID"); } }
        public string Name { get => name; set { name = value; OnPropertyChanged("Name"); } }
        public int Age { get => age; set { age = value; OnPropertyChanged("Age"); } }
        public ObservableCollection<Student> Students { get; set; }
        public DelegateCommand AddCommand { get; set; }
        public DelegateCommand RemoveCommand { get; set; }
        public DelegateCommand SearchCommand { get; set; }
        public DelegateCommand UpdateCommand { get; set; }

        StudentService studentService;
        private string name;
        private int age;
        private int iD;

        public StudentViewModel()
        {
            studentService = new StudentService();

            Students = studentService.GetAllStudents();
            AddCommand = new DelegateCommand(Add, canAdd);
            RemoveCommand = new DelegateCommand(Remove, canRemove);
            SearchCommand = new DelegateCommand(Search, canSearch);
            UpdateCommand = new DelegateCommand(Update, canAdd);
        }

        public void Add(object o)
        {
            Student s = new Student();
            s.ID = this.ID;
            s.Name = this.Name;
            s.Age = this.Age;
            studentService.AddStudent(s);
        }

        public void Remove(object o)
        {
            if (SelectedStudent != null)
            {
                studentService.Remove(SelectedStudent);
            }
        }

        public void Search(object o)
        {
            if (ID != 0 && !(string.IsNullOrEmpty(ID.ToString())))
            {
                Student s = studentService.GetStudentById(ID);
                this.Name = s.Name;
                this.Age = s.Age;
            }

        }

        public void Update(object o) {
            Student s = new Student();
            s.ID = ID;
            s.Name = Name;
            s.Age = this.Age;
            studentService.Update(s);
        
        }
        public bool canSearch(object o)
        {
            if (ID != 0 && !(string.IsNullOrEmpty(ID.ToString())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool canRemove(object o)
        {
            if (SelectedStudent != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool canAdd(object o)
        {

            if (string.IsNullOrEmpty(ID.ToString()) ||
               string.IsNullOrEmpty(Name) ||
               string.IsNullOrEmpty(Age.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
