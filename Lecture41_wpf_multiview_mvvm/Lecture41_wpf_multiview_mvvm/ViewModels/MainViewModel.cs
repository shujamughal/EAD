using Lecture41_wpf_multiview_mvvm.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lecture41_wpf_multiview_mvvm.ViewModels
{
    class MainViewModel :BaseViewModel
    {
        private BaseViewModel selectedViewModel;

        public BaseViewModel SelectedViewModel
        {
            get { return selectedViewModel; }
            set { selectedViewModel = value; 
                OnPropertyChanged("SelectedViewModel");
            }
        }

        public ICommand UpdateViewCommand { get; set; }
        public MainViewModel()
        {

            UpdateViewCommand = new DelegateCommand(ViewSelector,canExecute);
        }

        public bool canExecute(object o) {
            return true;
        }

        public void ViewSelector(object o) {
            
            if ((o as string).Equals("Student"))
            {
                SelectedViewModel = new StudentViewModel();
            }
            else if((o as string).Equals("Course"))
            {
                SelectedViewModel = new CourseViewModel();
            }

        }
    }
}
