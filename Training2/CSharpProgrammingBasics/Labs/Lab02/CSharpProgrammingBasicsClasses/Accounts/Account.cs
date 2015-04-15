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
    public abstract class Account : IAccount
    {
        

        private long m_Id;

        public long Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }
        private string m_Number;

        public string Number
        {
            get { return m_Number; }
            set { m_Number = value; }
        }

        public string Currency {  get;  set; }

        private CurrencyAmount Balance;

        public CurrencyAmount Balance1
        {
            get { return Balance; }
            set 
            {
                if (Balance1.Amount != value.Amount)
                {
                    BalanceChangedEventArguments bChange = new BalanceChangedEventArguments(this, value);
                    this.OnOnBalanceChanged(bChange);
                }
                Balance = value; 
            }
        }


        public Account(long id, string number, string currency)
        {
            this.Id = id;
            this.Number = number;
            this.Currency = currency;
            CurrencyAmount ca = new CurrencyAmount();
            ca.Amount = 10000;
            ca.Currency = currency;

            this.Balance1 = ca;
        }

        public Account(string currency) : this(-1, "x", currency)
        {
            this.Id = AccountHelper.GenerateAccountId();
            this.Number = GenerateAccountNumber();
        }

        #region Public methods

        public virtual TransactionStatus DebitAmount(CurrencyAmount myAmount)
        {
            if (CurrencyChecker(this.Balance1, myAmount) == true)
            {
                CurrencyAmount ca = this.Balance1;
                ca.Amount -= myAmount.Amount;
                this.Balance1 = ca;
                return TransactionStatus.Completed;
            }
            else
            {
                return TransactionStatus.Failed;
            }
           
        }

        public virtual TransactionStatus CreditAmount(CurrencyAmount myAmount)
        {
            if (CurrencyChecker(this.Balance, myAmount) == true)
            {
                CurrencyAmount ca = this.Balance1;
                ca.Amount += myAmount.Amount;
                if (this.GetType() == typeof(TransactionAccount))
                {
                    ITransactionAccount tr = (ITransactionAccount)this;
                    if (CheckLimit(tr, ca))
                        throw new LimitReachedException("Account limit is reached");
                }
                this.Balance1 = ca;
                return TransactionStatus.Completed;
            }
            else
            {
                return TransactionStatus.Failed;
            }
        }

        public bool CheckLimit(ITransactionAccount acc, CurrencyAmount amount)
        {
            if (amount.Amount > acc.Limit.Amount)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region Private Methods

        private bool CurrencyChecker(CurrencyAmount old, CurrencyAmount given) 
        {
            if (old.Currency == given.Currency)
            {
                return true;
            }
            else
            {
                throw new CurrencyMismatchException("The currency of the given amount is not the same as the transaction acc currency.");
                //throw new ApplicationException("The currency of the given amount is not the same as the transaction acc currency.");
            }
        }

        #endregion

        protected abstract string GenerateAccountNumber();

        //public event BalanceChanged OnBalanceChanged;

        protected virtual void OnOnBalanceChanged(BalanceChangedEventArguments e)
        {
            if (OnBalanceChanged != null)
                OnBalanceChanged(this, e);
        }

        public event EventHandler<BalanceChangedEventArguments> OnBalanceChanged;
          
    }
}
