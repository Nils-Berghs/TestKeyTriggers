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
        private MainViewModel MainViewModel { get; }

        public CodeViewModel CodeViewModel { get; }

        public ViewModelA(MainViewModel mainViewModel)
        {
            CodeViewModel = new CodeViewModel();

            CodeViewModel.CodeEntered += CodeViewModel_CodeEntered;
            MainViewModel = mainViewModel;
            
        }

        private void CodeViewModel_CodeEntered(object sender, EventArgs e)
        {
            MainViewModel.PushViewModel(new ViewModelB(MainViewModel));
        }

    }
}
