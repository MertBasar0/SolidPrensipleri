using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.LSP.Validate.Contre
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public int RectangleArea()
        {
            return Height * Width;
        }
    }
}
