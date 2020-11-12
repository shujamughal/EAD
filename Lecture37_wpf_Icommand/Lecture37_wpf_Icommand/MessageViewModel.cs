using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Lecture37_wpf_icommand
{
    class MessageViewModel
    {
        //public string TextMessage { get; set; }
        public ICommand DisplayMessageCommand { get; set; }

        public MessageViewModel()
        {
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
        }

        private void DisplayMessage(string message) {
            MessageBox.Show(message);
        }
    }
}
