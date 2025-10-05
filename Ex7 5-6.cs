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
            // TEHTÄVÄ 5: Lasketaan luvun neliö niin kauan kuin syötetty luku on positiivinen

            int luku; // Luodaan muuttuja luvulle

            do
            {
                luku = int.Parse(Console.ReadLine()); // Luetaan käyttäjältä luku

                if (luku >= 0) // Tarkistetaan että luku on positiivinen
                {
                    int nelio = luku * luku; // Lasketaan luvun neliö
                    Console.WriteLine(nelio); // Tulostetaan neliö
                }
            }
            while (luku >= 0); // Toistetaan niin kauan kuin luku on positiivinen


            // TEHTÄVÄ 6: Etsitään pienin ja suurin positiivinen luku käyttäjän syötteistä

            luku = 0; // Alustetaan luku nollaksi
            int pienin = int.MaxValue; // Alustetaan pienin mahdollisimman suureksi
            int suurin = int.MinValue; // Alustetaan suurin mahdollisimman pieneksi
            // pienin aloitetaan mahdollisimman suuresta arvosta, jotta ensimmäinen syöte on varmasti pienempi ja voi korvata sen
            // suurin aloitetaan mahdollisimman pienestä arvosta, jotta ensimmäinen syöte on varmasti suurempi ja voi korvata sen
            do
            {
                luku = int.Parse(Console.ReadLine()); // Luetaan uusi luku

                if (luku >= 0) // Jos luku on positiivinen
                {
                    if (luku < pienin) // Jos luku on pienempi kuin nykyinen pienin
                    {
                        pienin = luku; // Päivitetään pienin
                    }
                    if (luku > suurin) // Jos luku on suurempi kuin nykyinen suurin
                    {
                        suurin = luku; // Päivitetään suurin
                    }
                }
            }
            while (luku >= 0); // Toistetaan kunnes saadaan negatiivinen luku

            Console.WriteLine(pienin); // Tulostetaan pienin syötetty positiivinen luku
            Console.WriteLine(suurin); // Tulostetaan suurin syötetty positiivinen luku
        }
    }
}
