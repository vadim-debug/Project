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
    /// Логика взаимодействия для Filter.xaml
    /// </summary>
    public partial class Filter : Page
    {
        public string LoginPerson1;
        public string[] Year { get; set; }
      
        public Filter(String LoginPerson)
        {

            InitializeComponent();
            LoginPerson1 = LoginPerson;
            if (LoginPerson == "Client")
            {
                BtnAdd.Visibility = Visibility.Hidden;
                BtnDel.Visibility = Visibility.Hidden;
            }
            Year = new string[] {"2009","2010","2011","2012","2013","2014","2015","2016"};

            DataContext = this;
            ComboType.SelectedIndex = 0;
          var currentAuto = pro17Entities.GetContext().PRAuto.ToList();
            LviewAuto.ItemsSource = currentAuto;
        }
        private void UpdateAuto()
        {
            var currentAuto = pro17Entities.GetContext().PRAuto.ToList();
            currentAuto = currentAuto.Where(p => p.Model.ToLower().Contains(TboxSearch.Text.ToLower())).ToList();
            LviewAuto.ItemsSource = currentAuto.OrderBy(p => p.Dayprice).ToList();
            
        }
       

        private void TboxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateAuto();
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateAuto();
            
        }

        private void LviewAuto_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
           // NavigationService.Navigate(new AddEditAuto((sender as Button).DataContext as PRAuto));
            //MessageBox.Show("da");
        }

        private void BtnEdit1_Click(object sender, RoutedEventArgs e)
        {
            if (LoginPerson1 == "Client")
                MessageBox.Show("Недопустимое действие для вашего акк");
            if (LoginPerson1 == "Admin"|| LoginPerson1 == "Manager")
       NavigationService.Navigate(new AddEditAuto((sender as Button).DataContext as PRAuto));
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var ClientForRemoving = LviewAuto.SelectedItems.Cast<PRAuto>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {ClientForRemoving.Count()}элементов ? ", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    pro17Entities.GetContext().PRAuto.RemoveRange(ClientForRemoving);
                    pro17Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены! ");
                    LviewAuto.ItemsSource = pro17Entities.GetContext().PRAuto.ToList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditAuto(null));
        }
    }
}
