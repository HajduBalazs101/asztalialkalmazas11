using System;
// ua. import, namespace, névtér
namespace bomboclat1
{
    class Program
    // osztály definíció
    { 
        static void Main(string[] args)
        // static = azonnal elérhető,  main metódus (függvény), 1 bemenő paraméterrel, nincs visszatérési értéke
        // a bemenő paraméter egy string tömb
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(args[0]);
            Console.Write("Írjál be valamit: ");
            string bemenet = Console.ReadLine() ;
            Console.WriteLine("Eztet irtad be: {0}", bemenet);
            Console.ReadKey();
        }
    }
}
