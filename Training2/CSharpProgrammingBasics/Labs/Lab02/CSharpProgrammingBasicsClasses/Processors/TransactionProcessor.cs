using CSharpProgrammingBasics.Classes.Accounts;
using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Helpers;
using CSharpProgrammingBasics.Classes.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingBasics.Classes.Processors
{
    public class TransactionProcessor : ITransactionProcessor
    {
        public IList<TransactionLogEntry> _transactionLog = null;

        public TransactionLogEntry LastTransaction 
        {
            get
            {
                if (_transactionLog.Count == 0)
                {
                    return null;
                }
                else
                {
                    return _transactionLog[(_transactionLog.Count) - 1];
                }
            }
        }

        public int TransactionCount 
        { 
            get 
            { 
                return _transactionLog.Count; 
            } 
        }

        public TransactionLogEntry this[int key] 
        { 
            get 
            {
                if (key > ((_transactionLog.Count)-1) || (_transactionLog.Count == 0))
                {
                    return null;
                }
                return _transactionLog[key]; 
            } 
        }

        public TransactionLogger ExternalLogger { get; set; }

        private static ITransactionProcessor _transProc = null;

        public Common.TransactionStatus ProcessTransaction(Common.TransactionType trType, Common.CurrencyAmount amount, IAccount accountFrom, IAccount accountTo)
        {
            IAccount[] array = new IAccount[2];
            array[0] = accountFrom;
            array[1] = accountTo;

            switch ((trType.ToString()))
            {
                case "Transfer":
                    {
                        if (accountFrom.DebitAmount(amount) == TransactionStatus.Completed)
                        {
                            CallExternalLogger(accountFrom, TransactionType.Debit, amount);

                            if (accountTo.CreditAmount(amount) == TransactionStatus.Completed)
                            {
                                CallExternalLogger(accountTo, TransactionType.Credit, amount);
                                LogTransaction(trType, amount, array, TransactionStatus.Completed);
                                return TransactionStatus.Completed;
                            }
                            else
                            {
                                accountFrom.CreditAmount(amount);
                                LogTransaction(trType, amount, array, TransactionStatus.Failed);
                                return TransactionStatus.Failed;
                            }
                        }
                        else
                        {
                            LogTransaction(trType, amount, array, TransactionStatus.Failed);
                            return TransactionStatus.Failed;
                        }
                    }
                case "Debit":
                    {
                        if (accountFrom.DebitAmount(amount) == TransactionStatus.Completed)
                        {
                            CallExternalLogger(accountFrom, TransactionType.Debit, amount);
                            LogTransaction(trType, amount, array, TransactionStatus.Completed);
                            return TransactionStatus.Completed;
                        }
                        else
                        {
                            LogTransaction(trType, amount, array, TransactionStatus.Failed);
                            return TransactionStatus.Failed;
                        }
                    }
                case "Credit":
                    {
                        if (accountTo.CreditAmount(amount) == TransactionStatus.Completed)
                        {
                            CallExternalLogger(accountTo, TransactionType.Credit, amount);
                            LogTransaction(trType, amount, array, TransactionStatus.Completed);
                            return TransactionStatus.Completed;
                        }
                        else
                        {
                            LogTransaction(trType, amount, array, TransactionStatus.Failed);
                            return TransactionStatus.Failed;
                        }
                    }
                default:
                    {
                        LogTransaction(trType, amount, array, TransactionStatus.Failed);
                        return TransactionStatus.Failed;
                    }
            }
        }

        public TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] array)
        {
            if ((transactionType != TransactionType.Credit) && (transactionType != TransactionType.Debit))
            {
                LogTransaction(transactionType, amount, array, TransactionStatus.Failed);
                return TransactionStatus.Failed;
            }
            else
            {
                if (transactionType == TransactionType.Credit)
                {
                    foreach (var acc in array)
                    {
                        acc.CreditAmount(amount);
                        CallExternalLogger(acc, TransactionType.Credit, amount);
                    }
                    LogTransaction(transactionType, amount, array, TransactionStatus.Completed);
                    return TransactionStatus.Completed;
                }
                else
                {
                    foreach (var acc in array)
                    {
                        acc.DebitAmount(amount);
                        CallExternalLogger(acc, TransactionType.Debit, amount);
                    }
                    LogTransaction(transactionType, amount, array, TransactionStatus.Completed);
                    return TransactionStatus.Completed;
                }
            }
        }

        private TransactionProcessor()
        {
            this._transactionLog = new List<TransactionLogEntry>();
        }

        private void LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] array, TransactionStatus transactionStatus) 
        {
            TransactionLogEntry logEntry = new TransactionLogEntry();
            foreach (var acc in array)
            {
                logEntry.TransactionType = transactionType;
                logEntry.Amount = amount;
                logEntry.Accounts = (Account)acc;
                logEntry.Status = transactionStatus;

                _transactionLog.Add(logEntry);

            }
        }

        public static ITransactionProcessor tranpr
        {
            get
            {
                if (_transProc == null)
	            {
		                _transProc = new TransactionProcessor();
                        _transProc.ExternalLogger += AccountHelper.LogTransaction;
                        _transProc.ExternalLogger += AccountHelper.NotifyNationalBank;
	            }
                return _transProc;
            }
        }

        public static ITransactionProcessor GetTransactionProcessor()
        {
            return tranpr;
        }

        private void CallExternalLogger(IAccount acc, TransactionType trType, CurrencyAmount amount) 
        {
            ExternalLogger(acc, trType, amount);
        }

        public TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts) 
        {
            throw new NotImplementedException();
        }
    }
}
