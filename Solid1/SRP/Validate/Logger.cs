using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1.SRP.Validate
{
    class Logger
    {
        public void LogFile(string filepath, string log)
        {
            File.WriteAllText(filepath, log);
        }


        public string BuildLog(string information)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Date :");
            sb.Append(DateTime.Now.ToString());
            sb.AppendLine();
            sb.Append("information").Append(information);

          
            return sb.ToString();
        }
    }
}
