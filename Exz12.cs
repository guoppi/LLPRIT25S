using System; // Tarvitaan peruskirjastot, kuten Console ja Exception-luokat
namespace Programs
{
    public class Solution
    {
        // Esimerkkialiohjelma, jota ei tarvitse poistaa
        public void ExampleSubroutine()
        {
            // Ei tee mitään, mutta toimii testiohjelmassa
        }

        // Jakaa kaksi kokonaislukua ja käsittelee virheet
        public int Divide(int x, int y)
        {
            try
            {
                return (x / y); // Suorittaa jakolaskun
            }
            catch (System.DivideByZeroException dbz) // Jos jakaja on nolla
            {
                System.Console.WriteLine("Division with zero" + dbz.Message);
                return 0; // Palauttaa 0 virheen sattuessa
            }
            catch (Exception e) // Kaikki muut virheet
            {
                Console.WriteLine("Unknown error in subroutine divide \n" + e.Message);
                return 0;
            }
            catch // Jos virhe ei ole tunnistettu
            {
                Console.WriteLine("Strange error in subroutine divide\n");
                return 0;
            }
        }

        // Käyttäjän syötteiden lukeminen ja jakolaskun suorittaminen
        public void MyProgram()
        {
            Console.WriteLine("This program calculates quotients"); // Ohjelman aloitusviesti
            bool cont = true; // Jatketaanko ohjelmaa?
            int nmb1, nmb2; // Kokonaislukumuuttujat

            while (cont) // Toistetaan kunnes käyttäjä lopettaa
            {
                try
                {
                    Console.WriteLine("Give two integers:");
                    Console.WriteLine("Number 1:");
                    nmb1 = Convert.ToInt32(Console.ReadLine()); // Lukee ensimmäisen luvun
                    Console.WriteLine("Number 2:");
                    nmb2 = Convert.ToInt32(Console.ReadLine()); // Lukee toisen luvun

                    Console.WriteLine("The quotient is: " + Divide(nmb1, nmb2) + "\n\n"); // Tulostaa tuloksen

                    Console.WriteLine("Want to continue? (Y/N)");
                    if (Console.ReadLine() != "Y") // Jos vastaus ei ole Y, lopetetaan
                        cont = false;
                }
                catch
                {
                    Console.WriteLine("Invalid input from user, please give both values again"); // Virheellinen syöte
                }
            }
        }

        // Sama idea kuin MyProgram, mutta käyttää erillisiä aliohjelmia
        public void MyProgram2()
        {
            Console.WriteLine("This program calculates quotients");
            bool cont = true;

            while (cont)
            {
                try
                {
                    int nmb1 = ReadInteger("Please, give number 1"); // Lukee luvun aliohjelmalla
                    int nmb2 = ReadInteger("Please, give number 2");
                    Console.WriteLine("The quotient is: " + Divide(nmb1, nmb2) + "\n\n");
                    cont = Continue(); // Kysyy jatketaanko
                }
                catch (ApplicationException)
                {
                    Console.WriteLine("ApplicationException"); // Virhe ReadIntegerissä
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("FormatException"); // Virhe Continue-metodissa
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("GeneralException"); // Kaikki muut virheet
                    continue;
                }
            }    
        }

        // Lukee kokonaisluvun ja heittää virheen jos syöte ei ole kelvollinen
        public int ReadInteger(string prompt)
        {
            Console.WriteLine("Please, give me an intefer"); // Pyytää lukua
            string input = Console.ReadLine(); // Lukee syötteen
            try
            {
                int number = int.Parse(input); // Muuntaa kokonaisluvuksi
                return number;
            }
            catch
            {
                // Jos syöte ei ole kelvollinen, heitetään virhe
                throw new ApplicationException("Virhe aliohjelmassa ReadInteger: Luettu arvo '" + input + "', odotettu tyyppi integer.");
            }
        }

        // Kysyy käyttäjältä jatketaanko ohjelmaa
        public bool Continue()
        {
            Console.WriteLine("Want to continue? (Y/N)");
            string input = Console.ReadLine(); // Lukee syötteen
            string lowerInput = input.ToLower(); // Muuttaa syötteen pieniksi kirjaimiksi

            if (lowerInput == "y" || lowerInput == "yes" || lowerInput == "yap")
            {
                return true; // Jatketaan
            }
            else if (lowerInput == "n" || lowerInput == "no" || lowerInput == "nope")
            {
                return false; // Lopetetaan
            }
            else
            {
                // Jos syöte ei ole kelvollinen, heitetään virhe
                throw new FormatException("Virhe aliohjelmassa Continue: luettu arvo '" + input + "', odotettu Y/N tai vastaava.");
            }
        }
    }
}
