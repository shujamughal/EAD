using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
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

        public bool canExecute(string m) {

            if (string.IsNullOrEmpty(m))
            {
                return false;
            }
            else {
                return true;
            }
        }
        public void DisplayMessage(string m) {
           
            MessageBox.Show(m);
            
        }
    }
}
