namespace TeemaApplication
{
    partial class frmCreateOverTime
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
            this.gbxSearchCatagory = new System.Windows.Forms.GroupBox();
            this.cmbSubDepartment = new System.Windows.Forms.ComboBox();
            this.rdbSearchBySubDepartment = new System.Windows.Forms.RadioButton();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.rdbSearchByDepartment = new System.Windows.Forms.RadioButton();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.rdbSearchByBranch = new System.Windows.Forms.RadioButton();
            this.rdbAllEmployees = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpOvertimeDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gbxSearchCatagory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(213, 31);
            this.lblFormTopic.TabIndex = 19;
            this.lblFormTopic.Text = "Create Overtime";
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
            this.btnClose.Location = new System.Drawing.Point(491, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 26;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.gbxSearchCatagory.Location = new System.Drawing.Point(12, 43);
            this.gbxSearchCatagory.Name = "gbxSearchCatagory";
            this.gbxSearchCatagory.Size = new System.Drawing.Size(208, 193);
            this.gbxSearchCatagory.TabIndex = 27;
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
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(6, 115);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(196, 21);
            this.cmbDepartment.TabIndex = 4;
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
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(6, 65);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(196, 21);
            this.cmbBranch.TabIndex = 2;
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpOvertimeDate);
            this.groupBox1.Location = new System.Drawing.Point(226, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 176);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overtime Details";
            // 
            // dtpOvertimeDate
            // 
            this.dtpOvertimeDate.Location = new System.Drawing.Point(87, 45);
            this.dtpOvertimeDate.Name = "dtpOvertimeDate";
            this.dtpOvertimeDate.Size = new System.Drawing.Size(202, 20);
            this.dtpOvertimeDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Overtime Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Week";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Day";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(87, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Supervisor";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(87, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(202, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reason";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(87, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(202, 20);
            this.textBox5.TabIndex = 12;
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
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 246);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Print Form";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmCreateOverTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 531);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxSearchCatagory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateOverTime";
            this.Text = "Create Over Time Request";
            this.Load += new System.EventHandler(this.frmCreateOverTime_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCreateOverTime_MouseDown);
            this.gbxSearchCatagory.ResumeLayout(false);
            this.gbxSearchCatagory.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxSearchCatagory;
        private System.Windows.Forms.ComboBox cmbSubDepartment;
        private System.Windows.Forms.RadioButton rdbSearchBySubDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.RadioButton rdbSearchByDepartment;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.RadioButton rdbSearchByBranch;
        private System.Windows.Forms.RadioButton rdbAllEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpOvertimeDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}