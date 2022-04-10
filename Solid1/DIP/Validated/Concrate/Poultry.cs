using Solid1.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.DIP.Validated.Concrate
{
    public class Poultry : IProduct
    {
        public string GetCookingInstruction()
        {
            return "Kümes hayvani";
        }
    }
}
