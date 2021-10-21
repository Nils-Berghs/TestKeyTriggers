using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestKeyTriggers.Util;

namespace TestKeyTriggers.ViewModels
{
    public class CodeViewModel : ViewModelBase
    {
        public event EventHandler CodeEntered;
        private ViewModelA ViewModelA { get; }

        private string _Code;
        public string Code
        {
            get => _Code;
            set => SetProperty(ref _Code, value);
        }

        public ICommand KeyPressedCommand { get; }

        public CodeViewModel()
        {
            Code = "";
            KeyPressedCommand = new RelayCommand<KeyEventArgs>(key => OnKeyPressMethod(key));
        }
        
        private void OnKeyPressMethod(KeyEventArgs key)
        {
            Code += key.Key.ToString().Substring(6);
            if (Code.Length >= 8)
            {
                Code = "";
                CodeEntered?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
