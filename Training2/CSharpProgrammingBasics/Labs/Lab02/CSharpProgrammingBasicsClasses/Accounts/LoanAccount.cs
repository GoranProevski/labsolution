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
    public sealed class LoanAccount : DepositAccount, ILoanAccount
    {
        //public CurrencyAmount LoanBalance { get; set; }

        public LoanAccount(TimePeriod tp, InterestRate ir, DateTime sd, DateTime ed, ITransactionAccount trAcc, string currency):base(tp, ir, sd, ed, trAcc, currency)
        {

        }

        public override TransactionStatus DebitAmount(CurrencyAmount myAmount)
        {
            myAmount.Amount *= -1;
            return base.DebitAmount(myAmount);
        }

        public override TransactionStatus CreditAmount(CurrencyAmount myAmount)
        {
            myAmount.Amount *= -1;
            return base.CreditAmount(myAmount);
        }

        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber<LoanAccount>(this.Id);
        }
    }
}
