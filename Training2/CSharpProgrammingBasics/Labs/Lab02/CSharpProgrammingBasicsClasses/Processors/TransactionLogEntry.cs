using CSharpProgrammingBasics.Classes.Accounts;
using CSharpProgrammingBasics.Classes.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Processors
{
    public class TransactionLogEntry
    {
        public TransactionType TransactionType { get; set; }
        public CurrencyAmount Amount { get; set; }
        public Account Accounts { get; set; }
        public TransactionStatus Status { get; set; }

    }
}
