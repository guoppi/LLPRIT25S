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
            // TEHTÄVÄ 5: Päätellään toiminta kellonajan perusteella

            Console.Write("Enter time in hour (0-23): "); // Pyydetään käyttäjältä kellonaika
            int aika = Convert.ToInt32(Console.ReadLine()); // Muutetaan syöte kokonaisluvuksi

            if (aika < 0 || aika > 23) // Jos aika ei ole välillä 0–23
            {
                Console.WriteLine("Invalid hour input"); // Ilmoitetaan virheellinen syöte
            }
            else
            {
                // Jos aika on yöaikaa tai myöhään illalla
                if (aika <= 7 || aika > 22)
                {
                    Console.WriteLine("Go to sleep"); // Kehotetaan nukkumaan
                    if (aika == 7)
                    {
                        Console.WriteLine("Have breakfast"); // Jos kello on 7, syödään aamiainen
                    }
                }
                // Jos aika on työpäivän aikana
                else if (aika > 7 && aika <= 15)
                {
                    Console.WriteLine("Go to work"); // Kehotetaan menemään töihin
                    if (aika == 11)
                    {
                        Console.WriteLine("Have lunch"); // Jos kello on 11, syödään lounas
                    }
                }
                // Muina aikoina
                else
                {
                    Console.WriteLine("Go to friends"); // Kehotetaan tapaamaan kavereita
                    if (aika == 17)
                    {
                        Console.WriteLine("Have dinner"); // Jos kello on 17, syödään päivällinen
                    }
                }
            }
            Console.WriteLine(); // Rivinvaihto

            // TEHTÄVÄ 6: Lasketaan polttoaineen hinta ja annetaan kahvi yli 50 litran ostoksesta

            const double HINTA_95E = 1.341;     // 95E-bensiinin litrahinta
            const double HINTA_98 = 1.520;      // 98-bensiinin litrahinta
            const double HINTA_DIESEL = 1.153;  // Dieselin litrahinta

            Console.Write("Enter fuel type (95E, 98, Diesel): "); // Pyydetään polttoainetyyppi
            string fuelType = Console.ReadLine(); // Luetaan käyttäjän syöte

            double liters;       // Muuttuja litramäärälle
            double totalprice;   // Muuttuja kokonaishinnalle

            // Valitaan polttoainetyypin mukaan oikea hinta
            switch (fuelType)
            {
                case "95E":
                    Console.Write("Enter amount of liters: "); // Pyydetään litramäärä
                    liters = double.Parse(Console.ReadLine()); // Luetaan litramäärä
                    totalprice = liters * HINTA_95E; // Lasketaan hinta
                    break;

                case "98":
                    Console.Write("Enter amount of liters: ");
                    liters = double.Parse(Console.ReadLine());
                    totalprice = liters * HINTA_98;
                    break;

                case "Diesel":
                    Console.Write("Enter amount of liters: ");
                    liters = double.Parse(Console.ReadLine());
                    totalprice = liters * HINTA_DIESEL;
                    break;

                default:
                    Console.WriteLine("Invalid fuel command"); // Jos syöte ei vastaa mitään vaihtoehtoa
                    return; // Lopetetaan ohjelma
            }

            Console.WriteLine($"Total price is {totalprice:F2} euros"); // Tulostetaan kokonaishinta kahden desimaalin tarkkuudella

            if (liters >= 50.00) // Jos ostetaan vähintään 50 litraa
                Console.WriteLine("Free coffee"); // Annetaan ilmainen kahvi

            Console.WriteLine(); // Rivinvaihto

            // TEHTÄVÄ 7: Yksinkertainen laskin neljälle laskutoimitukselle

            Console.Write("Choose operation: plus, minus, mult, div: "); // Pyydetään laskutoimitus
            string operation = Console.ReadLine(); // Luetaan syöte

            Console.Write("Enter first number: "); // Pyydetään ensimmäinen luku
            double num1 = double.Parse(Console.ReadLine()); // Luetaan ja muunnetaan

            Console.Write("Enter second number: "); // Pyydetään toinen luku
            double num2 = double.Parse(Console.ReadLine()); // Luetaan ja muunnetaan

            double result; // Muuttuja tulokselle

            // Valitaan laskutoimitus
            switch (operation)
            {
                case "plus":
                    result = num1 + num2; // Lasketaan yhteen
                    Console.WriteLine($"Result is {result:F2}"); // Tulostetaan tulos
                    break;

                case "minus":
                    result = num1 - num2; // Vähennetään
                    Console.WriteLine($"Result is {result:F2}");
                    break;

                case "mult":
                    result = num1 * num2; // Kerrotaan
                    Console.WriteLine($"Result is {result:F2}");
                    break;

                case "div":
                    if (num2 == 0) // Tarkistetaan ettei jaeta nollalla
                    {
                        Console.WriteLine("Dividing with zero not allowed"); // Virheilmoitus
                    }
                    else
                    {
                        result = num1 / num2; // Jaetaan
                        Console.WriteLine($"Result is {result:F2}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator"); // Jos syöte ei vastaa mitään vaihtoehtoa
                    break;
            }
        }
    }
}
