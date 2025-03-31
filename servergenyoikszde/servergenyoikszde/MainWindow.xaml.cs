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
using ZstdSharp.Unsafe;


namespace servergenyoikszde
{

    public partial class MainWindow : Window
    {
        //kapcsolati string
        MySqlConnection kapcs = new MySqlConnection("server=localhost;database=asztali_11a;user id=root;password=''");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
               kapcs.Open();
            MySqlCommand parancs = kapcs.CreateCommand();
            var sql = $"SELECT * FROM user WHERE nev = '{txtNev.Text}' AND jelszo = '{txtJelszo.Text}' ;";
        }

        
    }
}
