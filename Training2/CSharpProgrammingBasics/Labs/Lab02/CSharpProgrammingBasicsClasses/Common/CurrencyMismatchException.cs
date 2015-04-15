using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Common
{
    public class CurrencyMismatchException : ApplicationException
    {
        public string Ex { get; set; }

        public CurrencyMismatchException(string s) : base(s)
        {

        }
    }
}
