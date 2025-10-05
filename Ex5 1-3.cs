using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TEHTÄVÄ 1: Lasketaan käyttäjän ikä ja tulostetaan se

            Console.Write("Enter your name: "); // Pyydetään käyttäjän nimi
            string nimi = Console.ReadLine(); // Luetaan nimi muuttujaan

            Console.Write("Enter your birth year: "); // Pyydetään syntymävuosi
            int syntymaVuosi = Convert.ToInt32(Console.ReadLine()); // Muutetaan syöte kokonaisluvuksi

            Console.Write("Enter current year: "); // Pyydetään kuluvan vuoden arvo
            int kuluvaVuosi = Convert.ToInt32(Console.ReadLine()); // Muutetaan syöte kokonaisluvuksi

            int ika = kuluvaVuosi - syntymaVuosi; // Lasketaan ikä vähentämällä syntymävuosi kuluvasta vuodesta

            Console.WriteLine(); // Tyhjä rivi
            Console.WriteLine($"{nimi} {ika} years"); // Tulostetaan nimi ja ikä
            Console.WriteLine(); // Tyhjä rivi

            // TEHTÄVÄ 2: Tulostetaan "o"-kirjaimista muodostettu kuvio

            string MERKKI = "o"; // Määritellään merkki, jota käytetään kuviossa

            // Tulostetaan kuvio rivittäin, käyttäen muotoilua ja välistyksiä
            Console.WriteLine("{0,4}", MERKKI);         // Rivin keskitys
            Console.WriteLine("{0,3}{0}{0}", MERKKI);   // Kolme merkkiä vierekkäin
            Console.WriteLine("{0,2}{0,4}", MERKKI);    // Kaksi merkkiä kaukana toisistaan
            Console.WriteLine("{0}{0,6}", MERKKI);      // Kaksi merkkiä vielä kauempana
            Console.WriteLine("{0,2}{0,4}", MERKKI);    // Sama kuin ylempi
            Console.WriteLine("{0,3}{0}{0}", MERKKI);   // Sama kuin ylempi
            Console.WriteLine("{0,4}", MERKKI);         // Sama kuin ensimmäinen
            Console.WriteLine(); // Tyhjä rivi

            // TEHTÄVÄ 3: Tulostetaan sama kuvio, mutta käyttäjän valitsemalla merkillä

            Console.Write("Enter a letter: "); // Pyydetään käyttäjältä merkki
            MERKKI = Console.ReadLine(); // Tallennetaan käyttäjän syöte muuttujaan

            Console.WriteLine(); // Tyhjä rivi

            // Tulostetaan sama kuvio uudelleen, mutta nyt käyttäjän merkillä
            Console.WriteLine("{0,4}", MERKKI);
            Console.WriteLine("{0,3}{0}{0}", MERKKI);
            Console.WriteLine("{0,2}{0,4}", MERKKI);
            Console.WriteLine("{0}{0,6}", MERKKI);
            Console.WriteLine("{0,2}{0,4}", MERKKI);
            Console.WriteLine("{0,3}{0}{0}", MERKKI);
            Console.WriteLine("{0,4}", MERKKI);
        }
    }
}
