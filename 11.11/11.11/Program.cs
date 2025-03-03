using System;

namespace _11._11
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] tomb = { 4, 5, 15, 9, 4, 2, 11, 2 };
            //int n = tomb.Length;
            //int keresettSzam = 9;
            //int i = 0;
            //while (i < n && tomb[i] != keresettSzam)
            //    i++;
            //if (i < n)
            //    Console.WriteLine("A keresett szám indexe: {0}", i);
            //else
            //    Console.WriteLine("A keresett szám nincs benne a tömbben");
            //Console.ReadKey();
            //


            //int[] a = new int[5];
            //Random vsz = new Random();
            //Console.WriteLine("A számok: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    a[i] = vsz.Next(101);
            //    Console.Write("{0,5}", a[i]);
            //}
            //Console.WriteLine();


            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = i + 1; j < 5; j++)
            //    {
            //        if (a[i] > a[j])
            //        {

            //            int s = a[i];
            //            a[i] = a[j];
            //            a[j] = s;
            //        }
            //    }
            //}


            //Console.WriteLine("A számok rendezve:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("{0,5}", a[i]);
            //}

            //Console.ReadKey();

            //rendezes 2

            //string[] nevek = new string[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    nevek[i] = Console.ReadLine();
            //}
            //Array.Sort(nevek);
            //Console.WriteLine();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("{0,5}   ",nevek[i]);
            //}




            //rendezes 2.1
            int[] a = { 6, 7, 8, 9, 10};
            bool voltcsere = false;
            do
            {
                voltcsere = false;
                for (int i = 0; i < 4; i++)
                {
                    if (a[i] > a[i+1])
                    {
                        int s = a[i];
                        a[i] = a[i+1];
                        a[i+1] = s;
                        voltcsere = true;
                    }
                }
            } while (voltcsere);
            foreach (var item in a)
            {
                Console.Write("{0,5}", item);
            }
            
        }
    }
}