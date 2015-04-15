using CSharpProgrammingBasics.Classes.Common;
using System;
namespace CSharpProgrammingBasics.Classes.Interfaces
{
    public interface ITransactionAccount : IAccount
    {
        CSharpProgrammingBasics.Classes.Common.CurrencyAmount Limit { get; set; }

        //bool CheckLimit(CurrencyAmount amount);
    }

}