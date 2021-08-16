using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static Mutex _mutex = null;

        protected override void OnStartup(StartupEventArgs e)
        {
            const string appName = "Calculator";
            bool _createdNew;

            _mutex = new Mutex(true, appName, out _createdNew);

            if(!_createdNew)
            {
                //Notify User the user is running.
                MessageBox.Show("Application is running already!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //Exit Application
                Application.Current.Shutdown();
            }

            base.OnStartup(e);
        }
    }
}
