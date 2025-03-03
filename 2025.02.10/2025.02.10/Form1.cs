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

namespace _2025._02._10
{
    public partial class Form1 : Form
    {
        struct vasarlas
        {
            public List<string> tetelek;
            
        }
        List<vasarlas> lista = new List<vasarlas>();
        public Form1()
        {
            InitializeComponent();
            var sr = new StreamReader("penztar.txt");
            var temp = new vasarlas();
            temp.tetelek = null;
            while (!sr.EndOfStream)
            {
                
                while (true)
                {
                    var sor = sr.ReadLine();
                    if (sor[0] == 'F') break;
                    temp.tetelek.Add(sor);
                }
                lista.Add(temp);
                temp.tetelek.Clear();
            }
            sr.Close();
        }
    }
}
