namespace TeemaApplication
{
    partial class frmGenerateBasicSalary
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.chbSearchFromSubDepartment = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.gbxSalaryMonth = new System.Windows.Forms.GroupBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateSalary = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTripleOTRate = new System.Windows.Forms.TextBox();
            this.txtDoubleOTRate = new System.Windows.Forms.TextBox();
            this.txtSingleOTRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGeneratedSalary = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.clmnTokenNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEPFNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBudegetAllowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNPDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPaidLeaveDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNoPayAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSalarytoEPFETF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOTNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOTDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOTTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOTAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPieceRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnGrossSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSalaryAdvance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPayee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnStampDuty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMeals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWelfareShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWelfareCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWloan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBankSaving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMedicalIns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBankloan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotalDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNetSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRoundBFsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRoundcfsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNetPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEPF12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnETF3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDepartmentDetails.SuspendLayout();
            this.gbxSalaryMonth.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneratedSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generate Salary";
            // 
            // gbxDepartmentDetails
            // 
            this.gbxDepartmentDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDepartmentDetails.Controls.Add(this.chbSearchFromSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.label7);
            this.gbxDepartmentDetails.Controls.Add(this.cmbSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(287, 129);
            this.gbxDepartmentDetails.TabIndex = 36;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // chbSearchFromSubDepartment
            // 
            this.chbSearchFromSubDepartment.AutoSize = true;
            this.chbSearchFromSubDepartment.Location = new System.Drawing.Point(97, 74);
            this.chbSearchFromSubDepartment.Name = "chbSearchFromSubDepartment";
            this.chbSearchFromSubDepartment.Size = new System.Drawing.Size(166, 17);
            this.chbSearchFromSubDepartment.TabIndex = 6;
            this.chbSearchFromSubDepartment.Text = "Search From Sub Department";
            this.chbSearchFromSubDepartment.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sub Department";
            // 
            // cmbSubDepartment
            // 
            this.cmbSubDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSubDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubDepartment.Enabled = false;
            this.cmbSubDepartment.FormattingEnabled = true;
            this.cmbSubDepartment.Location = new System.Drawing.Point(97, 97);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(185, 21);
            this.cmbSubDepartment.TabIndex = 3;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(7, 50);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(97, 47);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(185, 21);
            this.cmbDepartment.TabIndex = 2;
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
            this.cmbWorkingBranch.Size = new System.Drawing.Size(185, 21);
            this.cmbWorkingBranch.TabIndex = 1;
            this.cmbWorkingBranch.SelectedIndexChanged += new System.EventHandler(this.cmbWorkingBranch_SelectedIndexChanged);
            // 
            // lblWorkingBranch
            // 
            this.lblWorkingBranch.AutoSize = true;
            this.lblWorkingBranch.Location = new System.Drawing.Point(7, 22);
            this.lblWorkingBranch.Name = "lblWorkingBranch";
            this.lblWorkingBranch.Size = new System.Drawing.Size(84, 13);
            this.lblWorkingBranch.TabIndex = 0;
            this.lblWorkingBranch.Text = "Working Branch";
            // 
            // gbxSalaryMonth
            // 
            this.gbxSalaryMonth.Controls.Add(this.cmbMonth);
            this.gbxSalaryMonth.Controls.Add(this.cmbYear);
            this.gbxSalaryMonth.Controls.Add(this.label10);
            this.gbxSalaryMonth.Controls.Add(this.label3);
            this.gbxSalaryMonth.Location = new System.Drawing.Point(12, 178);
            this.gbxSalaryMonth.Name = "gbxSalaryMonth";
            this.gbxSalaryMonth.Size = new System.Drawing.Size(287, 76);
            this.gbxSalaryMonth.TabIndex = 51;
            this.gbxSalaryMonth.TabStop = false;
            this.gbxSalaryMonth.Text = "Salary Month";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(96, 46);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(186, 21);
            this.cmbMonth.TabIndex = 24;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cmbYear.Location = new System.Drawing.Point(96, 19);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(186, 21);
            this.cmbYear.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Year";
            // 
            // btnGenerateSalary
            // 
            this.btnGenerateSalary.Location = new System.Drawing.Point(184, 365);
            this.btnGenerateSalary.Name = "btnGenerateSalary";
            this.btnGenerateSalary.Size = new System.Drawing.Size(115, 23);
            this.btnGenerateSalary.TabIndex = 52;
            this.btnGenerateSalary.Text = "Generate Salary";
            this.btnGenerateSalary.UseVisualStyleBackColor = true;
            this.btnGenerateSalary.Click += new System.EventHandler(this.btnGenerateSalary_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTripleOTRate);
            this.groupBox1.Controls.Add(this.txtDoubleOTRate);
            this.groupBox1.Controls.Add(this.txtSingleOTRate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 99);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overtime Rates";
            // 
            // txtTripleOTRate
            // 
            this.txtTripleOTRate.Location = new System.Drawing.Point(96, 71);
            this.txtTripleOTRate.Name = "txtTripleOTRate";
            this.txtTripleOTRate.Size = new System.Drawing.Size(185, 20);
            this.txtTripleOTRate.TabIndex = 26;
            this.txtTripleOTRate.Text = "0";
            this.txtTripleOTRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDoubleOTRate
            // 
            this.txtDoubleOTRate.Location = new System.Drawing.Point(96, 45);
            this.txtDoubleOTRate.Name = "txtDoubleOTRate";
            this.txtDoubleOTRate.Size = new System.Drawing.Size(185, 20);
            this.txtDoubleOTRate.TabIndex = 25;
            this.txtDoubleOTRate.Text = "0";
            this.txtDoubleOTRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSingleOTRate
            // 
            this.txtSingleOTRate.Location = new System.Drawing.Point(96, 19);
            this.txtSingleOTRate.Name = "txtSingleOTRate";
            this.txtSingleOTRate.Size = new System.Drawing.Size(185, 20);
            this.txtSingleOTRate.TabIndex = 24;
            this.txtSingleOTRate.Text = "0";
            this.txtSingleOTRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Triple OT Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Double OT Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Single OT Rate";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvGeneratedSalary);
            this.groupBox2.Location = new System.Drawing.Point(306, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 603);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generated Salary";
            // 
            // dgvGeneratedSalary
            // 
            this.dgvGeneratedSalary.AllowUserToAddRows = false;
            this.dgvGeneratedSalary.AllowUserToDeleteRows = false;
            this.dgvGeneratedSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGeneratedSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneratedSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTokenNo,
            this.clmnEPFNo,
            this.clmnEmployeeName,
            this.clmnDesignation,
            this.clmnEmployeeCategory,
            this.clmnEmployeeGrade,
            this.clmnBasicSalary,
            this.clmnBudegetAllowance,
            this.clmnTotal,
            this.clmnNPDays,
            this.clmnPaidLeaveDays,
            this.clmnNoPayAmount,
            this.clmnSalarytoEPFETF,
            this.clmnOTNH,
            this.clmnOTDH,
            this.clmnOTTH,
            this.clmnOTAmount,
            this.clmnPieceRate,
            this.clmnGrossSalary,
            this.clmnSalaryAdvance,
            this.clmnEPF,
            this.clmnPayee,
            this.clmnStampDuty,
            this.clmnMeals,
            this.clmnWelfareShop,
            this.clmnWelfareCon,
            this.clmnWloan,
            this.clmnBankSaving,
            this.clmnMedicalIns,
            this.clmnBankloan,
            this.clmnMisc,
            this.clmnTotalDeduction,
            this.clmnNetSalary,
            this.clmnRoundBFsal,
            this.clmnRoundcfsal,
            this.clmnNetPayment,
            this.clmnEPF12,
            this.clmnETF3});
            this.dgvGeneratedSalary.Location = new System.Drawing.Point(6, 19);
            this.dgvGeneratedSalary.Name = "dgvGeneratedSalary";
            this.dgvGeneratedSalary.ReadOnly = true;
            this.dgvGeneratedSalary.RowHeadersVisible = false;
            this.dgvGeneratedSalary.Size = new System.Drawing.Size(852, 578);
            this.dgvGeneratedSalary.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::TeemaApplication.Properties.Resources.Notification_Boxes_03;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1140, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 55;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // clmnTokenNo
            // 
            this.clmnTokenNo.DataPropertyName = "TokenNo";
            this.clmnTokenNo.HeaderText = "Token No";
            this.clmnTokenNo.Name = "clmnTokenNo";
            this.clmnTokenNo.ReadOnly = true;
            // 
            // clmnEPFNo
            // 
            this.clmnEPFNo.DataPropertyName = "EPFNo";
            this.clmnEPFNo.HeaderText = "EPF No";
            this.clmnEPFNo.Name = "clmnEPFNo";
            this.clmnEPFNo.ReadOnly = true;
            // 
            // clmnEmployeeName
            // 
            this.clmnEmployeeName.DataPropertyName = "EmployeeName";
            this.clmnEmployeeName.HeaderText = "Employee Name";
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            this.clmnEmployeeName.ReadOnly = true;
            // 
            // clmnDesignation
            // 
            this.clmnDesignation.DataPropertyName = "Designation";
            this.clmnDesignation.HeaderText = "Designation";
            this.clmnDesignation.Name = "clmnDesignation";
            this.clmnDesignation.ReadOnly = true;
            // 
            // clmnEmployeeCategory
            // 
            this.clmnEmployeeCategory.DataPropertyName = "EmployeeCatarogy";
            this.clmnEmployeeCategory.HeaderText = "EmployeeCategory";
            this.clmnEmployeeCategory.Name = "clmnEmployeeCategory";
            this.clmnEmployeeCategory.ReadOnly = true;
            // 
            // clmnEmployeeGrade
            // 
            this.clmnEmployeeGrade.DataPropertyName = "EmployeeGrade";
            this.clmnEmployeeGrade.HeaderText = "EmployeeGrade";
            this.clmnEmployeeGrade.Name = "clmnEmployeeGrade";
            this.clmnEmployeeGrade.ReadOnly = true;
            // 
            // clmnBasicSalary
            // 
            this.clmnBasicSalary.DataPropertyName = "BasicSalary";
            this.clmnBasicSalary.HeaderText = "Basic Salary";
            this.clmnBasicSalary.Name = "clmnBasicSalary";
            this.clmnBasicSalary.ReadOnly = true;
            // 
            // clmnBudegetAllowance
            // 
            this.clmnBudegetAllowance.DataPropertyName = "BudgetedAllowance";
            this.clmnBudegetAllowance.HeaderText = "Budeget Allowance";
            this.clmnBudegetAllowance.Name = "clmnBudegetAllowance";
            this.clmnBudegetAllowance.ReadOnly = true;
            // 
            // clmnTotal
            // 
            this.clmnTotal.DataPropertyName = "Total";
            this.clmnTotal.HeaderText = "Total";
            this.clmnTotal.Name = "clmnTotal";
            this.clmnTotal.ReadOnly = true;
            // 
            // clmnNPDays
            // 
            this.clmnNPDays.DataPropertyName = "NPDays";
            this.clmnNPDays.HeaderText = "NP Days";
            this.clmnNPDays.Name = "clmnNPDays";
            this.clmnNPDays.ReadOnly = true;
            // 
            // clmnPaidLeaveDays
            // 
            this.clmnPaidLeaveDays.DataPropertyName = "PaidLeaveDays";
            this.clmnPaidLeaveDays.HeaderText = "Paid Leave Days";
            this.clmnPaidLeaveDays.Name = "clmnPaidLeaveDays";
            this.clmnPaidLeaveDays.ReadOnly = true;
            // 
            // clmnNoPayAmount
            // 
            this.clmnNoPayAmount.DataPropertyName = "NoPayamount";
            this.clmnNoPayAmount.HeaderText = "No Pay Amount";
            this.clmnNoPayAmount.Name = "clmnNoPayAmount";
            this.clmnNoPayAmount.ReadOnly = true;
            // 
            // clmnSalarytoEPFETF
            // 
            this.clmnSalarytoEPFETF.DataPropertyName = "SalaryToEPFETF";
            this.clmnSalarytoEPFETF.HeaderText = "SalarytoEPFETF";
            this.clmnSalarytoEPFETF.Name = "clmnSalarytoEPFETF";
            this.clmnSalarytoEPFETF.ReadOnly = true;
            // 
            // clmnOTNH
            // 
            this.clmnOTNH.DataPropertyName = "OTNH";
            this.clmnOTNH.HeaderText = "OT N/H";
            this.clmnOTNH.Name = "clmnOTNH";
            this.clmnOTNH.ReadOnly = true;
            // 
            // clmnOTDH
            // 
            this.clmnOTDH.DataPropertyName = "OTDH";
            this.clmnOTDH.HeaderText = "OT/DH";
            this.clmnOTDH.Name = "clmnOTDH";
            this.clmnOTDH.ReadOnly = true;
            // 
            // clmnOTTH
            // 
            this.clmnOTTH.DataPropertyName = "OTTH";
            this.clmnOTTH.HeaderText = "OT/TH";
            this.clmnOTTH.Name = "clmnOTTH";
            this.clmnOTTH.ReadOnly = true;
            // 
            // clmnOTAmount
            // 
            this.clmnOTAmount.DataPropertyName = "OTAmount";
            this.clmnOTAmount.HeaderText = "OTAmount";
            this.clmnOTAmount.Name = "clmnOTAmount";
            this.clmnOTAmount.ReadOnly = true;
            // 
            // clmnPieceRate
            // 
            this.clmnPieceRate.DataPropertyName = "PieceRate";
            this.clmnPieceRate.HeaderText = "Piece Rate";
            this.clmnPieceRate.Name = "clmnPieceRate";
            this.clmnPieceRate.ReadOnly = true;
            // 
            // clmnGrossSalary
            // 
            this.clmnGrossSalary.DataPropertyName = "GrossSalary";
            this.clmnGrossSalary.HeaderText = "Gross Salary";
            this.clmnGrossSalary.Name = "clmnGrossSalary";
            this.clmnGrossSalary.ReadOnly = true;
            // 
            // clmnSalaryAdvance
            // 
            this.clmnSalaryAdvance.DataPropertyName = "SalaryAdvnace";
            this.clmnSalaryAdvance.HeaderText = "Salary Advance";
            this.clmnSalaryAdvance.Name = "clmnSalaryAdvance";
            this.clmnSalaryAdvance.ReadOnly = true;
            // 
            // clmnEPF
            // 
            this.clmnEPF.DataPropertyName = "EPF8";
            this.clmnEPF.HeaderText = "EPF 8%";
            this.clmnEPF.Name = "clmnEPF";
            this.clmnEPF.ReadOnly = true;
            // 
            // clmnPayee
            // 
            this.clmnPayee.DataPropertyName = "Payee";
            this.clmnPayee.HeaderText = "Payee";
            this.clmnPayee.Name = "clmnPayee";
            this.clmnPayee.ReadOnly = true;
            // 
            // clmnStampDuty
            // 
            this.clmnStampDuty.DataPropertyName = "StampDuty";
            this.clmnStampDuty.HeaderText = "Stamp Duty";
            this.clmnStampDuty.Name = "clmnStampDuty";
            this.clmnStampDuty.ReadOnly = true;
            // 
            // clmnMeals
            // 
            this.clmnMeals.DataPropertyName = "Meals";
            this.clmnMeals.HeaderText = "Meals";
            this.clmnMeals.Name = "clmnMeals";
            this.clmnMeals.ReadOnly = true;
            // 
            // clmnWelfareShop
            // 
            this.clmnWelfareShop.DataPropertyName = "WelfareShop";
            this.clmnWelfareShop.HeaderText = "Welfare Shop";
            this.clmnWelfareShop.Name = "clmnWelfareShop";
            this.clmnWelfareShop.ReadOnly = true;
            // 
            // clmnWelfareCon
            // 
            this.clmnWelfareCon.DataPropertyName = "WelfareContribution";
            this.clmnWelfareCon.HeaderText = "Welfare Contribution";
            this.clmnWelfareCon.Name = "clmnWelfareCon";
            this.clmnWelfareCon.ReadOnly = true;
            // 
            // clmnWloan
            // 
            this.clmnWloan.DataPropertyName = "WelfareLoan";
            this.clmnWloan.HeaderText = "Welfare Loan";
            this.clmnWloan.Name = "clmnWloan";
            this.clmnWloan.ReadOnly = true;
            // 
            // clmnBankSaving
            // 
            this.clmnBankSaving.DataPropertyName = "BankSaving";
            this.clmnBankSaving.HeaderText = "BankSaving";
            this.clmnBankSaving.Name = "clmnBankSaving";
            this.clmnBankSaving.ReadOnly = true;
            // 
            // clmnMedicalIns
            // 
            this.clmnMedicalIns.DataPropertyName = "Medicalinsurance";
            this.clmnMedicalIns.HeaderText = "Medical Insurance";
            this.clmnMedicalIns.Name = "clmnMedicalIns";
            this.clmnMedicalIns.ReadOnly = true;
            // 
            // clmnBankloan
            // 
            this.clmnBankloan.DataPropertyName = "BankLoan";
            this.clmnBankloan.HeaderText = "Bank Loan";
            this.clmnBankloan.Name = "clmnBankloan";
            this.clmnBankloan.ReadOnly = true;
            // 
            // clmnMisc
            // 
            this.clmnMisc.DataPropertyName = "Misc";
            this.clmnMisc.HeaderText = "Misc";
            this.clmnMisc.Name = "clmnMisc";
            this.clmnMisc.ReadOnly = true;
            // 
            // clmnTotalDeduction
            // 
            this.clmnTotalDeduction.DataPropertyName = "TotalDeduction";
            this.clmnTotalDeduction.HeaderText = "Total Deduction";
            this.clmnTotalDeduction.Name = "clmnTotalDeduction";
            this.clmnTotalDeduction.ReadOnly = true;
            // 
            // clmnNetSalary
            // 
            this.clmnNetSalary.DataPropertyName = "NetSalary";
            this.clmnNetSalary.HeaderText = "Net Salary";
            this.clmnNetSalary.Name = "clmnNetSalary";
            this.clmnNetSalary.ReadOnly = true;
            // 
            // clmnRoundBFsal
            // 
            this.clmnRoundBFsal.DataPropertyName = "RoundupBFSalary";
            this.clmnRoundBFsal.HeaderText = "Roundup B/F Salary";
            this.clmnRoundBFsal.Name = "clmnRoundBFsal";
            this.clmnRoundBFsal.ReadOnly = true;
            // 
            // clmnRoundcfsal
            // 
            this.clmnRoundcfsal.DataPropertyName = "RoundupCFSalary";
            this.clmnRoundcfsal.HeaderText = "Roundup C/F Salary";
            this.clmnRoundcfsal.Name = "clmnRoundcfsal";
            this.clmnRoundcfsal.ReadOnly = true;
            // 
            // clmnNetPayment
            // 
            this.clmnNetPayment.DataPropertyName = "NetPayment";
            this.clmnNetPayment.HeaderText = "Net Payment";
            this.clmnNetPayment.Name = "clmnNetPayment";
            this.clmnNetPayment.ReadOnly = true;
            // 
            // clmnEPF12
            // 
            this.clmnEPF12.DataPropertyName = "EPF12";
            this.clmnEPF12.HeaderText = "EPF 12%";
            this.clmnEPF12.Name = "clmnEPF12";
            this.clmnEPF12.ReadOnly = true;
            // 
            // clmnETF3
            // 
            this.clmnETF3.DataPropertyName = "EPF3";
            this.clmnETF3.HeaderText = "ETF 3%";
            this.clmnETF3.Name = "clmnETF3";
            this.clmnETF3.ReadOnly = true;
            // 
            // frmGenerateBasicSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 658);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerateSalary);
            this.Controls.Add(this.gbxSalaryMonth);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGenerateBasicSalary";
            this.Text = "GenerateBasicSalary";
            this.Load += new System.EventHandler(this.frmGenerateBasicSalary_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGenerateBasicSalary_MouseDown);
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.gbxSalaryMonth.ResumeLayout(false);
            this.gbxSalaryMonth.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneratedSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.CheckBox chbSearchFromSubDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.GroupBox gbxSalaryMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerateSalary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTripleOTRate;
        private System.Windows.Forms.TextBox txtDoubleOTRate;
        private System.Windows.Forms.TextBox txtSingleOTRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvGeneratedSalary;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEPFNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBudegetAllowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNPDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPaidLeaveDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNoPayAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSalarytoEPFETF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOTNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOTDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOTTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOTAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPieceRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnGrossSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSalaryAdvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPayee;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnStampDuty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMeals;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWelfareShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWelfareCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWloan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBankSaving;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMedicalIns;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBankloan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotalDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNetSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRoundBFsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRoundcfsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNetPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEPF12;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnETF3;
    }
}