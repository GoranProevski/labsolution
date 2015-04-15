using CSharpProgrammingBasics.Classes.Accounts;
using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Helpers
{
    public static class AccountHelper
    {
        private static int s_AccountId;
        public static int GenerateAccountId()
        {
            s_AccountId++;
            return s_AccountId;
        }

        static AccountHelper()
        {
            s_AccountId = 0;
        }

        public static string GenerateAccountNumber(Type accountType, long accountId)
        {
            if (accountType == typeof(TransactionAccount))
            {
                return "TR0000" + accountId;
            }
            if (accountType == typeof(DepositAccount))
            {
                return "DP0000" + accountId;
            }
            if (accountType == typeof(LoanAccount))
            {
                return "LN0000" + accountId;
            }
            return "error";
        }

        public static string GenerateAccountNumber<T>(long accountId) where T : IAccount
        {
            Type actype = typeof(T);
            return GenerateAccountNumber(actype, accountId);
        }

        public static void LogTransaction(IAccount acc, TransactionType trType, CurrencyAmount amount)
        {
            if (amount.Amount > 20000)
            {
                Console.WriteLine("{0} {1} {2} {3}",acc.Number, trType.ToString(), amount.Amount.ToString(), amount.Currency);
            }
        }

        public static void NotifyNationalBank(IAccount acc, TransactionType trType, CurrencyAmount amount) 
        {
            if (amount.Amount > 25000)
            {
                Console.WriteLine("Notification from the bank");
            }
        }
    }
}