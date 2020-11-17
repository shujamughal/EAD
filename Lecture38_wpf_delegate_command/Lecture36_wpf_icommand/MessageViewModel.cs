using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Lecture36_wpf_icommand
{
    class MessageViewModel
    {
        
        public DelegateCommand cmd { get; set; }
        public DelegateCommand cmd2 { get; set; }

        public MessageViewModel()
        {
            cmd = new DelegateCommand(DisplayMessage, canExecute);
            cmd2 = new DelegateCommand(DisplayMessageOnConsole,canExecute);
        }

        public bool canExecute(object m) {

            if (string.IsNullOrEmpty(m as string))
            {
                return false;
            }
            else {
                return true;
            }
        }
        public void DisplayMessage(object m) {
           
            MessageBox.Show(m as string);
            
        }
        public void DisplayMessageOnConsole(object m)
        {

            Console.WriteLine(m);

        }
    }
}
