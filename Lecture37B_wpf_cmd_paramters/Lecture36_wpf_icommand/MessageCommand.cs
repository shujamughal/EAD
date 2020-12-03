using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lecture36_wpf_icommand
{
    class MessageCommand : ICommand
    {
        //public event EventHandler CanExecuteChanged;
        public event EventHandler CanExecuteChanged {
            add {
                CommandManager.RequerySuggested += value;
            }
            remove {
                CommandManager.RequerySuggested -= value;
            }
        }
        
        private MessageViewModel messagevm;
        public MessageCommand(MessageViewModel vm)
        {
            this.messagevm = vm;
        }
        public bool CanExecute(object parameter)
        {

            return messagevm.canExecute(parameter );
        }

        public void Execute(object parameter)
        {
            messagevm.DisplayMessage(parameter );
        }
        
    }
}
