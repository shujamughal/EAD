using Lecture41_wpf_mvvm_multiview.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lecture41_wpf_mvvm_multiview.ViewModels
{
    class MainViewModel :BaseViewModel
    {
        private BaseViewModel selectedViewModel;

        public BaseViewModel SelectedViewModel
        {
            get { return selectedViewModel; }
            set { selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }
        }

        public ICommand UpdateViewCommand { get; set; }
        public MainViewModel()
        {
            UpdateViewCommand = new DelegateCommand(ViewSelector, canExecute);
            selectedViewModel = new HomeViewModel();
        }

        bool canExecute(object o) {
            return true;
        }

        void ViewSelector(object o) {

            if ((o as string).Equals("Student"))
            {
                SelectedViewModel = new StudentViewModel();
            }
            else if ((o as string).Equals("Course"))
            {
                SelectedViewModel = new CourseViewModel();
            }
            else if ((o as string).Equals("Home"))
            {
                SelectedViewModel = new HomeViewModel();
            }
        }
    }
}
