using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpProgrammingBasics.Classes.Common
{
    public class ExceptionLogger
    {
        //public string myException { get; set; }

        public void LogException(Exception ex )
        {
            System.Diagnostics.Debug.WriteLine(ex.ToString());
        }

        public ExceptionLogger()
        {

        }
    }
}
