namespace TeemaApplication
{
    partial class frmAddPieceRate
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
            this.chbSearchFromSubDepartment = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbWorkingBranch = new System.Windows.Forms.ComboBox();
            this.lblWorkingBranch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEnteredDate = new System.Windows.Forms.DateTimePicker();
            this.txtPieceUnitRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPieceUnitMeasure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPieceRateCatagory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcEnterPieceRates = new System.Windows.Forms.TabControl();
            this.tbpEnterPieceRateToEmployees = new System.Windows.Forms.TabPage();
            this.dgvEnterPieceUnitsForEmployees = new System.Windows.Forms.DataGridView();
            this.clmnEntitled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnTokenNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWorkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPieceRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPayement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAvragePayement = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberOfWorkers = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPiecesCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxDepartmentDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbcEnterPieceRates.SuspendLayout();
            this.tbpEnterPieceRateToEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnterPieceUnitsForEmployees)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(293, 31);
            this.lblFormTopic.TabIndex = 22;
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
            this.btnClose.Location = new System.Drawing.Point(757, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 29;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.gbxDepartmentDetails.Size = new System.Drawing.Size(295, 125);
            this.gbxDepartmentDetails.TabIndex = 34;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
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
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpEnteredDate);
            this.groupBox1.Controls.Add(this.txtPieceUnitRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPieceUnitMeasure);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPieceRateCatagory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 125);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Piece Rate Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Entered Date";
            // 
            // dtpEnteredDate
            // 
            this.dtpEnteredDate.Location = new System.Drawing.Point(117, 98);
            this.dtpEnteredDate.Name = "dtpEnteredDate";
            this.dtpEnteredDate.Size = new System.Drawing.Size(172, 20);
            this.dtpEnteredDate.TabIndex = 7;
            // 
            // txtPieceUnitRate
            // 
            this.txtPieceUnitRate.Location = new System.Drawing.Point(117, 71);
            this.txtPieceUnitRate.Name = "txtPieceUnitRate";
            this.txtPieceUnitRate.Size = new System.Drawing.Size(172, 20);
            this.txtPieceUnitRate.TabIndex = 6;
            this.txtPieceUnitRate.Text = "0";
            this.txtPieceUnitRate.Leave += new System.EventHandler(this.txtPieceUnitRate_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Piece Unit Rate";
            // 
            // txtPieceUnitMeasure
            // 
            this.txtPieceUnitMeasure.Location = new System.Drawing.Point(117, 45);
            this.txtPieceUnitMeasure.Name = "txtPieceUnitMeasure";
            this.txtPieceUnitMeasure.Size = new System.Drawing.Size(172, 20);
            this.txtPieceUnitMeasure.TabIndex = 4;
            this.txtPieceUnitMeasure.Leave += new System.EventHandler(this.txtPieceUnitMeasure_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Piece Unit Measure";
            // 
            // txtPieceRateCatagory
            // 
            this.txtPieceRateCatagory.Location = new System.Drawing.Point(117, 19);
            this.txtPieceRateCatagory.Name = "txtPieceRateCatagory";
            this.txtPieceRateCatagory.Size = new System.Drawing.Size(172, 20);
            this.txtPieceRateCatagory.TabIndex = 2;
            this.txtPieceRateCatagory.Leave += new System.EventHandler(this.txtPieceRateCatagory_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Piece Rate Catagory";
            // 
            // tbcEnterPieceRates
            // 
            this.tbcEnterPieceRates.Controls.Add(this.tbpEnterPieceRateToEmployees);
            this.tbcEnterPieceRates.Controls.Add(this.tabPage2);
            this.tbcEnterPieceRates.Location = new System.Drawing.Point(314, 43);
            this.tbcEnterPieceRates.Name = "tbcEnterPieceRates";
            this.tbcEnterPieceRates.SelectedIndex = 0;
            this.tbcEnterPieceRates.Size = new System.Drawing.Size(473, 453);
            this.tbcEnterPieceRates.TabIndex = 36;
            // 
            // tbpEnterPieceRateToEmployees
            // 
            this.tbpEnterPieceRateToEmployees.Controls.Add(this.dgvEnterPieceUnitsForEmployees);
            this.tbpEnterPieceRateToEmployees.Location = new System.Drawing.Point(4, 22);
            this.tbpEnterPieceRateToEmployees.Name = "tbpEnterPieceRateToEmployees";
            this.tbpEnterPieceRateToEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEnterPieceRateToEmployees.Size = new System.Drawing.Size(465, 427);
            this.tbpEnterPieceRateToEmployees.TabIndex = 0;
            this.tbpEnterPieceRateToEmployees.Text = "Enter Piece Units For Employees";
            this.tbpEnterPieceRateToEmployees.UseVisualStyleBackColor = true;
            // 
            // dgvEnterPieceUnitsForEmployees
            // 
            this.dgvEnterPieceUnitsForEmployees.AllowUserToAddRows = false;
            this.dgvEnterPieceUnitsForEmployees.AllowUserToDeleteRows = false;
            this.dgvEnterPieceUnitsForEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnterPieceUnitsForEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnEntitled,
            this.clmnTokenNo,
            this.clmnWorkerName,
            this.clmnPieceRate,
            this.clmnMeasure,
            this.clmnPayement});
            this.dgvEnterPieceUnitsForEmployees.Location = new System.Drawing.Point(6, 6);
            this.dgvEnterPieceUnitsForEmployees.Name = "dgvEnterPieceUnitsForEmployees";
            this.dgvEnterPieceUnitsForEmployees.RowHeadersVisible = false;
            this.dgvEnterPieceUnitsForEmployees.Size = new System.Drawing.Size(453, 380);
            this.dgvEnterPieceUnitsForEmployees.TabIndex = 0;
            this.dgvEnterPieceUnitsForEmployees.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnterPieceUnitsForEmployees_CellEndEdit);
            this.dgvEnterPieceUnitsForEmployees.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvEnterPieceUnitsForEmployees_DataError);
            // 
            // clmnEntitled
            // 
            this.clmnEntitled.DataPropertyName = "Entitled";
            this.clmnEntitled.FalseValue = "False";
            this.clmnEntitled.HeaderText = "Entitled";
            this.clmnEntitled.Name = "clmnEntitled";
            this.clmnEntitled.TrueValue = "True";
            // 
            // clmnTokenNo
            // 
            this.clmnTokenNo.DataPropertyName = "TokenNo";
            this.clmnTokenNo.HeaderText = "Token No";
            this.clmnTokenNo.Name = "clmnTokenNo";
            // 
            // clmnWorkerName
            // 
            this.clmnWorkerName.DataPropertyName = "Name";
            this.clmnWorkerName.HeaderText = "Worker Name";
            this.clmnWorkerName.Name = "clmnWorkerName";
            // 
            // clmnPieceRate
            // 
            this.clmnPieceRate.DataPropertyName = "PieceRate";
            this.clmnPieceRate.HeaderText = "Piece Rate";
            this.clmnPieceRate.Name = "clmnPieceRate";
            // 
            // clmnMeasure
            // 
            this.clmnMeasure.DataPropertyName = "Measure";
            this.clmnMeasure.HeaderText = "Measure";
            this.clmnMeasure.Name = "clmnMeasure";
            // 
            // clmnPayement
            // 
            this.clmnPayement.DataPropertyName = "Payement";
            this.clmnPayement.HeaderText = "Payement";
            this.clmnPayement.Name = "clmnPayement";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(465, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enter Average Rate For Employees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAvragePayement);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNumberOfWorkers);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTotalValue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTotalPiecesCount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 126);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Average Payments";
            // 
            // txtAvragePayement
            // 
            this.txtAvragePayement.Location = new System.Drawing.Point(117, 97);
            this.txtAvragePayement.Name = "txtAvragePayement";
            this.txtAvragePayement.ReadOnly = true;
            this.txtAvragePayement.Size = new System.Drawing.Size(172, 20);
            this.txtAvragePayement.TabIndex = 14;
            this.txtAvragePayement.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Avrage Payement";
            // 
            // txtNumberOfWorkers
            // 
            this.txtNumberOfWorkers.Location = new System.Drawing.Point(117, 71);
            this.txtNumberOfWorkers.Name = "txtNumberOfWorkers";
            this.txtNumberOfWorkers.ReadOnly = true;
            this.txtNumberOfWorkers.Size = new System.Drawing.Size(172, 20);
            this.txtNumberOfWorkers.TabIndex = 12;
            this.txtNumberOfWorkers.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Number Of Workers";
            // 
            // txtTotalValue
            // 
            this.txtTotalValue.Location = new System.Drawing.Point(117, 45);
            this.txtTotalValue.Name = "txtTotalValue";
            this.txtTotalValue.ReadOnly = true;
            this.txtTotalValue.Size = new System.Drawing.Size(172, 20);
            this.txtTotalValue.TabIndex = 10;
            this.txtTotalValue.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Value";
            // 
            // txtTotalPiecesCount
            // 
            this.txtTotalPiecesCount.Location = new System.Drawing.Point(117, 19);
            this.txtTotalPiecesCount.Name = "txtTotalPiecesCount";
            this.txtTotalPiecesCount.ReadOnly = true;
            this.txtTotalPiecesCount.Size = new System.Drawing.Size(172, 20);
            this.txtTotalPiecesCount.TabIndex = 8;
            this.txtTotalPiecesCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Pieces Count";
            // 
            // frmAddPieceRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbcEnterPieceRates);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDepartmentDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddPieceRate";
            this.Text = "AddPieceRate";
            this.Load += new System.EventHandler(this.frmAddPieceRate_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddPieceRate_MouseDown);
            this.gbxDepartmentDetails.ResumeLayout(false);
            this.gbxDepartmentDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbcEnterPieceRates.ResumeLayout(false);
            this.tbpEnterPieceRateToEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnterPieceUnitsForEmployees)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxDepartmentDetails;
        private System.Windows.Forms.CheckBox chbSearchFromSubDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbWorkingBranch;
        private System.Windows.Forms.Label lblWorkingBranch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPieceUnitRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPieceUnitMeasure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPieceRateCatagory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbcEnterPieceRates;
        private System.Windows.Forms.TabPage tbpEnterPieceRateToEmployees;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnteredDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAvragePayement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberOfWorkers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPiecesCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvEnterPieceUnitsForEmployees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnEntitled;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWorkerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPieceRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPayement;
    }
}