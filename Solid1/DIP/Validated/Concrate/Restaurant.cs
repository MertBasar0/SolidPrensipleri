using Solid1.DIP.Validated.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.DIP.Validated.Concrate
{

    //Buradaki amaç bu versiyonda restaurant sınıfını alt seviyedeki modüllerden bağımsız hale getirmeye çalışmak..

    public class Restaurant
    {
        private List<IProduct> products;

        public Restaurant(List<IProduct> products)
        {
            this.products = products;

        }

        public string GenerateInstructions() //Sipariş oluştur..
        {
            string instruction = string.Empty;

            foreach (var item in products)
            {
                instruction += item.GetCookingInstruction()+" ";
            } 

            return instruction;
        }
    }
}
