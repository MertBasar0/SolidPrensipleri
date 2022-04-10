using Solid1.DIP.Validated.Abstract;
using Solid1.DIP.Validated.Concrate;
using Solid1.LSP.Bad;
using Solid1.LSP.Validate.Contre;
using Solid1.OCP.Validate.Abstract;
using Solid1.OCP.Validate.Concrete;
using Solid1.SRP.Bad;
using Solid1.SRP.Model;
using Solid1.SRP.Validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Solid prensibleri =>> solid 5 önemli oop pernsiplerinin kısaltmasıdır.
            //Temiz, modüler ve genişletilebilir yazılımlar yapamazsınız. Kod yazarken size önemli kurallar tanımlar.
            //Aynı zamanda agile/Adaptive yazılım geliştirme için gereklidir.


            //Employee e1 = new Employee();
            //e1.FirstName = "Mert";
            //e1.LastName = "Basar";
            //e1.Id = 1;
            ////e1.HireDate = new DateTime('04/09/1994');

            ////BadEmployeeProcessor bd = new BadEmployeeProcessor();
            ////bd.insertEmployee(e1);

            //GoodEmployeeProcces gr = new GoodEmployeeProcces();

            //gr.InsertEmployee(e1);



            //OCP => Open / Closed Principle

            //Sınıflar ve metotlar genişletilmeye açık değişikliğe kapalı olmalıdır.

            //Her ihtiyaç değişikliğinde, yazdığımız kodu değiştirmek zorunda kalmamak işleri kolaylaştırır.



            //GoodClass kahve1 = new Americano();

            //GoodClass kahve2 = new Espresso();

            //GoodClass kahve3 = new Latte();

            //GoodClass kahve4 = new Machiato();


            //double price = 0;

            //price = kahve1.GetTotalPrice(20);

            //price = kahve2.GetTotalPrice(20);

            ////price = kahve3.GetTotalPrice(20);

            ////price = kahve4.GetTotalPrice(20);
            
            //Console.WriteLine("Kahce Fiyati :"+ price);

            //Console.ReadKey();






            //LSP => Liskow Subtution Principle

            //Bir sınıftan türetilen sınıflar, base sınıfın yerinede kullanılabilmektedir.
            //Açmış olduğumuz Dörtgen ve Kare sınıfları üzerinden durumu aşağıda inceleyelim.
            //AreaCalculator() sınıfı üzerinden alan hesaplama testlerimizi gerçekleştirelim.

            //BadRectangle rectangle = new BadRectangle();

            //rectangle.Width = 2;
            //rectangle.Height = 3;


            ////Şimdi bu noktada değerlerimi atıp nesnemi oluşturdum.
            ////basit unit test yazalım.


            //if (BadAreaCalculator.CalculatorArea(rectangle)!=6)
            //{
            //    Console.WriteLine("hata");
               
            //}


            //BadSquare square = new BadSquare();
            ////square.Width = 2;
            //square.Height = 3;

            //if (BadAreaCalculator.CalculatorArea(square)!=9)
            //{
            //    Console.WriteLine("Kare alan hesaplama işleminde hata..");
            //}

            //Console.ReadKey();



            //BadRectangle newRectangle = new BadSquare();
            //newRectangle.Width = 2;
            //newRectangle.Height = 3;

            //if (bad)
            //{

            //}



            //Validate Klasöründe oluşturduğumuz sınıfları deniyoruz..

            //Rectangle rectangle = new Rectangle();

            //rectangle.Width = 2;
            //rectangle.Height = 3;

            //if (rectangle.RectangleArea()!=6)
            //{
            //    Console.WriteLine("Dörtgen alan hesaplama hatalıdır..");
            //}


            //Square square = new Square();
            //square.Width = 4;
            //if (square.SquareArea()!=16)
            //{
            //    Console.WriteLine("hata ");
            //}


            //ISP => İnterface Segregarion Principle
            //Sınıflar ihtiyaçları olmayan özellik ve davranışları içermemelidir.
            //=> ısp klasörine bak..


            List<IProduct> urunler = new List<IProduct>();

            Fish fsh = new Fish();
            Poultry plt = new Poultry();

            urunler.Add(fsh);
            urunler.Add(plt);

            Restaurant rest = new Restaurant(urunler);
            Console.WriteLine(rest.GenerateInstructions());
            Console.ReadKey();

            //DIP => Dependence 
            //Üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.

        }
    }
}
