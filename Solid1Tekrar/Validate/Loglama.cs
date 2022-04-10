using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1Tekrar.Validate
{
    class Loglama
    {
        public void Logla(string filepath, string log)
        {
            File.WriteAllText(filepath, log);
        }

        public string Doldur(string information)
        {
            StringBuilder st = new StringBuilder();
            st.Append("Loglama tarihi :");
            st.Append(DateTime.Now.ToString());
            st.Append(information);
             
            return st.ToString();
        }

    }
}
