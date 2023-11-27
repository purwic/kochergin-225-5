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



        private double a (char type, int i)
        {

            switch (type)
            {

                case 'а':

                    return 1 / Math.Pow(i, 2);



                case 'б':

                    return 1 / (i * (i + 1));



                case 'в':

                    return ;



                case 'г':

                    return ;



                case 'д':

                    return ;



                case 'е':

                    return ;




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

                if(!(epsilon > 0))
                {
                    throw new ArgumentException();
                }

                

            }

            catch { }
        }
    }
}
