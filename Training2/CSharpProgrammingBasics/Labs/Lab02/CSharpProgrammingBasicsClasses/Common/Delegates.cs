using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;

public delegate void TransactionLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount);

public class BalanceChangedEventArguments : System.EventArgs 
{
    public IAccount Account { get; private set; }

    public CurrencyAmount Change { get; private set; }

    public BalanceChangedEventArguments(IAccount acc, CurrencyAmount amount)
    {
        this.Account = acc;
        this.Change = amount;
    }

    //public delegate void BalanceChanged(object sender, BalanceChangedEventArguments eventArgs);
}

public delegate void BalanceChanged(object sender, BalanceChangedEventArguments eventArgs);