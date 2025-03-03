using System;

namespace _10._07
{
    class Program
    {
        static void Main(string[] args)
        {
            var bemenet = Console.ReadLine();
            var szam = Convert.ToInt32(bemenet);
            Console.WriteLine(szam);
            if (szam <= 0)
            {
                Console.WriteLine("A szám nem pozitív");
            }
            else
            {
                Console.WriteLine("A szám pozitív");
            }
            // termális operátor
            var szoveg = (szam <= 0) ? "A szám nem pozitív" : "A szám pozitív";
            Console.WriteLine(szoveg);
            // beágyazott elágazás
            if (szam <= 0)
            {
                if (szam < 0) Console.WriteLine("A szám negatív");
                else Console.WriteLine("A szám nulla");
            }
            else if (szam % 2 == 0)
            {
                Console.WriteLine("A szám páros");
            }
            else
            {
                Console.WriteLine("A szám páratlan");
            }
            for (int n = 1; n <= szam; n++)
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
