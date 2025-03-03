using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _12._02._03
{
    class Program
    {
        static string[] adatok = new string[2];
        
        static void Main(string[] args)
        {
            adatbekeres();
            fajlbairas();
            filebeolvasas();
            Console.ReadKey();
        }

        private static void filebeolvasas()
        {
            StreamReader reader = new StreamReader("feladat42.txt");
            while(!reader.EndOfStream)
            {
                string[] sor = reader.ReadLine().Split(' ');
                foreach(var item in sor)
                {
                    Console.WriteLine("Neve, átlaga: "+ item + " ");
                }
                Console.WriteLine();
            }
        }

        private static void fajlbairas()
        {
            StreamWriter file = new StreamWriter("feladat42.txt");
            foreach (var item in adatok)
            {
                file.WriteLine(item);
                
            }
            file.Close();
        }

        static void adatbekeres()
        {
            for (int i = 0; i < adatok.Length; i++)
            { 
                Console.WriteLine("Add meg a neved: ");
                string nev = Console.ReadLine();
                Console.WriteLine("Add meg az átlagod: ");
                double atlag = double.Parse(Console.ReadLine());
                adatok[i] = nev + " " + atlag; 
            }

        }
    }
}
