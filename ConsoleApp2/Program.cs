using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            // This line prints the welcome message to the user.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // This line prompts the user for the package weight.
            Console.WriteLine("Please enter the package weight: ");
            float packageWeight = float.Parse(Console.ReadLine());

            // This line checks if the package weight is greater than 50. If it is, the program prints an error message and ends.
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Environment.Exit(0);
            }

            // This line prompts the user for the package width.
            Console.WriteLine("Please enter the package width: ");
            float packageWidth = float.Parse(Console.ReadLine());

            // This line prompts the user for the package height.
            Console.WriteLine("Please enter the package height: ");
            float packageHeight = float.Parse(Console.ReadLine());

            // This line prompts the user for the package length.
            Console.WriteLine("Please enter the package length: ");
            float packageLength = float.Parse(Console.ReadLine());

            // This line calculates the total dimensions of the package.
            float totalDimensions = packageWidth + packageHeight + packageLength;

            // This line checks if the total dimensions of the package are greater than 50. If they are, the program prints an error message and ends.
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Environment.Exit(0);
            }

            // This line calculates the shipping quote.
            float shippingQuote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;

            // This line prints the shipping quote to the user.
            Console.WriteLine("Your estimated total for shipping this package is: $" + shippingQuote);

            // This line prints a thank you message to the user.
            Console.WriteLine("Thank you!");

            // This line keeps the console open until the user presses a key.
            Console.ReadKey();
        }
    }
}
