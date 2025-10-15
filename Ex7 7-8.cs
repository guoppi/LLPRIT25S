using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tehtävä 7: Laske keskiarvo yhdestä luvusta tai luvuista
            Console.WriteLine("Tehtävä 7: Laske keskiarvo syöttämällä positiivisia lukuja.");
            Console.WriteLine("Syötä negatiivinen luku lopettaaksesi.");

            double summa = 0;       // Summa syötetyistä luvuista
            int lukumaara = 0;      // Syötettyjen lukujen määrä

            while (true)
            {
                Console.Write("Syötä luku: ");
                string syote = Console.ReadLine();         // Luetaan syöte
                double luku = double.Parse(syote);         // Muutetaan syöte luvuksi

                if (luku < 0)                               // Negatiivinen luku lopettaa
                    break;
                // Kun käytät aaltosulkuja {} esimerkiksi switch-rakenteessa tai silmukoissa, 
                // on tärkeää olla tarkkana mihin kohtaan break sijoitetaan. Jos break-komento on aaltosulkujen ulkopuolella, 
                // C# ei tunnista sitä oikeassa kontekstissa ja ohjelma antaa virheen.


                summa += luku;                             // Lisätään luku summaan
                lukumaara++;                               // Kasvatetaan lukumäärää
            }

            if (lukumaara > 0)
            {
                double keskiarvo = summa / lukumaara;      // Lasketaan keskiarvo
                Console.WriteLine($"Keskiarvo on {keskiarvo:F3}"); // Tulostetaan keskiarvo
            }
            else
            {
                Console.WriteLine("Et syöttänyt yhtään positiivista lukua.");
            }

            Console.WriteLine(); // Tyhjä rivi selkeyden vuoksi

            // Tehtävä 8: Mahdollisuus laskea uusia keskiarvoja
            while (true)
            {
                Console.Write("Haluatko laskea uuden keskiarvon? (Yes/No): ");
                string vastaus = Console.ReadLine();        // Luetaan vastaus

                if (vastaus.ToLower() == "no")              // Jos vastaus on "no", lopetetaan, sekä lisätty To.Lower, ilman tätä moodle vpl antaa output too large 256kb, eli muuntaa kaikki merkkijonot pieniksi kirjaimeksi.
                {                                            // Koska en tiedä tulostaako moodle isol vai pienel ton "Yes" vai "yes" jne ni se ohjelma ns. jäi looppille ja minuutin jälkee se heittää just tota 256 kb erroria
                    Console.WriteLine("Ohjelma lopetetaan.");
                    break;
                }

                if (vastaus.ToLower() == "yes")             // Jos vastaus on "yes", aloitetaan uusi laskenta
                {
                    summa = 0;
                    lukumaara = 0;

                    Console.WriteLine("Syötä positiivisia lukuja. Negatiivinen luku lopettaa.");

                    while (true)
                    {
                        Console.Write("Syötä luku: ");
                        string syote = Console.ReadLine();
                        double luku = double.Parse(syote);  // Muutetaan syöte luvuksi

                        if (luku < 0)
                            break;

                        summa += luku;
                        lukumaara++;
                    }

                    if (lukumaara > 0)
                    {
                        double keskiarvo = summa / lukumaara;
                        Console.WriteLine($"Keskiarvo on {keskiarvo:F3}");
                    }
                    else
                    {
                        Console.WriteLine("Et syöttänyt yhtään positiivista lukua.");
                    }

                    Console.WriteLine(); // Tyhjä rivi selkeyden vuoksi
                }
                else
                {
                    Console.WriteLine("Vastaa Yes tai No."); // Jos vastaus ei ole kumpikaan
                }
            }
        }
    }
}
