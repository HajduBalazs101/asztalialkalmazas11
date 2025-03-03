using System;

namespace _0930
{
    class Program
    {
        static void Main(string[] args)
        {
            //string szam = "";
            //Console.WriteLine("telefonszámbekérő program");
            //Console.WriteLine();
            //do
            //{
            //    Console.WriteLine("Kérem a telefonszámot (06 utáni részt): ");
            //    szam = Console.ReadLine();
            //} while (szam.Length != 9 || (szam[0].ToString() != "2") && (szam[0].ToString() != "3") && (szam[0].ToString() != "7"));
            //if (szam[0].ToString() == "2") Console.WriteLine("Telenor");
            //else if (szam[0].ToString() == "3") Console.WriteLine("Telekom");
            //else if (szam[0].ToString() == "7") Console.WriteLine("Vodafone");

            int pozdb = 0;
            Random vsz = new Random();
            for (int i = 1; i <= 40; i++)
            {
                int szam = vsz.Next(-100, 101);
                if (szam > 0) pozdb++;
                if (i % 8 == 0) Console.WriteLine("{0,6}", szam);
                else Console.Write("{0,6}", szam);
            }
            Console.WriteLine();
            Console.WriteLine("{0} db pozitív szám van.", pozdb);

        }
    }
}
