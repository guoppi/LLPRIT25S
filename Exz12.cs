using System;
namespace Programs
{
    public class Solution
    {
        // You know what to do Owoh :3
        //IMPORTANT NOTE: you should declare ALL subroutines here in VPL (not in Visual Studio) as public non-static as
        //SO -- > Replace the word static with word public to make the test program compile
        public static void ExampleSubroutine()
        {
            //No need to remove this subroutine
        }
        //NOTE: DO NOT MODIFY THIS SUBROUTINE Divide---------------------------------
        public static int Divide(int x, int y)
        {
            try
            {
                return (x / y);
            }
            catch (System.DivideByZeroException dbz)
            {
                System.Console.WriteLine("Division with zero" + dbz.Message);
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown error in subroutine divide \n" + e.Message);
                return 0;
            }
            catch
            {
                Console.WriteLine("Strange error in subroutine divide\n");
                return 0;
            }
        }

        //Task 1: Modify this such that it will not terminate in case of false input---------------------------------

        public static void MyProgram()
        {
            Console.WriteLine("This program calculates quotients");
            bool cont = true;
            int nmb1, nmb2;
            while (cont)
            {
                try
                {
                    Console.WriteLine("Give two integers:");
                    Console.WriteLine("Number 1:");
                    nmb1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Number 2:");
                    nmb2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The quotient is: " + Divide(nmb1, nmb2) + "\n\n");
                    Console.WriteLine("Want to continue? (Y/N)");
                    if (Console.ReadLine() != "Y")
                        cont = false;
                }
                catch
                {
                    Console.WriteLine("Invalid input from user, please give both values again");
                }
            }
        }
        public static void MyProgram2()
        {
            Console.WriteLine("This program calculates quotients");
            bool cont = true;

            while (cont)
            {
                try
                {
                    int nmb1 = ReadInteger("Please, give number 1");
                    int nmb2 = ReadInteger("Please, give number 2");
                    Console.WriteLine("The quotient is: " + Divide(nmb1, nmb2) + "\n\n");
                    cont = Continue();
                }
                catch (ApplicationException)
                {
                    Console.WriteLine("ApplicationException");
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("FormatException");
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("GeneralException");
                    continue;
                }
            }
        }
        //NOTE: DO NOT ERASE ANYTHING ABOVE THIS LINE---------------------------------

        //Enter your subroutines here, just as is, on by one and run the test
        public static int ReadInteger(string prompt)
        {
            Console.WriteLine("Please, give me an intefer");
            string input = Console.ReadLine();
            try
            {
                int number = int.Parse(input);
                return number;
            }
            catch
            {
                if (prompt != null) ;
                {
                    throw new ApplicationException("Virhe aliohjelmassa ReadInteger: Luettu arvo '" + input + "', odotettu tyyppi integer.");
                }
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Want to continue? (Y/N)");
            string input = Console.ReadLine();
            string lowerInput = input.ToLower();
            if (lowerInput == "y" || lowerInput == "yes" || lowerInput == "yap")
            {
                return true;
            }
            else if (lowerInput == "n" || lowerInput == "no" || lowerInput == "nope")
            {
                return false;
            }
            else
            {
                throw new FormatException("Virhe aliohjelmassa Continue: luettu arvo '" + input + "', odotettu Y/N tai vastaava.");
            }
        }
        //NOTE: DO NOT ERASE ANYTHING BELOW THIS LINE---------------------------------        
    }
    class Program // If ur unsure why this is here or does this even belong here, think again xd
    {
        static void Main(string[] args)
        {
            Solution.ExampleSubroutine();
        }
    }
}
