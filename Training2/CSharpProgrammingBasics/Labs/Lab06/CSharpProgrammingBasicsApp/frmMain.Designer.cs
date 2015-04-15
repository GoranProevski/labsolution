namespace CSharpProgrammingBasicsApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateTransactionAccount = new System.Windows.Forms.Button();
            this.btnCreateDepositAccount = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDUnits = new System.Windows.Forms.ComboBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblPeriodValue = new System.Windows.Forms.Label();
            this.txtPeriodValue = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDUnits1 = new System.Windows.Forms.ComboBox();
            this.lblInterestUnit = new System.Windows.Forms.Label();
            this.lblInterestValue = new System.Windows.Forms.Label();
            this.txtInterestValue = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCurency = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLimitCurrency = new System.Windows.Forms.Label();
            this.lblTranLimit = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDEndDate = new System.Windows.Forms.Label();
            this.lblDStartDate = new System.Windows.Forms.Label();
            this.lblDInterest = new System.Windows.Forms.Label();
            this.lblDperiod = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblIdTo = new System.Windows.Forms.Label();
            this.lblNumberTo = new System.Windows.Forms.Label();
            this.lblCurencyTo = new System.Windows.Forms.Label();
            this.lblBalanceTo = new System.Windows.Forms.Label();
            this.btnMakeTransaction = new System.Windows.Forms.Button();
            this.btnMakeGroupTransaction = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblEntryStatus = new System.Windows.Forms.Label();
            this.lblEntryCurrency = new System.Windows.Forms.Label();
            this.lblEntryAmount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.txtTransactionCurrency = new System.Windows.Forms.TextBox();
            this.btnChargeFee = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cmbLUnit1 = new System.Windows.Forms.ComboBox();
            this.cmbLUnit = new System.Windows.Forms.ComboBox();
            this.txtLoanInterest = new System.Windows.Forms.TextBox();
            this.txtLoanPeriod = new System.Windows.Forms.TextBox();
            this.dtpLoanStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLoanEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateTransactionAccount
            // 
            this.btnCreateTransactionAccount.Location = new System.Drawing.Point(24, 612);
            this.btnCreateTransactionAccount.Name = "btnCreateTransactionAccount";
            this.btnCreateTransactionAccount.Size = new System.Drawing.Size(159, 35);
            this.btnCreateTransactionAccount.TabIndex = 0;
            this.btnCreateTransactionAccount.Text = "Create Transaction Account";
            this.btnCreateTransactionAccount.UseVisualStyleBackColor = true;
            this.btnCreateTransactionAccount.Click += new System.EventHandler(this.btnCreateTransactionAccount_Click);
            // 
            // btnCreateDepositAccount
            // 
            this.btnCreateDepositAccount.Location = new System.Drawing.Point(224, 612);
            this.btnCreateDepositAccount.Name = "btnCreateDepositAccount";
            this.btnCreateDepositAccount.Size = new System.Drawing.Size(128, 35);
            this.btnCreateDepositAccount.TabIndex = 1;
            this.btnCreateDepositAccount.Text = "Create Deposit Account";
            this.btnCreateDepositAccount.UseVisualStyleBackColor = true;
            this.btnCreateDepositAccount.Click += new System.EventHandler(this.btnCreateDepositAccount_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(76, 18);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtCurrency.TabIndex = 2;
            this.txtCurrency.Text = "MKD";
            this.txtCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(252, 18);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 20);
            this.txtLimit.TabIndex = 3;
            this.txtLimit.Text = "10000";
            this.txtLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(21, 25);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 4;
            this.lblCurrency.Text = "Currency";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(197, 25);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(28, 13);
            this.lblLimit.TabIndex = 5;
            this.lblLimit.Text = "Limit";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(24, 79);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(85, 73);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(115, 20);
            this.dtpStartDate.TabIndex = 7;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(24, 105);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(85, 99);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(115, 20);
            this.dtpEndDate.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDUnits);
            this.groupBox1.Controls.Add(this.lblUnits);
            this.groupBox1.Controls.Add(this.lblPeriodValue);
            this.groupBox1.Controls.Add(this.txtPeriodValue);
            this.groupBox1.Location = new System.Drawing.Point(27, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit Acc Period";
            // 
            // cmbDUnits
            // 
            this.cmbDUnits.FormattingEnabled = true;
            this.cmbDUnits.Location = new System.Drawing.Point(58, 76);
            this.cmbDUnits.Name = "cmbDUnits";
            this.cmbDUnits.Size = new System.Drawing.Size(75, 21);
            this.cmbDUnits.TabIndex = 4;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(17, 76);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(31, 13);
            this.lblUnits.TabIndex = 3;
            this.lblUnits.Text = "Units";
            // 
            // lblPeriodValue
            // 
            this.lblPeriodValue.AutoSize = true;
            this.lblPeriodValue.Location = new System.Drawing.Point(17, 35);
            this.lblPeriodValue.Name = "lblPeriodValue";
            this.lblPeriodValue.Size = new System.Drawing.Size(34, 13);
            this.lblPeriodValue.TabIndex = 2;
            this.lblPeriodValue.Text = "Value";
            // 
            // txtPeriodValue
            // 
            this.txtPeriodValue.Location = new System.Drawing.Point(58, 29);
            this.txtPeriodValue.Name = "txtPeriodValue";
            this.txtPeriodValue.Size = new System.Drawing.Size(75, 20);
            this.txtPeriodValue.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDUnits1);
            this.groupBox2.Controls.Add(this.lblInterestUnit);
            this.groupBox2.Controls.Add(this.lblInterestValue);
            this.groupBox2.Controls.Add(this.txtInterestValue);
            this.groupBox2.Location = new System.Drawing.Point(182, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 108);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposit Acc Interest Rate";
            // 
            // cmbDUnits1
            // 
            this.cmbDUnits1.FormattingEnabled = true;
            this.cmbDUnits1.Location = new System.Drawing.Point(63, 72);
            this.cmbDUnits1.Name = "cmbDUnits1";
            this.cmbDUnits1.Size = new System.Drawing.Size(60, 21);
            this.cmbDUnits1.TabIndex = 4;
            // 
            // lblInterestUnit
            // 
            this.lblInterestUnit.AutoSize = true;
            this.lblInterestUnit.Location = new System.Drawing.Point(23, 72);
            this.lblInterestUnit.Name = "lblInterestUnit";
            this.lblInterestUnit.Size = new System.Drawing.Size(31, 13);
            this.lblInterestUnit.TabIndex = 3;
            this.lblInterestUnit.Text = "Units";
            // 
            // lblInterestValue
            // 
            this.lblInterestValue.AutoSize = true;
            this.lblInterestValue.Location = new System.Drawing.Point(23, 32);
            this.lblInterestValue.Name = "lblInterestValue";
            this.lblInterestValue.Size = new System.Drawing.Size(34, 13);
            this.lblInterestValue.TabIndex = 2;
            this.lblInterestValue.Text = "Value";
            // 
            // txtInterestValue
            // 
            this.txtInterestValue.Location = new System.Drawing.Point(63, 29);
            this.txtInterestValue.Name = "txtInterestValue";
            this.txtInterestValue.Size = new System.Drawing.Size(60, 20);
            this.txtInterestValue.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 12;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(6, 33);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 13;
            // 
            // lblCurency
            // 
            this.lblCurency.AutoSize = true;
            this.lblCurency.Location = new System.Drawing.Point(6, 63);
            this.lblCurency.Name = "lblCurency";
            this.lblCurency.Size = new System.Drawing.Size(0, 13);
            this.lblCurency.TabIndex = 14;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(6, 84);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLimitCurrency);
            this.groupBox3.Controls.Add(this.lblTranLimit);
            this.groupBox3.Location = new System.Drawing.Point(188, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 100);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction account specific";
            // 
            // lblLimitCurrency
            // 
            this.lblLimitCurrency.AutoSize = true;
            this.lblLimitCurrency.Location = new System.Drawing.Point(44, 64);
            this.lblLimitCurrency.Name = "lblLimitCurrency";
            this.lblLimitCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblLimitCurrency.TabIndex = 1;
            // 
            // lblTranLimit
            // 
            this.lblTranLimit.AutoSize = true;
            this.lblTranLimit.Location = new System.Drawing.Point(44, 33);
            this.lblTranLimit.Name = "lblTranLimit";
            this.lblTranLimit.Size = new System.Drawing.Size(0, 13);
            this.lblTranLimit.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDEndDate);
            this.groupBox4.Controls.Add(this.lblDStartDate);
            this.groupBox4.Controls.Add(this.lblDInterest);
            this.groupBox4.Controls.Add(this.lblDperiod);
            this.groupBox4.Location = new System.Drawing.Point(378, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 100);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deposit Specific";
            // 
            // lblDEndDate
            // 
            this.lblDEndDate.AutoSize = true;
            this.lblDEndDate.Location = new System.Drawing.Point(164, 64);
            this.lblDEndDate.Name = "lblDEndDate";
            this.lblDEndDate.Size = new System.Drawing.Size(0, 13);
            this.lblDEndDate.TabIndex = 3;
            // 
            // lblDStartDate
            // 
            this.lblDStartDate.AutoSize = true;
            this.lblDStartDate.Location = new System.Drawing.Point(164, 20);
            this.lblDStartDate.Name = "lblDStartDate";
            this.lblDStartDate.Size = new System.Drawing.Size(0, 13);
            this.lblDStartDate.TabIndex = 2;
            // 
            // lblDInterest
            // 
            this.lblDInterest.AutoSize = true;
            this.lblDInterest.Location = new System.Drawing.Point(10, 64);
            this.lblDInterest.Name = "lblDInterest";
            this.lblDInterest.Size = new System.Drawing.Size(0, 13);
            this.lblDInterest.TabIndex = 1;
            // 
            // lblDperiod
            // 
            this.lblDperiod.AutoSize = true;
            this.lblDperiod.Location = new System.Drawing.Point(7, 20);
            this.lblDperiod.Name = "lblDperiod";
            this.lblDperiod.Size = new System.Drawing.Size(0, 13);
            this.lblDperiod.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblId);
            this.groupBox5.Controls.Add(this.lblNumber);
            this.groupBox5.Controls.Add(this.lblCurency);
            this.groupBox5.Controls.Add(this.lblBalance);
            this.groupBox5.Location = new System.Drawing.Point(9, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(148, 100);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Account common";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblIdTo);
            this.groupBox6.Controls.Add(this.lblNumberTo);
            this.groupBox6.Controls.Add(this.lblCurencyTo);
            this.groupBox6.Controls.Add(this.lblBalanceTo);
            this.groupBox6.Location = new System.Drawing.Point(9, 419);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(148, 100);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Account common";
            // 
            // lblIdTo
            // 
            this.lblIdTo.AutoSize = true;
            this.lblIdTo.Location = new System.Drawing.Point(6, 16);
            this.lblIdTo.Name = "lblIdTo";
            this.lblIdTo.Size = new System.Drawing.Size(0, 13);
            this.lblIdTo.TabIndex = 12;
            // 
            // lblNumberTo
            // 
            this.lblNumberTo.AutoSize = true;
            this.lblNumberTo.Location = new System.Drawing.Point(6, 33);
            this.lblNumberTo.Name = "lblNumberTo";
            this.lblNumberTo.Size = new System.Drawing.Size(0, 13);
            this.lblNumberTo.TabIndex = 13;
            // 
            // lblCurencyTo
            // 
            this.lblCurencyTo.AutoSize = true;
            this.lblCurencyTo.Location = new System.Drawing.Point(6, 63);
            this.lblCurencyTo.Name = "lblCurencyTo";
            this.lblCurencyTo.Size = new System.Drawing.Size(0, 13);
            this.lblCurencyTo.TabIndex = 14;
            // 
            // lblBalanceTo
            // 
            this.lblBalanceTo.AutoSize = true;
            this.lblBalanceTo.Location = new System.Drawing.Point(6, 84);
            this.lblBalanceTo.Name = "lblBalanceTo";
            this.lblBalanceTo.Size = new System.Drawing.Size(0, 13);
            this.lblBalanceTo.TabIndex = 15;
            // 
            // btnMakeTransaction
            // 
            this.btnMakeTransaction.Location = new System.Drawing.Point(12, 381);
            this.btnMakeTransaction.Name = "btnMakeTransaction";
            this.btnMakeTransaction.Size = new System.Drawing.Size(130, 23);
            this.btnMakeTransaction.TabIndex = 22;
            this.btnMakeTransaction.Text = "Make Transaction";
            this.btnMakeTransaction.UseVisualStyleBackColor = true;
            this.btnMakeTransaction.Click += new System.EventHandler(this.btnMakeTransaction_Click);
            // 
            // btnMakeGroupTransaction
            // 
            this.btnMakeGroupTransaction.Location = new System.Drawing.Point(388, 612);
            this.btnMakeGroupTransaction.Name = "btnMakeGroupTransaction";
            this.btnMakeGroupTransaction.Size = new System.Drawing.Size(126, 35);
            this.btnMakeGroupTransaction.TabIndex = 23;
            this.btnMakeGroupTransaction.Text = "Make Group Transaction";
            this.btnMakeGroupTransaction.UseVisualStyleBackColor = true;
            this.btnMakeGroupTransaction.Click += new System.EventHandler(this.btnMakeGroupTransaction_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(200, 391);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 25;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblEntryStatus);
            this.groupBox7.Controls.Add(this.lblEntryCurrency);
            this.groupBox7.Controls.Add(this.lblEntryAmount);
            this.groupBox7.Controls.Add(this.lblType);
            this.groupBox7.Location = new System.Drawing.Point(188, 419);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(172, 133);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Log Entry(last transaction)";
            // 
            // lblEntryStatus
            // 
            this.lblEntryStatus.AutoSize = true;
            this.lblEntryStatus.Location = new System.Drawing.Point(12, 117);
            this.lblEntryStatus.Name = "lblEntryStatus";
            this.lblEntryStatus.Size = new System.Drawing.Size(0, 13);
            this.lblEntryStatus.TabIndex = 3;
            // 
            // lblEntryCurrency
            // 
            this.lblEntryCurrency.AutoSize = true;
            this.lblEntryCurrency.Location = new System.Drawing.Point(12, 84);
            this.lblEntryCurrency.Name = "lblEntryCurrency";
            this.lblEntryCurrency.Size = new System.Drawing.Size(0, 13);
            this.lblEntryCurrency.TabIndex = 2;
            // 
            // lblEntryAmount
            // 
            this.lblEntryAmount.AutoSize = true;
            this.lblEntryAmount.Location = new System.Drawing.Point(12, 52);
            this.lblEntryAmount.Name = "lblEntryAmount";
            this.lblEntryAmount.Size = new System.Drawing.Size(0, 13);
            this.lblEntryAmount.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 13);
            this.lblType.TabIndex = 0;
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.Location = new System.Drawing.Point(511, 419);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTransactionAmount.TabIndex = 27;
            // 
            // txtTransactionCurrency
            // 
            this.txtTransactionCurrency.Location = new System.Drawing.Point(511, 471);
            this.txtTransactionCurrency.Name = "txtTransactionCurrency";
            this.txtTransactionCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtTransactionCurrency.TabIndex = 28;
            // 
            // btnChargeFee
            // 
            this.btnChargeFee.Location = new System.Drawing.Point(24, 573);
            this.btnChargeFee.Name = "btnChargeFee";
            this.btnChargeFee.Size = new System.Drawing.Size(75, 23);
            this.btnChargeFee.TabIndex = 29;
            this.btnChargeFee.Text = "Charge Fee";
            this.btnChargeFee.UseVisualStyleBackColor = true;
            this.btnChargeFee.Click += new System.EventHandler(this.btnChargeFee_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.cmbLUnit1);
            this.groupBox8.Controls.Add(this.cmbLUnit);
            this.groupBox8.Controls.Add(this.txtLoanInterest);
            this.groupBox8.Controls.Add(this.txtLoanPeriod);
            this.groupBox8.Location = new System.Drawing.Point(356, 130);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(281, 108);
            this.groupBox8.TabIndex = 30;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Loan Account";
            // 
            // cmbLUnit1
            // 
            this.cmbLUnit1.FormattingEnabled = true;
            this.cmbLUnit1.Location = new System.Drawing.Point(178, 72);
            this.cmbLUnit1.Name = "cmbLUnit1";
            this.cmbLUnit1.Size = new System.Drawing.Size(62, 21);
            this.cmbLUnit1.TabIndex = 3;
            // 
            // cmbLUnit
            // 
            this.cmbLUnit.FormattingEnabled = true;
            this.cmbLUnit.Location = new System.Drawing.Point(61, 73);
            this.cmbLUnit.Name = "cmbLUnit";
            this.cmbLUnit.Size = new System.Drawing.Size(49, 21);
            this.cmbLUnit.TabIndex = 2;
            // 
            // txtLoanInterest
            // 
            this.txtLoanInterest.Location = new System.Drawing.Point(178, 29);
            this.txtLoanInterest.Name = "txtLoanInterest";
            this.txtLoanInterest.Size = new System.Drawing.Size(62, 20);
            this.txtLoanInterest.TabIndex = 1;
            // 
            // txtLoanPeriod
            // 
            this.txtLoanPeriod.Location = new System.Drawing.Point(61, 29);
            this.txtLoanPeriod.Name = "txtLoanPeriod";
            this.txtLoanPeriod.Size = new System.Drawing.Size(49, 20);
            this.txtLoanPeriod.TabIndex = 0;
            // 
            // dtpLoanStartDate
            // 
            this.dtpLoanStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLoanStartDate.Location = new System.Drawing.Point(501, 72);
            this.dtpLoanStartDate.Name = "dtpLoanStartDate";
            this.dtpLoanStartDate.Size = new System.Drawing.Size(95, 20);
            this.dtpLoanStartDate.TabIndex = 31;
            // 
            // dtpLoanEndDate
            // 
            this.dtpLoanEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLoanEndDate.Location = new System.Drawing.Point(501, 98);
            this.dtpLoanEndDate.Name = "dtpLoanEndDate";
            this.dtpLoanEndDate.Size = new System.Drawing.Size(95, 20);
            this.dtpLoanEndDate.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Loan Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Loan End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Transfer Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Transfer Currency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Period";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Units";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Interest";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Units";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 38;
            this.button1.Text = "Add to transaction account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 680);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLoanEndDate);
            this.Controls.Add(this.dtpLoanStartDate);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnChargeFee);
            this.Controls.Add(this.txtTransactionCurrency);
            this.Controls.Add(this.txtTransactionAmount);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnMakeGroupTransaction);
            this.Controls.Add(this.btnMakeTransaction);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.btnCreateDepositAccount);
            this.Controls.Add(this.btnCreateTransactionAccount);
            this.Name = "frmMain";
            this.Text = "Account Details Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTransactionAccount;
        private System.Windows.Forms.Button btnCreateDepositAccount;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblPeriodValue;
        private System.Windows.Forms.TextBox txtPeriodValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblInterestUnit;
        private System.Windows.Forms.Label lblInterestValue;
        private System.Windows.Forms.TextBox txtInterestValue;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCurency;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLimitCurrency;
        private System.Windows.Forms.Label lblTranLimit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDEndDate;
        private System.Windows.Forms.Label lblDStartDate;
        private System.Windows.Forms.Label lblDInterest;
        private System.Windows.Forms.Label lblDperiod;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblIdTo;
        private System.Windows.Forms.Label lblNumberTo;
        private System.Windows.Forms.Label lblCurencyTo;
        private System.Windows.Forms.Label lblBalanceTo;
        private System.Windows.Forms.Button btnMakeTransaction;
        private System.Windows.Forms.Button btnMakeGroupTransaction;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblEntryAmount;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblEntryCurrency;
        private System.Windows.Forms.Label lblEntryStatus;
        private System.Windows.Forms.TextBox txtTransactionAmount;
        private System.Windows.Forms.TextBox txtTransactionCurrency;
        private System.Windows.Forms.Button btnChargeFee;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtLoanInterest;
        private System.Windows.Forms.TextBox txtLoanPeriod;
        private System.Windows.Forms.DateTimePicker dtpLoanStartDate;
        private System.Windows.Forms.DateTimePicker dtpLoanEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDUnits;
        private System.Windows.Forms.ComboBox cmbDUnits1;
        private System.Windows.Forms.ComboBox cmbLUnit1;
        private System.Windows.Forms.ComboBox cmbLUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

