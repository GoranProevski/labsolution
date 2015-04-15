using CSharpProgrammingBasics.Classes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Interfaces
{
    public interface IAccount
    {
        long Id { get; }
        string Number { get; }
        string Currency { get; }

        CurrencyAmount Balance1 { get; }

        //event BalanceChanged OnBalanceChanged;

        event EventHandler<BalanceChangedEventArguments> OnBalanceChanged;

        TransactionStatus DebitAmount(CurrencyAmount myAmount);
        TransactionStatus CreditAmount(CurrencyAmount myAmount);

        //bool CheckLimit(CurrencyAmount amount);
    }
}
