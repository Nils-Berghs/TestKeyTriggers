using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestKeyTriggers.Util;

namespace TestKeyTriggers.ViewModels
{
    public class MainViewModel:ViewModelBase
    {
        private Stack<ViewModelBase> ViewModels { get; }

        private ViewModelBase _CurrentViewModel;

        public ViewModelBase CurrentViewModel 
        { 
            get => _CurrentViewModel; 
            private set => SetProperty(ref _CurrentViewModel, value);
        }

        public MainViewModel()
        {
            ViewModels = new();
        }

        /// <summary>
        /// Pushes a viewmodel to the stack 
        /// </summary>
        /// <param name="viewModel"></param>
        public void PushViewModel(ViewModelBase viewModel)
        {
            ViewModels.Push(viewModel);
            CurrentViewModel = viewModel;
        }

        /// <summary>
        /// Pops a viewmodel from the stack
        /// </summary>
        public void PopViewModel()
        {
            _ = ViewModels.Pop();
            CurrentViewModel = ViewModels.Peek();
        }

    }
}
