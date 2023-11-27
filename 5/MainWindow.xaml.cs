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

namespace _5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            double product = 1.0;


            for (int j = 0; j < 15; j++)
            {
                product *= a(j);
            }

            Result.Content = $"{product}";

        }

        private double a (int i)
        {
            if (i == 0 || i == 1) { return 1; }


            return a(i - 2) + a(i - 1) / Math.Pow(2, i - 1);
        }

    }
}
