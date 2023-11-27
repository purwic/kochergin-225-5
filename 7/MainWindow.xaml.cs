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

namespace _7
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



        private int factorial(int n)
        {

            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= n;
            }

            if (n == 0)
            {
                return 1;
            }

            return result;
        }


        private double a (char type, int i)
        {

            switch (type)
            {

                case 'а':

                    return 1.0 / Math.Pow(i, 2);



                case 'б':

                    return 1.0 / (i * (i + 1));



                case 'в':

                    return Math.Pow(-1, i) / factorial(i);



                case 'г':

                    return Math.Pow(-2, i) / factorial(i);



                case 'д':

                    return Math.Pow(-1, i + 1) / (i * (i + 1) * (i + 2));



                case 'е':

                    return 1.0 / (Math.Pow(4, i) + Math.Pow(5, i + 2));




                default: throw new ArgumentException();
            }
        }



        private double sum(char type, double epsilon, int n)
        {


            /*
                если |a(n)| < epsilon, тогда оно примерно равно нулю при том что ряд сходится, в условии ска
            */

            if (Math.Abs(a(type, n)) < epsilon) { return 0; }



            /*
            если нет, тогда применяем формулу S^{\infty}_{k} = a_{k} + S^{\infty}_{k+1}
            */

            else { return a(type, n) + sum(type, epsilon, n + 1); }



        }


        private void Epsilon_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                double epsilon = double.Parse(Epsilon.Text);

                if (!(epsilon > 0))
                {
                    throw new ArgumentException();
                }


                // 0 и 1 в зависимости с чего начинается беск. сумма

                A.Content = $"{sum('а', epsilon, 1)}";
                B.Content = $"{sum('б', epsilon, 1)}";
                V.Content = $"{sum('в', epsilon, 1)}";
                G.Content = $"{sum('г', epsilon, 0)}";
                D.Content = $"{sum('д', epsilon, 1)}";
                E.Content = $"{sum('е', epsilon, 0)}";

            }

            catch
            {
                A.Content = "-";
                B.Content = "-";
                V.Content = "-";
                G.Content = "-";
                D.Content = "-";
                E.Content = "-";
            }
        }
    }
}
