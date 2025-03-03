using System;

namespace _11._25
{
    class Program
    {
   
        static void Main(string[] args)
        {
            int szam1 = 20, szam2 = 2;
            osszead();
            Console.WriteLine(kivonas(szam1, szam2));
            Console.WriteLine(szorzas());
            Console.WriteLine(osztas(szam1,szam2));
        }

        static void osszead()
        {
            Console.WriteLine(3+5);
        }
        static int kivonas(int szam1, int szam2)
        {
            return szam2 - szam1;
        }
        static int szorzas()
        {
            int szam1 = 2, szam2 = 31;
            return szam1 * szam2;
        }
        static int osztas(int szam1, int szam2)
        {
            return szam1 / szam2;
        }
    }
}
