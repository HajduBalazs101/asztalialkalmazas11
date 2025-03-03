using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helsinki
{
    public partial class Form1 : Form
    {
        // 1. felvenni egy struktúrát
        struct adatsor
        {
            public int helyezes;
            public int letszam;
            public string sportag;
            public string versenyszam;
        }
        // 2. létrehozni egy listát
        List<adatsor> lista = new List<adatsor>();
        public Form1()
        {
            InitializeComponent();
            // beolvasni a fájlt és eltárolni a struktúrában, majd a listában
            var sr = new StreamReader("helsinki.txt");
            var temp = new adatsor();
            while (!sr.EndOfStream)
            {
                var sor = sr.ReadLine().Split(' ');
                // eltároljuk a sztring tömböt egy adatsorban
                temp.helyezes = int.Parse(sor[0]);
                temp.letszam = int.Parse(sor[1]);
                temp.sportag = sor[2];
                temp.versenyszam = sor[3];
                // az átmeneti tárolót hozzáadjuk a listához
                lista.Add(temp);
            }
            sr.Close();
            // 3. feladat
            label3.Text = "3. feladat\nPontszerző helyezések száma: " + lista.Count;
            // 4. feladat
            int aranyermekSzama = 0;
            var ezustermekSzama = 0;
            var bronzermekSzama = 0;
            foreach (var item in lista)
            {
                if (item.helyezes == 1) aranyermekSzama++;
                if (item.helyezes == 2) ezustermekSzama++;
                if (item.helyezes == 3) bronzermekSzama++;
            }
            var ermekszamaOsszesen = aranyermekSzama + ezustermekSzama + bronzermekSzama;
            label4.Text = ermekszamaOsszesen.ToString();

            //5.feladat

            var osszesen = 0;
            foreach (var item in lista)
            {
                if (item.helyezes == 1)
                {
                    osszesen += 7;
                }
                else if (item.helyezes == 2)
                {
                    osszesen += 5;
                }
                else if (item.helyezes == 3)
                {
                    osszesen += 4;
                }
                else if (item.helyezes == 4)
                {
                    osszesen += 3;
                }
                else if (item.helyezes == 5)
                {
                    osszesen += 2;
                }
                else osszesen += 1;
                label5.Text = osszesen.ToString();

                var uszas = 0;
                var torna = 0;
                foreach (var szar in lista)
                {
                    if (szar.sportag == "uszas") uszas++;
                    else if (szar.sportag == "torna") torna++;

                }
                if (uszas > torna) label6.Text = "Úszás win";
                else if (uszas < torna) label6.Text = "Torna win";
                //7
                var sw = new StreamWriter("helsinki2.txt");
                var sor = item.helyezes + " " + osszesen + " " + item.letszam + " " + item.sportag + " " + item.versenyszam;
                sw.WriteLine(sor);
                sw.Close();
                //8
                var max = 0;
                var index = 0;
                foreach (var elem in lista)
                {
                    if (elem.letszam > max)
                    {
                        max = elem.letszam;
                        index = lista.IndexOf(item);
                    }
                }
                label8.Text = "Helyezés: " + lista[index].helyezes;
                label8.Text = "\nSportág: " + lista[index].sportag;
                label8.Text = "\nVersenyszám: " + lista[index].versenyszam;
                label8.Text = "\nSportolók száma: " + max;
            }
        }
    }
}