using System;
namespace Programs
{
public class Solution
{
    //IMPORTANT NOTE: you should declare ALL subroutines here in VPL (not in Visual Studio) as public non-static as
    //SO --> Replace the word static with word public to make the test program compile
    public void ExampleSubroutine()
    {
        // Tehtävä 1
        // Testataan OSquare4 viisi kertaa
        // Alustetaan laskuri count arvolla 0.
        // Toistetaan niin kauan kuin count on alle 5.
        // Kutsutaan aliohjelmaa, joka piirtää 4x4 neliön kirjaimilla 'o'.
        // Tulostetaan tyhjä rivi neliöiden väliin.
        // Lisätään countiin yksi, jotta silmukka etenee.

        // Testataan OSquareN arvoilla 1–5
        // Alustetaan muuttuja n arvolla 1.
        // Toistetaan niin kauan kuin n on enintään 5.
        // Kutsutaan aliohjelmaa, joka piirtää n x n neliön kirjaimilla 'o'.
        // Tulostetaan tyhjä rivi neliöiden väliin.
        // Lisätään n:ään yksi, jotta silmukka etenee.

        // Testataan XSquareN eri kokoisilla ja eri merkeillä
        // Piirretään n x n neliö valitulla merkillä.
        // Tulostetaan tyhjä rivi jokaisen neliön jälkeen.

        // Testataan GetXSquareN ja tulostetaan palautettu merkkijono
        // Kutsutaan aliohjelmaa, joka palauttaa n x n neliön merkkijonona.
        // Tulostetaan palautettu merkkijono.

        // Testataan OutputSum
        // Lasketaan kahden luvun summa ja tulostetaan tulos.

        // Testataan Sum ja tulostetaan tulos
        // Lasketaan kahden luvun summa ja tallennetaan tulos muuttujaan.
        // Tulostetaan laskettu summa.
    }

    // Tehtävä 1 aliohjelmat:

    // Aliohjelma, joka piirtää 4x4 neliön kirjaimilla 'o'.
    public void OSquare4()
    {
        // Toistetaan 4 riviä.
        // Jokaisella rivillä tulostetaan 4 'o'-merkkiä.
        // Rivin vaihto.
    }

    // Aliohjelma, joka piirtää n x n neliön kirjaimilla 'o'.
    public void OSquareN(int n)
    {
        // Toistetaan n riviä.
        // Jokaisella rivillä tulostetaan n 'o'-merkkiä.
        // Rivin vaihto.
    }

    // Aliohjelma, joka piirtää n x n neliön valitulla merkillä.
    public void XSquareN(int n, char merkki)
    {
        // Toistetaan n riviä.
        // Jokaisella rivillä tulostetaan n merkkiä.
        // Rivin vaihto.
    }

    // Aliohjelma, joka palauttaa n x n neliön merkkijonona.
    public string GetXSquareN(int n, char merkki)
    {
        // Alustetaan tyhjä merkkijono.
        // Toistetaan n riviä.
        // Jokaisella rivillä lisätään n merkkiä.
        // Lisätään rivinvaihto.
        // Palautetaan merkkijono.
    }

    // Aliohjelma, joka laskee kahden luvun summan ja tulostaa sen.
    public void OutputSum(double a, double b)
    {
        // Lasketaan summa.
        // Tulostetaan summa.
    }

    // Aliohjelma, joka laskee kahden luvun summan ja palauttaa sen.
    public double Sum(double a, double b)
    {
        // Palautetaan laskettu summa.
    }
}
}
