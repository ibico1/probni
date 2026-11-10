using System;

class Program
{
    static int rezervisanaMjesta = 0;

    static string RezervisiUlaznice(int broj)
    {
        if (broj <= 5)
        {
            rezervisanaMjesta += broj;
            return "Rezervacija uspjesna!";
        }

        return "Moguce je rezervisati najvise 5 ulaznica!";
    }

    static void Main()
    {
        Console.WriteLine(RezervisiUlaznice(5));
        Console.WriteLine(RezervisiUlaznice(5));
        Console.WriteLine(RezervisiUlaznice(5));

        Console.WriteLine("Ukupno rezervisanih mjesta: " + rezervisanaMjesta);
    }
}
//izmjene
