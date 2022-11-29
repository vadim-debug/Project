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

namespace Project
{
    /// <summary>
    /// Логика взаимодействия для HelloPage.xaml
    /// </summary>
    public partial class HelloPage : Page
    {
        String LoginPerson1;
        public HelloPage(string LoginPerson)
        {
            LoginPerson1 = LoginPerson;
            InitializeComponent();
            if(LoginPerson== "Manager" || LoginPerson == "Client")
            {
                ToClient.Visibility = Visibility.Hidden;
            }
            if (LoginPerson == "Client")
            {
                ToProcat.Visibility = Visibility.Hidden;
            }
        }
        
        private void ToClient_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show(LoginPerson1);
            NavigationService.Navigate(new Client(LoginPerson1));
        }

        private void ToAuto_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Auto(LoginPerson1));
        }

        private void ToProcat_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Procat());
        }

        private void BackToLogin_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
