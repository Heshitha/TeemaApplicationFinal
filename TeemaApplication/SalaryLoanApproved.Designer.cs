namespace TeemaApplication
{
    partial class frmSalaryLoanApproved
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStartingDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtRequestedAmount = new System.Windows.Forms.TextBox();
            this.txtLoanID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtInstallmentAmount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNumberOfMonths = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFixedIncentiveAllowance = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDayWages = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEpfSalary = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gdvLoanList = new System.Windows.Forms.DataGridView();
            this.clm_Token_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRequestedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDeduction_Amount_in_Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNumber_of_Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnApproved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnApproved = new System.Windows.Forms.Button();
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
            this.chbUnApprovedOnly = new System.Windows.Forms.CheckBox();
            this.lblFormTopic = new System.Windows.Forms.Label();
            this.chbSearchFromSubDepartment = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLoanList)).BeginInit();
            this.gbxEmployeeDetails.SuspendLayout();
            this.gbxDepartmentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(305, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 308);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary Loan Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStartingDate);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtRequestedAmount);
            this.groupBox2.Controls.Add(this.txtLoanID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 97);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // txtStartingDate
            // 
            this.txtStartingDate.Location = new System.Drawing.Point(152, 70);
            this.txtStartingDate.Name = "txtStartingDate";
            this.txtStartingDate.ReadOnly = true;
            this.txtStartingDate.Size = new System.Drawing.Size(128, 20);
            this.txtStartingDate.TabIndex = 29;
            this.txtStartingDate.TabStop = false;
            this.txtStartingDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // txtRequestedAmount
            // 
            this.txtRequestedAmount.Location = new System.Drawing.Point(152, 44);
            this.txtRequestedAmount.Name = "txtRequestedAmount";
            this.txtRequestedAmount.ReadOnly = true;
            this.txtRequestedAmount.Size = new System.Drawing.Size(128, 20);
            this.txtRequestedAmount.TabIndex = 27;
            this.txtRequestedAmount.TabStop = false;
            this.txtRequestedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLoanID
            // 
            this.txtLoanID.Location = new System.Drawing.Point(152, 17);
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.ReadOnly = true;
            this.txtLoanID.Size = new System.Drawing.Size(128, 20);
            this.txtLoanID.TabIndex = 18;
            this.txtLoanID.TabStop = false;
            this.txtLoanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.groupBox3.Controls.Add(this.txtInstallmentAmount);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtNumberOfMonths);
            this.groupBox3.Location = new System.Drawing.Point(6, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 72);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Installment Details";
            // 
            // txtInstallmentAmount
            // 
            this.txtInstallmentAmount.Location = new System.Drawing.Point(152, 19);
            this.txtInstallmentAmount.Name = "txtInstallmentAmount";
            this.txtInstallmentAmount.ReadOnly = true;
            this.txtInstallmentAmount.Size = new System.Drawing.Size(128, 20);
            this.txtInstallmentAmount.TabIndex = 21;
            this.txtInstallmentAmount.TabStop = false;
            this.txtInstallmentAmount.Text = "0";
            this.txtInstallmentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // txtNumberOfMonths
            // 
            this.txtNumberOfMonths.Location = new System.Drawing.Point(152, 45);
            this.txtNumberOfMonths.Name = "txtNumberOfMonths";
            this.txtNumberOfMonths.ReadOnly = true;
            this.txtNumberOfMonths.Size = new System.Drawing.Size(128, 20);
            this.txtNumberOfMonths.TabIndex = 23;
            this.txtNumberOfMonths.TabStop = false;
            this.txtNumberOfMonths.Text = "0";
            this.txtNumberOfMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFixedIncentiveAllowance);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtDayWages);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtEpfSalary);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(6, 122);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 100);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deduction From";
            // 
            // txtFixedIncentiveAllowance
            // 
            this.txtFixedIncentiveAllowance.Location = new System.Drawing.Point(152, 71);
            this.txtFixedIncentiveAllowance.Name = "txtFixedIncentiveAllowance";
            this.txtFixedIncentiveAllowance.ReadOnly = true;
            this.txtFixedIncentiveAllowance.Size = new System.Drawing.Size(128, 20);
            this.txtFixedIncentiveAllowance.TabIndex = 17;
            this.txtFixedIncentiveAllowance.TabStop = false;
            this.txtFixedIncentiveAllowance.Text = "0";
            this.txtFixedIncentiveAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // txtDayWages
            // 
            this.txtDayWages.Location = new System.Drawing.Point(152, 45);
            this.txtDayWages.Name = "txtDayWages";
            this.txtDayWages.ReadOnly = true;
            this.txtDayWages.Size = new System.Drawing.Size(128, 20);
            this.txtDayWages.TabIndex = 15;
            this.txtDayWages.TabStop = false;
            this.txtDayWages.Text = "0";
            this.txtDayWages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // txtEpfSalary
            // 
            this.txtEpfSalary.Location = new System.Drawing.Point(152, 19);
            this.txtEpfSalary.Name = "txtEpfSalary";
            this.txtEpfSalary.ReadOnly = true;
            this.txtEpfSalary.Size = new System.Drawing.Size(128, 20);
            this.txtEpfSalary.TabIndex = 13;
            this.txtEpfSalary.TabStop = false;
            this.txtEpfSalary.Text = "0";
            this.txtEpfSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // gdvLoanList
            // 
            this.gdvLoanList.AllowUserToAddRows = false;
            this.gdvLoanList.AllowUserToDeleteRows = false;
            this.gdvLoanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvLoanList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Token_No,
            this.clmnEmployeeName,
            this.clmnLoanID,
            this.clmnRequestedAmount,
            this.clmnDeduction_Amount_in_Month,
            this.clmnNumber_of_Month,
            this.clmnApproved});
            this.gdvLoanList.Location = new System.Drawing.Point(12, 386);
            this.gdvLoanList.Name = "gdvLoanList";
            this.gdvLoanList.ReadOnly = true;
            this.gdvLoanList.RowHeadersVisible = false;
            this.gdvLoanList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvLoanList.Size = new System.Drawing.Size(591, 244);
            this.gdvLoanList.TabIndex = 30;
            this.gdvLoanList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvLoanList_CellClick);
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
            this.clmnEmployeeName.DataPropertyName = "Name";
            this.clmnEmployeeName.HeaderText = "Employee Name";
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            this.clmnEmployeeName.ReadOnly = true;
            // 
            // clmnLoanID
            // 
            this.clmnLoanID.DataPropertyName = "LoanID";
            this.clmnLoanID.HeaderText = "Loan ID";
            this.clmnLoanID.Name = "clmnLoanID";
            this.clmnLoanID.ReadOnly = true;
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
            this.clmnDeduction_Amount_in_Month.DataPropertyName = "InstallmentAmount";
            this.clmnDeduction_Amount_in_Month.HeaderText = "Installment Amount";
            this.clmnDeduction_Amount_in_Month.Name = "clmnDeduction_Amount_in_Month";
            this.clmnDeduction_Amount_in_Month.ReadOnly = true;
            // 
            // clmnNumber_of_Month
            // 
            this.clmnNumber_of_Month.DataPropertyName = "NoOfInstallment";
            this.clmnNumber_of_Month.HeaderText = "Number of Month";
            this.clmnNumber_of_Month.Name = "clmnNumber_of_Month";
            this.clmnNumber_of_Month.ReadOnly = true;
            // 
            // clmnApproved
            // 
            this.clmnApproved.DataPropertyName = "IsApproved";
            this.clmnApproved.HeaderText = "Is Approved";
            this.clmnApproved.Name = "clmnApproved";
            this.clmnApproved.ReadOnly = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(528, 357);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnApproved
            // 
            this.btnApproved.Location = new System.Drawing.Point(447, 357);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(75, 23);
            this.btnApproved.TabIndex = 28;
            this.btnApproved.Text = "Approve";
            this.btnApproved.UseVisualStyleBackColor = true;
            this.btnApproved.Click += new System.EventHandler(this.btnApproved_Click);
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
            this.gbxEmployeeDetails.Location = new System.Drawing.Point(12, 192);
            this.gbxEmployeeDetails.Name = "gbxEmployeeDetails";
            this.gbxEmployeeDetails.Size = new System.Drawing.Size(287, 153);
            this.gbxEmployeeDetails.TabIndex = 27;
            this.gbxEmployeeDetails.TabStop = false;
            this.gbxEmployeeDetails.Text = "Employee Details";
            // 
            // txtToken_No
            // 
            this.txtToken_No.Location = new System.Drawing.Point(97, 124);
            this.txtToken_No.Name = "txtToken_No";
            this.txtToken_No.ReadOnly = true;
            this.txtToken_No.Size = new System.Drawing.Size(184, 20);
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
            this.txtEPF_No.Location = new System.Drawing.Point(97, 98);
            this.txtEPF_No.Name = "txtEPF_No";
            this.txtEPF_No.ReadOnly = true;
            this.txtEPF_No.Size = new System.Drawing.Size(184, 20);
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
            this.txtNIC_No.Location = new System.Drawing.Point(97, 71);
            this.txtNIC_No.Name = "txtNIC_No";
            this.txtNIC_No.ReadOnly = true;
            this.txtNIC_No.Size = new System.Drawing.Size(184, 20);
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
            this.txtDesignation.Location = new System.Drawing.Point(97, 45);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.ReadOnly = true;
            this.txtDesignation.Size = new System.Drawing.Size(184, 20);
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
            this.txtEmployeeName.Location = new System.Drawing.Point(97, 19);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(184, 20);
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
            this.gbxDepartmentDetails.Controls.Add(this.label1);
            this.gbxDepartmentDetails.Controls.Add(this.cmbSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.chbUnApprovedOnly);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(287, 143);
            this.gbxDepartmentDetails.TabIndex = 26;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // chbUnApprovedOnly
            // 
            this.chbUnApprovedOnly.AutoSize = true;
            this.chbUnApprovedOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUnApprovedOnly.Location = new System.Drawing.Point(97, 121);
            this.chbUnApprovedOnly.Name = "chbUnApprovedOnly";
            this.chbUnApprovedOnly.Size = new System.Drawing.Size(109, 17);
            this.chbUnApprovedOnly.TabIndex = 22;
            this.chbUnApprovedOnly.Text = "Unapproved Only";
            this.chbUnApprovedOnly.UseVisualStyleBackColor = true;
            this.chbUnApprovedOnly.CheckedChanged += new System.EventHandler(this.chbUnApprovedOnly_CheckedChanged);
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(266, 31);
            this.lblFormTopic.TabIndex = 25;
            this.lblFormTopic.Text = "Salary Loan Approve";
            // 
            // chbSearchFromSubDepartment
            // 
            this.chbSearchFromSubDepartment.AutoSize = true;
            this.chbSearchFromSubDepartment.Location = new System.Drawing.Point(97, 71);
            this.chbSearchFromSubDepartment.Name = "chbSearchFromSubDepartment";
            this.chbSearchFromSubDepartment.Size = new System.Drawing.Size(166, 17);
            this.chbSearchFromSubDepartment.TabIndex = 29;
            this.chbSearchFromSubDepartment.Text = "Search From Sub Department";
            this.chbSearchFromSubDepartment.UseVisualStyleBackColor = true;
            this.chbSearchFromSubDepartment.CheckedChanged += new System.EventHandler(this.chbSearchFromSubDepartment_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Sub Department";
            // 
            // cmbSubDepartment
            // 
            this.cmbSubDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSubDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubDepartment.Enabled = false;
            this.cmbSubDepartment.FormattingEnabled = true;
            this.cmbSubDepartment.Location = new System.Drawing.Point(97, 94);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(184, 21);
            this.cmbSubDepartment.TabIndex = 26;
            this.cmbSubDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbSubDepartment_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(7, 47);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 27;
            this.lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(97, 44);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(184, 21);
            this.cmbDepartment.TabIndex = 25;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbWorkingBranch
            // 
            this.cmbWorkingBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWorkingBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWorkingBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkingBranch.FormattingEnabled = true;
            this.cmbWorkingBranch.Location = new System.Drawing.Point(97, 19);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(184, 21);
            this.cmbWorkingBranch.TabIndex = 24;
            this.cmbWorkingBranch.SelectedIndexChanged += new System.EventHandler(this.cmbWorkingBranch_SelectedIndexChanged);
            // 
            // lblWorkingBranch
            // 
            this.lblWorkingBranch.AutoSize = true;
            this.lblWorkingBranch.Location = new System.Drawing.Point(7, 22);
            this.lblWorkingBranch.Name = "lblWorkingBranch";
            this.lblWorkingBranch.Size = new System.Drawing.Size(84, 13);
            this.lblWorkingBranch.TabIndex = 23;
            this.lblWorkingBranch.Text = "Working Branch";
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
            this.btnClose.Location = new System.Drawing.Point(575, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 32;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSalaryLoanApproved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 642);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gdvLoanList);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnApproved);
            this.Controls.Add(this.gbxEmployeeDetails);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalaryLoanApproved";
            this.Text = "SalaryLoanApproved";
            this.Load += new System.EventHandler(this.frmSalaryLoanApproved_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSalaryLoanApproved_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvLoanList)).EndInit();
            this.gbxEmployeeDetails.ResumeLayout(false);
            this.gbxEmployeeDetails.PerformLayout();
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStartingDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtRequestedAmount;
        private System.Windows.Forms.TextBox txtLoanID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtInstallmentAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNumberOfMonths;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFixedIncentiveAllowance;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDayWages;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEpfSalary;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView gdvLoanList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Token_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRequestedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDeduction_Amount_in_Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNumber_of_Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnApproved;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnApproved;
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
        private System.Windows.Forms.CheckBox chbUnApprovedOnly;
        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.CheckBox chbSearchFromSubDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.Button btnClose;
    }
}