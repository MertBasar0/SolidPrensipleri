using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.DIP.Bad
{
    public class BadRestaurant
    {

        //Restaurant sınıfı high-level bir modüldür.Yalnız low-level modüllerimiz fish ve poulty sınıflarına bağımlılığı vardır.


        BadFish tuna = new BadFish();
        BadPoultry duck = new BadPoultry();

        public string GenerateInstructions() //Sipariş oluştur..
        {
            return tuna.GetFishCookingInstruction()+" "+duck.GetFishCookingInstruction();
        }  
    }
}
