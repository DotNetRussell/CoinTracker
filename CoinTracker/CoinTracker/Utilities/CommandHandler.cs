using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CoinTracker.Utilities
{
    public class CommandHandler : ICommand
    {
        private Action _action;
        private Func<bool> _canExecute;
        public CommandHandler(Action action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
            {
                return _canExecute();
            }
            else
            {
                return true;
            }
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action?.Invoke();
        }
    }
}
