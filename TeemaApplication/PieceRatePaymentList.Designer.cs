namespace TeemaApplication
{
    partial class frmPieceRatePaymentList
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
            this.chbSearchFromSubDepartment = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpSelectedDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDepartmentDailyReport = new System.Windows.Forms.RadioButton();
            this.rdbDepartmentMonthlyReport = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPieceRateDetails = new System.Windows.Forms.DataGridView();
            this.clmnTokenNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintForm = new System.Windows.Forms.Button();
            this.tbcPieceRate = new System.Windows.Forms.TabControl();
            this.tbpEnteredPieceRate = new System.Windows.Forms.TabPage();
            this.tbpAvaragePieceRate = new System.Windows.Forms.TabPage();
            this.dgvAveragePieceRateDetails = new System.Windows.Forms.DataGridView();
            this.clmnTokenNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotalValue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDepartmentDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieceRateDetails)).BeginInit();
            this.tbcPieceRate.SuspendLayout();
            this.tbpEnteredPieceRate.SuspendLayout();
            this.tbpAvaragePieceRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAveragePieceRateDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(293, 31);
            this.lblFormTopic.TabIndex = 23;
            this.lblFormTopic.Text = "Add Piece Rate Details";
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
            this.btnClose.Location = new System.Drawing.Point(882, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 30;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxDepartmentDetails
            // 
            this.gbxDepartmentDetails.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDepartmentDetails.Controls.Add(this.label3);
            this.gbxDepartmentDetails.Controls.Add(this.chbSearchFromSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.label7);
            this.gbxDepartmentDetails.Controls.Add(this.dtpSelectedDate);
            this.gbxDepartmentDetails.Controls.Add(this.cmbSubDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.lblDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbDepartment);
            this.gbxDepartmentDetails.Controls.Add(this.cmbWorkingBranch);
            this.gbxDepartmentDetails.Controls.Add(this.lblWorkingBranch);
            this.gbxDepartmentDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxDepartmentDetails.Name = "gbxDepartmentDetails";
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(295, 151);
            this.gbxDepartmentDetails.TabIndex = 35;
            this.gbxDepartmentDetails.TabStop = false;
            this.gbxDepartmentDetails.Text = "Department Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Date / Month";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sub Department";
            // 
            // dtpSelectedDate
            // 
            this.dtpSelectedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSelectedDate.Location = new System.Drawing.Point(116, 124);
            this.dtpSelectedDate.Name = "dtpSelectedDate";
            this.dtpSelectedDate.Size = new System.Drawing.Size(173, 20);
            this.dtpSelectedDate.TabIndex = 0;
            this.dtpSelectedDate.ValueChanged += new System.EventHandler(this.dtpSelectedDate_ValueChanged);
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
            this.cmbSubDepartment.Size = new System.Drawing.Size(193, 21);
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
            this.cmbDepartment.Size = new System.Drawing.Size(193, 21);
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
            this.cmbWorkingBranch.Size = new System.Drawing.Size(193, 21);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDepartmentDailyReport);
            this.groupBox1.Controls.Add(this.rdbDepartmentMonthlyReport);
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 71);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Search Type";
            // 
            // rdbDepartmentDailyReport
            // 
            this.rdbDepartmentDailyReport.AutoSize = true;
            this.rdbDepartmentDailyReport.Location = new System.Drawing.Point(6, 42);
            this.rdbDepartmentDailyReport.Name = "rdbDepartmentDailyReport";
            this.rdbDepartmentDailyReport.Size = new System.Drawing.Size(141, 17);
            this.rdbDepartmentDailyReport.TabIndex = 1;
            this.rdbDepartmentDailyReport.Text = "Department Daily Report";
            this.rdbDepartmentDailyReport.UseVisualStyleBackColor = true;
            this.rdbDepartmentDailyReport.CheckedChanged += new System.EventHandler(this.rdbDepartmentDailyReport_CheckedChanged);
            // 
            // rdbDepartmentMonthlyReport
            // 
            this.rdbDepartmentMonthlyReport.AutoSize = true;
            this.rdbDepartmentMonthlyReport.Checked = true;
            this.rdbDepartmentMonthlyReport.Location = new System.Drawing.Point(6, 19);
            this.rdbDepartmentMonthlyReport.Name = "rdbDepartmentMonthlyReport";
            this.rdbDepartmentMonthlyReport.Size = new System.Drawing.Size(155, 17);
            this.rdbDepartmentMonthlyReport.TabIndex = 0;
            this.rdbDepartmentMonthlyReport.TabStop = true;
            this.rdbDepartmentMonthlyReport.Text = "Department Monthly Report";
            this.rdbDepartmentMonthlyReport.UseVisualStyleBackColor = true;
            this.rdbDepartmentMonthlyReport.CheckedChanged += new System.EventHandler(this.rdbDepartmentMonthlyReport_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbcPieceRate);
            this.groupBox2.Location = new System.Drawing.Point(314, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 446);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Piece Rate Details";
            // 
            // dgvPieceRateDetails
            // 
            this.dgvPieceRateDetails.AllowUserToAddRows = false;
            this.dgvPieceRateDetails.AllowUserToDeleteRows = false;
            this.dgvPieceRateDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPieceRateDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieceRateDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTokenNo,
            this.clmnName,
            this.clmnTotalValue});
            this.dgvPieceRateDetails.Location = new System.Drawing.Point(6, 6);
            this.dgvPieceRateDetails.Name = "dgvPieceRateDetails";
            this.dgvPieceRateDetails.ReadOnly = true;
            this.dgvPieceRateDetails.RowHeadersVisible = false;
            this.dgvPieceRateDetails.Size = new System.Drawing.Size(566, 383);
            this.dgvPieceRateDetails.TabIndex = 0;
            // 
            // clmnTokenNo
            // 
            this.clmnTokenNo.DataPropertyName = "TokenNo";
            this.clmnTokenNo.HeaderText = "Token No";
            this.clmnTokenNo.Name = "clmnTokenNo";
            this.clmnTokenNo.ReadOnly = true;
            // 
            // clmnName
            // 
            this.clmnName.DataPropertyName = "Name";
            this.clmnName.HeaderText = "Name";
            this.clmnName.Name = "clmnName";
            this.clmnName.ReadOnly = true;
            // 
            // clmnTotalValue
            // 
            this.clmnTotalValue.DataPropertyName = "TotalValue";
            this.clmnTotalValue.HeaderText = "Total Value";
            this.clmnTotalValue.Name = "clmnTotalValue";
            this.clmnTotalValue.ReadOnly = true;
            // 
            // btnPrintForm
            // 
            this.btnPrintForm.Location = new System.Drawing.Point(837, 495);
            this.btnPrintForm.Name = "btnPrintForm";
            this.btnPrintForm.Size = new System.Drawing.Size(75, 23);
            this.btnPrintForm.TabIndex = 38;
            this.btnPrintForm.Text = "Print Form";
            this.btnPrintForm.UseVisualStyleBackColor = true;
            this.btnPrintForm.Click += new System.EventHandler(this.btnPrintForm_Click);
            // 
            // tbcPieceRate
            // 
            this.tbcPieceRate.Controls.Add(this.tbpEnteredPieceRate);
            this.tbcPieceRate.Controls.Add(this.tbpAvaragePieceRate);
            this.tbcPieceRate.Location = new System.Drawing.Point(6, 19);
            this.tbcPieceRate.Name = "tbcPieceRate";
            this.tbcPieceRate.SelectedIndex = 0;
            this.tbcPieceRate.Size = new System.Drawing.Size(586, 421);
            this.tbcPieceRate.TabIndex = 1;
            // 
            // tbpEnteredPieceRate
            // 
            this.tbpEnteredPieceRate.Controls.Add(this.dgvPieceRateDetails);
            this.tbpEnteredPieceRate.Location = new System.Drawing.Point(4, 22);
            this.tbpEnteredPieceRate.Name = "tbpEnteredPieceRate";
            this.tbpEnteredPieceRate.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEnteredPieceRate.Size = new System.Drawing.Size(578, 395);
            this.tbpEnteredPieceRate.TabIndex = 0;
            this.tbpEnteredPieceRate.Text = "Entered Piece Rate Details";
            this.tbpEnteredPieceRate.UseVisualStyleBackColor = true;
            // 
            // tbpAvaragePieceRate
            // 
            this.tbpAvaragePieceRate.Controls.Add(this.dgvAveragePieceRateDetails);
            this.tbpAvaragePieceRate.Location = new System.Drawing.Point(4, 22);
            this.tbpAvaragePieceRate.Name = "tbpAvaragePieceRate";
            this.tbpAvaragePieceRate.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAvaragePieceRate.Size = new System.Drawing.Size(578, 395);
            this.tbpAvaragePieceRate.TabIndex = 1;
            this.tbpAvaragePieceRate.Text = "Average Piece Rate Details";
            this.tbpAvaragePieceRate.UseVisualStyleBackColor = true;
            // 
            // dgvAveragePieceRateDetails
            // 
            this.dgvAveragePieceRateDetails.AllowUserToAddRows = false;
            this.dgvAveragePieceRateDetails.AllowUserToDeleteRows = false;
            this.dgvAveragePieceRateDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAveragePieceRateDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAveragePieceRateDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTokenNo2,
            this.clmnName2,
            this.clmnTotalValue2});
            this.dgvAveragePieceRateDetails.Location = new System.Drawing.Point(6, 6);
            this.dgvAveragePieceRateDetails.Name = "dgvAveragePieceRateDetails";
            this.dgvAveragePieceRateDetails.ReadOnly = true;
            this.dgvAveragePieceRateDetails.RowHeadersVisible = false;
            this.dgvAveragePieceRateDetails.Size = new System.Drawing.Size(566, 383);
            this.dgvAveragePieceRateDetails.TabIndex = 0;
            // 
            // clmnTokenNo2
            // 
            this.clmnTokenNo2.DataPropertyName = "TokenNo";
            this.clmnTokenNo2.HeaderText = "Token No";
            this.clmnTokenNo2.Name = "clmnTokenNo2";
            this.clmnTokenNo2.ReadOnly = true;
            // 
            // clmnName2
            // 
            this.clmnName2.DataPropertyName = "Name";
            this.clmnName2.HeaderText = "Name";
            this.clmnName2.Name = "clmnName2";
            this.clmnName2.ReadOnly = true;
            // 
            // clmnTotalValue2
            // 
            this.clmnTotalValue2.DataPropertyName = "TotalValue";
            this.clmnTotalValue2.HeaderText = "Total Value";
            this.clmnTotalValue2.Name = "clmnTotalValue2";
            this.clmnTotalValue2.ReadOnly = true;
            // 
            // frmPieceRatePaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 530);
            this.Controls.Add(this.btnPrintForm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPieceRatePaymentList";
            this.Text = "Piece Rate Payment List";
            this.Load += new System.EventHandler(this.frmPieceRatePaymentList_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPieceRatePaymentList_MouseDown);
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieceRateDetails)).EndInit();
            this.tbcPieceRate.ResumeLayout(false);
            this.tbpEnteredPieceRate.ResumeLayout(false);
            this.tbpAvaragePieceRate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAveragePieceRateDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbSearchFromSubDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpSelectedDate;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDepartmentDailyReport;
        private System.Windows.Forms.RadioButton rdbDepartmentMonthlyReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPieceRateDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotalValue;
        private System.Windows.Forms.Button btnPrintForm;
        private System.Windows.Forms.TabControl tbcPieceRate;
        private System.Windows.Forms.TabPage tbpEnteredPieceRate;
        private System.Windows.Forms.TabPage tbpAvaragePieceRate;
        private System.Windows.Forms.DataGridView dgvAveragePieceRateDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotalValue2;
    }
}