using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._16_2
{
    class Program
    {
        //enum értékei 0,1,2 de felül lehet bírálni
        enum SportAgak { labdarugas = 100, tenisz = 200, forma1 = 300}
        struct tanulo
        {
            public string nev;
            public string osztaly;
            public double atlag;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SportAgak.tenisz);
            Console.WriteLine((int)SportAgak.forma1);


            //struktúra test numero uno
            var tanulo1 = new tanulo();
            tanulo1.nev = "cigány";
            tanulo1.osztaly = "11A";
            tanulo1.atlag = 4.87;
            Console.WriteLine("Tanuló neve: {0}, tanuló osztálya: {1}, tanuló átlaga: {2}", tanulo1.nev, tanulo1.osztaly, tanulo1.atlag);
            //struktúra dos
            var adatok = new tanulo[500];
            adatok[0].nev = "román";
            adatok[0].osztaly = "11A";
            adatok[0].atlag = 4.21;
            Console.WriteLine("Tanuló neve: {0}, tanuló osztálya: {1}, tanuló átlaga: {2}", adatok[0].nev, adatok[0].osztaly, adatok[0].atlag);
            //struktúra tres
            var gen = new Random();
            var megy = true;
            
            while (megy)
            {
                var vsz = gen.NextDouble() * 10;
                if (vsz < 5) megy = false;
                
            }
            for (int i = 0; i < adatok.Length; i++)
            {
                adatok[i].nev = "lorem ipsum";
                adatok[i].osztaly = "lorem ipsum 2";
                adatok[i].atlag = 0.0;
            }
            var file = new StreamWriter("adatok2.txt");
            for (int i = 0; i < adatok.Length; i++)
            {
                file.WriteLine("Tanuló neve: {0}, Tanuló osztálya: {1}, Tanuló átlaga: {2}", adatok[i].nev, adatok[i].osztaly, adatok[i].atlag);
            }
            Console.ReadKey();
        }
    }
}
