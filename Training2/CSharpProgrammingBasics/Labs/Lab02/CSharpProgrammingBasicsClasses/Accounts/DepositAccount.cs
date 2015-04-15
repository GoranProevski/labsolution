using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Helpers;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Accounts
{
    public class DepositAccount : Account, CSharpProgrammingBasics.Classes.Interfaces.IDepositAccount
    {
        public TimePeriod Period { get; set; }
        public InterestRate Interest { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ITransactionAccount TransactionAccount { get; set; }

        public DepositAccount(TimePeriod depositPeriod, InterestRate interestRate, DateTime startDate, DateTime endDate, ITransactionAccount transactionAccount, string currency):base(currency)
        {
            this.Period = depositPeriod;
            this.Interest = interestRate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TransactionAccount = transactionAccount;
        }

        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber<DepositAccount>(this.Id);
        }

    }
}
