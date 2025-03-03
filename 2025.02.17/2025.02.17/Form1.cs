using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025._02._17
{
    public struct krater
    {
        public double x;
        public double y;
        public double r;
        public string nev;
    }
    public partial class Form1 : Form
    {
        List<krater> lista = new List<krater>();
        public Form1()
        {
            InitializeComponent();
            using (var sr = new StreamReader("felszin.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var sor = sr.ReadLine().Split('\t');
                    var rekord = new krater();
                    rekord.x = double.Parse(sor[0]);
                    rekord.y = double.Parse(sor[1]);
                    rekord.r = double.Parse(sor[2]);
                    rekord.nev = sor[3];
                    lista.Add(rekord);
                }
            }
            //2. feladat Kráterek száma label2-n
            label2.Text = ("2.feladat: Kráterek száma: " + lista.Count.ToString());

            //4.feladat legnagyobb sugarú kráter
            var max = lista[0].r;
            var index = 0;
            foreach (var item in lista)
            {
                if (item.r > max)
                {
                    index = lista.IndexOf(item);
                    max = item.r;
                }
            }
            label4.Text = $"A legnagyobb kráter sugara: {lista[index].nev}, {lista[index].r} ";
            //6.feladat


        }
        //5.feladat
        private double tavolsag(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //3.feladat
            var valasz = textBox1.Text;
            var index = -1;
            foreach (var item in lista)
            {
                if (item.nev == valasz)
                {
                    index = lista.IndexOf(item);

                    break;
                }

            }
            if (index > 0)
            {
                label3.Text = $"A(z) {lista[index].nev} középpontja X={lista[index].x}, Y={lista[index].y}, sugara R={lista[index].r} ";
            }
            else
            {
                label3.Text = "Nincs ilyen nevű kráter";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var valasz = textBox2.Text;
            var index = -1;
            foreach (var item in lista)
            {
                if (item.nev == valasz)
                {
                    index = lista.IndexOf(item);
                    break;
                }
            }
            foreach (var item in lista)
            {

                if (tavolsag(lista[index].x, lista[index].y, item.x, item.y) < lista[index].r + item.r)
                {
                    //Console.WriteLine("összeér");
                }
                else { label5.Text += item.nev + "\n"; }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

