using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        var ujDolgozo = AdatBekeres();
        string fajlNev = "data.txt";
        List<string[]> dolgozok = new List<string[]>();

        try
        {
            // A fájlból beolvassuk az adatokat és a dolgozók listájába tesszük
            foreach (var sor in File.ReadLines(fajlNev))
            {
                dolgozok.Add(sor.Split(','));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Hiba: {0}", e.Message);
            return;
        }

        // Az új dolgozót hozzáadjuk a listához
        dolgozok.Add(ujDolgozo);

        // Az összes dolgozó adatát kiírjuk a konzolra
        foreach (var dolgozo in dolgozok)
        {
            Console.WriteLine("Név: {0} {1}, Lakcím: {2}, Fizetés: {3}", dolgozo[0], dolgozo[1], dolgozo[2], dolgozo[3]);
        }
        Console.WriteLine();
        try
        {
            // Újraírjuk a fájlt a dolgozók listájával, beleértve az új dolgozót is
            List<string> sorok = new List<string>();
            foreach (var dolgozo in dolgozok)
            {
                sorok.Add(string.Join(",", dolgozo));
            }
            File.WriteAllLines(fajlNev, sorok);
        }
        catch (Exception e)
        {
            Console.WriteLine("Hiba: {0}", e.Message);
            return;
        }

        // Fizetések összesítése
        int osszeg = 0;
        foreach (var dolgozo in dolgozok)
        {
            osszeg += int.Parse(dolgozo[3]);
        }
        Console.WriteLine("A fizetések összesen: {0}", osszeg);

        // Fizetések átlaga
        double atlag = 0;
        int db = dolgozok.Count;
        foreach (var dolgozo in dolgozok)
        {
            atlag += double.Parse(dolgozo[3]);
        }
        atlag /= db;
        Console.WriteLine("A fizetések átlaga: {0:F2}", atlag);

        // Miskolci dolgozók számolása
        int miskolciDb = 0;
        foreach (var dolgozo in dolgozok)
        {
            if (dolgozo[2] == "Miskolc")
            {
                miskolciDb++;
            }
        }
        Console.WriteLine("Miskolci dolgozók száma: {0}", miskolciDb);

        // A legnagyobb fizetésű dolgozó keresése
        string[] maxFizetesDolgozo = null;
        int maxFizetes = 0;
        foreach (var dolgozo in dolgozok)
        {
            int fizetes = int.Parse(dolgozo[3]);
            if (fizetes > maxFizetes)
            {
                maxFizetes = fizetes;
                maxFizetesDolgozo = dolgozo;
            }
        }
        Console.WriteLine("A legnagyobb fizetésű dolgozó: {0} {1}", maxFizetesDolgozo[0], maxFizetesDolgozo[1]);
    }

    static string[] AdatBekeres()
    {
        Console.Write("Kérem a dolgozó nevét (vezetéknév keresztnév): ");
        var nevek = Console.ReadLine().Split(' ');

        Console.Write("Kérem a dolgozó lakcímét: ");
        var lakcim = Console.ReadLine();

        Console.Write("Kérem a dolgozó fizetését: ");
        var fizetes = Console.ReadLine();

        return new[] { nevek[0], nevek[1], lakcim, fizetes };
    }
}
