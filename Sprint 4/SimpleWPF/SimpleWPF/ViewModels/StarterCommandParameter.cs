using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWPF.ViewModels
{
    public class StarterCommandParameter
    {
        private Action<object> commandAction;

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public StarterCommandParameter
            (Action<object> action)
        {
            commandAction = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            commandAction(parameter);
        }
    }
}
