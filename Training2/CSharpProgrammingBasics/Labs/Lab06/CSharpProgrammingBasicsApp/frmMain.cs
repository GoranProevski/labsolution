using CSharpProgrammingBasics.Classes.Accounts;
using CSharpProgrammingBasics.Classes.Common;
using CSharpProgrammingBasics.Classes.Interfaces;
using CSharpProgrammingBasics.Classes.Processors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpProgrammingBasics.Classes.Extensions;

namespace CSharpProgrammingBasicsApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// creates transaction account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            CurrencyAmount ca = new CurrencyAmount();
            ca.Amount = Convert.ToDecimal(txtLimit.Text);
            ca.Currency = txtCurrency.Text;
            ITransactionAccount ta = new TransactionAccount(ca, txtCurrency.Text);
            PopulateAccountCommon(ta);
        }

        /// <summary>
        /// populates the account details accordingly to account type
        /// </summary>
        /// <param name="acc"></param>
        private void PopulateAccountCommon(IAccount acc) 
        {
            lblId.Text = "Id: " + Convert.ToString(acc.Id);
            lblNumber.Text = "Number: " + acc.Number;
            lblCurency.Text = "Currency: " + acc.Currency;
            lblBalance.Text = "Balance: " + Convert.ToString(acc.Balance1.Amount);

            IsItTransactionAcc(acc);
            IsItDepositAcc(acc);
        }

        /// <summary>
        /// checks if the account is transaction account
        /// </summary>
        /// <param name="ac"></param>
        private void IsItTransactionAcc(IAccount ac) 
        {
            if (ac.GetType() == typeof(TransactionAccount))
            {

                lblTranLimit.Text = "Limit: " + ((ITransactionAccount)ac).Limit.Amount.ToString();
                lblLimitCurrency.Text = "Currency: " + ((ITransactionAccount)ac).Limit.Currency;
                lblDStartDate.Text = "";
                lblDEndDate.Text = "";
            }
            else
            {
                lblTranLimit.Text = "";
                lblLimitCurrency.Text = "";
                
            }
        }


        /// <summary>
        /// creates a deposit account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {
            TimePeriod tp = new TimePeriod();
            tp.Period = int.Parse(txtPeriodValue.Text);
            Enum.TryParse<UnitOfTime>(cmbDUnits.SelectedValue.ToString(), out tp.Unit);

            InterestRate ir = new InterestRate();
            ir.Percent = decimal.Parse(txtInterestValue.Text);
            Enum.TryParse<UnitOfTime>(cmbDUnits1.SelectedValue.ToString(), out ir.Unit);

            DateTime sd = dtpStartDate.Value;
            DateTime ed = dtpEndDate.Value;

            CurrencyAmount ca = new CurrencyAmount();
            ca.Amount = Convert.ToDecimal(txtLimit.Text);
            ca.Currency = txtCurrency.Text;

            TransactionAccount ta = new TransactionAccount(ca, txtCurrency.Text);

            DepositAccount da = new DepositAccount(tp, ir, sd, ed, ta, txtCurrency.Text);

            PopulateAccountCommon(da);
        }
        /// <summary>
        /// checks if the account is deposit account
        /// </summary>
        /// <param name="acc"></param>
        private void IsItDepositAcc(IAccount acc) 
        {
            if (acc.GetType() == typeof(DepositAccount))
            {
                lblDperiod.Text = "Period: " + ((IDepositAccount)acc).Period.Period.ToString() + " " + ((IDepositAccount)acc).Period.Unit.ToString();
                lblDInterest.Text = "Interest: " + ((IDepositAccount)acc).Interest.Percent.ToString() + "% per " + ((IDepositAccount)acc).Interest.Unit.ToString();
                lblDStartDate.Text = dtpStartDate.Value.ToShortDateString();
                lblDEndDate.Text = dtpEndDate.Value.ToShortDateString();
            }
            else
            {
                lblDInterest.Text = "";
                lblDperiod.Text = "";
            }
        }

        /// <summary>
        /// initiates a transaction. in this case 
        /// a transfer from a transaction to a loan acc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            bool _errorOccurred = false;
            string _errorMsg = null;

            ITransactionAccount acc = CreateTransactionAccount();

            ILoanAccount loanAcc = CreateLoanAccount(acc);

            ITransactionAccount ta = CreateTransactionAccount();

            //TimePeriod tp = new TimePeriod();
            //tp.Period = int.Parse(txtPeriodValue.Text);
            //Enum.TryParse<UnitOfTime>(cmbDUnits.SelectedValue.ToString(), out tp.Unit);

            //InterestRate ir = new InterestRate();
            //ir.Percent = decimal.Parse(txtInterestValue.Text);
            //Enum.TryParse<UnitOfTime>(cmbDUnits1.SelectedValue.ToString(), out ir.Unit);

            //DateTime sd = dtpStartDate.Value;
            //DateTime ed = dtpEndDate.Value;

            IDepositAccount da = CreateDepositAccount(ta);

            CurrencyAmount trAmount = new CurrencyAmount();
            trAmount.Amount = Convert.ToDecimal(txtTransactionAmount.Text);
            trAmount.Currency = txtTransactionCurrency.Text;

            ITransactionProcessor tranp = TransactionProcessor.GetTransactionProcessor();

            try
            {
                tranp.ProcessTransaction(TransactionType.Transfer, trAmount, ta, loanAcc);
                //tranp.ProcessTransaction(TransactionType.Credit, trAmount, da, ta);
            }
            catch(LimitReachedException ex)
            {
                _errorOccurred = true;
                _errorMsg = ex.Message;
            }
            catch(CurrencyMismatchException ex)
            {
                _errorOccurred = true;
                _errorMsg = ex.Message;
            }
            catch (ApplicationException ex)
            {
                _errorOccurred = true;
                _errorMsg = ex.Message;
                throw new CurrencyMismatchException("bla");
            }
            finally 
            {
                if (_errorOccurred)
                {
                    MessageBox.Show(_errorMsg);
                }
            }
            //lblId.Text = Convert.ToString(ta.Id);
            //lblNumber.Text = ta.Number;
            //lblCurency.Text = ta.Currency;
            //lblBalance.Text = Convert.ToString(ta.Balance1.Amount);

            //lblIdTo.Text = Convert.ToString(loanAcc.Id);
            //lblNumberTo.Text = loanAcc.Number;
            //lblCurencyTo.Text = loanAcc.Currency;
            //lblBalanceTo.Text = Convert.ToString(loanAcc.Balance1.Amount);

            DisplayLastTransactionDetails(tranp);

            lblIdTo.Text = "To Id: " + Convert.ToString(loanAcc.Id);
            lblNumberTo.Text = "To Number: " + loanAcc.Number;
            lblCurencyTo.Text = "Currency: " + loanAcc.Currency;
            lblBalanceTo.Text = "New Balance: " + Convert.ToString(loanAcc.Balance1.Amount);


        }

        /// <summary>
        /// method used for creating transaction accounts
        /// </summary>
        /// <returns></returns>
        private ITransactionAccount CreateTransactionAccount()
        {
            CurrencyAmount ca = new CurrencyAmount();
            ca.Amount = Convert.ToDecimal(txtLimit.Text);
            ca.Currency = txtCurrency.Text;
            ITransactionAccount ta = new TransactionAccount(ca, txtCurrency.Text);
            return ta;
        }

        /// <summary>
        /// method for creating loan accounts
        /// </summary>
        /// <param name="trAcc"></param>
        /// <returns></returns>
        private ILoanAccount CreateLoanAccount(ITransactionAccount trAcc) 
        {
            //CurrencyAmount ca = new CurrencyAmount();
            //ca.Amount = Convert.ToDecimal(txtAmount.Text);
            //ca.Currency = txtCurrency.Text;
            //ITransactionAccount ta = CreateTransactionAccount();

            TimePeriod tp = new TimePeriod();
            tp.Period = int.Parse(txtLoanPeriod.Text);
            Enum.TryParse<UnitOfTime>(cmbLUnit.SelectedValue.ToString(), out tp.Unit);

            InterestRate ir = new InterestRate();
            ir.Percent = decimal.Parse(txtLoanInterest.Text);
            Enum.TryParse<UnitOfTime>(cmbLUnit1.SelectedValue.ToString(), out ir.Unit);

            DateTime sd = dtpLoanStartDate.Value;
            DateTime ed = dtpLoanEndDate.Value;

            
            ILoanAccount loanAcc = CreateAcc<LoanAccount>(trAcc);

            //ILoanAccount loanAcc = new LoanAccount(tp, ir, sd, ed, trAcc, txtCurrency.Text);


            return loanAcc;
        }

        /// <summary>
        /// method for creating deposit accounts
        /// </summary>
        /// <param name="trAcc"></param>
        /// <returns></returns>
        private IDepositAccount CreateDepositAccount(ITransactionAccount trAcc)
        {

            //TimePeriod tp = new TimePeriod();
            //tp.Period = int.Parse(txtPeriodValue.Text);
            //Enum.TryParse<UnitOfTime>(cmbDUnits.SelectedValue.ToString(), out tp.Unit);

            //InterestRate ir = new InterestRate();
            //ir.Percent = decimal.Parse(txtInterestValue.Text);
            //Enum.TryParse<UnitOfTime>(cmbDUnits1.SelectedValue.ToString(), out ir.Unit);

            //DateTime sd = dtpStartDate.Value;
            //DateTime ed = dtpEndDate.Value;

            ////CurrencyAmount ca = new CurrencyAmount();
            ////ca.Amount = Convert.ToDecimal(txtAmount.Text);
            ////ca.Currency = txtCurrency.Text;

            ////TransactionAccount ta = new TransactionAccount(ca, txtCurrency.Text);

            //DepositAccount da = new DepositAccount(tp, ir, sd, ed, trAcc, txtCurrency.Text);

            //da.OnBalanceChanged += HandleBalanceChange;

            //return da;

            IDepositAccount da = CreateAcc<DepositAccount>(trAcc);

            return da;
        }

        /// <summary>
        /// initiates a group transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeGroupTransaction_Click(object sender, EventArgs e)
        {
            IAccount[] array = new IAccount[2];

            //array[0] = CreateDepositAccount();
            //array[1] = CreateLoanAccount();
            
            //CreateAccountType[] accToCreate = {CreateAccountType.TransactionAccount, CreateAccountType.DepositAccount, CreateAccountType.LoanAccount};
            CreateAccountType accToCreate = CreateAccountType.TransactionAccount | CreateAccountType.DepositAccount | CreateAccountType.LoanAccount;
            ITransactionAccount acc = null;

            Dictionary<CreateAccountType, IAccount> dictionary = CreateAccounts(accToCreate, acc);

            IAccount trAcc;
            array[0] = null;
            array[1] = null;

            if (dictionary.TryGetValue(CreateAccountType.TransactionAccount, out trAcc)) ;
            

            Dictionary<CreateAccountType, IAccount> dictionary1 = CreateAccounts(accToCreate, (ITransactionAccount)trAcc);

            if (dictionary1.TryGetValue(CreateAccountType.DepositAccount, out array[0])) ;

            if (dictionary1.TryGetValue(CreateAccountType.LoanAccount, out array[1])) ;

            

            string firstId = array[0].Id.ToString();
            string firstBalance = array[0].Balance1.Amount.ToString();

            string secondId = array[1].Id.ToString();
            string secondBalance = array[1].Balance1.Amount.ToString();

            CurrencyAmount ca = new CurrencyAmount();
            ca.Amount = Convert.ToDecimal(txtTransactionAmount.Text);
            ca.Currency = txtTransactionCurrency.Text;

            ITransactionProcessor tranp = TransactionProcessor.GetTransactionProcessor();

            tranp.ProcessGroupTransaction(TransactionType.Debit, ca, array);

            lblIdTo.Text = "Id: " + Convert.ToString(array[0].Id);
            lblNumberTo.Text = "From " + firstBalance + " to " + array[0].Balance1.Amount.ToString();
            lblCurencyTo.Text = "Id: " + array[1].Id.ToString();
            lblBalanceTo.Text = "From " + secondBalance + " to " + array[1].Balance1.Amount.ToString();

            DisplayLastTransactionDetails(tranp);

        }

        /// <summary>
        /// displays the last transaction details 
        /// </summary>
        /// <param name="proc"></param>
        private void DisplayLastTransactionDetails(ITransactionProcessor proc) 
        {
            lblCount.Text = "Number of Transactions: " + proc.TransactionCount.ToString();
            TransactionLogEntry entry = new TransactionLogEntry();
            //entry = proc.LastTransaction;

            entry = proc[((proc.TransactionCount) - 1)];

            PopulateAccountCommon(entry.Accounts);

            lblType.Text = entry.TransactionType.ToString();
            lblEntryAmount.Text = entry.Amount.Amount.ToString();
            lblEntryCurrency.Text = entry.Amount.Currency.ToString();
            lblEntryStatus.Text = entry.Status.ToString();

            
        }


        private Dictionary<CreateAccountType, IAccount> CreateAccounts(CreateAccountType accountTypesToCreate, ITransactionAccount transactionAccount)
        {
            Dictionary<CreateAccountType, IAccount> dictionary = new Dictionary<CreateAccountType, IAccount>();
            if ((accountTypesToCreate.HasFlag(CreateAccountType.TransactionAccount)) && (transactionAccount == null))
            {
                IAccount acc = CreateTransactionAccount();
                dictionary.Add(CreateAccountType.TransactionAccount, acc);
                return dictionary;
            }
            else
            {
                IAccount dp = CreateDepositAccount(transactionAccount);
                IAccount la = CreateLoanAccount(transactionAccount);
                dictionary.Add(CreateAccountType.DepositAccount,dp);
                dictionary.Add(CreateAccountType.LoanAccount, la);
                return dictionary;
            }


        }


        /// <summary>
        /// handles the onbalancechanged event
        /// </summary>
        /// <param name="acc"></param>
        /// <param name="bChange"></param>
        public void HandleBalanceChange(object acc, BalanceChangedEventArguments bChange)
        {
            Console.WriteLine("the new value is {0} {1}", bChange.Account.Number, bChange.Change.Amount);
        }

        /// <summary>
        /// charges a fee for processing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChargeFee_Click(object sender, EventArgs e)
        {

            IAccount[] array = new IAccount[2];

            CurrencyAmount ca = new CurrencyAmount();
            ca.Amount = 15;
            ca.Currency = "MKD";

            ITransactionAccount trAcc = CreateTransactionAccount();
            array[0] = CreateDepositAccount(trAcc);
            array[1] = CreateLoanAccount(trAcc);


            ProcessorExtensions.ChargeProcessingFee(TransactionProcessor.tranpr, ca, array);

            //TransactionProcessor.tranpr.ChargeProcessingFee(ca, array);

            DisplayLastTransactionDetails(TransactionProcessor.tranpr);
        }

        /// <summary>
        /// populates the comboboxes on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbDUnits.DataSource = Enum.GetValues(typeof(UnitOfTime));
            cmbDUnits1.DataSource = Enum.GetValues(typeof(UnitOfTime));
            cmbLUnit.DataSource = Enum.GetValues(typeof(UnitOfTime));
            cmbLUnit1.DataSource = Enum.GetValues(typeof(UnitOfTime));

        }



        /// <summary>
        /// generic method for creating different acc types
        /// based on provided value for the type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="trAcc"></param>
        /// <returns></returns>
        private T CreateAcc<T>(ITransactionAccount trAcc) where T : IAccount
        {
            if (typeof(T) == typeof(DepositAccount))
            {
                TimePeriod tp = new TimePeriod();
                tp.Period = int.Parse(txtPeriodValue.Text);
                Enum.TryParse<UnitOfTime>(cmbDUnits.SelectedValue.ToString(), out tp.Unit);

                InterestRate ir = new InterestRate();
                ir.Percent = decimal.Parse(txtInterestValue.Text);
                Enum.TryParse<UnitOfTime>(cmbDUnits1.SelectedValue.ToString(), out ir.Unit);

                DateTime sd = dtpStartDate.Value;
                DateTime ed = dtpEndDate.Value;

                IDepositAccount da = new DepositAccount(tp, ir, sd, ed, trAcc, txtCurrency.Text);

                da.OnBalanceChanged += HandleBalanceChange;

                return (T)da;

            }
            if (typeof(T) == typeof(LoanAccount))
            {

                TimePeriod tp = new TimePeriod();
                tp.Period = int.Parse(txtLoanPeriod.Text);
                Enum.TryParse<UnitOfTime>(cmbLUnit.SelectedValue.ToString(), out tp.Unit);

                InterestRate ir = new InterestRate();
                ir.Percent = decimal.Parse(txtLoanInterest.Text);
                Enum.TryParse<UnitOfTime>(cmbLUnit1.SelectedValue.ToString(), out ir.Unit);

                DateTime sd = dtpLoanStartDate.Value;
                DateTime ed = dtpLoanEndDate.Value;

                ILoanAccount loanAcc = new LoanAccount(tp, ir, sd, ed, trAcc, txtCurrency.Text);

                return (T)loanAcc;
            }

            return default(T);
        }

        /// <summary>
        /// used for adding value to a transaction account,
        /// and to check if the exception for reaching the
        /// transaction account limit fires
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            bool _errorOccurred = false;
            string _errorMsg = null;

            ITransactionAccount acc = CreateTransactionAccount();

            ILoanAccount loanAcc = CreateLoanAccount(acc);

            ITransactionAccount ta = CreateTransactionAccount();

            IDepositAccount da = CreateDepositAccount(ta);

            CurrencyAmount trAmount = new CurrencyAmount();
            trAmount.Amount = Convert.ToDecimal(txtTransactionAmount.Text);
            trAmount.Currency = txtTransactionCurrency.Text;

            ITransactionProcessor tranp = TransactionProcessor.GetTransactionProcessor();

            try
            {
                //tranp.ProcessTransaction(TransactionType.Transfer, trAmount, ta, loanAcc);
                tranp.ProcessTransaction(TransactionType.Credit, trAmount, da, ta);
            }
            catch (LimitReachedException ex)
            {
                _errorOccurred = true;
                _errorMsg = ex.Message;
                //throw new BusinessLogicException("something went wrong", ex);
            }
            catch (CurrencyMismatchException ex)
            {
                _errorOccurred = true;
                _errorMsg = ex.Message;
            }
            catch (ApplicationException ex)
            {
                _errorOccurred = true;
                _errorMsg = ex.Message;
                
            }
            catch(Exception ex)
            {
                _errorOccurred = true;
                _errorMsg = ex.Message;
            }
            finally
            {
                if (_errorOccurred)
                {
                    MessageBox.Show(_errorMsg);
                }
            }

            DisplayLastTransactionDetails(tranp);
        }
    }
}
