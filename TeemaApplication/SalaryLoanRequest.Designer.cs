namespace TeemaApplication
{
    partial class frmSalaryLoanRequest
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
            this.lblFormTopic = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCSLStartingDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCSLRequestedAmount = new System.Windows.Forms.TextBox();
            this.txtCSLLoanID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCSLInstallmentAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCSLNumberOfMonths = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCSLFixedIncentiveAllowance = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCSLDayWages = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCSLEpfSalary = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gdvLoanDetails = new System.Windows.Forms.DataGridView();
            this.clm_Token_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRequestedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDeduction_Amount_in_Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNumber_of_Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnIsApproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxSalary_Loan = new System.Windows.Forms.GroupBox();
            this.gbxOtherDetails = new System.Windows.Forms.GroupBox();
            this.txtRequested_Amount = new System.Windows.Forms.TextBox();
            this.dtpStarting_Date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxInstallmentDetails = new System.Windows.Forms.GroupBox();
            this.txtDeductionAmountinMonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumber_of_Month = new System.Windows.Forms.TextBox();
            this.gbxDeductionFrom = new System.Windows.Forms.GroupBox();
            this.txtFixedIncentiveAllowance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDayWages = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalFromEPFSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.txtToken_No = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEPF_No = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNIC_No = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.gbxFilterBy = new System.Windows.Forms.GroupBox();
            this.chbUnFinished = new System.Windows.Forms.CheckBox();
            this.chbUnApproved = new System.Windows.Forms.CheckBox();
            this.chbFinished = new System.Windows.Forms.CheckBox();
            this.chbApproved = new System.Windows.Forms.CheckBox();
            this.chbSearchFromSubDepartment = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLoanDetails)).BeginInit();
            this.gbxSalary_Loan.SuspendLayout();
            this.gbxOtherDetails.SuspendLayout();
            this.gbxInstallmentDetails.SuspendLayout();
            this.gbxDeductionFrom.SuspendLayout();
            this.gbxEmployeeDetails.SuspendLayout();
            this.gbxDepartmentDetails.SuspendLayout();
            this.gbxFilterBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(267, 31);
            this.lblFormTopic.TabIndex = 3;
            this.lblFormTopic.Text = "Salary Loan Request";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::TeemaApplication.Properties.Resources.Notification_Boxes_03;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(879, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(305, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 308);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Created Salary Loan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCSLStartingDate);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtCSLRequestedAmount);
            this.groupBox2.Controls.Add(this.txtCSLLoanID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 97);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // txtCSLStartingDate
            // 
            this.txtCSLStartingDate.Location = new System.Drawing.Point(152, 70);
            this.txtCSLStartingDate.Name = "txtCSLStartingDate";
            this.txtCSLStartingDate.ReadOnly = true;
            this.txtCSLStartingDate.Size = new System.Drawing.Size(128, 20);
            this.txtCSLStartingDate.TabIndex = 29;
            this.txtCSLStartingDate.TabStop = false;
            this.txtCSLStartingDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Starting Date";
            // 
            // txtCSLRequestedAmount
            // 
            this.txtCSLRequestedAmount.Location = new System.Drawing.Point(152, 44);
            this.txtCSLRequestedAmount.Name = "txtCSLRequestedAmount";
            this.txtCSLRequestedAmount.ReadOnly = true;
            this.txtCSLRequestedAmount.Size = new System.Drawing.Size(128, 20);
            this.txtCSLRequestedAmount.TabIndex = 27;
            this.txtCSLRequestedAmount.TabStop = false;
            this.txtCSLRequestedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCSLLoanID
            // 
            this.txtCSLLoanID.Location = new System.Drawing.Point(152, 17);
            this.txtCSLLoanID.Name = "txtCSLLoanID";
            this.txtCSLLoanID.ReadOnly = true;
            this.txtCSLLoanID.Size = new System.Drawing.Size(128, 20);
            this.txtCSLLoanID.TabIndex = 18;
            this.txtCSLLoanID.TabStop = false;
            this.txtCSLLoanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Loan ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Requested Amount";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCSLInstallmentAmount);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtCSLNumberOfMonths);
            this.groupBox3.Location = new System.Drawing.Point(6, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 72);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Installment Details";
            // 
            // txtCSLInstallmentAmount
            // 
            this.txtCSLInstallmentAmount.Location = new System.Drawing.Point(152, 19);
            this.txtCSLInstallmentAmount.Name = "txtCSLInstallmentAmount";
            this.txtCSLInstallmentAmount.ReadOnly = true;
            this.txtCSLInstallmentAmount.Size = new System.Drawing.Size(128, 20);
            this.txtCSLInstallmentAmount.TabIndex = 21;
            this.txtCSLInstallmentAmount.TabStop = false;
            this.txtCSLInstallmentAmount.Text = "0";
            this.txtCSLInstallmentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Installment Amount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Number of Months";
            // 
            // txtCSLNumberOfMonths
            // 
            this.txtCSLNumberOfMonths.Location = new System.Drawing.Point(152, 45);
            this.txtCSLNumberOfMonths.Name = "txtCSLNumberOfMonths";
            this.txtCSLNumberOfMonths.ReadOnly = true;
            this.txtCSLNumberOfMonths.Size = new System.Drawing.Size(128, 20);
            this.txtCSLNumberOfMonths.TabIndex = 23;
            this.txtCSLNumberOfMonths.TabStop = false;
            this.txtCSLNumberOfMonths.Text = "0";
            this.txtCSLNumberOfMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCSLFixedIncentiveAllowance);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtCSLDayWages);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtCSLEpfSalary);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(6, 122);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 100);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deduction From";
            // 
            // txtCSLFixedIncentiveAllowance
            // 
            this.txtCSLFixedIncentiveAllowance.Location = new System.Drawing.Point(152, 71);
            this.txtCSLFixedIncentiveAllowance.Name = "txtCSLFixedIncentiveAllowance";
            this.txtCSLFixedIncentiveAllowance.ReadOnly = true;
            this.txtCSLFixedIncentiveAllowance.Size = new System.Drawing.Size(128, 20);
            this.txtCSLFixedIncentiveAllowance.TabIndex = 17;
            this.txtCSLFixedIncentiveAllowance.TabStop = false;
            this.txtCSLFixedIncentiveAllowance.Text = "0";
            this.txtCSLFixedIncentiveAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Fixed Incentive Allowance";
            // 
            // txtCSLDayWages
            // 
            this.txtCSLDayWages.Location = new System.Drawing.Point(152, 45);
            this.txtCSLDayWages.Name = "txtCSLDayWages";
            this.txtCSLDayWages.ReadOnly = true;
            this.txtCSLDayWages.Size = new System.Drawing.Size(128, 20);
            this.txtCSLDayWages.TabIndex = 15;
            this.txtCSLDayWages.TabStop = false;
            this.txtCSLDayWages.Text = "0";
            this.txtCSLDayWages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Day Wages";
            // 
            // txtCSLEpfSalary
            // 
            this.txtCSLEpfSalary.Location = new System.Drawing.Point(152, 19);
            this.txtCSLEpfSalary.Name = "txtCSLEpfSalary";
            this.txtCSLEpfSalary.ReadOnly = true;
            this.txtCSLEpfSalary.Size = new System.Drawing.Size(128, 20);
            this.txtCSLEpfSalary.TabIndex = 13;
            this.txtCSLEpfSalary.TabStop = false;
            this.txtCSLEpfSalary.Text = "0";
            this.txtCSLEpfSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Total From EPF Salary";
            // 
            // gdvLoanDetails
            // 
            this.gdvLoanDetails.AllowUserToAddRows = false;
            this.gdvLoanDetails.AllowUserToDeleteRows = false;
            this.gdvLoanDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvLoanDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvLoanDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Token_No,
            this.clmnEmployeeName,
            this.clmnLoanID,
            this.clmnRequestedAmount,
            this.clmnDeduction_Amount_in_Month,
            this.clmnNumber_of_Month,
            this.clmnIsApproved});
            this.gdvLoanDetails.Location = new System.Drawing.Point(305, 357);
            this.gdvLoanDetails.Name = "gdvLoanDetails";
            this.gdvLoanDetails.ReadOnly = true;
            this.gdvLoanDetails.RowHeadersVisible = false;
            this.gdvLoanDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvLoanDetails.Size = new System.Drawing.Size(602, 206);
            this.gdvLoanDetails.TabIndex = 24;
            // 
            // clm_Token_No
            // 
            this.clm_Token_No.DataPropertyName = "TokenNo";
            this.clm_Token_No.HeaderText = "Token No.";
            this.clm_Token_No.Name = "clm_Token_No";
            this.clm_Token_No.ReadOnly = true;
            // 
            // clmnEmployeeName
            // 
            this.clmnEmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnEmployeeName.DataPropertyName = "Name";
            this.clmnEmployeeName.HeaderText = "Employee Name";
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            this.clmnEmployeeName.ReadOnly = true;
            // 
            // clmnLoanID
            // 
            this.clmnLoanID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnLoanID.DataPropertyName = "LoanID";
            this.clmnLoanID.HeaderText = "Loan ID";
            this.clmnLoanID.Name = "clmnLoanID";
            this.clmnLoanID.ReadOnly = true;
            this.clmnLoanID.Width = 65;
            // 
            // clmnRequestedAmount
            // 
            this.clmnRequestedAmount.DataPropertyName = "RequestedAmount";
            this.clmnRequestedAmount.HeaderText = "Requested Amount";
            this.clmnRequestedAmount.Name = "clmnRequestedAmount";
            this.clmnRequestedAmount.ReadOnly = true;
            // 
            // clmnDeduction_Amount_in_Month
            // 
            this.clmnDeduction_Amount_in_Month.DataPropertyName = "DeductionAmount";
            this.clmnDeduction_Amount_in_Month.HeaderText = "Installment Amount";
            this.clmnDeduction_Amount_in_Month.Name = "clmnDeduction_Amount_in_Month";
            this.clmnDeduction_Amount_in_Month.ReadOnly = true;
            // 
            // clmnNumber_of_Month
            // 
            this.clmnNumber_of_Month.DataPropertyName = "NumberOfMonth";
            this.clmnNumber_of_Month.HeaderText = "Number of Month";
            this.clmnNumber_of_Month.Name = "clmnNumber_of_Month";
            this.clmnNumber_of_Month.ReadOnly = true;
            // 
            // clmnIsApproved
            // 
            this.clmnIsApproved.DataPropertyName = "IsApproved";
            this.clmnIsApproved.HeaderText = "Is Approved";
            this.clmnIsApproved.Name = "clmnIsApproved";
            this.clmnIsApproved.ReadOnly = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(832, 328);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(751, 328);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbxSalary_Loan
            // 
            this.gbxSalary_Loan.Controls.Add(this.gbxOtherDetails);
            this.gbxSalary_Loan.Controls.Add(this.gbxInstallmentDetails);
            this.gbxSalary_Loan.Controls.Add(this.gbxDeductionFrom);
            this.gbxSalary_Loan.Location = new System.Drawing.Point(609, 43);
            this.gbxSalary_Loan.Name = "gbxSalary_Loan";
            this.gbxSalary_Loan.Size = new System.Drawing.Size(298, 279);
            this.gbxSalary_Loan.TabIndex = 23;
            this.gbxSalary_Loan.TabStop = false;
            this.gbxSalary_Loan.Text = "New Salary Loan";
            // 
            // gbxOtherDetails
            // 
            this.gbxOtherDetails.Controls.Add(this.txtRequested_Amount);
            this.gbxOtherDetails.Controls.Add(this.dtpStarting_Date);
            this.gbxOtherDetails.Controls.Add(this.label9);
            this.gbxOtherDetails.Controls.Add(this.label1);
            this.gbxOtherDetails.Location = new System.Drawing.Point(6, 19);
            this.gbxOtherDetails.Name = "gbxOtherDetails";
            this.gbxOtherDetails.Size = new System.Drawing.Size(286, 72);
            this.gbxOtherDetails.TabIndex = 29;
            this.gbxOtherDetails.TabStop = false;
            // 
            // txtRequested_Amount
            // 
            this.txtRequested_Amount.Location = new System.Drawing.Point(152, 19);
            this.txtRequested_Amount.Name = "txtRequested_Amount";
            this.txtRequested_Amount.Size = new System.Drawing.Size(128, 20);
            this.txtRequested_Amount.TabIndex = 10;
            this.txtRequested_Amount.Text = "0";
            this.txtRequested_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpStarting_Date
            // 
            this.dtpStarting_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStarting_Date.Location = new System.Drawing.Point(152, 45);
            this.dtpStarting_Date.Name = "dtpStarting_Date";
            this.dtpStarting_Date.Size = new System.Drawing.Size(128, 20);
            this.dtpStarting_Date.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Starting Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Requested Amount";
            // 
            // gbxInstallmentDetails
            // 
            this.gbxInstallmentDetails.Controls.Add(this.txtDeductionAmountinMonth);
            this.gbxInstallmentDetails.Controls.Add(this.label2);
            this.gbxInstallmentDetails.Controls.Add(this.label10);
            this.gbxInstallmentDetails.Controls.Add(this.txtNumber_of_Month);
            this.gbxInstallmentDetails.Location = new System.Drawing.Point(6, 203);
            this.gbxInstallmentDetails.Name = "gbxInstallmentDetails";
            this.gbxInstallmentDetails.Size = new System.Drawing.Size(286, 72);
            this.gbxInstallmentDetails.TabIndex = 28;
            this.gbxInstallmentDetails.TabStop = false;
            this.gbxInstallmentDetails.Text = "Installment Details";
            // 
            // txtDeductionAmountinMonth
            // 
            this.txtDeductionAmountinMonth.Location = new System.Drawing.Point(152, 19);
            this.txtDeductionAmountinMonth.Name = "txtDeductionAmountinMonth";
            this.txtDeductionAmountinMonth.ReadOnly = true;
            this.txtDeductionAmountinMonth.Size = new System.Drawing.Size(128, 20);
            this.txtDeductionAmountinMonth.TabIndex = 21;
            this.txtDeductionAmountinMonth.TabStop = false;
            this.txtDeductionAmountinMonth.Text = "0";
            this.txtDeductionAmountinMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Installment Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Number of Months";
            // 
            // txtNumber_of_Month
            // 
            this.txtNumber_of_Month.Location = new System.Drawing.Point(152, 45);
            this.txtNumber_of_Month.Name = "txtNumber_of_Month";
            this.txtNumber_of_Month.ReadOnly = true;
            this.txtNumber_of_Month.Size = new System.Drawing.Size(128, 20);
            this.txtNumber_of_Month.TabIndex = 23;
            this.txtNumber_of_Month.TabStop = false;
            this.txtNumber_of_Month.Text = "0";
            this.txtNumber_of_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbxDeductionFrom
            // 
            this.gbxDeductionFrom.Controls.Add(this.txtFixedIncentiveAllowance);
            this.gbxDeductionFrom.Controls.Add(this.label8);
            this.gbxDeductionFrom.Controls.Add(this.txtDayWages);
            this.gbxDeductionFrom.Controls.Add(this.label5);
            this.gbxDeductionFrom.Controls.Add(this.txtTotalFromEPFSalary);
            this.gbxDeductionFrom.Controls.Add(this.label4);
            this.gbxDeductionFrom.Location = new System.Drawing.Point(6, 97);
            this.gbxDeductionFrom.Name = "gbxDeductionFrom";
            this.gbxDeductionFrom.Size = new System.Drawing.Size(286, 100);
            this.gbxDeductionFrom.TabIndex = 19;
            this.gbxDeductionFrom.TabStop = false;
            this.gbxDeductionFrom.Text = "Deduction From";
            // 
            // txtFixedIncentiveAllowance
            // 
            this.txtFixedIncentiveAllowance.Location = new System.Drawing.Point(152, 71);
            this.txtFixedIncentiveAllowance.Name = "txtFixedIncentiveAllowance";
            this.txtFixedIncentiveAllowance.Size = new System.Drawing.Size(128, 20);
            this.txtFixedIncentiveAllowance.TabIndex = 14;
            this.txtFixedIncentiveAllowance.Text = "0";
            this.txtFixedIncentiveAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fixed Incentive Allowance";
            // 
            // txtDayWages
            // 
            this.txtDayWages.Location = new System.Drawing.Point(152, 45);
            this.txtDayWages.Name = "txtDayWages";
            this.txtDayWages.Size = new System.Drawing.Size(128, 20);
            this.txtDayWages.TabIndex = 13;
            this.txtDayWages.Text = "0";
            this.txtDayWages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Day Wages";
            // 
            // txtTotalFromEPFSalary
            // 
            this.txtTotalFromEPFSalary.Location = new System.Drawing.Point(152, 19);
            this.txtTotalFromEPFSalary.Name = "txtTotalFromEPFSalary";
            this.txtTotalFromEPFSalary.Size = new System.Drawing.Size(128, 20);
            this.txtTotalFromEPFSalary.TabIndex = 12;
            this.txtTotalFromEPFSalary.Text = "0";
            this.txtTotalFromEPFSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total From EPF Salary";
            // 
            // gbxEmployeeDetails
            // 
            this.gbxEmployeeDetails.Controls.Add(this.txtToken_No);
            this.gbxEmployeeDetails.Controls.Add(this.label13);
            this.gbxEmployeeDetails.Controls.Add(this.txtEPF_No);
            this.gbxEmployeeDetails.Controls.Add(this.label12);
            this.gbxEmployeeDetails.Controls.Add(this.txtNIC_No);
            this.gbxEmployeeDetails.Controls.Add(this.label7);
            this.gbxEmployeeDetails.Controls.Add(this.txtDesignation);
            this.gbxEmployeeDetails.Controls.Add(this.label6);
            this.gbxEmployeeDetails.Controls.Add(this.txtEmployeeName);
            this.gbxEmployeeDetails.Controls.Add(this.label3);
            this.gbxEmployeeDetails.Location = new System.Drawing.Point(12, 246);
            this.gbxEmployeeDetails.Name = "gbxEmployeeDetails";
            this.gbxEmployeeDetails.Size = new System.Drawing.Size(287, 150);
            this.gbxEmployeeDetails.TabIndex = 22;
            this.gbxEmployeeDetails.TabStop = false;
            this.gbxEmployeeDetails.Text = "Employee Details";
            // 
            // txtToken_No
            // 
            this.txtToken_No.Location = new System.Drawing.Point(105, 124);
            this.txtToken_No.Name = "txtToken_No";
            this.txtToken_No.ReadOnly = true;
            this.txtToken_No.Size = new System.Drawing.Size(176, 20);
            this.txtToken_No.TabIndex = 23;
            this.txtToken_No.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Token No";
            // 
            // txtEPF_No
            // 
            this.txtEPF_No.Location = new System.Drawing.Point(105, 98);
            this.txtEPF_No.Name = "txtEPF_No";
            this.txtEPF_No.ReadOnly = true;
            this.txtEPF_No.Size = new System.Drawing.Size(176, 20);
            this.txtEPF_No.TabIndex = 18;
            this.txtEPF_No.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "EPF No.";
            // 
            // txtNIC_No
            // 
            this.txtNIC_No.Location = new System.Drawing.Point(105, 71);
            this.txtNIC_No.Name = "txtNIC_No";
            this.txtNIC_No.ReadOnly = true;
            this.txtNIC_No.Size = new System.Drawing.Size(176, 20);
            this.txtNIC_No.TabIndex = 16;
            this.txtNIC_No.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NIC No";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(105, 45);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.ReadOnly = true;
            this.txtDesignation.Size = new System.Drawing.Size(176, 20);
            this.txtDesignation.TabIndex = 14;
            this.txtDesignation.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Designation";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(105, 19);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(176, 20);
            this.txtEmployeeName.TabIndex = 9;
            this.txtEmployeeName.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee Name";
            // 
            // gbxDepartmentDetails
            // 
            this.gbxDepartmentDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDepartmentDetails.Controls.Add(this.chbSearchFromSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.label21);
            this.gbxDepartmentDetails.Controls.Add(this.cmbSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.gbxFilterBy);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(287, 197);
            this.gbxDepartmentDetails.TabIndex = 21;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // gbxFilterBy
            // 
            this.gbxFilterBy.Controls.Add(this.chbUnFinished);
            this.gbxFilterBy.Controls.Add(this.chbUnApproved);
            this.gbxFilterBy.Controls.Add(this.chbFinished);
            this.gbxFilterBy.Controls.Add(this.chbApproved);
            this.gbxFilterBy.Location = new System.Drawing.Point(96, 126);
            this.gbxFilterBy.Name = "gbxFilterBy";
            this.gbxFilterBy.Size = new System.Drawing.Size(185, 62);
            this.gbxFilterBy.TabIndex = 9;
            this.gbxFilterBy.TabStop = false;
            this.gbxFilterBy.Text = "Filter By";
            // 
            // chbUnFinished
            // 
            this.chbUnFinished.AutoSize = true;
            this.chbUnFinished.Checked = true;
            this.chbUnFinished.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbUnFinished.Location = new System.Drawing.Point(81, 18);
            this.chbUnFinished.Name = "chbUnFinished";
            this.chbUnFinished.Size = new System.Drawing.Size(82, 17);
            this.chbUnFinished.TabIndex = 5;
            this.chbUnFinished.Text = "Un Finished";
            this.chbUnFinished.UseVisualStyleBackColor = true;
            this.chbUnFinished.CheckedChanged += new System.EventHandler(this.chbUnFinished_CheckedChanged);
            // 
            // chbUnApproved
            // 
            this.chbUnApproved.AutoSize = true;
            this.chbUnApproved.Checked = true;
            this.chbUnApproved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbUnApproved.Location = new System.Drawing.Point(81, 41);
            this.chbUnApproved.Name = "chbUnApproved";
            this.chbUnApproved.Size = new System.Drawing.Size(89, 17);
            this.chbUnApproved.TabIndex = 7;
            this.chbUnApproved.Text = "Un Approved";
            this.chbUnApproved.UseVisualStyleBackColor = true;
            this.chbUnApproved.CheckedChanged += new System.EventHandler(this.chbUnApproved_CheckedChanged);
            // 
            // chbFinished
            // 
            this.chbFinished.AutoSize = true;
            this.chbFinished.Checked = true;
            this.chbFinished.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFinished.Location = new System.Drawing.Point(6, 18);
            this.chbFinished.Name = "chbFinished";
            this.chbFinished.Size = new System.Drawing.Size(65, 17);
            this.chbFinished.TabIndex = 4;
            this.chbFinished.Text = "Finished";
            this.chbFinished.UseVisualStyleBackColor = true;
            this.chbFinished.CheckedChanged += new System.EventHandler(this.chbFinished_CheckedChanged);
            // 
            // chbApproved
            // 
            this.chbApproved.AutoSize = true;
            this.chbApproved.Checked = true;
            this.chbApproved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbApproved.Location = new System.Drawing.Point(6, 41);
            this.chbApproved.Name = "chbApproved";
            this.chbApproved.Size = new System.Drawing.Size(72, 17);
            this.chbApproved.TabIndex = 6;
            this.chbApproved.Text = "Approved";
            this.chbApproved.UseVisualStyleBackColor = true;
            this.chbApproved.CheckedChanged += new System.EventHandler(this.chbApproved_CheckedChanged);
            // 
            // chbSearchFromSubDepartment
            // 
            this.chbSearchFromSubDepartment.AutoSize = true;
            this.chbSearchFromSubDepartment.Location = new System.Drawing.Point(96, 74);
            this.chbSearchFromSubDepartment.Name = "chbSearchFromSubDepartment";
            this.chbSearchFromSubDepartment.Size = new System.Drawing.Size(166, 17);
            this.chbSearchFromSubDepartment.TabIndex = 16;
            this.chbSearchFromSubDepartment.Text = "Search From Sub Department";
            this.chbSearchFromSubDepartment.UseVisualStyleBackColor = true;
            this.chbSearchFromSubDepartment.CheckedChanged += new System.EventHandler(this.chbSearchFromSubDepartment_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Sub Department";
            // 
            // cmbSubDepartment
            // 
            this.cmbSubDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSubDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubDepartment.Enabled = false;
            this.cmbSubDepartment.FormattingEnabled = true;
            this.cmbSubDepartment.Location = new System.Drawing.Point(96, 97);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(185, 21);
            this.cmbSubDepartment.TabIndex = 13;
            this.cmbSubDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbSubDepartment_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(6, 50);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 14;
            this.lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(96, 47);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(185, 21);
            this.cmbDepartment.TabIndex = 12;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbWorkingBranch
            // 
            this.cmbWorkingBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWorkingBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWorkingBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkingBranch.FormattingEnabled = true;
            this.cmbWorkingBranch.Location = new System.Drawing.Point(96, 19);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(185, 21);
            this.cmbWorkingBranch.TabIndex = 11;
            this.cmbWorkingBranch.SelectedIndexChanged += new System.EventHandler(this.cmbWorkingBranch_SelectedIndexChanged);
            // 
            // lblWorkingBranch
            // 
            this.lblWorkingBranch.AutoSize = true;
            this.lblWorkingBranch.Location = new System.Drawing.Point(6, 22);
            this.lblWorkingBranch.Name = "lblWorkingBranch";
            this.lblWorkingBranch.Size = new System.Drawing.Size(84, 13);
            this.lblWorkingBranch.TabIndex = 10;
            this.lblWorkingBranch.Text = "Working Branch";
            // 
            // frmSalaryLoanRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gdvLoanDetails);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxSalary_Loan);
            this.Controls.Add(this.gbxEmployeeDetails);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalaryLoanRequest";
            this.Text = "Salary Loan Request";
            this.Load += new System.EventHandler(this.frmSalaryLoanRequest_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSalaryLoanRequest_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLoanDetails)).EndInit();
            this.gbxSalary_Loan.ResumeLayout(false);
            this.gbxOtherDetails.ResumeLayout(false);
            this.gbxOtherDetails.PerformLayout();
            this.gbxInstallmentDetails.ResumeLayout(false);
            this.gbxInstallmentDetails.PerformLayout();
            this.gbxDeductionFrom.ResumeLayout(false);
            this.gbxDeductionFrom.PerformLayout();
            this.gbxEmployeeDetails.ResumeLayout(false);
            this.gbxEmployeeDetails.PerformLayout();
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.gbxFilterBy.ResumeLayout(false);
            this.gbxFilterBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCSLStartingDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCSLRequestedAmount;
        private System.Windows.Forms.TextBox txtCSLLoanID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCSLInstallmentAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCSLNumberOfMonths;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCSLFixedIncentiveAllowance;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCSLDayWages;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCSLEpfSalary;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView gdvLoanDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Token_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRequestedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDeduction_Amount_in_Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNumber_of_Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnIsApproved;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbxSalary_Loan;
        private System.Windows.Forms.GroupBox gbxOtherDetails;
        private System.Windows.Forms.TextBox txtRequested_Amount;
        private System.Windows.Forms.DateTimePicker dtpStarting_Date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxInstallmentDetails;
        private System.Windows.Forms.TextBox txtDeductionAmountinMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumber_of_Month;
        private System.Windows.Forms.GroupBox gbxDeductionFrom;
        private System.Windows.Forms.TextBox txtFixedIncentiveAllowance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDayWages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalFromEPFSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxEmployeeDetails;
        private System.Windows.Forms.TextBox txtToken_No;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEPF_No;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNIC_No;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.GroupBox gbxFilterBy;
        private System.Windows.Forms.CheckBox chbUnFinished;
        private System.Windows.Forms.CheckBox chbUnApproved;
        private System.Windows.Forms.CheckBox chbFinished;
        private System.Windows.Forms.CheckBox chbApproved;
        private System.Windows.Forms.CheckBox chbSearchFromSubDepartment;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
    }
}