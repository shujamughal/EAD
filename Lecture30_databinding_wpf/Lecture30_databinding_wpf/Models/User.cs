using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lecture30_databinding_wpf.Models
{
    class User : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { 
                
                name = value;
                this.NotifyPropertyChanged("Name");
            }
        }

        private int age;

        public event PropertyChangedEventHandler PropertyChanged;

        public int Age
        {
            get { return age; }
            set { age = value;
                this.NotifyPropertyChanged("Age");
            }
        }

        public void NotifyPropertyChanged(string propName) {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
