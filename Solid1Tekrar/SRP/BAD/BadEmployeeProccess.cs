using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1Tekrar.SRP.BAD
{
    class BadEmployeeProccess
    {
        public void Iffetsiz(Employee newEmployee)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                
                sb.Append(newEmployee.Id);
                sb.AppendLine();
                sb.Append(newEmployee.AdSoyad);
                sb.AppendLine();
                sb.Append(newEmployee.HireDate);

                File.WriteAllText(@"C:\solidtest\EmployeeData.txt", sb.ToString());

                sb = new StringBuilder();

                sb.Append("Kayıt ekleme tarihi :");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append(newEmployee.AdSoyad);

                File.WriteAllText(@"C:\solidtest\Log.txt", sb.ToString());

                Console.WriteLine("başarılı");
            }
            catch (Exception ex)
            {

                sb = new StringBuilder();
                sb.Append("Sistemsel hatanın tarihi :");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.AppendLine(ex.Message);

                File.WriteAllText(@"C:\\solidtest\Log.txt", sb.ToString());

                Console.WriteLine("başarısız..");
            }
        }
    }
}
