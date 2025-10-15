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
            // Tehtävä 4: Kysytään käyttäjältä 10 nimeä ja tulostetaan ne yhdelle riville pilkulla erotettuna
            string[] nimet = new string[10]; // Luodaan taulukko 10 nimelle

            Console.WriteLine("Anna 10 nimeä:");

            for (int i = 0; i < 10; i++) // Silmukka 10 kertaa
            {
                int remaining = 10 - i; // Lasketaan montako nimeä on jäljellä
                Console.Write($"Anna nimi {i + 1}, (jäljellä {remaining - 1}): ");
                nimet[i] = Console.ReadLine(); // Tallennetaan nimi taulukkoon
            }

            Console.WriteLine(); // Tyhjä rivi
            Console.WriteLine("Syötetyt nimet:");
            Console.WriteLine(string.Join(", ", nimet)); // Tulostetaan nimet yhdellä rivillä pilkulla erotettuna
            Console.WriteLine();

            // Tehtävä 5: Kysytään nimet uudelleen ja tulostetaan ne käänteisessä järjestyksessä
            Console.WriteLine("Nimet käänteisessä järjestyksessä:");

            for (int i = 0; i < 10; i++) // Syötetään nimet uudelleen
            {
                int remaining = 10 - i;
                Console.Write($"Anna nimi {i + 1}, (jäljellä {remaining - 1}): ");
                nimet[i] = Console.ReadLine(); // Korvataan aiemmat nimet
            }

            Console.WriteLine(); // Tyhjä rivi
            Console.WriteLine("Syötetyt nimet käänteisessä järjestyksessä");
            Array.Reverse(nimet); // Käännetään taulukon järjestys
            Console.WriteLine(string.Join(", ", nimet)); // Tulostetaan nimet käänteisessä järjestyksessä
            Console.WriteLine();
        }
    }
}
