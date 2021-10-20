using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestKeyTriggers.Util
{
    /// <summary>
    /// A  RelayCommandImplementation with a parameter
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> Action;
        private readonly Predicate<T> Predicate;

        public RelayCommand(Action<T> execute, Predicate<T> canExecute = null) 
        {
            Action = execute ?? throw new ArgumentNullException(nameof(execute));
            Predicate = canExecute;

        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
            => Predicate == null || Predicate((T)parameter);

        public void Execute(object parameter)
        {
            if (parameter == null)
                Action(default);
            else if (parameter is T t) //if parameter is T or subclass Of T
                Action(t);
            else
            {
                try
                {
                    //If parameters is not of type T, try converting it using I convertible
                    Action((T)Convert.ChangeType(parameter, typeof(T)));
                }
                catch { }
            }
        }
    }

    /// <summary>
    /// A RelayCommand Implementation  without a parameter,
    /// 
    /// </summary>
    public class RelayCommand 
    {
        private readonly Action Action;
        private readonly Func<bool> Predicate;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            Action  = execute ?? throw new ArgumentNullException("execute");
            Predicate = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
            => Predicate == null || Predicate();

        public void Execute(object parameter)
        {
            Action();
        }
    }
}
