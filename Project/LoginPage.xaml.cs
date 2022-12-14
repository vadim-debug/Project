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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string personData = LoginText.Text;
            if (LoginText.Text =="Admin" || LoginText.Text == "Manager" || LoginText.Text == "Client")
            {
                NavigationService.Navigate(new HelloPage(personData));
            }
            
          
        }

        private void Guest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HelloPage("Client"));
        }
    }
}
