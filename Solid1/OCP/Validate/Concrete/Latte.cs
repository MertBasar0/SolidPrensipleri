using Solid1.OCP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.OCP.Validate.Concrete
{
    internal class Latte : GoodClass
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 3.50;
        }
    }
}
