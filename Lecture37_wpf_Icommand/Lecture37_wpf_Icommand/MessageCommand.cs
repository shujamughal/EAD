using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lecture37_wpf_icommand
{
    class MessageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<string> methodExected;

        public MessageCommand(Action<string> method)
        {
            this.methodExected = method;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            methodExected.Invoke(parameter as string);
        }
    }
}
