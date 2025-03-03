using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = 0, k = 0;
            Console.WriteLine("Kérem az alap sugarát: ");
            double r = Convert.ToDouble(Console.ReadLine());
            //akt paraméter
            kor(r, ref t, ref k);
            Console.WriteLine("Területe: {0}", t);
            Console.WriteLine("Kerülete: {0}", k);

        }
        //formális paraméterben is fel kell töntetni az átadás típusát
        static void kor(double sugar, ref double terulet, ref double kerulet)
        {
            terulet = sugar * sugar * Math.PI;
            kerulet = 2 * sugar * Math.PI;
        }
    }
}
