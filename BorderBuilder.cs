using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid_Builder
{
    internal class BorderBuilder
    {
        private string GenerateLongBorder(int size)
        {
            // Genrates border that does not contain the shape
            StringBuilder border = new StringBuilder();

            for (int length = 0; length < size + 2; length++)
            {
                border.Append("▓");
            }
            border.Append("\n");

            return border.ToString();
        }

        public string GenerateBorder(string shape)
        {
            // Shape array
            string[] shapeArr = shape.Split("\n");

            // Border
            StringBuilder border = new StringBuilder();

            int size = shapeArr[0].Length;

            border.Append(GenerateLongBorder(size));
            // Shape
            foreach (var row in shapeArr)
            {
                border.Append("▓");
                border.Append(row);
                border.Append("▓");
                border.Append("\n");
            }
            border.Append(GenerateLongBorder(size));

            return border.ToString();
        }
    }
}
