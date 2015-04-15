using CSharpProgrammingBasics.Classes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasicsApp
{
    public class BusinessLogicException : ApplicationException
    {

        public BusinessLogicException(string s):base(s)
        {

        }

        public BusinessLogicException(string Message, Exception innerException)
            : base(Message, innerException)
        {
            ExceptionLogger logger = new ExceptionLogger();
            logger.LogException(innerException);
        }
    }
}
