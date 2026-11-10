using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> rezervacije = new Dictionary<string, int>();

    static string RezervisiUlaznice(string korisnik, int broj)
    {
        if (broj <= 5)
        {
            if (!rezervacije.ContainsKey(korisnik))
            {
                rezervacije[korisnik] = 0;
            }

            rezervacije[korisnik] += broj;
            return "Rezervacija uspjesna!";
        }

        return "Moguce je rezervisati najvise 5 ulaznica!";
    }

    static void Main()
    {
        Console.WriteLine(RezervisiUlaznice("ana", 5));
        Console.WriteLine(RezervisiUlaznice("ana", 5));
        Console.WriteLine(RezervisiUlaznice("ana", 5));

        Console.WriteLine("Ana ukupno rezervisala: " + rezervacije["ana"]);
    }
}