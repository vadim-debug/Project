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
    /// Логика взаимодействия для Auto.xaml
    /// </summary>
    public partial class Auto : Page
    {
        public Auto()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditAuto((sender as Button).DataContext as PRAuto));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditAuto(null));
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var ClientForRemoving = DGridProject.SelectedItems.Cast<PRAuto>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {ClientForRemoving.Count()}элементов ?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    pro17Entities.GetContext().PRAuto.RemoveRange(ClientForRemoving);
                    pro17Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены! ");
                    DGridProject.ItemsSource = pro17Entities.GetContext().PRAuto.ToList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnBackToMain_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HelloPage());
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                pro17Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridProject.ItemsSource = pro17Entities.GetContext().PRAuto.ToList();
            }
        }
    }
}
