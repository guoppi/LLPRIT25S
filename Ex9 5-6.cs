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
            // Tehtävä 5

            Console.Write("Anna luku: "); // Pyydetään käyttäjältä lukua.
            string syote = Console.ReadLine(); // Luetaan käyttäjän syöte merkkijonona.
            int n; // Määritellään kokonaislukumuuttuja n.
            if (!int.TryParse(syote, out n)) // Yritetään muuntaa syöte kokonaisluvuksi.
            {
                n = 1; // Jos muunnos epäonnistuu, asetetaan n arvoksi 1.
            }
            for (int i = 1; i <= 10; i++) // Toistetaan silmukka 1–10.
            {
                Console.WriteLine(i * n); // Tulostetaan i:n ja n:n tulo.
            }
            Console.WriteLine(); // Tulostetaan tyhjä rivi.

            // Tehtävä 6

            int[] tunnusluvut = new int[10]; // Luodaan taulukko 10 henkilönumeroa varten.
            string[] nimet = new string[10]; // Luodaan taulukko 10 nimeä varten.

            for (int i = 0; i < 10; i++) // Toistetaan silmukka 10 kertaa.
            {
                Console.Write($"Anna tunnusluku: "); // Pyydetään henkilön tunnuslukua.
                string tunnusSyote = Console.ReadLine(); // Luetaan syöte.
                if (!int.TryParse(tunnusSyote, out tunnusluvut[i])) // Yritetään muuntaa syöte numeroksi.
                {
                    tunnusluvut[i] = 0; // Jos epäonnistuu, asetetaan arvoksi 0.
                }
                Console.Write("Anna henkilön nimi: "); // Pyydetään henkilön nimeä.
                string nimiSyote = Console.ReadLine(); // Luetaan nimi.
                nimet[i] = nimiSyote ?? ""; // Tallennetaan nimi, tai tyhjä merkkijono jos null.
            }
            Console.WriteLine(); // Tyhjä rivi.
            Console.Write($"Anna haettavan nimi: "); // Pyydetään haettavaa nimeä.
            string haettavaNimi = Console.ReadLine() ?? ""; // Luetaan haettava nimi.
            int indeksi = 0; // Alustetaan indeksi.
            bool loytyi = false; // Alustetaan löytymisen tila.

            while (indeksi < 10) // Käydään nimet läpi silmukassa.
            {
                if (!string.IsNullOrEmpty(nimet[indeksi]) && // Tarkistetaan että nimi ei ole tyhjä
                    nimet[indeksi].Equals(haettavaNimi, StringComparison.OrdinalIgnoreCase)) // Verrataan nimiä kirjainkoolla ei ole väliä.
                {
                    Console.WriteLine($"{tunnusluvut[indeksi]}: {nimet[indeksi]}"); // Tulostetaan henkilön tunnusluku ja nimi.
                    loytyi = true; // Merkitään että löytyi.
                    break; // Keskeytetään silmukka.
                }
                indeksi++; // Siirrytään seuraavaan indeksiin.
            }

            if (!loytyi) // Jos nimeä ei löytynyt.
            {
                Console.WriteLine("Person not found"); // Ilmoitetaan ettei henkilöä löytynyt.
            }
        }
    }
}
