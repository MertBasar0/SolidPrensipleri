using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.LSP.Bad
{
    class BadAreaCalculator
    {
        public static double CalculatorArea(BadRectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public static double CalculatorArea(BadSquare square)
        {
            return square.Height * square.Width;
        }
    }
}
