using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MvvMTutorial.WpfApp.Command
{
    class RelayCommand : ICommand
    {
        private readonly Action<Object> execute;
        private readonly Predicate<Object> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public RelayCommand(Action<Object> execute, Predicate<Object> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute != null ? canExecute(parameter) : false;
        }

        public void Execute(object parameter)
        {
            if (execute != null) this.execute(parameter);
        }
    }
}
