using System;
using System.Text;

namespace Pyramid_Builder
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int pyrHeight = int.Parse(Console.ReadLine());

            //Functions 
            static string BrickLayer(int Bricks)
            {
                string layer = "";

                return layer;
            }

            StringBuilder Pyramid = new StringBuilder(); // build the pyramid

            // append string to Pyramid
            for(int i = pyrHeight; i > 0; i--)
            {
                Pyramid.AppendLine(BrickLayer(i));
            }

            var outputPyramid = Pyramid.ToString(); // outputs the built pyramid
        }
    }

}

// height = 3

// #
// ##
// ###
