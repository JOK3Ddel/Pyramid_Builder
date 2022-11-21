using System;

namespace Pyramid_Builder
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // Initialization
            int pyrHeight;
            string pyrChar;
            string userInput;

            ShapeBuilder pyramid = new ShapeBuilder();
            BorderBuilder border = new BorderBuilder();

            Console.WriteLine("Enter 'n' to exit the App.\nEnter 'y' to start.");
            userInput = Console.ReadLine();
            while (userInput != "n")
            {
                // Prompt user for size
                Console.WriteLine("Please enter the size of your shape: ");

                try
                {
                    pyrHeight = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    throw;
                }

                // Prompt user for symbol
                Console.WriteLine("Please enter the (1) symbol for your shape: ");
                pyrChar = Console.ReadLine();

                try
                {
                    while (pyrChar.Length != 1)
                    {
                        Console.WriteLine("Please enter a valid symbol amount.");
                        pyrChar = Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                Console.WriteLine(border.GenerateBorder(pyramid.buildTriangle(pyrHeight, pyrChar)));
                
                // Prompt User to continue
                Console.WriteLine("Do you wish to continue? y/n");
                userInput = Console.ReadLine();
            }
        }
    }
}
