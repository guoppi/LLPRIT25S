using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            // TEHTÄVÄ 1: Tulostetaan luvut 1:stä n:ään asti

            Console.Write("Anna arvo luvulle n: "); // Pyydetään käyttäjältä luku
            int n = int.Parse(Console.ReadLine());  // Muutetaan syöte kokonaisluvuksi

            for (int i = 1; i <= n; i++) // Käydään luvut läpi 1:stä n:ään
            {
                if (i < n)
                    Console.Write(i + ", "); // Tulostetaan luku ja pilkku, jos ei viimeinen
                else
                    Console.Write(i); // Viimeinen luku ilman pilkkua
            }
            Console.WriteLine(); // Rivinvaihto

            // TEHTÄVÄ 2: Tulostetaan luvut n:stä 1:een

            Console.Write("Anna arvo luvulle n: "); // Pyydetään uusi luku
            n = int.Parse(Console.ReadLine()); // Tallennetaan se samaan muuttujaan

            for (int i = n; i >= 1; i--) // Käydään luvut läpi n:stä alaspäin
            {
                if (i > 1)
                    Console.Write(i + ", "); // Tulostetaan luku ja pilkku
                else
                    Console.Write(i); // Viimeinen luku ilman pilkkua
            }
            Console.WriteLine(); // Rivinvaihto

            // TEHTÄVÄ 3: Tulostetaan kirjaimet a:sta käyttäjän antamaan kirjaimeen asti

            Console.Write("Anna jokin pieni kirjain a-z: "); // Pyydetään kirjain
            char kirjain = char.Parse(Console.ReadLine()); // Muutetaan syöte merkiksi

            for (char c = 'a'; c <= kirjain; c++) // Käydään kirjaimet a:sta annettuun kirjaimeen
            {
                if (c < kirjain)
                    Console.Write(c + ", "); // Tulostetaan kirjain ja pilkku
                else
                    Console.Write(c); // Viimeinen kirjain ilman pilkkua
            }
            Console.WriteLine(); // Rivinvaihto

            // TEHTÄVÄ 4: Tulostetaan kirjaimet kahden annetun kirjaimen välillä

            Console.Write("Anna ensimmäinen kirjain: "); // Pyydetään ensimmäinen kirjain
            kirjain = char.Parse(Console.ReadLine()); // Tallennetaan se samaan muuttujaan

            Console.Write("Anna toinen kirjain: "); // Pyydetään toinen kirjain
            char toinenKirjain = char.Parse(Console.ReadLine()); // Tallennetaan toiseen muuttujaan

            if (kirjain < toinenKirjain) // Jos ensimmäinen kirjain on ennen toista
            {
                for (char c = kirjain; c <= toinenKirjain; c++) // Käydään kirjaimet eteenpäin
                {
                    Console.Write(c); // Tulostetaan kirjain
                    if (c != toinenKirjain)
                    {
                        Console.Write(", "); // Pilkku jos ei viimeinen
                    }
                }
            }
            else // Jos ensimmäinen kirjain on myöhemmin kuin toinen
            {
                for (char c = kirjain; c >= toinenKirjain; c--) // Käydään kirjaimet taaksepäin
                {
                    Console.Write(c); // Tulostetaan kirjain
                    if (c != toinenKirjain)
                    {
                        Console.Write(", "); // Pilkku jos ei viimeinen
                    }
                }
                Console.WriteLine(); // Rivinvaihto
            }
        }
    }
}
