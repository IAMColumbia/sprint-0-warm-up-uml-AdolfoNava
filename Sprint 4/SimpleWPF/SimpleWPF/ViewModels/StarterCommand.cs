using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleWPF.ViewModels
{
    public class StarterCommand : ICommand
    {
        private Action commandAction;

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public StarterCommand(Action action)
        {
            commandAction = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            commandAction();
        }
    }
}
