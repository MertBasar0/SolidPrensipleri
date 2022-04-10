using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.ISP.Bad
{
    internal class BadHawk : IBird
    {
        public string fly()
        {
            throw new NotImplementedException();
        }

        public string walk()
        {
            throw new NotImplementedException();
        }
    }
}
