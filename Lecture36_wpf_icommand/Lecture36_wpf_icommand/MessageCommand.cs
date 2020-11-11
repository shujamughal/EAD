using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lecture36_wpf_icommand
{
    class MessageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action methodExected;

        public MessageCommand(Action method)
        {
            this.methodExected = method;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            methodExected.Invoke();
        }
    }
}
