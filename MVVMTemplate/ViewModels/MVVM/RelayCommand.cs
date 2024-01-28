using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMTemplate.ViewModels.MVVM
{
    internal class RelayCommand : ICommand
    {
        private Action _execute;
        private Func<bool> _canExecute;
        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            if(execute == null)
                throw new ArgumentNullException("execute == null");
            _execute = execute;
            if (_canExecute == null)
                _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;
        public void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public bool CanExecute(object parameter)
        {
            return (CanExecuteChanged == null || _canExecute());
        }

        public void Execute(object parameter)
        {
            if (CanExecute(parameter)&&_execute != null)
                _execute();
        }
    }
}
