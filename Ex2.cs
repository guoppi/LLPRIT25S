using System;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int WEIGHT = 2500; // int because the weight is integer
            int PASSENGERS = 5; // inter because number of passenger is integer
            double DISTANCE = 149021003.5; // double because it is more precise for large numbers
            float FUEL = 6.4f; // float because it is more common for decimal numbers
            string COLOUR = "green"; // string because of letter

            Console.WriteLine("Car weight is " + WEIGHT + " kg");
            Console.WriteLine("Car colour is " + COLOUR);
            Console.WriteLine("There are " + PASSENGERS + " passengers");
            Console.WriteLine("One hundred km drive consumes " + FUEL + " liters of gasoline per kilometer");
            Console.WriteLine("Distance to the sun is " + DISTANCE + " kilometers");
            // Voidaan myös tulostaa muodossa ($"Distance to the sun is {DISTANCE} kilometers"); näin ollen ei tarvitse laittaa "+" tai "" merkkejä ja lyhentää huomattavasti joitakin tulostuksia.

            string state = "South Karelia"; // string because of its letter
            int population = 124394; // int because population is integer
            string grade = "A"; // string because its letter
            string grade2 = "B"; // string because its letter
            string grade3 = "C"; // string because its letter
            string grade4 = "D"; // string because its letter
            string grade5 = "E"; // string because its letter
            string car = "Ferrari"; // string because its letter
            int lap = 5; // int because it is a number
            float progress = 56.7f; // float because it is a decimal number with less precision
            string username = "Bond"; // string because its letter
            string loginStatus = "successful"; // information if the login was successful or not, string because it is text
            int daysToOlympics = 365; // int because it is integer
            int productPrice = 50; // int because it is integer

            Console.WriteLine("The population of " + state + " is " + population);
            Console.WriteLine();
            Console.WriteLine("The best grade is " + grade);
            Console.WriteLine("The good grade is " + grade2);
            Console.WriteLine("The average grade is " + grade3);
            Console.WriteLine("The poor grade is " + grade4);
            Console.WriteLine("The worst grade is " + grade5);
            Console.WriteLine();
            Console.WriteLine(car + " is in lap " + lap + " at formula race");
            Console.WriteLine();
            Console.WriteLine("The file upload is " + progress + "% completed");
            Console.WriteLine();
            Console.WriteLine("The username is " + username);
            Console.WriteLine("The login was " + loginStatus);
            Console.WriteLine();
            Console.WriteLine("There are " + daysToOlympics + " days left before the next Olympic games");
            Console.WriteLine();
            Console.WriteLine("The price of the product is " + productPrice + " euros");
            Console.WriteLine("Price of a product in a webshop catalogue is " + productPrice + " euros");
        }
    }
}
