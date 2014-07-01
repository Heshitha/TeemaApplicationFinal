namespace TeemaApplication
{
    partial class ApproveSalaryAdvance
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
            this.gbxDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.txtSubDepartment = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.lblFormTopic = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFormNo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.clmnTokenNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRequestedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEPFSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDayWages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFixedInsentiveAllowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnVariableInsentiveAllowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintForm = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.gbxDepartmentDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDepartmentDetails
            // 
            this.gbxDepartmentDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDepartmentDetails.Controls.Add(this.txtSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.txtDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.txtBranch);
            this.gbxDepartmentDetails.Controls.Add(this.label7);
            this.gbxDepartmentDetails.Controls.Add(this.lblDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(248, 99);
            this.gbxDepartmentDetails.TabIndex = 39;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // txtSubDepartment
            // 
            this.txtSubDepartment.Location = new System.Drawing.Point(96, 71);
            this.txtSubDepartment.Name = "txtSubDepartment";
            this.txtSubDepartment.ReadOnly = true;
            this.txtSubDepartment.Size = new System.Drawing.Size(142, 20);
            this.txtSubDepartment.TabIndex = 8;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(96, 45);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(142, 20);
            this.txtDepartment.TabIndex = 7;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(96, 19);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.ReadOnly = true;
            this.txtBranch.Size = new System.Drawing.Size(142, 20);
            this.txtBranch.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sub Department";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(6, 48);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
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
            this.lblFormTopic.Size = new System.Drawing.Size(312, 31);
            this.lblFormTopic.TabIndex = 37;
            this.lblFormTopic.Text = "Approve Salary Advance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFormNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 59);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overtime Details";
            // 
            // cmbFormNo
            // 
            this.cmbFormNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormNo.FormattingEnabled = true;
            this.cmbFormNo.Location = new System.Drawing.Point(96, 19);
            this.cmbFormNo.Name = "cmbFormNo";
            this.cmbFormNo.Size = new System.Drawing.Size(142, 21);
            this.cmbFormNo.TabIndex = 13;
            this.cmbFormNo.SelectedIndexChanged += new System.EventHandler(this.cmbFormNo_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Form No";
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
            this.btnClose.Location = new System.Drawing.Point(888, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 41;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvEmployeeDetails
            // 
            this.dgvEmployeeDetails.AllowUserToAddRows = false;
            this.dgvEmployeeDetails.AllowUserToDeleteRows = false;
            this.dgvEmployeeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTokenNo,
            this.clmnEmployeeName,
            this.clmnRequestedAmount,
            this.clmnEPFSalary,
            this.clmnDayWages,
            this.clmnFixedInsentiveAllowance,
            this.clmnVariableInsentiveAllowance});
            this.dgvEmployeeDetails.Location = new System.Drawing.Point(266, 45);
            this.dgvEmployeeDetails.Name = "dgvEmployeeDetails";
            this.dgvEmployeeDetails.RowHeadersVisible = false;
            this.dgvEmployeeDetails.Size = new System.Drawing.Size(652, 318);
            this.dgvEmployeeDetails.TabIndex = 42;
            // 
            // clmnTokenNo
            // 
            this.clmnTokenNo.DataPropertyName = "TokenNo";
            this.clmnTokenNo.HeaderText = "Token No";
            this.clmnTokenNo.Name = "clmnTokenNo";
            // 
            // clmnEmployeeName
            // 
            this.clmnEmployeeName.DataPropertyName = "Name";
            this.clmnEmployeeName.HeaderText = "Name";
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            // 
            // clmnRequestedAmount
            // 
            this.clmnRequestedAmount.DataPropertyName = "RequestAmount";
            this.clmnRequestedAmount.HeaderText = "Requested Amount";
            this.clmnRequestedAmount.Name = "clmnRequestedAmount";
            // 
            // clmnEPFSalary
            // 
            this.clmnEPFSalary.DataPropertyName = "EPFSal";
            this.clmnEPFSalary.HeaderText = "EPF Salary";
            this.clmnEPFSalary.Name = "clmnEPFSalary";
            // 
            // clmnDayWages
            // 
            this.clmnDayWages.DataPropertyName = "DayWages";
            this.clmnDayWages.HeaderText = "Day Wages";
            this.clmnDayWages.Name = "clmnDayWages";
            // 
            // clmnFixedInsentiveAllowance
            // 
            this.clmnFixedInsentiveAllowance.DataPropertyName = "FixedInsentive";
            this.clmnFixedInsentiveAllowance.HeaderText = "Fixed Insentive Allowance";
            this.clmnFixedInsentiveAllowance.Name = "clmnFixedInsentiveAllowance";
            // 
            // clmnVariableInsentiveAllowance
            // 
            this.clmnVariableInsentiveAllowance.DataPropertyName = "VariableInsentive";
            this.clmnVariableInsentiveAllowance.HeaderText = "Variable Insentive Allowance";
            this.clmnVariableInsentiveAllowance.Name = "clmnVariableInsentiveAllowance";
            // 
            // btnPrintForm
            // 
            this.btnPrintForm.Location = new System.Drawing.Point(843, 369);
            this.btnPrintForm.Name = "btnPrintForm";
            this.btnPrintForm.Size = new System.Drawing.Size(75, 23);
            this.btnPrintForm.TabIndex = 44;
            this.btnPrintForm.Text = "Print Form";
            this.btnPrintForm.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(762, 369);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 43;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // ApproveSalaryAdvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 402);
            this.Controls.Add(this.btnPrintForm);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.dgvEmployeeDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApproveSalaryAdvance";
            this.Text = "ApproveSalaryAdvance";
            this.Load += new System.EventHandler(this.ApproveSalaryAdvance_Load);
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.TextBox txtSubDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvEmployeeDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRequestedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEPFSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDayWages;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFixedInsentiveAllowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnVariableInsentiveAllowance;
        private System.Windows.Forms.Button btnPrintForm;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.ComboBox cmbFormNo;
    }
}