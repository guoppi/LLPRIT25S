using System;

namespace Programs
{
    public class Solution
    {
        // Tämä metodi testaa kaikkia muita aliohjelmia.
        public void ExampleSubroutine()
        {
            // Testataan Sum-metodia
            double result1 = Sum(2.5, 7.5); // Lasketaan 2.5 + 7.5 ja tallennetaan tulos muuttujaan result1.
            Console.WriteLine("Summa: " + result1); // Tulostetaan laskettu summa.

            double result2 = Sum(100.25, 200.75); // Lasketaan 100.25 + 200.75 ja tallennetaan tulos.
            Console.WriteLine("Summa: " + result2); // Tulostetaan laskettu summa.

            // Testataan ArraySum-metodia
            double[] numbers = { 1, 2, 3, 4, 5 }; // Luodaan taulukko numbers.
            double arrayResult = ArraySum(numbers); // Lasketaan taulukon summa.
            Console.WriteLine("Taulukon summa: " + arrayResult); // Tulostetaan taulukon summa.
            
            // Testataan Factorial-metodia
            int tulos = Factorial(1); // Lasketaan 1! ja tallennetaan tulos.
            int tulos2 = Factorial(6); // Lasketaan 6! ja tallennetaan tulos.
            int tulos3 = Factorial(10); // Lasketaan 10! ja tallennetaan tulos.
            Console.WriteLine(tulos); // Tulostetaan 1!.
            Console.WriteLine(tulos2); // Tulostetaan 6!.
            Console.WriteLine(tulos3); // Tulostetaan 10!.
            
            // Testataan BinCoeff-metodia
            int binCoeff1 = BinCoeff(10, 5); // Lasketaan binomikerroin C(10,5).
            int binCoeff2 = BinCoeff(6, 3); // Lasketaan binomikerroin C(6,3).
            int binCoeff3 = BinCoeff(10, 3); // Lasketaan binomikerroin C(10,3).
            Console.WriteLine(binCoeff1); // Tulostetaan C(10,5).
            Console.WriteLine(binCoeff2); // Tulostetaan C(6,3).
            Console.WriteLine(binCoeff3); // Tulostetaan C(10,3).
            
            // Testataan MinFind-metodia
            int[] myTable = { 34, 22, 66, 23, 5, 33, 72 }; // Luodaan taulukko myTable.
            int min = MinFind(myTable); // Etsitään pienimmän arvon indeksi.
            Console.WriteLine("Pienimmän arvon indeksi on: " + min); // Tulostetaan pienimmän arvon indeksi.
            Console.WriteLine("Alkaen indeksistä 0: " + MinFind(myTable, 0)); // Etsitään pienin arvo alkaen indeksistä 0.
            Console.WriteLine("Alkaen indeksistä 1: " + MinFind(myTable, 1)); // Etsitään pienin arvo alkaen indeksistä 1.
            Console.WriteLine("Alkaen indeksistä 4: " + MinFind(myTable, 4)); // Etsitään pienin arvo alkaen indeksistä 4.
            Console.WriteLine("Alkaen indeksistä 5: " + MinFind(myTable, 5)); // Etsitään pienin arvo alkaen indeksistä 5.
            Console.WriteLine("Alkaen indeksistä 6: " + MinFind(myTable, 6)); // Etsitään pienin arvo alkaen indeksistä 6.
            Console.WriteLine("Alkaen indeksistä 7: " + MinFind(myTable, 7)); // Etsitään pienin arvo alkaen indeksistä 7.
            
            // Testataan lajittelua Factorial- ja BinCoeff-taulukoilla
            int[] factorialArray = { Factorial(1), Factorial(6), Factorial(10) }; // Luodaan factorial-taulukko.
            int[] binCoeffArray = { BinCoeff(10, 5), BinCoeff(6, 3), BinCoeff(10, 3) }; // Luodaan binCoeff-taulukko.

            int[] sortedFactorial = Sort(factorialArray); // Lajitellaan factorial-taulukko.
            int[] sortedBinCoeff = Sort(binCoeffArray); // Lajitellaan binCoeff-taulukko.

            Console.WriteLine("Lajiteltu Factorial-taulukko:");
            foreach (int val in sortedFactorial) // Käydään läpi lajitelun factorial-taulukon arvot.
            {
                Console.Write(val + " "); // Tulostetaan arvo.
            }
            Console.WriteLine(); // Rivinvaihto.

            Console.WriteLine("Lajiteltu BinCoeff-taulukko:");
            foreach (int val in sortedBinCoeff) // Käydään läpi lajitelun binCoeff-taulukon arvot.
            {
                Console.Write(val + " "); // Tulostetaan arvo.
            }
            Console.WriteLine(); // Rivinvaihto.

            int[] sorted = Sort(myTable); // Lajitellaan myTable.
            Console.WriteLine("Lajiteltu: " + string.Join(", ", sorted)); // Tulostetaan lajitelun taulukon arvot pilkulla erotettuna.

            // Testataan haku taulukosta
            string[] words = { "kissa", "koira", "lintu", "kala" }; // Luodaan merkkijonotaulukko.
            Console.WriteLine("koira indeksi: " + Seek(words, "koira")); // Etsitään "koira" taulukosta.
            Console.WriteLine("hevonen indeksi: " + Seek(words, "hevonen")); // Etsitään "hevonen" taulukosta (ei löydy).

            // Testataan AddData ja SeekNumber
            string[] nimiLista = new string[10]; // Luodaan nimi-taulukko.
            string[] numeroLista = new string[10]; // Luodaan numero-taulukko.

            nimiLista = AddData(nimiLista, 0, "Allu"); // Lisätään nimi indeksiin 0.
            numeroLista = AddData(numeroLista, 0, "0401234567"); // Lisätään numero indeksiin 0.
            nimiLista = AddData(nimiLista, 1, "Jonne"); // Lisätään nimi indeksiin 1.
            numeroLista = AddData(numeroLista, 1, "0509876543"); // Lisätään numero indeksiin 1.
            nimiLista = AddData(nimiLista, 2, "Jussi"); // Lisätään nimi indeksiin 2.
            numeroLista = AddData(numeroLista, 2, "0445551234"); // Lisätään numero indeksiin 2.

            Console.WriteLine("Nimet: " + string.Join(", ", nimiLista)); // Tulostetaan kaikki nimet.
            Console.WriteLine("Numerot: " + string.Join(", ", numeroLista)); // Tulostetaan kaikki numerot.

            Console.WriteLine("Hanhi numero: " + SeekNumber(nimiLista, numeroLista, "Hanhi")); // Haetaan Hanhen numero.
            Console.WriteLine("Poro numero: " + SeekNumber(nimiLista, numeroLista, "Poro")); // Haetaan Poron numero.
            Console.WriteLine("Jussi numero: " + SeekNumber(nimiLista, numeroLista, "Jussi")); // Haetaan Jussin numero.
        }

        // Laskee kahden luvun summan
        public double Sum(double a, double b)
        {
            return a + b; // Palauttaa summan.
        }

        // Laskee taulukon kaikkien arvojen summan
        public double ArraySum(double[] arr)
        {
            double total = 0; // Alustetaan summa.
            for (int i = 0; i < arr.Length; i++) // Käydään läpi taulukko.
            {
                total = Sum(total, arr[i]); // Lisätään arvo summaan.
            }
            return total; // Palautetaan summa.
        }

        // Laskee kertoman (n!)
        public int Factorial(int n)
        {
            int kertoma = 1; // Alustetaan kertoma.
            for (int i = 1; i <= n; i++) // Käydään läpi luvut 1...n.
            {
                kertoma *= i; // Kerrotaan kertoma i:llä.
            }
            return kertoma; // Palautetaan kertoma.
        }

        // Laskee binomikertoimen C(n,k)
        public int BinCoeff(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k)); // Palauttaa binomikertoimen kaavan mukaan.
        }

        // Palauttaa pienimmän arvon indeksin taulukosta
        public int MinFind(int[] arr)
        {
            int min = 0; // Alustetaan pienimmän arvon indeksi.
            for (int i = 1; i < arr.Length; i++) // Käydään läpi taulukko.
            {
                if (arr[i] < arr[min]) // Jos nykyinen arvo on pienempi kuin nykyinen minimi.
                {
                    min = i; // Päivitetään minimi-indeksi.
                }
            }
            return min; // Palautetaan pienimmän arvon indeksi.
        }

        // Palauttaa pienimmän arvon indeksin alkaen annetusta indeksistä
        public int MinFind(int[] arr, int n)
        {
            if (n >= arr.Length) // Jos aloitusindeksi on taulukon ulkopuolella.
            {
                return -1; // Palautetaan -1.
            }
            int min = n; // Alustetaan minimi-indeksi aloitusindeksillä.
            for (int i = n; i < arr.Length; i++) // Käydään läpi taulukko alkaen n:stä.
            {
                if (arr[i] < arr[min]) // Jos nykyinen arvo on pienempi kuin nykyinen minimi.
                {
                    min = i; // Päivitetään minimi-indeksi.
                }
            }
            return min; // Palautetaan pienimmän arvon indeksi.
        }

        // Lajittelee taulukon valintalajittelulla
        public int[] Sort(int[] taulu)
        {
            int[] sortedArray = (int[])taulu.Clone(); // Kopioidaan taulukko.

            for (int i = 0; i < sortedArray.Length - 1; i++) // Käydään läpi taulukko.
            {
                int k = MinFind(sortedArray, i); // Etsitään pienimmän arvon indeksi alkaen i:stä.
                if (i != k) // Jos indeksi ei ole sama.
                {
                    sortedArray = swap(sortedArray, i, k); // Vaihdetaan arvot.
                }
            }

            return sortedArray; // Palautetaan lajitelun taulukko.
        }

        // Vaihtaa kahden indeksin arvot taulukossa
        public int[] swap(int[] taulu, int i, int j)
        {
            int[] localArray = new int[taulu.Length]; // Luodaan uusi taulukko.
            for (int k = 0; k < localArray.Length; k++) // Kopioidaan arvot.
            {
                localArray[k] = taulu[k];
            }
            int temp = localArray[i]; // Tallennetaan i:n arvo.
            localArray[i] = localArray[j]; // Vaihdetaan i:n arvo j:n arvoksi.
            localArray[j] = temp; // Vaihdetaan j:n arvo tempiksi.
            
            return localArray; // Palautetaan taulukko.
        }

        // Etsii merkkijonon taulukosta ja palauttaa sen indeksin
        public int Seek(string[] arr, string target)
        {
            for (int i = 0; i < arr.Length; i++) // Käydään läpi taulukko.
            {
                if (arr[i].Equals(target, StringComparison.OrdinalIgnoreCase)) // Verrataan merkkijonoa (ei kirjainkoolla väliä).
                    return i; // Palautetaan indeksi, jos löytyy.
            }
            return -1; // Palautetaan -1, jos ei löydy.
        }

        // Lisää dataa taulukkoon annetussa indeksissä
        public string[] AddData(string[] arr, int index, string data)
        {
            if (arr == null) // Jos taulukkoa ei ole alustettu.
            {
                arr = new string[69]; // Luodaan uusi taulukko.
            }
            if (index < 0 || index >= arr.Length) // Jos indeksi on virheellinen.
                return arr; // Palautetaan alkuperäinen taulukko.
            
            arr[index] = data; // Lisätään data indeksiin.
            return arr; // Palautetaan taulukko.
        }

        // Etsii nimen perusteella numeron kahdesta taulukosta
        public string SeekNumber(string[] nimet, string[] numerot, string etsiTama)
        {
            for (int i = 0; i < nimet.Length; i++) // Käydään läpi nimet-taulukko.
            {
                if (nimet[i] == etsiTama) // Jos nimi täsmää.
                {
                    return numerot[i]; // Palautetaan vastaava numero.
                }
            }
            return ""; // Palautetaan tyhjä merkkijono, jos ei löydy.
        }
    }
}
