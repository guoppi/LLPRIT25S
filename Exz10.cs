using System;
namespace Programs
{
    public class Solution
    {
        //IMPORTANT NOTE: you should declare ALL subroutines here in VPL (not in Visual Studio) as public non-static as
        //SO -- > Replace the word static with word public to make the test program compile
        public void ExampleSubroutine()
        {
            //No need to remove this subroutine
                    // Testataan OSquare4 viisi kertaa
        int count = 0;
        while (count < 5)
        {
            OSquare4();
            Console.WriteLine(); // Tyhjä rivi erottamaan neliöt
            count++;
        }

        // Testataan OSquareN arvoilla 1–5
        int n = 1;
        while (n <= 5)
        {
            OSquareN(n);
            Console.WriteLine(); // Tyhjä rivi erottamaan neliöt
            n++;
        }

        // Testataan XSquareN eri kokoisilla ja eri merkeillä
        XSquareN(3, '*');
        Console.WriteLine();
        XSquareN(5, '#');
        Console.WriteLine();
        XSquareN(2, '+');
        Console.WriteLine();

        // Testataan GetXSquareN ja tulostetaan palautettu merkkijono
        string square = GetXSquareN(4, '@');
        Console.WriteLine(square);

        // Testataan OutputSum
        OutputSum(3.5, 4.2);
        OutputSum(10.1, 5.9);

        // Testataan Sum ja tulostetaan tulos
        double result1 = Sum(2.5, 7.5);
        Console.WriteLine("Summa: " + result1);

        double result2 = Sum(100.25, 200.75);
        Console.WriteLine("Summa: " + result2);
        }

//NOTE: DO NOT ERASE ANYTHING ABOVE THIS LINE---------------------------------
        
        
        //Enter your subroutines here, just as is, on by one and run the test
            public void OSquare4()
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("o");
                    }
                    Console.WriteLine();
                }
            }

            public void OSquareN(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("o");
                    }
                    Console.WriteLine();
                }
            }

            public void XSquareN(int n, char merkki)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                    Console.Write(merkki);
                    }
                    Console.WriteLine();
                }
            }

            public string GetXSquareN(int n, char merkki)
            {
                string tulos = "";
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        tulos += merkki;
                    }
                    tulos += "\n";
                }
                return tulos;
            }

            public void OutputSum(double a, double b)
            {
                double summa = a + b;
                Console.WriteLine("Summa: " + summa);
            }

            public double Sum(double a, double b)
            {
                return a + b;
            }
        


//NOTE: DO NOT ERASE ANYTHING BELOW THIS LINE---------------------------------        
    }
}
