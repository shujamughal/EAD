using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace Lecture41_wpf_mvvm_multiview.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

       protected void OnPropertyChanged(string propName) {

            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        
        }
    }
}
