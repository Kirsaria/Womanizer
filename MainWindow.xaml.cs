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

namespace Womanizer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetSeasonalCalendars();
        }
        private void SetSeasonalCalendars()
        {
            DateTime now = DateTime.Now;
            if (now.Month >= 6 && now.Month <= 8) // Лето
            {
                Calendar1.Visibility = Visibility.Visible;
                Calendar2.Visibility = Visibility.Visible;
                Calendar3.Visibility = Visibility.Visible;
            }
        }
    }
}
