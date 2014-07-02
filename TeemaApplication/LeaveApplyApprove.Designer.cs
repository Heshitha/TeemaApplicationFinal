namespace TeemaApplication
{
    partial class frmLeaveApplyApprove
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
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxCreatedAdvance = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSubstitutename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubstitueID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNumberofdays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLeaveto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLeavefrom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtOtherleavedescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeaveReason = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaynopay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFullhalfday = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chbUnApprovedOnly = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxSalaryMonth = new System.Windows.Forms.GroupBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvLeavesapplied = new System.Windows.Forms.DataGridView();
            this.clmnTokenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLeaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLeaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApprove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grpEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.txtNICNo = new System.Windows.Forms.TextBox();
            this.txtTokenNo = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtEPFNO = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.gbxDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.chbSearchFromSubDepartment = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.gbxCreatedAdvance.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbxSalaryMonth.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeavesapplied)).BeginInit();
            this.grpEmployeeDetails.SuspendLayout();
            this.gbxDepartmentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Approve Leaves";
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
            this.btnClose.Location = new System.Drawing.Point(946, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxCreatedAdvance
            // 
            this.gbxCreatedAdvance.Controls.Add(this.groupBox3);
            this.gbxCreatedAdvance.Controls.Add(this.groupBox4);
            this.gbxCreatedAdvance.Controls.Add(this.groupBox5);
            this.gbxCreatedAdvance.Location = new System.Drawing.Point(305, 43);
            this.gbxCreatedAdvance.Name = "gbxCreatedAdvance";
            this.gbxCreatedAdvance.Size = new System.Drawing.Size(671, 208);
            this.gbxCreatedAdvance.TabIndex = 44;
            this.gbxCreatedAdvance.TabStop = false;
            this.gbxCreatedAdvance.Text = "Applied Leave Deatails";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSubstitutename);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtSubstitueID);
            this.groupBox3.Location = new System.Drawing.Point(6, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 66);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // txtSubstitutename
            // 
            this.txtSubstitutename.Location = new System.Drawing.Point(173, 36);
            this.txtSubstitutename.Name = "txtSubstitutename";
            this.txtSubstitutename.ReadOnly = true;
            this.txtSubstitutename.Size = new System.Drawing.Size(191, 20);
            this.txtSubstitutename.TabIndex = 23;
            this.txtSubstitutename.TabStop = false;
            this.txtSubstitutename.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Substitute Token ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Substitue Name";
            // 
            // txtSubstitueID
            // 
            this.txtSubstitueID.Location = new System.Drawing.Point(173, 13);
            this.txtSubstitueID.Name = "txtSubstitueID";
            this.txtSubstitueID.ReadOnly = true;
            this.txtSubstitueID.Size = new System.Drawing.Size(191, 20);
            this.txtSubstitueID.TabIndex = 21;
            this.txtSubstitueID.TabStop = false;
            this.txtSubstitueID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNumberofdays);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtLeaveto);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtLeavefrom);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(382, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 99);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // txtNumberofdays
            // 
            this.txtNumberofdays.Location = new System.Drawing.Point(122, 70);
            this.txtNumberofdays.Name = "txtNumberofdays";
            this.txtNumberofdays.ReadOnly = true;
            this.txtNumberofdays.Size = new System.Drawing.Size(153, 20);
            this.txtNumberofdays.TabIndex = 26;
            this.txtNumberofdays.TabStop = false;
            this.txtNumberofdays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Number of Days";
            // 
            // txtLeaveto
            // 
            this.txtLeaveto.Location = new System.Drawing.Point(122, 44);
            this.txtLeaveto.Name = "txtLeaveto";
            this.txtLeaveto.ReadOnly = true;
            this.txtLeaveto.Size = new System.Drawing.Size(153, 20);
            this.txtLeaveto.TabIndex = 24;
            this.txtLeaveto.TabStop = false;
            this.txtLeaveto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Leave To";
            // 
            // txtLeavefrom
            // 
            this.txtLeavefrom.Location = new System.Drawing.Point(122, 18);
            this.txtLeavefrom.Name = "txtLeavefrom";
            this.txtLeavefrom.ReadOnly = true;
            this.txtLeavefrom.Size = new System.Drawing.Size(153, 20);
            this.txtLeavefrom.TabIndex = 22;
            this.txtLeavefrom.TabStop = false;
            this.txtLeavefrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Leave From";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtOtherleavedescription);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtLeaveReason);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtPaynopay);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtFullhalfday);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(6, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 117);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // txtOtherleavedescription
            // 
            this.txtOtherleavedescription.Location = new System.Drawing.Point(174, 90);
            this.txtOtherleavedescription.Name = "txtOtherleavedescription";
            this.txtOtherleavedescription.ReadOnly = true;
            this.txtOtherleavedescription.Size = new System.Drawing.Size(191, 20);
            this.txtOtherleavedescription.TabIndex = 19;
            this.txtOtherleavedescription.TabStop = false;
            this.txtOtherleavedescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Other leave Description";
            // 
            // txtLeaveReason
            // 
            this.txtLeaveReason.Location = new System.Drawing.Point(174, 64);
            this.txtLeaveReason.Name = "txtLeaveReason";
            this.txtLeaveReason.ReadOnly = true;
            this.txtLeaveReason.Size = new System.Drawing.Size(191, 20);
            this.txtLeaveReason.TabIndex = 17;
            this.txtLeaveReason.TabStop = false;
            this.txtLeaveReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Leave Reason";
            // 
            // txtPaynopay
            // 
            this.txtPaynopay.Location = new System.Drawing.Point(174, 38);
            this.txtPaynopay.Name = "txtPaynopay";
            this.txtPaynopay.ReadOnly = true;
            this.txtPaynopay.Size = new System.Drawing.Size(191, 20);
            this.txtPaynopay.TabIndex = 15;
            this.txtPaynopay.TabStop = false;
            this.txtPaynopay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Pay/No Pay";
            // 
            // txtFullhalfday
            // 
            this.txtFullhalfday.Location = new System.Drawing.Point(174, 12);
            this.txtFullhalfday.Name = "txtFullhalfday";
            this.txtFullhalfday.ReadOnly = true;
            this.txtFullhalfday.Size = new System.Drawing.Size(191, 20);
            this.txtFullhalfday.TabIndex = 13;
            this.txtFullhalfday.TabStop = false;
            this.txtFullhalfday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Fullday/Half Day";
            // 
            // chbUnApprovedOnly
            // 
            this.chbUnApprovedOnly.AutoSize = true;
            this.chbUnApprovedOnly.Checked = true;
            this.chbUnApprovedOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbUnApprovedOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUnApprovedOnly.Location = new System.Drawing.Point(96, 73);
            this.chbUnApprovedOnly.Name = "chbUnApprovedOnly";
            this.chbUnApprovedOnly.Size = new System.Drawing.Size(110, 17);
            this.chbUnApprovedOnly.TabIndex = 43;
            this.chbUnApprovedOnly.Text = "UnApproved Only";
            this.chbUnApprovedOnly.UseVisualStyleBackColor = true;
            this.chbUnApprovedOnly.CheckedChanged += new System.EventHandler(this.chbUnApprovedOnly_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(187, 460);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // gbxSalaryMonth
            // 
            this.gbxSalaryMonth.Controls.Add(this.cmbMonth);
            this.gbxSalaryMonth.Controls.Add(this.cmbYear);
            this.gbxSalaryMonth.Controls.Add(this.label10);
            this.gbxSalaryMonth.Controls.Add(this.chbUnApprovedOnly);
            this.gbxSalaryMonth.Controls.Add(this.label3);
            this.gbxSalaryMonth.Location = new System.Drawing.Point(12, 173);
            this.gbxSalaryMonth.Name = "gbxSalaryMonth";
            this.gbxSalaryMonth.Size = new System.Drawing.Size(287, 96);
            this.gbxSalaryMonth.TabIndex = 41;
            this.gbxSalaryMonth.TabStop = false;
            this.gbxSalaryMonth.Text = "Leave month";
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
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
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
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLeavesapplied);
            this.groupBox2.Location = new System.Drawing.Point(305, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 233);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leaves";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(890, 496);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 31);
            this.btnSubmit.TabIndex = 38;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // dgvLeavesapplied
            // 
            this.dgvLeavesapplied.AllowUserToAddRows = false;
            this.dgvLeavesapplied.AllowUserToDeleteRows = false;
            this.dgvLeavesapplied.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeavesapplied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeavesapplied.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTokenID,
            this.clmnEmpName,
            this.LeaveID,
            this.clmnLeaveType,
            this.clmnLeaveDate,
            this.btnApprove});
            this.dgvLeavesapplied.Location = new System.Drawing.Point(6, 18);
            this.dgvLeavesapplied.Name = "dgvLeavesapplied";
            this.dgvLeavesapplied.RowHeadersVisible = false;
            this.dgvLeavesapplied.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeavesapplied.Size = new System.Drawing.Size(657, 208);
            this.dgvLeavesapplied.TabIndex = 3;
            // 
            // clmnTokenID
            // 
            this.clmnTokenID.DataPropertyName = "TokenID";
            this.clmnTokenID.HeaderText = "TokenID";
            this.clmnTokenID.Name = "clmnTokenID";
            // 
            // clmnEmpName
            // 
            this.clmnEmpName.DataPropertyName = "Name";
            this.clmnEmpName.HeaderText = "Name";
            this.clmnEmpName.Name = "clmnEmpName";
            // 
            // LeaveID
            // 
            this.LeaveID.DataPropertyName = "PersonalLeaveID";
            this.LeaveID.HeaderText = "Leave ID";
            this.LeaveID.Name = "LeaveID";
            // 
            // clmnLeaveType
            // 
            this.clmnLeaveType.DataPropertyName = "LeaveType";
            this.clmnLeaveType.HeaderText = "Leave Type";
            this.clmnLeaveType.Name = "clmnLeaveType";
            // 
            // clmnLeaveDate
            // 
            this.clmnLeaveDate.DataPropertyName = "LeaveDate";
            this.clmnLeaveDate.HeaderText = "Leave Date";
            this.clmnLeaveDate.Name = "clmnLeaveDate";
            // 
            // btnApprove
            // 
            this.btnApprove.DataPropertyName = "Approve";
            this.btnApprove.FalseValue = "false";
            this.btnApprove.HeaderText = "Approve";
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.TrueValue = "true";
            // 
            // grpEmployeeDetails
            // 
            this.grpEmployeeDetails.Controls.Add(this.txtNICNo);
            this.grpEmployeeDetails.Controls.Add(this.txtTokenNo);
            this.grpEmployeeDetails.Controls.Add(this.txtDesignation);
            this.grpEmployeeDetails.Controls.Add(this.txtEPFNO);
            this.grpEmployeeDetails.Controls.Add(this.txtEmployeeName);
            this.grpEmployeeDetails.Controls.Add(this.label24);
            this.grpEmployeeDetails.Controls.Add(this.label4);
            this.grpEmployeeDetails.Controls.Add(this.label25);
            this.grpEmployeeDetails.Controls.Add(this.label28);
            this.grpEmployeeDetails.Controls.Add(this.label26);
            this.grpEmployeeDetails.Controls.Add(this.label27);
            this.grpEmployeeDetails.Location = new System.Drawing.Point(12, 275);
            this.grpEmployeeDetails.Name = "grpEmployeeDetails";
            this.grpEmployeeDetails.Size = new System.Drawing.Size(287, 157);
            this.grpEmployeeDetails.TabIndex = 39;
            this.grpEmployeeDetails.TabStop = false;
            this.grpEmployeeDetails.Text = "Employee Details";
            // 
            // txtNICNo
            // 
            this.txtNICNo.Location = new System.Drawing.Point(108, 73);
            this.txtNICNo.Name = "txtNICNo";
            this.txtNICNo.Size = new System.Drawing.Size(173, 20);
            this.txtNICNo.TabIndex = 1;
            // 
            // txtTokenNo
            // 
            this.txtTokenNo.Location = new System.Drawing.Point(108, 125);
            this.txtTokenNo.Name = "txtTokenNo";
            this.txtTokenNo.Size = new System.Drawing.Size(173, 20);
            this.txtTokenNo.TabIndex = 1;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(108, 47);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(173, 20);
            this.txtDesignation.TabIndex = 1;
            // 
            // txtEPFNO
            // 
            this.txtEPFNO.Location = new System.Drawing.Point(108, 99);
            this.txtEPFNO.Name = "txtEPFNO";
            this.txtEPFNO.Size = new System.Drawing.Size(173, 20);
            this.txtEPFNO.TabIndex = 1;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(108, 21);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(173, 20);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 13);
            this.label24.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "EPF No";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Designation";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 128);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Token No";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Employee Name";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 76);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "NIC No";
            // 
            // gbxDepartmentDetails
            // 
            this.gbxDepartmentDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDepartmentDetails.Controls.Add(this.chbSearchFromSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.label15);
            this.gbxDepartmentDetails.Controls.Add(this.cmbSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(287, 124);
            this.gbxDepartmentDetails.TabIndex = 45;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // chbSearchFromSubDepartment
            // 
            this.chbSearchFromSubDepartment.AutoSize = true;
            this.chbSearchFromSubDepartment.Location = new System.Drawing.Point(96, 74);
            this.chbSearchFromSubDepartment.Name = "chbSearchFromSubDepartment";
            this.chbSearchFromSubDepartment.Size = new System.Drawing.Size(166, 17);
            this.chbSearchFromSubDepartment.TabIndex = 6;
            this.chbSearchFromSubDepartment.Text = "Search From Sub Department";
            this.chbSearchFromSubDepartment.UseVisualStyleBackColor = true;
            this.chbSearchFromSubDepartment.CheckedChanged += new System.EventHandler(this.chbSearchFromSubDepartment_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Sub Department";
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
            this.cmbSubDepartment.TabIndex = 3;
            this.cmbSubDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbSubDepartment_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(6, 50);
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
            this.cmbDepartment.Location = new System.Drawing.Point(96, 47);
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
            this.cmbWorkingBranch.Location = new System.Drawing.Point(96, 19);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(185, 21);
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
            // frmLeaveApplyApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 540);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.gbxCreatedAdvance);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbxSalaryMonth);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpEmployeeDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLeaveApplyApprove";
            this.Text = "Leave Apply Approve";
            this.Load += new System.EventHandler(this.frmLeaveApplyApprove_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLeaveApplyApprove_MouseDown);
            this.gbxCreatedAdvance.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbxSalaryMonth.ResumeLayout(false);
            this.gbxSalaryMonth.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeavesapplied)).EndInit();
            this.grpEmployeeDetails.ResumeLayout(false);
            this.grpEmployeeDetails.PerformLayout();
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxCreatedAdvance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSubstitutename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubstitueID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNumberofdays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLeaveto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLeavefrom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtOtherleavedescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeaveReason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaynopay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFullhalfday;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chbUnApprovedOnly;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxSalaryMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvLeavesapplied;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLeaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLeaveDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btnApprove;
        private System.Windows.Forms.GroupBox grpEmployeeDetails;
        private System.Windows.Forms.TextBox txtNICNo;
        private System.Windows.Forms.TextBox txtTokenNo;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtEPFNO;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.CheckBox chbSearchFromSubDepartment;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
    }
}