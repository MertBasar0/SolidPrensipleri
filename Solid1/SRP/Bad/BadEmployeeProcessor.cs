using Solid1.SRP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.SRP.Bad
{
    class BadEmployeeProcessor
    {

        //Aşağıda yapılan işlemlere bakarsanız, sınıf içerisinde çalışan ekleme kodumuzu birden fazla işlem yaptığını görebilirsiniz.
        //Hem ekleme hem log işlemleri bir arada gitmektedir. Alttaki kod bu nedenle single responsibility prensibine ters düşmektedir.


        //Aşağıdaki yöntemde logglama ile ilgili sürec değiştirildiğinde, sınıflara müdahale etmeniz gerekecektir. // Farklı bir yol,
        //farklı bir dosya ya da farklı bir loglama çeşidi durumunda projenin genişletilebilmesine engel teşkil eder. Hata riskini
        //artırır.

        //Bu dışında tamamen srp üzerinden gidilecek olursa, Console yazma işlemi class içerisinde olmamalıdır.
        //Platform değişiklikleri kullanıcı değişiklikleri ile tölere edilebilir olması için dönene değere göre program.cs de 
        //ilgili yere mesaj verdirmeliyiz.


        public void insertEmployee(Employee newEmployee)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                
                sb.Append(newEmployee.Id);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.LastName);
                sb.AppendLine();
                sb.Append(newEmployee.HireDate);


                File.WriteAllText(@"C:\\solidtest\EmployeeData.txt", sb.ToString());


                sb = new StringBuilder();

                sb.Append("Kayıt eklenme tarihi:");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Işlemi yapan personel adi :");
                sb.Append(newEmployee.Id);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName).Append(" ");
                sb.Append(newEmployee.LastName);
                File.WriteAllText(@"C:\\solidtest\Log.txt", sb.ToString());

                Console.WriteLine("Çalışan başarılı bir şekilde sisteme kayıt edildi.");   
            }
            catch (Exception ex)
            {
                sb= new StringBuilder();
                sb.Append("Sistemsel hatanın tarihi");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata mesajımız: ");
                sb.Append(ex.Message);
                File.WriteAllText(@"C:\\solidtest\Log.txt", sb.ToString());

                Console.WriteLine("Hata..");

                
            }
           


        }
    }
}
