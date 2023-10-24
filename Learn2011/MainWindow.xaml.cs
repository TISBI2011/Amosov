using Learn2011.AppWindows;
using Learn2011.Pages;
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

namespace Learn2011
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

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainMenuPage());
        }

        private void BProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();

            //profileWindow.Show();
            profileWindow.ShowDialog();
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void BSendMessage_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Вы отправили: " + TBMessage.Text);
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoginPage());
        }

        private void DGUsers_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageUser());
        }
    }
}
