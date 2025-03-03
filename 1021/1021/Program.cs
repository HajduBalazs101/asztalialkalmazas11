using System;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            //létrehozzuk a változókat
            int[] lsz = new int[5];
            int i = 0, j = 0;
            char karakter = ' ';
            bool volt = true;
            Random vsz = new Random();
            Console.WriteLine("   A lottószámok:");
            do
            {
                //lottószámok generálása
                for (i = 0; i <= 4; i++)
                {
                    //ha nem az első szám, akkor ellenőrizzuk a duplikációt
                    if (i > 0)
                    {
                        do
                        {
                            //alapból a duplikáció hamis
                            lsz[i] = vsz.Next(90) + 1;
                            volt = false;
                            for (j = 0; j < i; j++)
                            {
                               
                                if (lsz[i] == lsz[j])
                                {
                                    volt = true;
                                }
                            }
                            
                        } while (volt == true); //ismételjük, amíg minden szám különböző
                    }
                    else lsz[i] = vsz.Next(90) + 1;
                    //kiírjuk a lottószámokat
                    Console.Write("{0,5}", lsz[i]);
                }
                karakter = 'n';
                Console.WriteLine();
                Console.Write("Legyen új sorsolás? (i) Más billentyűre kilép! ");
                karakter = Convert.ToChar(Console.ReadLine());
            //amíg a bemenet 'i', addig a program újrafut
            } while (karakter == 'i');
        }
    }
}
