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

        private void Button1Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "1";
        }

        private void Button2Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "2";
        }

        private void Button3Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "3";
        }

        private void Button4Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "4";
        }

        private void Button5Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "5";
        }

        private void Button6Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "6";
        }

        private void Button7Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "7";
        }

        private void Button8Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "8";
        }

        private void Button9Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "9";
        }

        private void Button0Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "0";
        }

        private void ButtonPlusClick(object sender, RoutedEventArgs e)
        {
            ButtonCheck('+');
        }

        private void ButtonMinusClick(object sender, RoutedEventArgs e)
        {
            ButtonCheck('-');
        }

        private void ButtonMultiplyClick(object sender, RoutedEventArgs e)
        {
            ButtonCheck('*');
        }

        private void ButtonDivClick(object sender, RoutedEventArgs e)
        {
            ButtonCheck('/');
        }

        private void ButtonEqualClick(object sender, RoutedEventArgs e)
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

        private void ButtonCClick(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
        }
    }
}
