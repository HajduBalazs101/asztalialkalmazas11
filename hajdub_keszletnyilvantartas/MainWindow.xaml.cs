using MySql.Data.MySqlClient;
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

namespace hajdub_keszletnyilvantartas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            MySqlConnection kapcs = new MySqlConnection("server = localhost;database = asztali_11a; uid = root; password = ''");
        public MainWindow()
        {
            InitializeComponent();
            kapcs.Open();
            Betolt();
        }
        private void Betolt()
        {
            
            var lekerdezes = new MySqlCommand("SELECT * FROM hajdub_termek", kapcs);
            var reader = lekerdezes.ExecuteReader();
            while (reader.Read())
            {
                lbTermekek.Items.Add(reader["id"] + " " + reader["cikkszam"] + " " + reader["megnevezes"]);
            }
            kapcs.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kapcs.Open();
            var sql = $"INSERT INTO hajdub_termek (cikkszam, megnevezes) VALUES ('{txtCikkszam.Text}', '{txtMegnevezes.Text}')";
            var parancs = new MySqlCommand(sql, kapcs);
            parancs.ExecuteNonQuery();

            lbTermekek.Items.Clear();
            txtCikkszam.Clear();
            txtMegnevezes.Clear();
            Betolt();
            kapcs.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var selected = lbTermekek.SelectedItem.ToString();
            var id = selected.Split(' ')[0];
            kapcs.Open();
            var sql = $"DELETE FROM hajdub_termek WHERE id = {id}";
            var parancs = new MySqlCommand(sql, kapcs);
            parancs.ExecuteNonQuery();
            lbTermekek.Items.Clear();
            Betolt();
            kapcs.Close();
        }

        private void lbTermekek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbTermekek.SelectedItem != null)
            { 
            var selecteditem = lbTermekek.SelectedItem;
            var resz = selecteditem.ToString().Split(' ');
            txtSzar1.Text = resz[1];
            txtSzar2.Text = resz[2];
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (lbTermekek.SelectedItem != null)
            { 
            var select = lbTermekek.SelectedItem.ToString();
            var resz = select.Split(' ');
            var sql = $"UPDATE hajdub_termek SET cikkszam = '{txtSzar1.Text}', megnevezes = '{txtSzar2.Text}' WHERE id = '{resz[0]}'";
            var parancs = new MySqlCommand(sql, kapcs);
            kapcs.Open();
            parancs.ExecuteNonQuery();
            lbTermekek.Items.Clear();
            txtSzar1.Clear();
            txtSzar2.Clear();
            Betolt();
            kapcs.Close();
            }
        }
    }
}
