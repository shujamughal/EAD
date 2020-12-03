using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lecture36_wpf_icommand
{
    class MessageViewModel
    {
        
        public MessageCommand cmd { get; set; }
        public MessageViewModel()
        {
            cmd = new MessageCommand(this);
        }

        public bool canExecute(object m) {
            /*var data = m as object[];
            var d1 = data[0] as string;
            var d2 = data[1] as string;

            if (string.IsNullOrEmpty(d1) || string.IsNullOrEmpty(d2))
            {
                return false;
            }
            else {
                return true;
            }*/
            return true;
        }
        public void DisplayMessage(object m) {
            var data = m as object[];
            var d1 = data[0] as PasswordBox;
            var d2 = data[1] as PasswordBox;
            MessageBox.Show($"{d1.Password} and {d2.Password}");
            
        }
    }
}
