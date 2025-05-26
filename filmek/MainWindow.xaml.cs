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
using MySql.Data.MySqlClient;

namespace filmek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection kapcs = new MySqlConnection("server = localhost;database = hajdub_kkszki; uid = root; password = ''");
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Betolt()
        {
            
            var lekerdezes = new MySqlCommand("SELECT * FROM filmek", kapcs);
            var reader = lekerdezes.ExecuteReader();
            while (reader.Read())
            {
                lbAdatok.Items.Add(reader["filmazon"] + ";" + reader["cim"].ToString() + ";" + reader["ev"] + ";" + reader["szines"].ToString() + ";" + reader["mufaj"].ToString() + ";" + reader["hossz"]);
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kapcs.Open();
            Betolt();
            kapcs.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (lbAdatok.SelectedItem != null)
            {
                var select = lbAdatok.SelectedItem.ToString();
                var resz = select.Split(';');
                var sql = $"UPDATE filmek SET cim = '{tb1.Text}', ev = '{tb2.Text}', szines = '{tb3.Text}', mufaj = '{tb4.Text}', hossz = '{tb5.Text}' WHERE filmazon = '{resz[0]}'";
                var parancs = new MySqlCommand(sql, kapcs);
                kapcs.Open();
                parancs.ExecuteNonQuery();
                lbAdatok.Items.Clear();
                tb1.Clear();
                tb2.Clear();
                tb3.Clear();
                tb4.Clear();
                tb5.Clear();
                Betolt();
                kapcs.Close();
            }
        }

        private void lbAdatok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbAdatok.SelectedItem != null)
            {
                var selecteditem = lbAdatok.SelectedItem;
                var resz = selecteditem.ToString().Split(';');
                lbFilmAzon.Content = resz[0];
                tb1.Text = resz[1];
                tb2.Text = resz[2];
                tb3.Text = resz[3];
                tb4.Text = resz[4];
                tb5.Text = resz[5];
            }
        }
    }
}
