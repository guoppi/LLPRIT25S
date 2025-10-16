using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tehtävä 6: Nimitaulukko ja indeksihaku

            string[] nimet = new string[10];

            Console.WriteLine("Anna 10 nimeä:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Anna nimi {i + 1}: ");
                nimet[i] = Console.ReadLine(); // Tallennetaan nimi taulukkoon
            }

            // Kysytään käyttäjältä kokonaisluku n (1–10)
            Console.Write("\nAnna kokonaisluku (1-10): ");
            string syote = Console.ReadLine();
            if (int.TryParse(syote, out int n))
            {
                if (n >= 1 && n <= 10)
                {
                    // Tulostetaan nimi indeksissä n-1 (koska taulukko alkaa nollasta)
                    Console.WriteLine($"Nimi indeksissä {n}: {nimet[n - 1]}");
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }

                Console.WriteLine();

                // Tehtävä 7: Liukuluvut ja raja-arvon ylitysten laskeminen

                float[] luvut = new float[100];
                int count = 0;

                Console.WriteLine("Syötä liukulukuja (max 100). Tyhjä syöte lopettaa:");
                Console.WriteLine();
                while (count < 100)
                {
                    Console.Write($"Anna liukuluku {count + 1}: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        break; // Lopetetaan syöttö, jos syötetään tyhjä rivi
                    }

                    // Yritetään muuntaa syöte liukuluvuksi
                    if (float.TryParse(input, out float number))
                    {
                        if (number == 0)
                        {
                            break; // Lopetetaan syöttö, jos syötetään 0
                        }
                        luvut[count] = number; // Tallennetaan luku taulukkoon
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Virheellinen syöte, yritä uudelleen.");
                    }
                }
                Console.WriteLine();

                // Kysytään raja-arvo

                Console.Write("\nAnna raja-arvo: ");
                if (float.TryParse(Console.ReadLine(), out float rajaArvo))
                {
                    int yliRajaArvo = 0;

                    // Lasketaan kuinka moni syötetyistä luvuista ylittää raja-arvon
                    for (int i = 0; i < count; i++)
                    {
                        if (luvut[i] > rajaArvo)
                        {
                            yliRajaArvo++;
                        }
                    }
                    Console.WriteLine($"\n{yliRajaArvo} syötetyistä luvuista on suurempi kuin raja-arvo {rajaArvo}.");
                }
                else
                {
                    Console.WriteLine("Virheellinen raja-arvo.");
                }
            }
        }
    }
}
