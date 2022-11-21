using System;
using System.Text;

namespace Pyramid_Builder
{
    internal class ShapeBuilder
    {
        public string buildTriangle(int height, string character)
        {
            StringBuilder shapeString = new StringBuilder();

            for (int row = 0; row < height; row++)
            {
                for (int spaces = height; spaces > row+1; spaces--)
                {
                    shapeString.Append(" ");
                }

                for (int bricks = 1; bricks <= row+1; bricks++)
                {
                    shapeString.Append((bricks == 1) ? character : $"{character}{character}");
                    //if (bricks == 1)
                    //{
                    //    shapeString.Append("_");
                    //}
                    //else
                    //{
                    //    shapeString.Append("__");
                    //}
                }

                for (int spaces = height; spaces > row+1; spaces--)
                {
                    shapeString.Append(" ");
                }

                shapeString.Append((row == height-1) ? "" : "\n");

            }

            return shapeString.ToString();
        }
    }
}
