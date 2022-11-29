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
    /// Логика взаимодействия для AddEditClient.xaml
    /// </summary>
    public partial class AddEditClient : Page
    {
        private PRClient _CurrentClient = new PRClient();
        public AddEditClient(PRClient Selected_Client)
        {
            InitializeComponent();
            if (Selected_Client != null)
            {
                _CurrentClient = Selected_Client;
            }

            DataContext = _CurrentClient;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(_CurrentClient.Name))

                errors.AppendLine("Укажите Имя");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_CurrentClient.ID == 0)
                pro17Entities.GetContext().PRClient.Add(_CurrentClient);

            try
            {
                pro17Entities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                this.NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
