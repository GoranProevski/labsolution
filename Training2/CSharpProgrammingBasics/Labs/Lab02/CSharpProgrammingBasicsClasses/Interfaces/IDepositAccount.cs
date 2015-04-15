using CSharpProgrammingBasics.Classes.Accounts;
using System;
namespace CSharpProgrammingBasics.Classes.Interfaces
{
    public interface IDepositAccount : IAccount
    {
        DateTime EndDate { get; set; }
        CSharpProgrammingBasics.Classes.Common.InterestRate Interest { get; set; }
        CSharpProgrammingBasics.Classes.Common.TimePeriod Period { get; set; }
        DateTime StartDate { get; set; }
        ITransactionAccount TransactionAccount { get; set; }
    }
}
