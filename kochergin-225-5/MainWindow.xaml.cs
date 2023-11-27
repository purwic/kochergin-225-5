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

namespace kochergin_225_5
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


        private void compute()
        {

            try
            {

                int count = 0;
                bool ended = false;

                

                foreach (string item in ListBoxData.Items)
                {

                    int item_ = int.Parse(item);

                    if (item_ != 0)
                    {

                        if (item_ % 7 == 0 && item_ % 2 == 0) { count++; }

                    }

                    else
                    {
                        ended = true;
                        break;
                    }

                }


                if (ended)
                {

                    if (count != 0)
                    {
                        TextBlockAnswer.Text = $"Ответ: {count}";

                    }

                    else
                    {
                        TextBlockAnswer.Text = $"Ответ: Таких чисел нет";
                    }

                }

                if (ListBoxData.Items.IsEmpty)
                {
                    TextBlockAnswer.Text = "Ответ:";
                }
            }



            catch { }


        }



        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {

                try
                {
                    if (ListBoxData.Items.IsEmpty)
                    {
                        ListBoxData.Items.Add($"{Convert.ToInt32(Input.Text)}");
                        Input.Text = "";
                        compute();
                    }

                    else if (int.Parse($"{ListBoxData.Items[ListBoxData.Items.Count - 1]}") != 0)
                    {

                        ListBoxData.Items.Add($"{Convert.ToInt32(Input.Text)}");
                        Input.Text = "";
                        compute();

                    }
                }

                catch { }


            }

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ListBoxData.Items.Clear();
            compute();
        }

    }
}
