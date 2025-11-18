using System;

namespace Programs
{
    public class Solution
    {
        // Tämä metodi testaa kaikkia muita aliohjelmia.
        public void ExampleSubroutine()
        {
            // Testataan Sum-metodia
            // Lasketaan 2.5 + 7.5 ja tallennetaan tulos muuttujaan result1.
            // Tulostetaan laskettu summa.

            // Lasketaan 100.25 + 200.75 ja tallennetaan tulos.
            // Tulostetaan laskettu summa.

            // Testataan ArraySum-metodia
            // Luodaan taulukko numbers.
            // Lasketaan taulukon summa.
            // Tulostetaan taulukon summa.

            // Testataan Factorial-metodia
            // Lasketaan 1! ja tallennetaan tulos.
            // Lasketaan 6! ja tallennetaan tulos.
            // Lasketaan 10! ja tallennetaan tulos.
            // Tulostetaan 1!.
            // Tulostetaan 6!.
            // Tulostetaan 10!.

            // Testataan BinCoeff-metodia
            // Lasketaan binomikerroin C(10,5).
            // Lasketaan binomikerroin C(6,3).
            // Lasketaan binomikerroin C(10,3).
            // Tulostetaan C(10,5).
            // Tulostetaan C(6,3).
            // Tulostetaan C(10,3).

            // Testataan MinFind-metodia
            // Luodaan taulukko myTable.
            // Etsitään pienimmän arvon indeksi.
            // Tulostetaan pienimmän arvon indeksi.
            // Etsitään pienin arvo alkaen indeksistä 0.
            // Etsitään pienin arvo alkaen indeksistä 1.
            // Etsitään pienin arvo alkaen indeksistä 4.
            // Etsitään pienin arvo alkaen indeksistä 5.
            // Etsitään pienin arvo alkaen indeksistä 6.
            // Etsitään pienin arvo alkaen indeksistä 7.

            // Testataan lajittelua Factorial- ja BinCoeff-taulukoilla
            // Luodaan factorial-taulukko.
            // Luodaan binCoeff-taulukko.
            // Lajitellaan factorial-taulukko.
            // Lajitellaan binCoeff-taulukko.
            // Tulostetaan lajiteltu factorial-taulukko.
            // Tulostetaan lajiteltu binCoeff-taulukko.
            // Lajitellaan myTable.
            // Tulostetaan lajitelun taulukon arvot pilkulla erotettuna.

            // Testataan haku taulukosta
            // Luodaan merkkijonotaulukko.
            // Etsitään "koira" taulukosta.
            // Etsitään "hevonen" taulukosta (ei löydy).

            // Testataan AddData ja SeekNumber
            // Luodaan nimi-taulukko.
            // Luodaan numero-taulukko.
            // Lisätään nimi indeksiin 0.
            // Lisätään numero indeksiin 0.
            // Lisätään nimi indeksiin 1.
            // Lisätään numero indeksiin 1.
            // Lisätään nimi indeksiin 2.
            // Lisätään numero indeksiin 2.
            // Tulostetaan kaikki nimet.
            // Tulostetaan kaikki numerot.
            // Haetaan Hanhen numero.
            // Haetaan Poron numero.
            // Haetaan Jussin numero.


            // Laskee kahden luvun summan
            public double Sum(double a, double b)
            {
                // Palauttaa summan.
            }

            // Laskee taulukon kaikkien arvojen summan
            public double ArraySum(double[] arr)
            {
                // Alustetaan summa.
                // Käydään läpi taulukko.
                // Lisätään arvo summaan.
                // Palautetaan summa.
            }

            // Laskee kertoman (n!)
            public int Factorial(int n)
            {
                // Alustetaan kertoma.
                // Käydään läpi luvut 1...n.
                // Kerrotaan kertoma i:llä.
                // Palautetaan kertoma.
            }

            // Laskee binomikertoimen C(n,k)
            public int BinCoeff(int n, int k)
            {
                // Palauttaa binomikertoimen kaavan mukaan.
            }

            // Palauttaa pienimmän arvon indeksin taulukosta
            public int MinFind(int[] arr)
            {
                // Alustetaan pienimmän arvon indeksi.
                // Käydään läpi taulukko.
                // Jos nykyinen arvo on pienempi kuin nykyinen minimi.
                // Päivitetään minimi-indeksi.
                // Palautetaan pienimmän arvon indeksi.
            }

            // Palauttaa pienimmän arvon indeksin alkaen annetusta indeksistä
            public int MinFind(int[] arr, int n)
            {
                // Jos aloitusindeksi on taulukon ulkopuolella.
                // Palautetaan -1.
                // Alustetaan minimi-indeksi aloitusindeksillä.
                // Käydään läpi taulukko alkaen n:stä.
                // Jos nykyinen arvo on pienempi kuin nykyinen minimi.
                // Päivitetään minimi-indeksi.
                // Palautetaan pienimmän arvon indeksi.
            }

            // Lajittelee taulukon valintalajittelulla
            public int[] Sort(int[] taulu)
            {
                // Kopioidaan taulukko.
                // Käydään läpi taulukko.
                // Etsitään pienimmän arvon indeksi alkaen i:stä.
                // Jos indeksi ei ole sama.
                // Vaihdetaan arvot.
                // Palautetaan lajitelun taulukko.
            }

            // Vaihtaa kahden indeksin arvot taulukossa
            public int[] swap(int[] taulu, int i, int j)
            {
                // Luodaan uusi taulukko.
                // Kopioidaan arvot.
                // Tallennetaan i:n arvo.
                // Vaihdetaan i:n arvo j:n arvoksi.
                // Vaihdetaan j:n arvo tempiksi.
                // Palautetaan taulukko.
            }

            // Etsii merkkijonon taulukosta ja palauttaa sen indeksin
            public int Seek(string[] arr, string target)
            {
                // Käydään läpi taulukko.
                // Verrataan merkkijonoa (ei kirjainkoolla väliä).
                // Palautetaan indeksi, jos löytyy.
                // Palautetaan -1, jos ei löydy.
            }

            // Lisää dataa taulukkoon annetussa indeksissä
            public string[] AddData(string[] arr, int index, string data)
            {
                // Jos taulukkoa ei ole alustettu.
                // Luodaan uusi taulukko.
                // Jos indeksi on virheellinen.
                // Palautetaan alkuperäinen taulukko.
                // Lisätään data indeksiin.
                // Palautetaan taulukko.
            }

            // Etsii nimen perusteella numeron kahdesta taulukosta
            public string SeekNumber(string[] nimet, string[] numerot, string etsiTama)
            {
                // Käydään läpi nimet-taulukko.
                // Jos nimi täsmää.
                // Palautetaan vastaava numero.
                // Palautetaan tyhjä merkkijono, jos ei löydy.
            }
