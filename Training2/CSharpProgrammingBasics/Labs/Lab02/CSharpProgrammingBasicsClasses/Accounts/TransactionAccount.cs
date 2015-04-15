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
    [AccountMetadata(AccountDescription="transaction account", AccountLimitations="something")]
    public class TransactionAccount : Account, CSharpProgrammingBasics.Classes.Interfaces.ITransactionAccount
    {
        public CurrencyAmount Limit { get; set; }

        public TransactionAccount(CurrencyAmount limit, string currency):base(currency)
        {
            this.Limit = limit;
        }

        protected override string GenerateAccountNumber()
        {
            return AccountHelper.GenerateAccountNumber<TransactionAccount>(this.Id);
        }

        //public bool CheckLimit(CurrencyAmount amount)
        //{
        //    if (amount.Amount > this.Limit.Amount)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}
