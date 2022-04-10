using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.OCP
{

    public enum CoffeeType
    {
        Latte,
        Expresso,
        TürkKahvesi,
        Americano
    }
    public class BadCofee
    {
        double totalPrice = 0;
        
        //Burada daha fazla kahve çeşidi eklenirse, 
        public double GetTotalPrice (double amount, CoffeeType type)
        {
            if (type == CoffeeType.Expresso)
            {
                totalPrice = amount * 4.50;
            }
            else if (type == CoffeeType.Latte)
            {
                totalPrice = amount * 2.70;
            }
            else if (type == CoffeeType.TürkKahvesi)
            {
                totalPrice = amount * 3.90;
            }


            return totalPrice;
        }
    }
}
