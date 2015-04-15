using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Interfaces
{
    public interface ITransactionProcessor
    {
        TransactionLogEntry LastTransaction { get; }
        int TransactionCount { get; }

        TransactionLogger ExternalLogger { get; set; }

        TransactionLogEntry this[int key] { get; }
        TransactionStatus ProcessTransaction(TransactionType trType, CurrencyAmount amount, IAccount accountFrom, IAccount accountTo);

        TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] array);

        TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts);
    }
}
