using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            // TEHTÄVÄ 1 ja 2 – Verrataan kahta lukua

            // Pyydetään käyttäjältä ensimmäinen luku
            Console.Write("Anna ensimmäinen luku: ");
            int a = Convert.ToInt32(Console.ReadLine());

            // Pyydetään käyttäjältä toinen luku
            Console.Write("Anna toinen luku: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Verrataan lukuja ja tulostetaan kumpi on suurempi tai ovatko ne yhtä suuret
            if (a > b)
            {
                Console.WriteLine($"{a} is bigger");
            }
            else if (b > a)
            {
                Console.WriteLine($"{b} is bigger");
            }
            else
            {
                Console.WriteLine($"Both numbers have same value {a}");
            }
            Console.WriteLine();

            // TEHTÄVÄ 3 – Kopioiden hinnan laskeminen

            // Pyydetään käyttäjältä kopioiden määrä
            Console.Write("Anna kopioiden määrä: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double hinta;

            // Lasketaan hinta: ensimmäiset 10 kopiota maksavat 0.50 €/kpl, loput 0.20 €/kpl
            if (x <= 10)
            {
                hinta = x * 0.50;
            }
            else
            {
                hinta = 10 * 0.50 + (x - 10) * 0.20;
            }

            // Tulostetaan kopioiden kokonaishinta kahden desimaalin tarkkuudella
            Console.WriteLine($"Kopio maksaa {hinta:F2} euroa");
        }
    }
}
