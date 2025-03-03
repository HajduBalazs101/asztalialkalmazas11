using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _12._09
{
    class Program
    {
        static string[,] adatokMem = new string[100, 100];
        
        static int dim1 = 0, dim2 = 0;
        static void Main(string[] args)
        {
            adatbekeres();
            megjelenit();
            fajlbair();
            Console.ReadKey();
        }

        static void fajlbair()
        {
            var fajl = new StreamWriter("kimenet.txt");
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    fajl.Write($"{adatokMem[i, j]}"+ " ");
                }
                fajl.WriteLine();

            }
            fajl.Close();
        }

        static void adatbekeres()
        {
            StreamReader sr = new StreamReader("adatok.txt");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(',');
                dim2 = 0;
                foreach(var item in sor)
                {
                    adatokMem[dim1, dim2] = item;
                    //Console.Write(item + " ");
                    dim2++;
                }
                Console.WriteLine();
                dim1++;
                
            }
            sr.Close();
            
        }

        static void megjelenit()
        {
            
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{adatokMem[i,j]}");
                }
                Console.WriteLine();
                
            }
        }
    }
}
