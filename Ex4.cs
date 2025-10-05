using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Tehtävä 1 – Kokonaislukujen jakaminen ja tyyppimuunnos

                int i = 10;
                int k = 100;
                double j = (double)i / k; // Muunnetaan i ensin doubleksi, jotta jakolasku ei ole kokonaislukujen välinen
                Console.WriteLine("j = " + j);
                Console.WriteLine();

                // Alkuperäinen virhe: jos molemmat luvut ovat kokonaislukuja, tulos on myös kokonaisluku (esim. 10 / 100 = 0).
                // Vasta tämän jälkeen tulos muunnetaan doubleksi, jolloin saadaan 0.0.
                // Oikea tapa: muunnetaan jompikumpi tai molemmat luvut doubleksi ennen jakolaskua, jolloin saadaan tarkka tulos (0.1).

                // Tehtävä 2 – Tyyppimuunnokset eri tietotyyppeihin

                // Kaikki desimaaliluvut ovat oletuksena double-tyyppisiä.
                // Tyyppimuunnoksissa vasemman ja oikean puolen tietotyypin täytyy täsmätä, jotta ohjelma toimii oikein.

                // byte myByte = 293.34; // Ei toimi, koska byte sallii vain arvot välillä 0–255. Tämä aiheuttaisi ylivuodon (overflow).
                Console.Write("Number constant 293.34 converts in type byte as ");
                Console.WriteLine("with no methods"); // Ei mahdollista ilman erillistä käsittelyä
                Console.WriteLine();

                int myInt = (int)293.34; // Muunnetaan kokonaisluvuksi, mutta desimaaliosa menetetään
                Console.Write("Number constant 293.34 converts in type int as ");
                Console.WriteLine(myInt + " with explicit casting but with loss of data");
                Console.WriteLine();

                float myFloat = (float)293.34; // Muunnetaan floatiksi, ei menetä tietoa
                Console.Write("Number constant 293.34 converts in type float as ");
                Console.WriteLine(myFloat + " with explicit casting and without loss of data");
                Console.WriteLine();

                double myDouble = 293.34; // Double on oletustyyppi desimaaliluvuille
                Console.Write("Number constant 293.34 converts in type double as ");
                Console.WriteLine(myDouble + " without explicit casting");
                Console.WriteLine();

                decimal myDecimal = (decimal)293.34; // Muunnetaan decimal-tyypiksi, ei menetä tietoa
                Console.Write("Number constant 293.34 converts in type decimal as ");
                Console.WriteLine(myDecimal + " with explicit casting and without loss of data");
                Console.WriteLine();

                bool myBoolean = Convert.ToBoolean(293.34); // Muunnetaan booleaniksi: kaikki nollasta poikkeavat arvot ovat true
                Console.Write("Number constant 293.34 converts in type boolean as ");
                Console.WriteLine(myBoolean + " not with explicit casting, but with Convert object");
                Console.WriteLine();

                string myString = Convert.ToString(293.34); // Muunnetaan merkkijonoksi
                Console.Write("Number constant 293.34 converts in type string as ");
                Console.WriteLine(myString + " not with explicit casting, but with Convert object");
                Console.WriteLine();

                // Tehtävä 3 – Merkkijonon muuntaminen numeerisiksi arvoiksi ilman CultureInfoa

                string origNr = "293,34";

                // Korvataan pilkku pisteellä, jotta desimaalierotin toimii oletuskulttuurissa (esim. en-US)
                origNr = origNr.Replace(',', '.');

                // Muunnetaan merkkijono eri numeerisiin tyyppeihin
                float floatNr = Convert.ToSingle(origNr);      // Muuntaa floatiksi. Convert.ToFloat ei ole olemassa, vaan Single on floatin virallinen nimi C#:ssa.
                double doubleNr = Convert.ToDouble(origNr);    // Muuntaa doubleksi
                decimal decimalNr = Convert.ToDecimal(origNr); // Muuntaa decimaliksi
                string stringNr = origNr;                      // Merkkijono pysyy samana

                // Tulostetaan tulokset
                Console.WriteLine("Byte type is NOT ok");      // Ei voida muuntaa suoraan
                Console.WriteLine("Int type is NOT ok");       // Ei voida muuntaa suoraan
                Console.WriteLine("Float type is ok: " + floatNr);
                Console.WriteLine("Double type is ok: " + doubleNr);
                Console.WriteLine("Decimal type is ok: " + decimalNr);
                Console.WriteLine("Boolean type is NOT ok");   // Ei voida muuntaa suoraan
                Console.WriteLine("String type is ok: " + stringNr);
                Console.WriteLine();

                // Tehtävä 4 – Celsius → Fahrenheit muunnos

                double c1 = 0;
                double c2 = 100;
                double c3 = 37.3;

                // Fahrenheit-laskenta: käytetään double-tyyppiä tarkkuuden säilyttämiseksi
                double f1 = (9.0 / 5.0) * c1 + 32;
                double f2 = (9.0 / 5.0) * c2 + 32;
                double f3 = (9.0 / 5.0) * c3 + 32;

                Console.WriteLine($"{c1}°C = {f1}°F");
                Console.WriteLine($"{c2}°C = {f2}°F");
                Console.WriteLine($"{c3}°C = {f3}°F");
                Console.WriteLine();

                // Tehtävä 5 – Monimutkainen laskukaava

                // Määritellään muuttujat double-tyyppisinä, jotta laskut ovat tarkkoja
                double x = 1, y = 1, z = 1, w = 0;
                double x1 = 11, y1 = 11, z1 = 11, w1 = 11;

                // Lasketaan kaavan mukaiset arvot
                double result1 = (10 + x) / (9 * x + 2) - 4 * (x / y) + (z * 3 + w) / (z / x + y);
                double result2 = (10 + x1) / (9 * x1 + 2) - 4 * (x1 / y1) + (z1 * 3 + w1) / (z1 / x1 + y1);

                Console.WriteLine($"f({x},{y},{z},{w}) = {result1}");
                Console.WriteLine($"f({x1},{y1},{z1},{w1}) = {result2}");
            }
        }
    }
}
