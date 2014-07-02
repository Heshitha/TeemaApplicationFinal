namespace TeemaApplication
{
    partial class frmAddLeaves
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearAddLeaves = new System.Windows.Forms.Button();
            this.btnAddLeaves = new System.Windows.Forms.Button();
            this.txtCasual = new System.Windows.Forms.TextBox();
            this.txtAnnual = new System.Windows.Forms.TextBox();
            this.lblCasual = new System.Windows.Forms.Label();
            this.lblAnnual = new System.Windows.Forms.Label();
            this.dgvLeaves = new System.Windows.Forms.DataGridView();
            this.clmnTokenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEPFNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAnnual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCasual = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cmbLeaveYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbSearchFromSubDepartment = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Leaves";
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
            this.btnClose.Location = new System.Drawing.Point(795, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 18;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLeaves);
            this.groupBox2.Location = new System.Drawing.Point(305, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 428);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Leaves";
            // 
            // btnClearAddLeaves
            // 
            this.btnClearAddLeaves.Location = new System.Drawing.Point(206, 204);
            this.btnClearAddLeaves.Name = "btnClearAddLeaves";
            this.btnClearAddLeaves.Size = new System.Drawing.Size(75, 23);
            this.btnClearAddLeaves.TabIndex = 10;
            this.btnClearAddLeaves.Text = "Clear";
            this.btnClearAddLeaves.UseVisualStyleBackColor = true;
            // 
            // btnAddLeaves
            // 
            this.btnAddLeaves.Location = new System.Drawing.Point(122, 204);
            this.btnAddLeaves.Name = "btnAddLeaves";
            this.btnAddLeaves.Size = new System.Drawing.Size(75, 23);
            this.btnAddLeaves.TabIndex = 11;
            this.btnAddLeaves.Text = "Add Leaves";
            this.btnAddLeaves.UseVisualStyleBackColor = true;
            this.btnAddLeaves.Click += new System.EventHandler(this.btnAddLeaves_Click);
            // 
            // txtCasual
            // 
            this.txtCasual.Location = new System.Drawing.Point(108, 177);
            this.txtCasual.Name = "txtCasual";
            this.txtCasual.Size = new System.Drawing.Size(173, 20);
            this.txtCasual.TabIndex = 10;
            // 
            // txtAnnual
            // 
            this.txtAnnual.Location = new System.Drawing.Point(108, 151);
            this.txtAnnual.Name = "txtAnnual";
            this.txtAnnual.Size = new System.Drawing.Size(173, 20);
            this.txtAnnual.TabIndex = 9;
            // 
            // lblCasual
            // 
            this.lblCasual.AutoSize = true;
            this.lblCasual.Location = new System.Drawing.Point(6, 180);
            this.lblCasual.Name = "lblCasual";
            this.lblCasual.Size = new System.Drawing.Size(39, 13);
            this.lblCasual.TabIndex = 5;
            this.lblCasual.Text = "Casual";
            // 
            // lblAnnual
            // 
            this.lblAnnual.AutoSize = true;
            this.lblAnnual.Location = new System.Drawing.Point(6, 154);
            this.lblAnnual.Name = "lblAnnual";
            this.lblAnnual.Size = new System.Drawing.Size(40, 13);
            this.lblAnnual.TabIndex = 7;
            this.lblAnnual.Text = "Annual";
            // 
            // dgvLeaves
            // 
            this.dgvLeaves.AllowUserToAddRows = false;
            this.dgvLeaves.AllowUserToDeleteRows = false;
            this.dgvLeaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTokenID,
            this.clmnEmpName,
            this.clmnEPFNO,
            this.clmnAnnual,
            this.clmnCasual});
            this.dgvLeaves.Location = new System.Drawing.Point(6, 19);
            this.dgvLeaves.Name = "dgvLeaves";
            this.dgvLeaves.ReadOnly = true;
            this.dgvLeaves.RowHeadersVisible = false;
            this.dgvLeaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaves.Size = new System.Drawing.Size(506, 403);
            this.dgvLeaves.TabIndex = 3;
            this.dgvLeaves.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeaves_CellClick);
            // 
            // clmnTokenID
            // 
            this.clmnTokenID.DataPropertyName = "TokenID";
            this.clmnTokenID.HeaderText = "TokenID";
            this.clmnTokenID.Name = "clmnTokenID";
            this.clmnTokenID.ReadOnly = true;
            // 
            // clmnEmpName
            // 
            this.clmnEmpName.DataPropertyName = "Name";
            this.clmnEmpName.HeaderText = "Name";
            this.clmnEmpName.Name = "clmnEmpName";
            this.clmnEmpName.ReadOnly = true;
            // 
            // clmnEPFNO
            // 
            this.clmnEPFNO.DataPropertyName = "EPFNo";
            this.clmnEPFNO.HeaderText = "EPF No";
            this.clmnEPFNO.Name = "clmnEPFNO";
            this.clmnEPFNO.ReadOnly = true;
            // 
            // clmnAnnual
            // 
            this.clmnAnnual.DataPropertyName = "AnnualLeaves";
            this.clmnAnnual.HeaderText = "Annual";
            this.clmnAnnual.Name = "clmnAnnual";
            this.clmnAnnual.ReadOnly = true;
            // 
            // clmnCasual
            // 
            this.clmnCasual.DataPropertyName = "CasualLeaves";
            this.clmnCasual.HeaderText = "Casual";
            this.clmnCasual.Name = "clmnCasual";
            this.clmnCasual.ReadOnly = true;
            // 
            // grpEmployeeDetails
            // 
            this.grpEmployeeDetails.Controls.Add(this.btnClearAddLeaves);
            this.grpEmployeeDetails.Controls.Add(this.txtNICNo);
            this.grpEmployeeDetails.Controls.Add(this.btnAddLeaves);
            this.grpEmployeeDetails.Controls.Add(this.txtTokenNo);
            this.grpEmployeeDetails.Controls.Add(this.txtCasual);
            this.grpEmployeeDetails.Controls.Add(this.txtDesignation);
            this.grpEmployeeDetails.Controls.Add(this.txtAnnual);
            this.grpEmployeeDetails.Controls.Add(this.lblCasual);
            this.grpEmployeeDetails.Controls.Add(this.txtEPFNO);
            this.grpEmployeeDetails.Controls.Add(this.lblAnnual);
            this.grpEmployeeDetails.Controls.Add(this.txtEmployeeName);
            this.grpEmployeeDetails.Controls.Add(this.label24);
            this.grpEmployeeDetails.Controls.Add(this.label4);
            this.grpEmployeeDetails.Controls.Add(this.label25);
            this.grpEmployeeDetails.Controls.Add(this.label28);
            this.grpEmployeeDetails.Controls.Add(this.label26);
            this.grpEmployeeDetails.Controls.Add(this.label27);
            this.grpEmployeeDetails.Location = new System.Drawing.Point(12, 205);
            this.grpEmployeeDetails.Name = "grpEmployeeDetails";
            this.grpEmployeeDetails.Size = new System.Drawing.Size(287, 234);
            this.grpEmployeeDetails.TabIndex = 21;
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
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "EPF No";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Designation";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 131);
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
            this.label27.Location = new System.Drawing.Point(6, 79);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "NIC No";
            // 
            // gbxDepartmentDetails
            // 
            this.gbxDepartmentDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDepartmentDetails.Controls.Add(this.cmbLeaveYear);
            this.gbxDepartmentDetails.Controls.Add(this.label2);
            this.gbxDepartmentDetails.Controls.Add(this.chbSearchFromSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.label7);
            this.gbxDepartmentDetails.Controls.Add(this.cmbSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 46);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(287, 153);
            this.gbxDepartmentDetails.TabIndex = 35;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // cmbLeaveYear
            // 
            this.cmbLeaveYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeaveYear.FormattingEnabled = true;
            this.cmbLeaveYear.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cmbLeaveYear.Location = new System.Drawing.Point(96, 19);
            this.cmbLeaveYear.Name = "cmbLeaveYear";
            this.cmbLeaveYear.Size = new System.Drawing.Size(185, 21);
            this.cmbLeaveYear.TabIndex = 9;
            this.cmbLeaveYear.SelectedIndexChanged += new System.EventHandler(this.cmbLeaveYear_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "For the year";
            // 
            // chbSearchFromSubDepartment
            // 
            this.chbSearchFromSubDepartment.AutoSize = true;
            this.chbSearchFromSubDepartment.Location = new System.Drawing.Point(96, 101);
            this.chbSearchFromSubDepartment.Name = "chbSearchFromSubDepartment";
            this.chbSearchFromSubDepartment.Size = new System.Drawing.Size(166, 17);
            this.chbSearchFromSubDepartment.TabIndex = 6;
            this.chbSearchFromSubDepartment.Text = "Search From Sub Department";
            this.chbSearchFromSubDepartment.UseVisualStyleBackColor = true;
            this.chbSearchFromSubDepartment.CheckedChanged += new System.EventHandler(this.chbSearchFromSubDepartment_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 127);
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
            this.cmbSubDepartment.Location = new System.Drawing.Point(96, 124);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(185, 21);
            this.cmbSubDepartment.TabIndex = 3;
            this.cmbSubDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbSubDepartment_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(6, 77);
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
            this.cmbDepartment.Location = new System.Drawing.Point(96, 74);
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
            this.cmbWorkingBranch.Location = new System.Drawing.Point(96, 46);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(185, 21);
            this.cmbWorkingBranch.TabIndex = 1;
            this.cmbWorkingBranch.SelectedIndexChanged += new System.EventHandler(this.cmbWorkingBranch_SelectedIndexChanged);
            // 
            // lblWorkingBranch
            // 
            this.lblWorkingBranch.AutoSize = true;
            this.lblWorkingBranch.Location = new System.Drawing.Point(6, 49);
            this.lblWorkingBranch.Name = "lblWorkingBranch";
            this.lblWorkingBranch.Size = new System.Drawing.Size(84, 13);
            this.lblWorkingBranch.TabIndex = 0;
            this.lblWorkingBranch.Text = "Working Branch";
            // 
            // frmAddLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 487);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpEmployeeDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddLeaves";
            this.Text = "Add Leaves";
            this.Load += new System.EventHandler(this.frmAddLeaves_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddLeaves_MouseDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearAddLeaves;
        private System.Windows.Forms.Button btnAddLeaves;
        private System.Windows.Forms.TextBox txtCasual;
        private System.Windows.Forms.TextBox txtAnnual;
        private System.Windows.Forms.Label lblCasual;
        private System.Windows.Forms.Label lblAnnual;
        private System.Windows.Forms.DataGridView dgvLeaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEPFNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAnnual;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCasual;
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
        private System.Windows.Forms.ComboBox cmbLeaveYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbSearchFromSubDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
    }
}