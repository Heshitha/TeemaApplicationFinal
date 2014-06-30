namespace TeemaApplication
{
    partial class frmViewSecurityRoutine
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
            this.gbxDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartingDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRoutineDetails = new System.Windows.Forms.DataGridView();
            this.clmnTokenNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFingerPrintMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.gbxDepartmentDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutineDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(280, 31);
            this.lblFormTopic.TabIndex = 11;
            this.lblFormTopic.Text = "View Security Routine";
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
            this.btnClose.Location = new System.Drawing.Point(990, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 18;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxDepartmentDetails
            // 
            this.gbxDepartmentDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDepartmentDetails.Controls.Add(this.btnSearch);
            this.gbxDepartmentDetails.Controls.Add(this.label1);
            this.gbxDepartmentDetails.Controls.Add(this.dtpStartingDate);
            this.gbxDepartmentDetails.Controls.Add(this.label3);
            this.gbxDepartmentDetails.Controls.Add(this.dtpEndDate);
            this.gbxDepartmentDetails.Controls.Add(this.cmbWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(295, 128);
            this.gbxDepartmentDetails.TabIndex = 36;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(96, 72);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(193, 20);
            this.dtpEndDate.TabIndex = 0;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // cmbWorkingBranch
            // 
            this.cmbWorkingBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWorkingBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWorkingBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkingBranch.FormattingEnabled = true;
            this.cmbWorkingBranch.Location = new System.Drawing.Point(96, 19);
            this.cmbWorkingBranch.Name = "cmbWorkingBranch";
            this.cmbWorkingBranch.Size = new System.Drawing.Size(193, 21);
            this.cmbWorkingBranch.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date";
            // 
            // dtpStartingDate
            // 
            this.dtpStartingDate.Location = new System.Drawing.Point(96, 46);
            this.dtpStartingDate.Name = "dtpStartingDate";
            this.dtpStartingDate.Size = new System.Drawing.Size(193, 20);
            this.dtpStartingDate.TabIndex = 2;
            this.dtpStartingDate.ValueChanged += new System.EventHandler(this.dtpStartingDate_ValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(214, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRoutineDetails);
            this.groupBox1.Location = new System.Drawing.Point(314, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 450);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Routine Times";
            // 
            // dgvRoutineDetails
            // 
            this.dgvRoutineDetails.AllowUserToAddRows = false;
            this.dgvRoutineDetails.AllowUserToDeleteRows = false;
            this.dgvRoutineDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoutineDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoutineDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTokenNo,
            this.clmnFingerPrintMachine,
            this.clmnName,
            this.clmnDateTime});
            this.dgvRoutineDetails.Location = new System.Drawing.Point(6, 19);
            this.dgvRoutineDetails.Name = "dgvRoutineDetails";
            this.dgvRoutineDetails.ReadOnly = true;
            this.dgvRoutineDetails.RowHeadersVisible = false;
            this.dgvRoutineDetails.Size = new System.Drawing.Size(694, 425);
            this.dgvRoutineDetails.TabIndex = 0;
            // 
            // clmnTokenNo
            // 
            this.clmnTokenNo.DataPropertyName = "TokenNo";
            this.clmnTokenNo.HeaderText = "Token No";
            this.clmnTokenNo.Name = "clmnTokenNo";
            this.clmnTokenNo.ReadOnly = true;
            // 
            // clmnFingerPrintMachine
            // 
            this.clmnFingerPrintMachine.DataPropertyName = "Device";
            this.clmnFingerPrintMachine.HeaderText = "Finger Print Machine";
            this.clmnFingerPrintMachine.Name = "clmnFingerPrintMachine";
            this.clmnFingerPrintMachine.ReadOnly = true;
            // 
            // clmnName
            // 
            this.clmnName.DataPropertyName = "Name";
            this.clmnName.HeaderText = "Name";
            this.clmnName.Name = "clmnName";
            this.clmnName.ReadOnly = true;
            // 
            // clmnDateTime
            // 
            this.clmnDateTime.DataPropertyName = "DateTime";
            this.clmnDateTime.HeaderText = "Date Time";
            this.clmnDateTime.Name = "clmnDateTime";
            this.clmnDateTime.ReadOnly = true;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(945, 501);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(75, 23);
            this.btnPrintReport.TabIndex = 38;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // frmViewSecurityRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 536);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewSecurityRoutine";
            this.Text = "View Security Routine";
            this.Load += new System.EventHandler(this.frmViewSecurityRoutine_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmViewSecurityRoutine_MouseDown);
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutineDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartingDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRoutineDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFingerPrintMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDateTime;
        private System.Windows.Forms.Button btnPrintReport;
    }
}