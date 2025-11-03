using System;

namespace Programs
{
    static class Solution
    {
        //Almnost 100%
        //IMPORTANT NOTE: you should declare ALL subroutines here in VPL (not in Visual Studio) as public non-static as
        //SO -- > Replace the word static with word public to make the test program compile
        public static void ExampleSubroutine()
        {
            // Testataan Sum ja tulostetaan tulos
            double result1 = Sum(2.5, 7.5);
            Console.WriteLine("Summa: " + result1);

            double result2 = Sum(100.25, 200.75);
            Console.WriteLine("Summa: " + result2);
            Console.WriteLine();

            // Testataan ArraySum
            double[] numbers = { 1, 2, 3, 4, 5 };
            double arrayResult = ArraySum(numbers);
            Console.WriteLine("Talulukon summa: " + arrayResult);
            Console.WriteLine();
            // Testataan Factorial
            int tulos = Factorial(1);
            int tulos2 = Factorial(6);
            int tulos3 = Factorial(10);
            Console.WriteLine(tulos);
            Console.WriteLine(tulos2);
            Console.WriteLine(tulos3);
            Console.WriteLine();

            // Testataan BinCoeff
            int binCoeff1 = BinCoeff(10, 5);
            int binCoeff2 = BinCoeff(6, 3);
            int binCoeff3 = BinCoeff(10, 3);
            Console.WriteLine(binCoeff1);
            Console.WriteLine(binCoeff2);
            Console.WriteLine(binCoeff3);
            Console.WriteLine();

            // Testataan MinFind
            int[] myTable = { 34, 22, 66, 23, 5, 33, 72 };
            int min = MinFind(myTable);
            Console.WriteLine("Pienimmän arvon indeksi on: " + min);
            Console.WriteLine("Alkaen indeksistä 0: " + MinFind(myTable, 0));
            Console.WriteLine("Alkaen indeksistä 1: " + MinFind(myTable, 1));
            Console.WriteLine("Alkaen indeksistä 4: " + MinFind(myTable, 4));
            Console.WriteLine("Alkaen indeksistä 5: " + MinFind(myTable, 5));
            Console.WriteLine("Alkaen indeksistä 6: " + MinFind(myTable, 6));
            Console.WriteLine("Alkaen indeksistä 7: " + MinFind(myTable, 7));
            Console.WriteLine();

            // Tehtävä 6: Testataan lajittelua Factorial- ja BinCoeff-taulukoilla
            int[] factorialArray = { Factorial(1), Factorial(6), Factorial(10) };
            int[] binCoeffArray = { BinCoeff(10, 5), BinCoeff(6, 3), BinCoeff(10, 3) };

            int[] sortedFactorial = Sort(factorialArray);
            int[] sortedBinCoeff = Sort(binCoeffArray);

            Console.WriteLine("Lajiteltu Factorial-taulukko:");
            foreach (int val in sortedFactorial)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Lajiteltu BinCoeff-taulukko:");
            foreach (int val in sortedBinCoeff)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();

            int[] sorted = Sort(myTable);
            Console.WriteLine("Lajiteltu: " + string.Join(", ", sorted));

            string[] words = { "kissa", "koira", "lintu", "kala" };
            Console.WriteLine("koira indeksi: " + Seek(words, "koira"));
            Console.WriteLine("hevonen indeksi: " + Seek(words, "hevonen"));

            string[] nimiLista = new string[10];
            string[] numeroLista = new string[10];

            nimiLista = AddData(nimiLista, 0, "Hanhi");
            numeroLista = AddData(numeroLista, 0, "0401234567");
            nimiLista = AddData(nimiLista, 1, "Poro");
            numeroLista = AddData(numeroLista, 1, "0509876543");
            nimiLista = AddData(nimiLista, 2, "Jussi");
            numeroLista = AddData(numeroLista, 2, "0445551234");

            Console.WriteLine("Nimet: " + string.Join(", ", nimiLista));
            Console.WriteLine("Numerot: " + string.Join(", ", numeroLista));

            Console.WriteLine("Hanhi numero: " + SeekNumber(nimiLista, numeroLista, "Hanhi"));
            Console.WriteLine("Poro numero: " + SeekNumber(nimiLista, numeroLista, "Poro"));
            Console.WriteLine("Jussi numero: " + SeekNumber(nimiLista, numeroLista, "Jussi"));

        }
        //NOTE: DO NOT ERASE ANYTHING ABOVE THIS LINE---------------------------------

        //Enter your subroutines here, just as is, on by one and run the test

        // Aliohjelma, joka laskee kahden luvun summan ja palauttaa sen.
        public static double Sum(double a, double b)
        {
            return a + b; // Palautetaan laskettu summa.
        }
        public static double ArraySum(double[] arr)
        {
            double total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total = Sum(total, arr[i]);
            }
            return total;
        }
        public static int Factorial(int n)
        {

            int kertoma = 1;
            for (int i = 1; i <= n; i++)
            {
                kertoma *= i;
            }
            return kertoma;
        }
        public static int BinCoeff(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
        public static int MinFind(int[] arr)
        {
            int min = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[min])
                {
                    min = i;
                }
            }
            return min;
        }
        // MinFind 5

        public static int MinFind(int[] arr, int n)
        {
            if (n >= arr.Length)
            {
                return -1;
            }
            int min = n;
            for (int i = n; i < arr.Length; i++)
            {
                if (arr[i] < arr[min])
                {
                    min = i;
                }
            }
            return min;
        }
        public static int[] Sort(int[] taulu)
        {
            int[] sortedArray = (int[])taulu.Clone();

            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                int k = MinFind(sortedArray, i);
                if (i != k)
                {
                    sortedArray = swap(sortedArray, i, k);
                }
            }
            return sortedArray;
        }
        public static int[] swap(int[] taulu, int i, int j)
        {
            int[] localArray = new int[taulu.Length];
            for (int k = 0; k < localArray.Length; k++)
            {
                localArray[k] = taulu[k];
            }
            int temp = localArray[i];
            localArray[i] = localArray[j];
            localArray[j] = temp;

            return localArray;
        }

        public static int Seek(string[] arr, string target)
        {
            if (arr == null || target == null) return -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null && arr[i].Equals(target, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }
        public static string[] AddData(string[] arr, int index, string data)
        {
            if (arr == null || index < 0 || index >= arr.Length) return arr;
            string[] copy = (string[])arr.Clone();
            copy[index] = data;
            return copy;
        }

        public static string SeekNumber(string[] names, string[] numbers, string searchName)
        {
            if (names == null || numbers == null || searchName == null) return null;
            if (names.Length != numbers.Length) return "";
            int index = Seek(names, searchName);
            if (index == -1) return "";
            return numbers[index] ?? "";
        }
        //NOTE: DO NOT ERASE ANYTHING ABOVE THIS LINE---------------------------------
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution.ExampleSubroutine();
        }
    }
}
