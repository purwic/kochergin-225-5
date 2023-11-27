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

namespace _3
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


        private void compute()
        {
            try
            {

                int a = int.Parse(A.Text);
                int b = int.Parse(B.Text);

                if (a < b)
                {

                    ulong product = 1;

                    for (int i = a; i <= b; i++)
                    {
                        product *= ulong.Parse($"{i}");

                    }

                    if ( a > 0 && product == 0) { throw new ArgumentException(); }



                    Result.Content = $"{product}";

                }
                else { throw new ArgumentException(); }

            }

            catch
            {
                Result.Content = "-";
            }
        }



        private void A_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }

        private void B_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}
