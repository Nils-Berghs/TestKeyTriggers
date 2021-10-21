using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestKeyTriggers.Util;

namespace TestKeyTriggers.ViewModels
{
    public class ViewModelB:ViewModelBase
    {
        public ICommand GoBackCommand { get; }

        public ViewModelB(MainViewModel mainViewModel)
        {
            GoBackCommand = new RelayCommand(() => mainViewModel.PopViewModel());
        }
    }
}
