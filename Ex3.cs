using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TEHTÄVÄ 1 – Lasketaan ikä
            string nimi = "Meow Uwu"; // Tallennetaan nimi
            int arvo = 2000; // Syntymävuosi tallennetaan muuttujaan "arvo"
            arvo = DateTime.Now.Year - arvo; // Lasketaan ikä vähentämällä syntymävuosi nykyvuodesta
            Console.WriteLine($"{nimi}, {arvo} vuotta"); // Tulostetaan nimi ja ikä
            Console.WriteLine();

            // TEHTÄVÄ 2 – Lasketaan jalat, sormet, joukkueet ja pallot
            const int jalkaa = 2, sormia = 10, pelaaja = 11, palloja = 3;
            int[] henkiloita = { 100, 123456789 };

            foreach (int henkilomaara in henkiloita)
            {
                int feet = henkilomaara * jalkaa;
                int fingers = henkilomaara * sormia;
                Console.WriteLine($"{henkilomaara} persons have {feet} feet and {fingers} fingers");
                int teams = henkilomaara / pelaaja;
                int leftover = henkilomaara % pelaaja;
                Console.WriteLine($"{henkilomaara} persons form {teams} teams and {leftover} persons are left out");
                int balls = teams * palloja;
                Console.WriteLine($"{teams} football teams need {balls} balls\n");
            }
            /* Tältä näyttää miltä koodi näyttää ilman taulukkoa ja foreach. Huomattavasti lyhyempi toi ylempi.
            
            const int JALKAA = 2;
            const int SORMIA = 10;
            const int PELAAJAA = 11;
            const int PALLOJA = 3;

            // Ensimmäinen henkilöluku
            int henkilomaara = 100;

            int arvo = henkilomaara * JALKAA;
            Console.WriteLine(henkilomaara + " persons have " + arvo + " feet");

            arvo = henkilomaara * SORMIA;
            Console.WriteLine(henkilomaara + " persons have " + arvo + " fingers");

            arvo = henkilomaara / PELAAJAA;
            int jaannos = henkilomaara % PELAAJAA;
            Console.WriteLine(henkilomaara + " persons form " + arvo + " teams and " + jaannos + " persons are left out");

            arvo = arvo * PALLOJA;
            Console.WriteLine(arvo + " balls are needed");

            Console.WriteLine(); // Tyhjä rivi

            // Toinen henkilöluku
            henkilomaara = 123456789;

            arvo = henkilomaara * JALKAA;
            Console.WriteLine(henkilomaara + " persons have " + arvo + " feet");

            arvo = henkilomaara * SORMIA;
            Console.WriteLine(henkilomaara + " persons have " + arvo + " fingers");

            arvo = henkilomaara / PELAAJAA;
            jaannos = henkilomaara % PELAAJAA;
            Console.WriteLine(henkilomaara + " persons form " + arvo + " teams and " + jaannos + " persons are left out");

            arvo = arvo * PALLOJA;
            Console.WriteLine(arvo + " balls are needed");

            Console.WriteLine(); */

            // TEHTÄVÄ 3 – Lasketaan ympyrän pinta-ala ja piiri
            const double PII = 3.14159; // Piin arvo
            double[] radius = { 1, 5, 10 }; // Kolme eri säteen arvoa
            foreach (double r in radius)
            {
                double piiri  = 2 * PII * r; // Piiri
                double ala = PII * r * r; // Pinta-ala
                // Tulostetaan säde, pinta-ala ja piiri kahden desimaalin tarkkuudella
                Console.WriteLine($"Radius: {r:0.00}, Area: {ala:0.00}, Circumference: {piiri:0.00}");
                Console.WriteLine();
            }

            // TEHTÄVÄ 4 – Muunnetaan bittimäärät eri yksiköissä
            arvo = 8; // Yksi tavu = 8 bittiä
            arvo = 1024 * arvo; // Kilotavun bittimäärä
            Console.WriteLine($"1 Kilobyte has {arvo} bits");

            arvo = 1024 * arvo; // Megatavun bittimäärä
            Console.WriteLine($"1 Megabyte has {arvo} bits");

            arvo = 1024 * arvo; // Gigatavun bittimäärä
            Console.WriteLine($"1 Gigabyte has {arvo} bits");

            arvo = 1024 * arvo; // Teratavun bittimäärä
            Console.WriteLine($"1 Terabyte has {arvo} bits");

            Console.WriteLine($"1 byte has 8 bits");
            Console.WriteLine();

            // TEHTÄVÄ 5 – Muunnetaan suuri bittimäärä eri yksiköihin
            const ulong totalBits = 123456789123456789; // Kokonaisbittimäärä
            const ulong bitsPerTerabytes = 1024UL * 1024 * 1024 * 1024 * 8;
            const ulong bitsPerGigabytes = 1024UL * 1024 * 1024 * 8;
            const ulong bitsPerMegabytes = 1024UL * 1024 * 8;
            const ulong bitsPerKilobytes = 1024UL * 8;
            const ulong bitsPerBytes = 8;

            ulong arvoUlong = totalBits / bitsPerTerabytes; // Teratavujen määrä
            Console.WriteLine($"{arvoUlong} terabytes");
            ulong remainder = totalBits % bitsPerTerabytes; // Jakojäännös

            arvoUlong = remainder / bitsPerGigabytes; // Gigatavujen määrä
            Console.WriteLine($"{arvoUlong} gigabytes");
            remainder %= bitsPerGigabytes;

            arvoUlong = remainder / bitsPerMegabytes; // Megatavujen määrä
            Console.WriteLine($"{arvoUlong} megabytes");
            remainder %= bitsPerMegabytes;

            arvoUlong = remainder / bitsPerKilobytes; // Kilotavujen määrä
            Console.WriteLine($"{arvoUlong} kilobytes");
            remainder %= bitsPerKilobytes;

            arvoUlong = remainder / bitsPerBytes; // Tavujen määrä
            Console.WriteLine($"{arvoUlong} bytes");

            arvoUlong = remainder % bitsPerBytes; // Jäljelle jäävät bitit
            Console.WriteLine($"and {arvoUlong} bits");
        }
    }
}
