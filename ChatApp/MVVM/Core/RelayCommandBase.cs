using System.Windows.Input;

namespace ChatClient.MVVM.Core
{
    public class RelayCommandBase
    {

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}