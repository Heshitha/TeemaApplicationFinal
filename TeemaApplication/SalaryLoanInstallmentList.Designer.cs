namespace TeemaApplication
{
    partial class frmSalaryLoanInstallmentList
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gdvInstallmentList = new System.Windows.Forms.DataGridView();
            this.clmnPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLoanId = new System.Windows.Forms.ComboBox();
            this.txtStartingDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtRequestedAmount = new System.Windows.Forms.TextBox();
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
            this.gbxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.cmbTokenNo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.lblSubDepartment = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.lblFormTopic = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.chbSearchFromSubDepartment = new System.Windows.Forms.CheckBox();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvInstallmentList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbxEmployeeDetails.SuspendLayout();
            this.gbxDepartmentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPay);
            this.groupBox6.Controls.Add(this.txtAmount);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(305, 43);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(281, 75);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pay Loan Installment";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(200, 45);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 34;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(149, 19);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(126, 20);
            this.txtAmount.TabIndex = 31;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Amount";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gdvInstallmentList);
            this.groupBox5.Location = new System.Drawing.Point(305, 124);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(281, 486);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Installment List";
            // 
            // gdvInstallmentList
            // 
            this.gdvInstallmentList.AllowUserToAddRows = false;
            this.gdvInstallmentList.AllowUserToDeleteRows = false;
            this.gdvInstallmentList.AllowUserToOrderColumns = true;
            this.gdvInstallmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvInstallmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvInstallmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnPaymentDate,
            this.clmnPayment});
            this.gdvInstallmentList.Location = new System.Drawing.Point(7, 20);
            this.gdvInstallmentList.Name = "gdvInstallmentList";
            this.gdvInstallmentList.ReadOnly = true;
            this.gdvInstallmentList.RowHeadersVisible = false;
            this.gdvInstallmentList.Size = new System.Drawing.Size(268, 460);
            this.gdvInstallmentList.TabIndex = 0;
            // 
            // clmnPaymentDate
            // 
            this.clmnPaymentDate.DataPropertyName = "paymentDate";
            this.clmnPaymentDate.HeaderText = "Payment Date";
            this.clmnPaymentDate.Name = "clmnPaymentDate";
            this.clmnPaymentDate.ReadOnly = true;
            // 
            // clmnPayment
            // 
            this.clmnPayment.DataPropertyName = "payment";
            this.clmnPayment.HeaderText = "Payment";
            this.clmnPayment.Name = "clmnPayment";
            this.clmnPayment.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 332);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary Loan Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbLoanId);
            this.groupBox2.Controls.Add(this.txtStartingDate);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtRequestedAmount);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 122);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(143, 96);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(126, 20);
            this.txtStatus.TabIndex = 32;
            this.txtStatus.TabStop = false;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Status";
            // 
            // cmbLoanId
            // 
            this.cmbLoanId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanId.FormattingEnabled = true;
            this.cmbLoanId.Location = new System.Drawing.Point(143, 17);
            this.cmbLoanId.Name = "cmbLoanId";
            this.cmbLoanId.Size = new System.Drawing.Size(126, 21);
            this.cmbLoanId.TabIndex = 30;
            this.cmbLoanId.SelectedIndexChanged += new System.EventHandler(this.cmbLoanId_SelectedIndexChanged);
            this.cmbLoanId.DataSourceChanged += new System.EventHandler(this.cmbLoanId_DataSourceChanged);
            // 
            // txtStartingDate
            // 
            this.txtStartingDate.Location = new System.Drawing.Point(143, 70);
            this.txtStartingDate.Name = "txtStartingDate";
            this.txtStartingDate.ReadOnly = true;
            this.txtStartingDate.Size = new System.Drawing.Size(126, 20);
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
            this.txtRequestedAmount.Location = new System.Drawing.Point(143, 44);
            this.txtRequestedAmount.Name = "txtRequestedAmount";
            this.txtRequestedAmount.ReadOnly = true;
            this.txtRequestedAmount.Size = new System.Drawing.Size(126, 20);
            this.txtRequestedAmount.TabIndex = 27;
            this.txtRequestedAmount.TabStop = false;
            this.txtRequestedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.groupBox3.Location = new System.Drawing.Point(6, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 72);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Installment Details";
            // 
            // txtInstallmentAmount
            // 
            this.txtInstallmentAmount.Location = new System.Drawing.Point(143, 19);
            this.txtInstallmentAmount.Name = "txtInstallmentAmount";
            this.txtInstallmentAmount.ReadOnly = true;
            this.txtInstallmentAmount.Size = new System.Drawing.Size(126, 20);
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
            this.txtNumberOfMonths.Location = new System.Drawing.Point(143, 45);
            this.txtNumberOfMonths.Name = "txtNumberOfMonths";
            this.txtNumberOfMonths.ReadOnly = true;
            this.txtNumberOfMonths.Size = new System.Drawing.Size(126, 20);
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
            this.groupBox4.Location = new System.Drawing.Point(6, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 100);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deduction From";
            // 
            // txtFixedIncentiveAllowance
            // 
            this.txtFixedIncentiveAllowance.Location = new System.Drawing.Point(143, 71);
            this.txtFixedIncentiveAllowance.Name = "txtFixedIncentiveAllowance";
            this.txtFixedIncentiveAllowance.ReadOnly = true;
            this.txtFixedIncentiveAllowance.Size = new System.Drawing.Size(126, 20);
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
            this.txtDayWages.Location = new System.Drawing.Point(143, 45);
            this.txtDayWages.Name = "txtDayWages";
            this.txtDayWages.ReadOnly = true;
            this.txtDayWages.Size = new System.Drawing.Size(126, 20);
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
            this.txtEpfSalary.Location = new System.Drawing.Point(143, 19);
            this.txtEpfSalary.Name = "txtEpfSalary";
            this.txtEpfSalary.ReadOnly = true;
            this.txtEpfSalary.Size = new System.Drawing.Size(126, 20);
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
            // gbxEmployeeDetails
            // 
            this.gbxEmployeeDetails.Controls.Add(this.cmbEmployeeName);
            this.gbxEmployeeDetails.Controls.Add(this.cmbTokenNo);
            this.gbxEmployeeDetails.Controls.Add(this.label13);
            this.gbxEmployeeDetails.Controls.Add(this.txtDesignation);
            this.gbxEmployeeDetails.Controls.Add(this.label6);
            this.gbxEmployeeDetails.Controls.Add(this.label3);
            this.gbxEmployeeDetails.Location = new System.Drawing.Point(12, 174);
            this.gbxEmployeeDetails.Name = "gbxEmployeeDetails";
            this.gbxEmployeeDetails.Size = new System.Drawing.Size(287, 98);
            this.gbxEmployeeDetails.TabIndex = 30;
            this.gbxEmployeeDetails.TabStop = false;
            this.gbxEmployeeDetails.Text = "Employee Details";
            // 
            // cmbEmployeeName
            // 
            this.cmbEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeName.FormattingEnabled = true;
            this.cmbEmployeeName.Location = new System.Drawing.Point(105, 44);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.Size = new System.Drawing.Size(176, 21);
            this.cmbEmployeeName.TabIndex = 20;
            this.cmbEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeName_SelectedIndexChanged);
            // 
            // cmbTokenNo
            // 
            this.cmbTokenNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTokenNo.FormattingEnabled = true;
            this.cmbTokenNo.Location = new System.Drawing.Point(105, 17);
            this.cmbTokenNo.Name = "cmbTokenNo";
            this.cmbTokenNo.Size = new System.Drawing.Size(176, 21);
            this.cmbTokenNo.TabIndex = 6;
            this.cmbTokenNo.SelectedIndexChanged += new System.EventHandler(this.cmbTokenNo_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Token No";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(105, 71);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.ReadOnly = true;
            this.txtDesignation.Size = new System.Drawing.Size(176, 20);
            this.txtDesignation.TabIndex = 14;
            this.txtDesignation.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee Name";
            // 
            // gbxDepartmentDetails
            // 
            this.gbxDepartmentDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDepartmentDetails.Controls.Add(this.chbSearchFromSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(287, 125);
            this.gbxDepartmentDetails.TabIndex = 29;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // lblSubDepartment
            // 
            this.lblSubDepartment.AutoSize = true;
            this.lblSubDepartment.Location = new System.Drawing.Point(6, 99);
            this.lblSubDepartment.Name = "lblSubDepartment";
            this.lblSubDepartment.Size = new System.Drawing.Size(84, 13);
            this.lblSubDepartment.TabIndex = 5;
            this.lblSubDepartment.Text = "Sub Department";
            // 
            // cmbSubDepartment
            // 
            this.cmbSubDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubDepartment.FormattingEnabled = true;
            this.cmbSubDepartment.Location = new System.Drawing.Point(105, 96);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(176, 21);
            this.cmbSubDepartment.TabIndex = 4;
            this.cmbSubDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbSubDepartment_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(6, 49);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(105, 46);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(176, 21);
            this.cmbDepartment.TabIndex = 2;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbWorkingBranch
            // 
            this.cmbWorkingBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkingBranch.FormattingEnabled = true;
            this.cmbWorkingBranch.Location = new System.Drawing.Point(105, 19);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(176, 21);
            this.cmbWorkingBranch.TabIndex = 1;
            this.cmbWorkingBranch.SelectedIndexChanged += new System.EventHandler(this.cmbWorkingBranch_SelectedIndexChanged);
            // 
            // lblWorkingBranch
            // 
            this.lblWorkingBranch.AutoSize = true;
            this.lblWorkingBranch.Location = new System.Drawing.Point(6, 22);
            this.lblWorkingBranch.Name = "lblWorkingBranch";
            this.lblWorkingBranch.Size = new System.Drawing.Size(84, 13);
            this.lblWorkingBranch.TabIndex = 0;
            this.lblWorkingBranch.Text = "Working Branch";
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(347, 31);
            this.lblFormTopic.TabIndex = 28;
            this.lblFormTopic.Text = "Salary Loan Installment List";
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
            this.btnClose.Location = new System.Drawing.Point(558, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 34;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chbSearchFromSubDepartment
            // 
            this.chbSearchFromSubDepartment.AutoSize = true;
            this.chbSearchFromSubDepartment.Location = new System.Drawing.Point(105, 73);
            this.chbSearchFromSubDepartment.Name = "chbSearchFromSubDepartment";
            this.chbSearchFromSubDepartment.Size = new System.Drawing.Size(166, 17);
            this.chbSearchFromSubDepartment.TabIndex = 30;
            this.chbSearchFromSubDepartment.Text = "Search From Sub Department";
            this.chbSearchFromSubDepartment.UseVisualStyleBackColor = true;
            this.chbSearchFromSubDepartment.CheckedChanged += new System.EventHandler(this.chbSearchFromSubDepartment_CheckedChanged);
            // 
            // frmSalaryLoanInstallmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 624);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxEmployeeDetails);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalaryLoanInstallmentList";
            this.Text = "SalaryLoanInstallmentList";
            this.Load += new System.EventHandler(this.frmSalaryLoanInstallmentList_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSalaryLoanInstallmentList_MouseDown);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvInstallmentList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbxEmployeeDetails.ResumeLayout(false);
            this.gbxEmployeeDetails.PerformLayout();
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView gdvInstallmentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPayment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoanId;
        private System.Windows.Forms.TextBox txtStartingDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtRequestedAmount;
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
        private System.Windows.Forms.GroupBox gbxEmployeeDetails;
        private System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.ComboBox cmbTokenNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.Label lblSubDepartment;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chbSearchFromSubDepartment;
    }
}