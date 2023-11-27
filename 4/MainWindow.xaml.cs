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

namespace _4
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


        private ulong factorial (ulong n)
        {

            if (n == 1) return 1;

            return n * factorial(n - 1);

        }


        private void compute()
        {
            try
            {

                ulong n = ulong.Parse(N.Text);



                if (n > 0)
                {

                    double sum = 1;

                    for (ulong i = 1; i <= n; i++)
                    {

                        sum += 1.0 / factorial(i);

                    }

                    // когда превышено значение допустимое ulong, компьютер приравнивает product нулю
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
    }
}
