using System;

namespace _11._18
{
    class Program
    {
        static int alapErtek;
        static void Main(string[] args)
        {
            alapErtek = 100;
            generator(alapErtek);
        }
        static void generator(int meddigGeneral)
        {
            var gen = new Random();
            int vsz = gen.Next(meddigGeneral);
            Console.WriteLine(vsz);
        }
    }
}