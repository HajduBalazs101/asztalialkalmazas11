using System;

namespace oktatoprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, eredmeny = 0, valasz = 0, pont = 0;
            Random vsz = new Random();
            Console.WriteLine("Oktatóprogram");
            Console.WriteLine("");
            for (int i = 1; i <= 10; i++)
            {
                a = vsz.Next(20);
                do
                {
                    b = vsz.Next(20) - 10;
                    eredmeny = a + b;
                } while (eredmeny > 15 || eredmeny < -5);
                Console.Write("{0}   {1}", i, a);
                if (b >= 0) Console.Write("+");
                Console.Write("{0} = ", b);
                valasz = Convert.ToInt32(Console.ReadLine());
                if (valasz == eredmeny) pont++;

            }
            Console.WriteLine();
            switch (pont)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("Elégtelen");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Elégséges");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Közepes");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Jó");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Jeles");
                    break;
            }
            
        }
    }
}
