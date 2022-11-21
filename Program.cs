using System;

namespace Pyramid_Builder
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of your shape: ");
            int pyrHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the symbol for your shape: ");
            string pyrChar = Console.ReadLine();

            ShapeBuilder pyramid = new ShapeBuilder();
            BorderBuilder border = new BorderBuilder();

            Console.WriteLine(border.GenerateBorder(pyramid.buildTriangle(pyrHeight, pyrChar)));
        }
    }
}

// height = 3

// #
// ##
// ###

//   #
//  ##
// ###

// ###
//  ##
//   #
