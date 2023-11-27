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

namespace _6
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


        // в виде реккур. функции
        private double sum (int n, int k)
        {
            if (n == 1)
            {
                return 1;
            }

            return Math.Pow(n, k) + sum(n - 1, k);
        }



        private void compute()
        {

            try
            {

                int n = int.Parse(N.Text);
                int k = int.Parse(K.Text);

                if (0 < n)
                {

                    double sum = 0;

                    for (int i = 1; i <= n; i++)
                    {
                        sum += Math.Pow(i, k);

                    }

                    // переполнение
                    if (sum == 0) { throw new ArgumentException(); }



                    Result.Content = $"{sum}";

                }
                else { throw new ArgumentException(); }

            }

            catch
            {
                Result.Content = "-";
            }
        }


        private void N_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }

        private void K_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}
