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
using System.Globalization;

namespace calendar1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

            public void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
            {
                CultureInfo culture = new CultureInfo("pt-BR");
                calendr.SelectedDate = DateTime.Now.AddDays(1);
                textBox.Text = calendr.DisplayDate.ToString("dd.MM.yyyy", culture);
            }
        private void TextBox_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            textBox.Clear();
        }



    }
    }

