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
            // Tehtävä 1: Tulostetaan n:n monikertoja, kunnes luku ylittää 100
            Console.WriteLine("Tehtävä 1: Tulostetaan n:n monikertoja alle 100.");
            Console.Write("Anna kokonaisluku n: ");
            int n = int.Parse(Console.ReadLine());

            int luku = n;
            while (luku < 100)
            {
                Console.WriteLine(luku);
                luku += n;
            }

            Console.WriteLine();

            // Tehtävä 2: Tulostetaan kuvio, jossa jokaisella rivillä on n-arvoja rivin numeron verran
            Console.WriteLine("Tehtävä 2: Tulostetaan kuvio.");
            Console.Write("Anna kokonaisluku n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Tehtävä 3 ja 4: Syötetään 10 nimeä ja tulostetaan ne normaalisti ja käänteisesti
            Console.WriteLine("Tehtävä 3 ja 4: Syötä 10 nimeä.");
            string[] nimet = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Syötä nimi ({10 - i} jäljellä): ");
                nimet[i] = Console.ReadLine();
            }

            Console.WriteLine("\nNimet normaalissa järjestyksessä:");
            Console.WriteLine(string.Join(", ", nimet));

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
