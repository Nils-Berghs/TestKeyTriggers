using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestKeyTriggers.Util;

namespace TestKeyTriggers.ViewModels
{
    public class ViewModelA:ViewModelBase
    {
        private string _Code;
        public string Code
        {
            get => _Code;
            set => SetProperty(ref _Code, value);
        }

        public ICommand HandleKeyCommand { get; }

        public ViewModelA()
        {
            HandleKeyCommand = new RelayCommand<KeyEventArgs>(e => HandleKeyPress)
        }
    }
}
