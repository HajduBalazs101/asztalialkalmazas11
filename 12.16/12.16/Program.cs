using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajlfajl
{
    class Program
    {
        //1.
        static string[] adatbekeres()
        {
            string[] bekert = new string[3];
            Console.WriteLine("Kérem a termék nevét");
            bekert[0] = Console.ReadLine();
            Console.WriteLine("Kérem a termék árát");
            bekert[1] = Console.ReadLine();
            Console.WriteLine("Kérem a termék mennyiségét");
            bekert[2] = Console.ReadLine();
            return bekert;
        }
        //2.
        static bool iras(string[] tomb)
        {
            // ha az sw nek a 2. paramétere true akkor hozzáfűző(append) módban működik
            var egySor = tomb[0] + "," + tomb[1] + "," + tomb[2];
            try
            {
                var fajl = new StreamWriter("adatok.txt", true);
                fajl.Write(egySor);
                fajl.WriteLine();
                fajl.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // 3. megjelenites
        static void megjelenit(string fajlnev)
        {
            try
            {
                var fajl = new StreamReader(fajlnev);
                while (!fajl.EndOfStream)
                {
                    var sorTomb = fajl.ReadLine().Split(',');
                    foreach (var item in sorTomb)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                fajl.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            string[] bejovo = adatbekeres();
            //Console.WriteLine((iras(bejovo))?"Sikerült":"Nem Sikerült"); 
            if (iras(bejovo))
            {
                megjelenit("adatok.txt");
            }
            Console.ReadKey();
        }
    }
}