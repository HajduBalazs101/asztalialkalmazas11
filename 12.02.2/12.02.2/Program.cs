using System;
using System.IO;
namespace _12._02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[5];
            Random vsz = new Random();

            for (int i = 0; i < 5; i++)
            {
                szamok[i] = vsz.Next(101);
            }
            try
            {
                StreamWriter fajl = new StreamWriter("ize.txt");
                foreach (var item in szamok)
                {
                    fajl.Write("{0,5}", item);
                }
                fajl.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("halo boos, no file i found");
            }
            catch (IOException)
            {
                Console.WriteLine("halo boos, eee michael michael. I have a problem.");
            }
            catch (Exception)
            {
                Console.WriteLine("halo boos, some problem");
            }
            finally
            {
                Console.WriteLine("fasza minden, lezártam");
            }
        }
        static void fajlbololvas(string fajlnev)
        {


            try
            {
                StreamReader fajl = new StreamReader("ize2.txt");
                while (!fajl.EndOfStream)
                {
                    Console.WriteLine(fajl.ReadLine());
                }
                fajl.Close();
            }x

            catch (Exception)
            {
                Console.WriteLine("hiba");
            }
        }
    }
}
