using System;

namespace _1014_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] tomb = new double[4, 7];
            int i = 0, j = 0;
            double sorOsszeg = 0, oszloposszeg = 0;
            Random vsz = new Random();
            Console.WriteLine("    1        2       3       4      5        6        7       sorösszeg ");
            for (i = 0; i <= 3; i++)
            {
                for (j = 0; j <= 6; j++)
                {
                    tomb[i, j] = vsz.Next(-100, 101);
                    tomb[i, j] = tomb[i, j] / 100;
                    if (tomb[i, j] < 0) Console.Write("  {0:0.00}  ", tomb[i, j]);
                    else Console.Write("  {0:0.00}  ", tomb[i, j]);
                    sorOsszeg += tomb[i, j];
                }
                if (sorOsszeg < 0) Console.WriteLine("  {0:0.00}  ", sorOsszeg);
                else Console.WriteLine("  {0:0.00}  ", sorOsszeg); sorOsszeg = 0;
                
            }
            Console.WriteLine();
            for (j = 0; j <= 6; j++)
            {
                for (i = 0; i <= 3; i++)
                {
                    oszloposszeg += tomb[i, j];
                }
                if (oszloposszeg < 0) Console.Write("  {0:0.00}  ", oszloposszeg);
                else Console.Write("  {0:0.00}  ", oszloposszeg); oszloposszeg = 0;
            }
        }
    }
}
