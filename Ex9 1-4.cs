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
            // Tehtävä 1
            // Pyydetään käyttäjältä kokonaisluku
            Console.WriteLine("Tehtävä 1: Tulostetaan luvut, jotka ovat n:n monikertoja ja alle 100.");
            Console.Write("Anna kokonaisluku n: ");
            int n = int.Parse(Console.ReadLine());

            int luku = n;

            // Tulostetaan n:n monikertoja, kunnes luku ylittää 100
            while (luku < 100)
            {
                Console.WriteLine(luku);
                luku += n;
            }

            Console.WriteLine(); // Tyhjä rivi

            // Tehtävä 2
            // Pyydetään uusi kokonaisluku
            Console.WriteLine("Tehtävä 2: Tulostetaan kuvio, jossa rivillä i on i kappaletta n-arvoja.");
            Console.Write("Anna kokonaisluku n: ");
            n = int.Parse(Console.ReadLine());

            // Tulostetaan kuvio
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n); // Tulostetaan n
                }
                Console.WriteLine(); // Siirrytään seuraavalle riville
            }

            Console.WriteLine();
            //Tehtävä 3 ja 4
            // Luodaan taulukko nimille
            Console.WriteLine("Tehtävä 3 ja 4: Syötä 10 nimeä. Tulostetaan nimet normaalisti ja käänteisesti.");
            string[] nimet = new string[10];

            // Pyydetään käyttäjältä 10 nimeä
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Syötä nimi ({10 - i} jäljellä): ");
                nimet[i] = Console.ReadLine();
            }

            // Tulostetaan nimet normaalissa järjestyksessä
            Console.WriteLine("\nNimet normaalissa järjestyksessä:");
            Console.WriteLine(string.Join(", ", nimet));

            // Tulostetaan nimet käänteisessä järjestyksessä
            Console.WriteLine("\nNimet käänteisessä järjestyksessä:");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(nimet[i]);
                if (i > 0)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
