using System;

namespace _1104_tetelek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = new int[15];
            //int[] ketto = new int[15];
            //int[] harom = new int[15];
            //int[] egyeb = new int[15];
            //int i = 0, j = 0, dbketto = 0, dbharom = 0, dbegyeb = 0;
            //Random vsz = new Random();
            //for (i = 0; i < 15; i++)
            //{
            //    a[i] = vsz.Next(101);
            //    Console.Write("{0,5}", a[i]);
            //    if (a[i] % 2 == 0)
            //    {
            //        ketto[dbketto] = a[i];
            //        dbketto++;
            //    }
            //    else
            //    {
            //        if (a[i] % 3 == 0)
            //        {
            //            harom[dbharom] = a[i];
            //            dbharom++;
            //        }
            //        else
            //        {
            //            egyeb[dbegyeb] = a[i];
            //            dbegyeb++;
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine(" A kettővel osztható számok: ");
            //for (j = 0; j < dbketto; j++) Console.Write("{0,5}", ketto[j]);
            //Console.WriteLine();
            //Console.WriteLine(" A kettővel nem, de hárommal osztható számok: ");
            //for (j = 0; j < dbharom; j++) Console.Write("{0,5}", harom[j]);
            //Console.WriteLine();
            //Console.WriteLine(" Az egyéb számok: ");
            //for (j = 0; j < dbegyeb; j++) Console.Write("{0,5}", egyeb[j]);
            //Console.ReadKey();




            int[] a = new int[15],
            b = new int[15];
            int i = 0,
            j = 0, db = 0;
            Random vsz = new Random();
            for (i = 0; i < 15; i++)
            {
                a[i] = vsz.Next(101);
                Console.Write(" {0,5}", a[i]);
                if (a[i] % 5 == 0)
                {
                    b[db] = a[i];
                    db++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Az öttel osztható számok: ");
            for (j = 0; j < db; j++) Console.Write("{0,5}",b[j]);
            Console.ReadKey();
        }
    }
}
