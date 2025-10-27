using System;

class Program
{
    static void Main() // Ohjelman aloituspaikka. Tämä suoritetaan ensimmäisenä kun ohjelma käynnistyy.
    {
        //Tehtävä 1
        // Testataan OSquare4 viisi kertaa
        int count = 0; // Alustetaan laskuri count arvolla 0.
        while (count < 5) // Toistetaan niin kauan kuin count on alle 5.
        {
            OSquare4(); // Kutsutaan aliohjelmaa, joka piirtää 4x4 neliön kirjaimilla 'o'.
            Console.WriteLine(); // Tulostetaan tyhjä rivi neliöiden väliin.
            count++; // Lisätään countiin yksi, jotta silmukka etenee.
        }

        // Testataan OSquareN arvoilla 1–5
        int n = 1; // Alustetaan muuttuja n arvolla 1.
        while (n <= 5) // Toistetaan niin kauan kuin n on enintään 5.
        {
            OSquareN(n); // Kutsutaan aliohjelmaa, joka piirtää n x n neliön kirjaimilla 'o'.
            Console.WriteLine(); // Tulostetaan tyhjä rivi neliöiden väliin.
            n++; // Lisätään n:ään yksi, jotta silmukka etenee.
        }

        // Testataan XSquareN eri kokoisilla ja eri merkeillä
        XSquareN(3, '*'); // Piirretään 3x3 neliö tähdillä '*'.
        Console.WriteLine(); // Tyhjä rivi.
        XSquareN(5, '#'); // Piirretään 5x5 neliö risuilla '#'.
        Console.WriteLine(); // Tyhjä rivi.
        XSquareN(2, '+'); // Piirretään 2x2 neliö plussilla '+'.
        Console.WriteLine(); // Tyhjä rivi.

        // Testataan GetXSquareN ja tulostetaan palautettu merkkijono
        string square = GetXSquareN(4, '@'); // Kutsutaan aliohjelmaa, joka palauttaa 4x4 neliön @-merkeillä merkkijonona.
        Console.WriteLine(square); // Tulostetaan palautettu merkkijono.

        // Testataan OutputSum
        OutputSum(3.5, 4.2); // Lasketaan 3.5 + 4.2 ja tulostetaan tulos.
        OutputSum(10.1, 5.9); // Lasketaan 10.1 + 5.9 ja tulostetaan tulos.

        // Testataan Sum ja tulostetaan tulos
        double result1 = Sum(2.5, 7.5); // Lasketaan 2.5 + 7.5 ja tallennetaan tulos muuttujaan.
        Console.WriteLine("Summa: " + result1); // Tulostetaan laskettu summa.

        double result2 = Sum(100.25, 200.75); // Lasketaan 100.25 + 200.75 ja tallennetaan tulos.
        Console.WriteLine("Summa: " + result2); // Tulostetaan laskettu summa.
    }

    // Tehtävä 1 aliohjelma
    // Aliohjelma, joka piirtää 4x4 neliön kirjaimilla 'o'.
    static void OSquare4()
    {
        for (int i = 0; i < 4; i++) // Toistetaan 4 riviä.
        {
            for (int j = 0; j < 4; j++) // Jokaisella rivillä tulostetaan 4 'o'-merkkiä.
            {
                Console.Write("o"); // Tulostetaan yksi 'o'.
            }
            Console.WriteLine(); // Rivin vaihto.
        }
    }

    // Aliohjelma, joka piirtää n x n neliön kirjaimilla 'o'.
    static void OSquareN(int n)
    {
        for (int i = 0; i < n; i++) // Toistetaan n riviä.
        {
            for (int j = 0; j < n; j++) // Jokaisella rivillä tulostetaan n 'o'-merkkiä.
            {
                Console.Write("o"); // Tulostetaan yksi 'o'.
            }
            Console.WriteLine(); // Rivin vaihto.
        }
    }

    // Aliohjelma, joka piirtää n x n neliön valitulla merkillä.
    static void XSquareN(int n, char merkki)
    {
        for (int i = 0; i < n; i++) // Toistetaan n riviä.
        {
            for (int j = 0; j < n; j++) // Jokaisella rivillä tulostetaan n merkkiä.
            {
                Console.Write(merkki); // Tulostetaan valittu merkki.
            }
            Console.WriteLine(); // Rivin vaihto.
        }
    }

    // Aliohjelma, joka palauttaa n x n neliön merkkijonona.
    static string GetXSquareN(int n, char merkki)
    {
        string tulos = ""; // Alustetaan tyhjä merkkijono.
        for (int i = 0; i < n; i++) // Toistetaan n riviä.
        {
            for (int j = 0; j < n; j++) // Jokaisella rivillä lisätään n merkkiä.
            {
                tulos += merkki; // Lisätään merkki merkkijonoon.
            }
            tulos += "\n"; // Lisätään rivinvaihto.
        }
        return tulos; // Palautetaan valmis merkkijono.
    }

    // Aliohjelma, joka laskee kahden luvun summan ja tulostaa sen.
    static void OutputSum(double a, double b)
    {
        double summa = a + b; // Lasketaan summa.
        Console.WriteLine("Summa: " + summa); // Tulostetaan summa.
    }

    // Aliohjelma, joka laskee kahden luvun summan ja palauttaa sen.
    static double Sum(double a, double b)
    {
        return a + b; // Palautetaan laskettu summa.
    }
}
