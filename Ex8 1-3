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
            // Tehtävä 1: Täytetään taulukko vuorotellen nollilla ja ykkösillä
            int[] taulukko = new int[5]; // Luodaan taulukko, jossa on 5 alkiota
            int i = 0;

            while (i < taulukko.Length) // Käydään taulukko läpi
            {
                if (i % 2 == 0) // Jos indeksi on parillinen
                {
                    taulukko[i] = 0;
                }
                else // Jos indeksi on pariton
                {
                    taulukko[i] = 1;
                }
                i++;
            }

            // Tulostetaan taulukon sisältö
            for (int j = 0; j < taulukko.Length; j++)
            {
                Console.WriteLine(taulukko[j]);
            }
            Console.WriteLine(); // Tyhjä rivi

            // Tehtävä 2: Muokataan taulukon sisältöä ja tulostetaan se käänteisessä järjestyksessä
            i = 0;
            while (i < taulukko.Length)
            {
                taulukko[i] = i + 1; // Täytetään taulukko arvoilla 1, 2, 3, ...
                i++;
            }

            i = 0;
            while (i < taulukko.Length)
            {
                taulukko[i] = taulukko[i] * 2; // Kerrotaan jokainen arvo kahdella
                i++;
            }

            i = taulukko.Length - 1;
            while (i >= 0)
            {
                Console.WriteLine(taulukko[i]); // Tulostetaan taulukko takaperin
                i--;
            }
            Console.WriteLine(); // Tyhjä rivi

            // Tehtävä 3: Käyttäjä syöttää taulukon koon ja arvot, jotka tulostetaan lopuksi
            Console.Write("Anna taulukon koko: ");
            int koko = int.Parse(Console.ReadLine()); // Luetaan taulukon koko käyttäjältä
            taulukko = new int[koko]; // Luodaan uusi taulukko annetulla koolla
            int laskuri = 0;

            // Luetaan käyttäjältä arvot taulukkoon
            do
            {
                Console.Write($"Anna kokonaislukuja indeksiin {laskuri}: ");
                taulukko[laskuri] = int.Parse(Console.ReadLine());
                laskuri++;
            }
            while (laskuri < taulukko.Length);

            // Tulostetaan käyttäjän syöttämät arvot
            for (int j = 0; j < taulukko.Length; j++)
            {
                Console.WriteLine(taulukko[j]);
            }
        }
    }
}
