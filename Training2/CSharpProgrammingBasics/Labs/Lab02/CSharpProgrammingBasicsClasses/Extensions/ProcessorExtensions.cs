using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Extensions
{
    public static class ProcessorExtensions
    {

        public static TransactionStatus ChargeProcessingFee(this ITransactionProcessor processor, CurrencyAmount amount, IEnumerable<IAccount> accounts) 
        {
            TransactionType trType = new TransactionType();
            trType = TransactionType.Debit;
            return processor.ProcessGroupTransaction(trType, amount, accounts.ToArray());

        } 
    }
}
