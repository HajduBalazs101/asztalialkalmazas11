﻿using MySql.Data.MySqlClient;
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
        MySqlConnection kapcs = new MySqlConnection("server = server.fh2.hu;database = v2labgwj_11a; uid = v2labgwj_11a; password = 'VGFR2GJjqudMt8Q4SA5j'");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            kapcs.Open();
            var sql = $"SELECT * FROM hajdub_user WHERE nev = '{txtNev.Text}' AND jelszo = '{txtJelszo.Text}' ;";
            lbDebug.Content = sql;
            var parancs = new MySqlCommand(sql, kapcs);
            var reader = parancs.ExecuteReader();
            if (reader.Read())
            {
                lbDebug.Content = "Sikeres bejelentkezés";            
            }
            else
            {
                lbDebug.Content = "Sikertelen bejelentkezés";
            }
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            if(regpass == regpass2)
            {
                MessageBox.Show("A két jelszó megegyezik!");
            }
            else
            {
                MessageBox.Show("A két jelszó nem egyezik meg!");
            }

        }
    }
}
