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

namespace _2025._01._20
{
    public partial class Form1 : Form
    {
        struct tura
        {
            public string kezdet;
            public string veg;
            public double hossz;
            public int emel;
            public int lejt;
            public bool ph;
        }
        List<tura> turak = new List<tura>();
        static int kezdomagassag = 0;
        public Form1()
        {
            InitializeComponent();
            beolvas();
            Label label3 = new Label();
            label3.Text = "Teszt";
            this.Controls.Add(label3);
            statisztika(); 
        }
        void statisztika()
        {
            label2.Text = "3. feladat: a túrák száma: " + turak.Count.ToString();
            //4. a túra teljes hossza
            double teljesHossz = 0;
            foreach(var item in turak)
            {
                teljesHossz += item.hossz;
            }
            Label label4 = new Label();
            this.Controls.Add(label4);
            label4.Location = new Point(69, 100);
            label4.Size = new Size(200, 13);
            label4.Text = "4.feladat: a túra teljes hossza:" + teljesHossz.ToString();

            //5.feladat; a legrövidebb szakasz adatai
            
            Label label5 = new Label();
            this.Controls.Add(label5);
            label5.Location = new Point(69, 200);
            label5.Size = new Size(200, 200);
            double minimum = Double.MaxValue;
            var kez = "";
            var veg = "";
                foreach(var item in turak)
                {
                        if(item.hossz < minimum)
                        { 
                            minimum = item.hossz;
                            kez = item.kezdet;
                            veg = item.veg;
                        }
                }
            label5.Text = " 5.feladat: A legrövidebb szakasz: " + minimum + " km\n kezdete: " + kez + "\n vége: " + veg;
            // 7.feladat
            Label label6 = new Label();
            this.Controls.Add(label6);
            label6.Location = new Point(400, 200);
            label6.Size = new Size(200, 200);
            foreach(var item in turak)
            {
                Console.WriteLine(hianyosNev(item)? "hiányos név" : "nem hiányos név");
                label6.Text += hianyosNev(item) ? item.kezdet + "\n" : "";
            }

            // 8.feladat legmagasabb végőpont magassága
            Label label7 = new Label();
            this.Controls.Add(label7);
            label7.Location = new Point(200, 400);
            label7.Size = new Size(300,200);
            var maxMagassag = 0;
            var vegPontNeve = "";
            foreach (var item in turak)
            {
                if (kezdomagassag + item.emel - item.lejt > maxMagassag)
                {
                    maxMagassag = kezdomagassag + item.emel - item.lejt;
                    vegPontNeve = item.veg;
                }
            }
            label7.Text += "7.feladat: Max magasság, végpont : " + maxMagassag + vegPontNeve;
            // 9.feladat kektura2.csv elkészítése
            var sw = new StreamWriter("kektura2.csv");
            sw.WriteLine(kezdomagassag);
            foreach (var item in turak)
            {
                if(hianyosNev(item) == false)
                {
                    sw.WriteLine($"{item.kezdet};{item.veg};{item.hossz};{item.emel};{item.lejt};{item.ph}");
                }
                else
                {
                    sw.WriteLine($"{item.kezdet};{item.veg};{item.hossz};{item.emel};{item.lejt};{((item.ph) ? "i" : "n")}");
                }
            }
            sw.Close();
        }
        // 6.feladat
        bool hianyosNev(tura szakasz)
        {
            if(szakasz.ph == true) {
                if(!szakasz.veg.Contains("pecsetlelohely")){
                    return true;
                }
                return false;
            }
            else {
                return false;
            }
        }
        void beolvas()
        {
            var sr = new StreamReader("kektura.csv");
            var elsoSor = sr.ReadLine();
            kezdomagassag = int.Parse(elsoSor);
            label2.Text = elsoSor;
            while (!sr.EndOfStream)
            {
                var sor = sr.ReadLine().Split(';');
                var rekord = new tura();
                rekord.kezdet = sor[0];
                rekord.veg = sor[1];
                rekord.hossz = double.Parse(sor[2]);
                rekord.emel = int.Parse(sor[3]);
                rekord.lejt = int.Parse(sor[4]);
                rekord.ph = (sor[5] == "i") ? true : false;
                turak.Add(rekord);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
