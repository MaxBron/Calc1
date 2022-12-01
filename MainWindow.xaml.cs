using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml.Linq;

namespace Calculator1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonCheck(char symbol)
        {
            if (textBlock.Text == "")
            {
                textBlock.Text = textBlock.Text;
            }
            else if (textBlock.Text[^1] == symbol)
            {
                textBlock.Text = textBlock.Text;
            }
            else
            {
                textBlock.Text += symbol;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "9";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "0";
        }

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            ButtonCheck('+');
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            ButtonCheck('-');
        }

        private void Button_multiply_Click(object sender, RoutedEventArgs e)
        {
            ButtonCheck('*');
        }

        private void Button_d_Click(object sender, RoutedEventArgs e)
        {
            ButtonCheck('/');
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {

            if (textBlock.Text.Contains('='))
            {
                int i = textBlock.Text.IndexOf('=') + 1;
                textBlock.Text = textBlock.Text[i..];
            }
            else
            {
                try
                {
                    double result = Convert.ToDouble(new DataTable().Compute(textBlock.Text, null));
                    textBlock.Text += '=' + Convert.ToString(result);
                }
                catch
                {
                    textBlock.Text = textBlock.Text;
                }
            }
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
        }
    }
}
