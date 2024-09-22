using System;
using System.Collections.Generic;
using System.Globalization;
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
            Calendar2.DisplayDate = new DateTime(2024, 10, 01);
            Calendar3.DisplayDate = new DateTime(2024, 11, 01);
        }
        private bool isUpdating = false;
        private void Calendar1_DisplayDateChanged(object sender, CalendarDateChangedEventArgs e)
        {
            if (isUpdating) return;

            try
            {
                isUpdating = true;

                // Изменяем дату первого календаря на 3 месяца вперед
                Calendar1.DisplayDate = Calendar1.DisplayDate.AddMonths(2);

                // Изменяем даты последующих календарей
                DateTime nextMonth1 = Calendar1.DisplayDate.AddMonths(1);
                Calendar2.DisplayDate = nextMonth1;
                DateTime nextMonth2 = Calendar1.DisplayDate.AddMonths(2);
                Calendar3.DisplayDate = nextMonth2;
            }
            finally
            {
                isUpdating = false;
            }
        }

    }
}
