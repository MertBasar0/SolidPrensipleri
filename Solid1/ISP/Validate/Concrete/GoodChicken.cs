using Solid1.ISP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.ISP.Validate.Concrete
{
    internal class GoodChicken : IUcamayanKuslar
    {
        public string Walk()
        {
            return "tavuklar yürüyor..";
        }
    }
}
