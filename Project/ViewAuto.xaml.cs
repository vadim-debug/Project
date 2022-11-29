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
    /// Логика взаимодействия для ViewAuto.xaml
    /// </summary>
    public partial class ViewAuto : Page
    {
        private PRAuto _CurrentAuto = new PRAuto();
        public ViewAuto(PRAuto Selected_Auto)
        {
            InitializeComponent();
            if (Selected_Auto != null)
            {
                _CurrentAuto = Selected_Auto;
            }

            DataContext = _CurrentAuto;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
