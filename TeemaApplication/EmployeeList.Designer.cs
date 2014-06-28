namespace TeemaApplication
{
    partial class frmEmployeeList
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
            this.gbxEmployeeList = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTokenNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSubDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxSearchCatagory = new System.Windows.Forms.GroupBox();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.rdbSearchBySubDepartment = new System.Windows.Forms.RadioButton();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.rdbSearchByDepartment = new System.Windows.Forms.RadioButton();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.rdbSearchByBranch = new System.Windows.Forms.RadioButton();
            this.rdbAllEmployees = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxEmployeeList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.gbxSearchCatagory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(184, 31);
            this.lblFormTopic.TabIndex = 18;
            this.lblFormTopic.Text = "Employee List";
            // 
            // gbxEmployeeList
            // 
            this.gbxEmployeeList.Controls.Add(this.groupBox1);
            this.gbxEmployeeList.Controls.Add(this.gbxSearchCatagory);
            this.gbxEmployeeList.Location = new System.Drawing.Point(12, 48);
            this.gbxEmployeeList.Name = "gbxEmployeeList";
            this.gbxEmployeeList.Size = new System.Drawing.Size(782, 487);
            this.gbxEmployeeList.TabIndex = 20;
            this.gbxEmployeeList.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEmployees);
            this.groupBox1.Location = new System.Drawing.Point(220, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnEmployeeName,
            this.clmnTokenNo,
            this.clmnBranch,
            this.clmnDepartment,
            this.clmnSubDepartment});
            this.dgvEmployees.Location = new System.Drawing.Point(6, 19);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(544, 437);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // clmnEmployeeName
            // 
            this.clmnEmployeeName.DataPropertyName = "Name";
            this.clmnEmployeeName.HeaderText = "Employee Name";
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            // 
            // clmnTokenNo
            // 
            this.clmnTokenNo.DataPropertyName = "TokenNo";
            this.clmnTokenNo.HeaderText = "Token No";
            this.clmnTokenNo.Name = "clmnTokenNo";
            // 
            // clmnBranch
            // 
            this.clmnBranch.DataPropertyName = "Branch";
            this.clmnBranch.HeaderText = "Branch";
            this.clmnBranch.Name = "clmnBranch";
            // 
            // clmnDepartment
            // 
            this.clmnDepartment.DataPropertyName = "Department";
            this.clmnDepartment.HeaderText = "Department";
            this.clmnDepartment.Name = "clmnDepartment";
            // 
            // clmnSubDepartment
            // 
            this.clmnSubDepartment.DataPropertyName = "SubDepartment";
            this.clmnSubDepartment.HeaderText = "Sub Department";
            this.clmnSubDepartment.Name = "clmnSubDepartment";
            // 
            // gbxSearchCatagory
            // 
            this.gbxSearchCatagory.Controls.Add(this.cmbSubDepartment);
            this.gbxSearchCatagory.Controls.Add(this.rdbSearchBySubDepartment);
            this.gbxSearchCatagory.Controls.Add(this.cmbDepartment);
            this.gbxSearchCatagory.Controls.Add(this.rdbSearchByDepartment);
            this.gbxSearchCatagory.Controls.Add(this.cmbBranch);
            this.gbxSearchCatagory.Controls.Add(this.rdbSearchByBranch);
            this.gbxSearchCatagory.Controls.Add(this.rdbAllEmployees);
            this.gbxSearchCatagory.Location = new System.Drawing.Point(6, 19);
            this.gbxSearchCatagory.Name = "gbxSearchCatagory";
            this.gbxSearchCatagory.Size = new System.Drawing.Size(208, 193);
            this.gbxSearchCatagory.TabIndex = 0;
            this.gbxSearchCatagory.TabStop = false;
            this.gbxSearchCatagory.Text = "Search Catagory";
            // 
            // cmbSubDepartment
            // 
            this.cmbSubDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubDepartment.FormattingEnabled = true;
            this.cmbSubDepartment.Location = new System.Drawing.Point(6, 165);
            this.cmbSubDepartment.Name = "cmbSubDepartment";
            this.cmbSubDepartment.Size = new System.Drawing.Size(196, 21);
            this.cmbSubDepartment.TabIndex = 6;
            this.cmbSubDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbSubDepartment_SelectedIndexChanged);
            // 
            // rdbSearchBySubDepartment
            // 
            this.rdbSearchBySubDepartment.AutoSize = true;
            this.rdbSearchBySubDepartment.Location = new System.Drawing.Point(6, 142);
            this.rdbSearchBySubDepartment.Name = "rdbSearchBySubDepartment";
            this.rdbSearchBySubDepartment.Size = new System.Drawing.Size(154, 17);
            this.rdbSearchBySubDepartment.TabIndex = 5;
            this.rdbSearchBySubDepartment.TabStop = true;
            this.rdbSearchBySubDepartment.Text = "Search By Sub Department";
            this.rdbSearchBySubDepartment.UseVisualStyleBackColor = true;
            this.rdbSearchBySubDepartment.CheckedChanged += new System.EventHandler(this.rdbSearchBySubDepartment_CheckedChanged);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(6, 115);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(196, 21);
            this.cmbDepartment.TabIndex = 4;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // rdbSearchByDepartment
            // 
            this.rdbSearchByDepartment.AutoSize = true;
            this.rdbSearchByDepartment.Location = new System.Drawing.Point(6, 92);
            this.rdbSearchByDepartment.Name = "rdbSearchByDepartment";
            this.rdbSearchByDepartment.Size = new System.Drawing.Size(132, 17);
            this.rdbSearchByDepartment.TabIndex = 3;
            this.rdbSearchByDepartment.TabStop = true;
            this.rdbSearchByDepartment.Text = "Search By Department";
            this.rdbSearchByDepartment.UseVisualStyleBackColor = true;
            this.rdbSearchByDepartment.CheckedChanged += new System.EventHandler(this.rdbSearchByDepartment_CheckedChanged);
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(6, 65);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(196, 21);
            this.cmbBranch.TabIndex = 2;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // rdbSearchByBranch
            // 
            this.rdbSearchByBranch.AutoSize = true;
            this.rdbSearchByBranch.Location = new System.Drawing.Point(6, 42);
            this.rdbSearchByBranch.Name = "rdbSearchByBranch";
            this.rdbSearchByBranch.Size = new System.Drawing.Size(111, 17);
            this.rdbSearchByBranch.TabIndex = 1;
            this.rdbSearchByBranch.TabStop = true;
            this.rdbSearchByBranch.Text = "Search By Branch";
            this.rdbSearchByBranch.UseVisualStyleBackColor = true;
            this.rdbSearchByBranch.CheckedChanged += new System.EventHandler(this.rdbSearchByBranch_CheckedChanged);
            // 
            // rdbAllEmployees
            // 
            this.rdbAllEmployees.AutoSize = true;
            this.rdbAllEmployees.Checked = true;
            this.rdbAllEmployees.Location = new System.Drawing.Point(6, 19);
            this.rdbAllEmployees.Name = "rdbAllEmployees";
            this.rdbAllEmployees.Size = new System.Drawing.Size(90, 17);
            this.rdbAllEmployees.TabIndex = 0;
            this.rdbAllEmployees.TabStop = true;
            this.rdbAllEmployees.Text = "All Employees";
            this.rdbAllEmployees.UseVisualStyleBackColor = true;
            this.rdbAllEmployees.CheckedChanged += new System.EventHandler(this.rdbAllEmployees_CheckedChanged);
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
            this.btnClose.Location = new System.Drawing.Point(764, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 19;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 547);
            this.Controls.Add(this.gbxEmployeeList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeList";
            this.Text = "EmployeeList";
            this.Load += new System.EventHandler(this.frmEmployeeList_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEmployeeList_MouseDown);
            this.gbxEmployeeList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.gbxSearchCatagory.ResumeLayout(false);
            this.gbxSearchCatagory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.GroupBox gbxEmployeeList;
        private System.Windows.Forms.GroupBox gbxSearchCatagory;
        private System.Windows.Forms.RadioButton rdbAllEmployees;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.RadioButton rdbSearchBySubDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.RadioButton rdbSearchByDepartment;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.RadioButton rdbSearchByBranch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTokenNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSubDepartment;
    }
}