using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1Tekrar.Validate
{
    class GoodInsert
    {
        Loglama loglama;
        string log;
        
        public GoodInsert()
        {
            loglama = new Loglama();
        }

        public bool Ekle (Employee emp)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(emp.Id.ToString());
                sb.Append(emp.AdSoyad);
                sb.Append(emp.HireDate.ToString());

                File.WriteAllText(@"C:\\ ");

                log =  loglama.Doldur(sb.ToString());
                loglama.Logla(@"C:\\solidtest\EmployeeData", log);


                

                return true;
            }
            catch (Exception)
            {

                return false;
            }

            
        }


    }
}
