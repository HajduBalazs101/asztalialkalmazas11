using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
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

namespace szamologep.wpfapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentNumber = "";
        private List<int> temp = new List<int>();
        private StreamWriter sr;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            var eredmeny = int.Parse(szam1.Text) + int.Parse(szam2.Text);
            kimenet.Text = eredmeny.ToString();

            sr.WriteLine($"{szam1.Text} + {szam2.Text} = {kimenet.Text}");

        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            var eredmeny = int.Parse(szam1.Text) - int.Parse(szam2.Text);
            kimenet.Text = eredmeny.ToString();

            sr.WriteLine($"{szam1.Text} - {szam2.Text} = {kimenet.Text}");
        }

        private void multiple_Click(object sender, RoutedEventArgs e)
        {
            var eredmeny = int.Parse(szam1.Text) * int.Parse(szam2.Text);
            kimenet.Text = eredmeny.ToString();

            sr.WriteLine($"{szam1.Text} * {szam2.Text} = {kimenet.Text}");
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            var eredmeny = int.Parse(szam1.Text) / int.Parse(szam2.Text);
            kimenet.Text = eredmeny.ToString();

            sr.WriteLine($"{szam1.Text} / {szam2.Text} = {kimenet.Text}");
        }

        private void kilep_Click(object sender, RoutedEventArgs e)
        {
            sr.Close();
            Close();
        }


        private void one_Click_1(object sender, RoutedEventArgs e)
        {
            currentNumber += "1";
            tb1.Text = currentNumber;
        }

        private void two_Click_1(object sender, RoutedEventArgs e)
        {
            currentNumber += "2";
            tb1.Text = currentNumber;
        }

        private void three_Click_1(object sender, RoutedEventArgs e)
        {
            currentNumber += "3";
            tb1.Text = currentNumber;
        }

        private void four_Click_1(object sender, RoutedEventArgs e)
        {
            currentNumber += "4";
            tb1.Text = currentNumber;
        }

        private void five_Click_1(object sender, RoutedEventArgs e)
        {
            currentNumber += "5";
            tb1.Text = currentNumber;
        }

        private void six_Click_1(object sender, RoutedEventArgs e)
        {
            currentNumber += "6";
            tb1.Text = currentNumber;
        }

        private void seven_Click_1(object sender, RoutedEventArgs e)
        {
            currentNumber += "7";
            tb1.Text = currentNumber;
        }

        private void eight_Click_1(object sender, RoutedEventArgs e)
        {
            currentNumber += "8";
            tb1.Text = currentNumber;
        }

        private void nine_Click_1(object sender, RoutedEventArgs e)
        {
            currentNumber += "9";
            tb1.Text = currentNumber;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(currentNumber))
            {
                temp.Add(int.Parse(currentNumber));
                currentNumber = "";
                tb1.Text = "";
            }
            tb1.Text += "+";
        }

        private void _out_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(currentNumber))
            {
                temp.Add(int.Parse(currentNumber));
                currentNumber = "";
            }
            
            int eredmeny = temp.Sum();
            tb1.Text = eredmeny.ToString();
            temp.Clear();
        }
    }
}
