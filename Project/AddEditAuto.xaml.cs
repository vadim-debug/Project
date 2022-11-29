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
    /// Логика взаимодействия для AddEditAuto.xaml
    /// </summary>
    public partial class AddEditAuto : Page
    {
        private PRAuto _CurrentAuto = new PRAuto();
        public AddEditAuto(PRAuto Selected_Auto)
        {
            InitializeComponent();
            if (Selected_Auto != null)
            {
                _CurrentAuto = Selected_Auto;
            }

            DataContext = _CurrentAuto;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(_CurrentAuto.Model))

                errors.AppendLine("Укажите Имя");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_CurrentAuto.ID == 0)
                pro17Entities.GetContext().PRAuto.Add(_CurrentAuto);

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
