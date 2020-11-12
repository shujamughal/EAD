using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lecture36_wpf_icommand
{
    class MessageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MessageViewModel messagevm;
        public MessageCommand(MessageViewModel vm)
        {
            this.messagevm = vm;
        }
        public bool CanExecute(object parameter)
        {
            return false;
        }

        public void Execute(object parameter)
        {
            messagevm.DisplayMessage();
        }
    }
}
