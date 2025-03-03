using System;

namespace _1104_tetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            //osszegzes
            //int[] a = new int[4];
            //int osszeg = 0;
            //Random vsz = new Random();
            //for (int i = 0; i < 4; i++)
            //{
            //    a[i] = vsz.Next(101);
            //    osszeg += a[i];
            //    Console.WriteLine("{0,5}", a[i]);   
            //}
            //Console.WriteLine("összeg = {0}", osszeg);


            //megszamlalas
            //int[] a = new int[12];
            //int pos = 0, neg = 0, i = 0, nul = 0;
            //Random vsz = new Random();
            //for (i = 0; i < 12; i++)
            //{
            //    a[i] = vsz.Next(-50, 51);
            //    if (a[i] > 0) pos++;
            //    else if (a[i] < 0) neg++;
            //    else nul++;
            //    Console.Write("{0,5}", a[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("{0} db pozitív szám van", pos);
            //Console.WriteLine("{0} db negatív szám van", neg);
            //Console.WriteLine("{0} db nulla van", nul);


            //Eldöntés
            //int[] a = new int[6];
            //int i = 0;
            //bool van = false;
            //Random vsz = new Random();
            //for (i = 0; i < 6; i++)
            //{
            //    a[i] = vsz.Next(51);
            //    Console.Write("{0,5}", a[i]);
            //}
            //i = 0;
            //do
            //{
            //    if (a[i] % 5 == 0)
            //    {
            //        van = true;

            //    }
            //    i++;
            //} while (van == false && i <= 6);
            //Console.WriteLine();
            //if (van) Console.WriteLine("Van 5-tel osztható szám.");
            //else Console.WriteLine("Nincs 5-tel osztható szám.");


            //kiválasztás
            //    int[] a = new int[10];
            //    int i = 0;
            //    bool van = false;
            //    Random vsz = new Random();
            //    for (i = 0; i < 10; i++)
            //    {
            //        a[i] = vsz.Next(-50, 51);
            //        Console.Write("{0,5}", a[i]);
            //    }
            //    i = 0;
            //    do
            //    {
            //        if (a[i] > 0) van = true;
            //        i++;
            //    } while (van == false && i < 10);
            //    Console.WriteLine();
            //    if (van) Console.WriteLine("Az 1. pozitív szám : {0}, indexe : {1}", a[i-1], i-1);
            //    else Console.WriteLine("Nincs pozitív szám");


            //min-max
            int[] a = new int[5];
            int i = 0;
            
            Random vsz = new Random();
            for (i = 0; i < 5; i++)
            {
                a[i] = vsz.Next(51);
                Console.Write("{0,5}", a[i]);
            }
            i = 0;
            int min = a[0];
            do
            {
                if (a[i] < min) min = a[i];
                i++;
            } while (i != 5);
            Console.WriteLine();
            Console.WriteLine("A legkisebb elem: {0}", min);
        }
    }
}
