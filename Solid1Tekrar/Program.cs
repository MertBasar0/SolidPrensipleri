using Solid1Tekrar.SRP.BAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1Tekrar
{
    public class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee()
            {
                Id = 1,
                AdSoyad = "Mert Başar",
                HireDate = new DateTime(1994,9,4)
            };

            BadEmployeeProccess bd = new BadEmployeeProccess();
            bd.Iffetsiz(employee);
            Console.ReadKey();
        }
    }
}
