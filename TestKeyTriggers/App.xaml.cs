using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TestKeyTriggers.ViewModels;

namespace TestKeyTriggers
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainViewModel mainViewModel = new();
            

            MainWindow  window = new();
            window.DataContext = mainViewModel;
            mainViewModel.PushViewModel(new ViewModelA(mainViewModel));

            window.Show();
        }
    }
}
