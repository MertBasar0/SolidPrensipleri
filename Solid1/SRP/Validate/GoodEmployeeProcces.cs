using Solid1.SRP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.SRP.Validate
{
    class GoodEmployeeProcces
    {
        Logger logger;
        string log;

        public GoodEmployeeProcces()
        {
            logger = new Logger();
        }

        public bool InsertEmployee(Employee newEmployee)
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


                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\\solidtest\Log.txt", log);

                return true;
            }
            catch (Exception ex)
            {

                sb = new StringBuilder();
                sb.Append("Hata Mesaji :");
                sb.Append(ex.Message);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\\solidtest\Log.txt", sb.ToString());

                return false;
            }
            
        }
    }
}
