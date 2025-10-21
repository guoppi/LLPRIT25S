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
            // Tehtävä 1: Tulostetaan n:n monikertoja alle 100
            Console.WriteLine("Tehtävä 1: Tulostetaan n:n monikertoja alle 100.");
            Console.Write("Anna kokonaisluku n: ");
            int n = int.Parse(Console.ReadLine());

            int luku = n;

            // while-toisto: jatkuu niin kauan kuin ehto (luku < 100) on tosi
            while (luku < 100)
            {
                Console.WriteLine(luku);
                luku += n; // lisätään n joka kierroksella
            }

            Console.WriteLine();

            // Tehtävä 2: Tulostetaan kuvio
            Console.WriteLine("Tehtävä 2: Tulostetaan kuvio.");
            Console.Write("Anna kokonaisluku n: ");
            n = int.Parse(Console.ReadLine());

            // for-rakenne: toistetaan i = 1...n
            for (int i = 1; i <= n; i++)
            {
                // sisempi for: toistetaan j = 1...i
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n); // tulostetaan n
                }
                Console.WriteLine(); // siirrytään seuraavalle riville
            }

            Console.WriteLine();

            // Tehtävä 3 ja 4: Syötetään 10 nimeä
            Console.WriteLine("Tehtävä 3 ja 4: Syötä 10 nimeä.");
            string[] nimet = new string[10];

            // for-rakenne: toistetaan 10 kertaa, i = 0...9
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Syötä nimi ({10 - i} jäljellä): ");
                nimet[i] = Console.ReadLine(); // tallennetaan nimi taulukkoon
            }

            // Tulostetaan nimet normaalissa järjestyksessä
            Console.WriteLine("\nNimet normaalissa järjestyksessä:");
            Console.WriteLine(string.Join(", ", nimet));

            // Tulostetaan nimet käänteisessä järjestyksessä
            Console.WriteLine("\nNimet käänteisessä järjestyksessä:");
            // for-rakenne: toistetaan taulukon lopusta alkuun
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(nimet[i]);
                // if-rakenne: lisätään pilkku, jos ei olla viimeisessä
                if (i > 0)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
