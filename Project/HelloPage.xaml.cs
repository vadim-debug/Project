﻿using System;
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
        public HelloPage()
        {
            InitializeComponent();
        }

        private void ToClient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Client());
        }

        private void ToAuto_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Auto());
        }

        private void ToProcat_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Procat());
        }
    }
}
