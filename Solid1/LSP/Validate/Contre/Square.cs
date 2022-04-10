using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.LSP.Validate.Contre
{
    internal class Square : Shape
    {
        public int Width { get; set; }

        public double SquareArea()
        {
            return Width * Width;
        }
    }
}
