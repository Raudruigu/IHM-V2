using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using IHM_V2.View;

namespace IHM_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunBackupBtn(object sender, RoutedEventArgs e)
        {
            Main.Content = new RunBackupJobView();
        }

        private void ManageBackupBtn(object sender, RoutedEventArgs e)
        {
            Main.Content = new ManageBackupJobsView();
        }

        private void NewBackupBtn(object sender, RoutedEventArgs e)
        {
            Main.Content = new NewBackupJobView();
        }

        private void SettingsBtn(object sender, RoutedEventArgs e)
        {
            Main.Content = new SettingsView();
        }

    }
}
