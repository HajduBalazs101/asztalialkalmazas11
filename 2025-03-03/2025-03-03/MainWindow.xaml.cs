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

namespace _2025_03_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> lista = new List<string>()
        {
            "első","második","harmadik"
        };
        public MainWindow()
        {
            InitializeComponent();
            listbox1.ItemsSource = lista;
            combobox1.ItemsSource = lista;
            lista.Add("negyedik");
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "OK";
            MessageBox.Show("OK");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void szamol_Click(object sender, RoutedEventArgs e)
        {
            var ar = ((bool)chkafa.IsChecked) ? (int.Parse(textbox1.Text) + int.Parse(textbox2.Text)) * 1.27 : (int.Parse(textbox1.Text) + int.Parse(textbox2.Text));
            MessageBox.Show(ar.ToString());

        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            label1.Content = listbox1.SelectedItem;
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            label1.Content = combobox1.SelectedItem;
        }

        
    }
}
