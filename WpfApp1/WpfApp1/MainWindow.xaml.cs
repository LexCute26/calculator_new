using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.NoResize;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Width = 381;
        }

        private void ShowMemory_Click(object sender, RoutedEventArgs e)
        {
            if (!showMemory.Header.ToString().Contains("✓"))
            {
                lblData.Visibility = Visibility.Visible;
                showMemory.Header = "✓ _Show Memory";
                showHistory.IsEnabled = false;
                this.Width = 696;
            }
            else
            {
                lblData.Visibility = Visibility.Hidden;
                showMemory.Header = "_Show Memory";
                showHistory.IsEnabled = true;
                this.Width = 381;
            }
        }

        private void cmdExit_Click(object sender, RoutedEventArgs e)
        {
            ExitApplication();
        }

        private void ExitApplication(System.ComponentModel.CancelEventArgs e = null)
        {
            if (MessageBox.Show("Do you want to exit the Application?"
                + Environment.NewLine + Environment.NewLine +
                "Note: History and Memory Trail will be deleted", "Close", MessageBoxButton.YesNoCancel,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                e.Cancel = false;
                Application.Current.Shutdown();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
                e.Cancel = true;
                ExitApplication(e);
        }

        private void ShowHistory_Click(object sender, RoutedEventArgs e)
        {
            if (this.lvHistory.IsVisible == false)
            {
                lblData.Visibility = Visibility.Visible;
                showHistory.Header = "✓ Show _History";
                lvHistory.Visibility =  Visibility.Visible;
                showMemory.IsEnabled = false;
                this.Width = 696;
            }
            else
            {
                lblData.Visibility = Visibility.Hidden;
                showHistory.Header = "Show _History";
                lvHistory.Visibility = Visibility.Hidden;
                showMemory.IsEnabled = true;
                this.Width = 381;
            }
        }
    }
}
