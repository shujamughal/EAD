using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Lecture36_wpf_icommand
{
    class MessageViewModel
    {
        public string MessageText { get; set; }
        public MessageCommand cmd { get; set; }
        public MessageViewModel()
        {
            cmd = new MessageCommand(this);
        }

        public void DisplayMessage() {
            MessageBox.Show(MessageText);
        }
    }
}
