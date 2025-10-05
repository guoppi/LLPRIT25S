using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tehtävä 4 – Celsius → Fahrenheit muunnos

            Console.Write("Enter temperature in Celsius: ");
            string input = Console.ReadLine().Replace('.', ','); // Vaihdetaan piste pilkuksi, jotta toimii suomalaisessa desimaalimuodossa
            double celsius = Convert.ToDouble(input); // Muutetaan syöte double-tyyppiseksi
            double fahrenheit = celsius * 9 / 5 + 32; // Muunnoskaava Fahrenheitiksi
            Console.WriteLine();
            Console.WriteLine("{0,-12}{1,12}", "Fahrenheit", "Celsius"); // Otsikkorivi muotoiltuna
            Console.WriteLine("{0,-12:F1}{1,12:F2}", fahrenheit, celsius); // Tulostetaan arvot muotoiltuna
            Console.WriteLine();

            // Tehtävä 5 – Monimutkainen laskukaava

            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            Console.Write("Enter y: ");
            double y = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            Console.Write("Enter z: ");
            double z = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            Console.Write("Enter w: ");
            double w = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

            // Lasketaan kaavan mukainen arvo
            double tulos = (10 + x) / (9 * x + 2) - 4 * (x / y) + (z * 3 + w) / (z / x + y);
            Console.WriteLine();
            Console.WriteLine($"f({x},{y},{z},{w}) = {tulos}"); // Tulostetaan laskettu arvo
            Console.WriteLine();

            // Tehtävä 6 – Muuttujien manipulointi

            Console.Write("Enter value i: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value j: ");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            i++;                // i = i + 1;
            i++; j += i;        // i = i + 1; j = j + i;
            k *= i * j; k++;    // k = k * i * j; k = k + 1; 
            j--; i += j + k;    // j = j - 1; i = i + (j + k); 
            ++j; k -= j;        // j = j + 1; k = k - j;

            // Tulostetaan lopulliset arvot
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine();

            // Tehtävä 7 – Lisää laskutoimituksia

            Console.Write("Enter a value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter c value: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            c = c + 1;      // c++;
            c = c + 1;      // b += ++c + c;
            b = b + c + c;
            a = a - b;      // a -= b++;
            b = b + 1;
            a = a + 1;      // ++a;

            // Tulostetaan lopulliset arvot
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // Tehtävä 8 – Muotoilumerkkijonon rakentaminen

            int n = 0, w2 = 10;
            string myFormatCode = "{" + n++ + "," + -w2 + "}"; // Rakennetaan muotoilumerkkijono, jossa n=0 ja w2=-10
            myFormatCode += "{" + n + "," + w2 + "}";           // Lisätään toinen osa: n=1 ja w2=10
            Console.WriteLine(myFormatCode, n, w2);             // Tulostetaan muotoilumerkkijonon mukaisesti

            // myFormatCode sisältää rakenteen eli tasaus- ja leveystiedot (esim. {0,-10}{1,10}),
            // ja n sekä w2 ovat ne arvot, jotka sijoitetaan siihen. Format-koodi tulee ensin,
            // koska se määrittää, miten arvot esitetään tulostuksessa.

            // Ymmärsin kyllä heti, että n++ kasvattaa muuttujaa ja antaa ensin alkuperäisen arvon,
            // mutta en tullut ajatelleeksi, että tässä rakennetaan muotoilumerkkijonoa, jossa määritellään
            // tulostuksen tasaus ja leveys. Eli kyseessä on tapa muodostaa esim. {0,-10} ohjelmallisesti.
            //
            // Kun ajoin koodin, tulostui:
            // 1         10
            // eli n=1 vasemmalle tasattuna ja w2=10 oikealle tasattuna. Nyt tajuan, että kyseessä on
            // string.Format-tyylinen muotoilu
            // Molempia muuttujia (n ja w2) käytettiin sekä muotoilumerkkijonon rakentamiseen että tulostukseen,
            // koska muotoilussa määritellään vain rakenne (esim. tasaus ja leveys), ja arvot annetaan erikseen.
            // Tämä tapa selkeyttää koodin ja voidaan uudelleenkäyttää, eikä samoja muuttujia tarvitse määritellä uudelleen.
        }
    }
}
