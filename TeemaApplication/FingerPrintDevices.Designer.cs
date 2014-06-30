namespace TeemaApplication
{
    partial class frmFingerPrintDevices
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnANDDTestDevice = new System.Windows.Forms.Button();
            this.txtANDDIpAddress = new System.Windows.Forms.TextBox();
            this.btnANDDAddNew = new System.Windows.Forms.Button();
            this.txtANDDPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtANDDIpPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbANDDCommunicationType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtANDDDeviceName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEDDTestDevice = new System.Windows.Forms.Button();
            this.txtEDDIpAddress = new System.Windows.Forms.TextBox();
            this.btnEDDDone = new System.Windows.Forms.Button();
            this.txtEDDPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEDDIpPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEDDCommunicationType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEDDDeviceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEDDDeviceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdvDeviceDetails = new System.Windows.Forms.DataGridView();
            this.clmnDeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCommunicationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnIPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnIPPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDeviceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(249, 31);
            this.lblFormTopic.TabIndex = 24;
            this.lblFormTopic.Text = "Fingerprint Devices";
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
            this.btnClose.TabIndex = 31;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnANDDTestDevice);
            this.groupBox3.Controls.Add(this.txtANDDIpAddress);
            this.groupBox3.Controls.Add(this.btnANDDAddNew);
            this.groupBox3.Controls.Add(this.txtANDDPassword);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtANDDIpPort);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbANDDCommunicationType);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtANDDDeviceName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 180);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Device Details";
            // 
            // btnANDDTestDevice
            // 
            this.btnANDDTestDevice.Location = new System.Drawing.Point(123, 150);
            this.btnANDDTestDevice.Name = "btnANDDTestDevice";
            this.btnANDDTestDevice.Size = new System.Drawing.Size(75, 23);
            this.btnANDDTestDevice.TabIndex = 17;
            this.btnANDDTestDevice.Text = "Test Device";
            this.btnANDDTestDevice.UseVisualStyleBackColor = true;
            this.btnANDDTestDevice.Click += new System.EventHandler(this.btnANDDTestDevice_Click);
            // 
            // txtANDDIpAddress
            // 
            this.txtANDDIpAddress.Location = new System.Drawing.Point(130, 71);
            this.txtANDDIpAddress.Name = "txtANDDIpAddress";
            this.txtANDDIpAddress.Size = new System.Drawing.Size(149, 20);
            this.txtANDDIpAddress.TabIndex = 16;
            // 
            // btnANDDAddNew
            // 
            this.btnANDDAddNew.Location = new System.Drawing.Point(204, 150);
            this.btnANDDAddNew.Name = "btnANDDAddNew";
            this.btnANDDAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnANDDAddNew.TabIndex = 15;
            this.btnANDDAddNew.Text = "Add New";
            this.btnANDDAddNew.UseVisualStyleBackColor = true;
            this.btnANDDAddNew.Click += new System.EventHandler(this.btnANDDAddNew_Click);
            // 
            // txtANDDPassword
            // 
            this.txtANDDPassword.Location = new System.Drawing.Point(130, 124);
            this.txtANDDPassword.Name = "txtANDDPassword";
            this.txtANDDPassword.Size = new System.Drawing.Size(149, 20);
            this.txtANDDPassword.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password";
            // 
            // txtANDDIpPort
            // 
            this.txtANDDIpPort.Location = new System.Drawing.Point(130, 98);
            this.txtANDDIpPort.Name = "txtANDDIpPort";
            this.txtANDDIpPort.Size = new System.Drawing.Size(149, 20);
            this.txtANDDIpPort.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "IP Port";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "IP Address";
            // 
            // cmbANDDCommunicationType
            // 
            this.cmbANDDCommunicationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbANDDCommunicationType.FormattingEnabled = true;
            this.cmbANDDCommunicationType.Location = new System.Drawing.Point(130, 45);
            this.cmbANDDCommunicationType.Name = "cmbANDDCommunicationType";
            this.cmbANDDCommunicationType.Size = new System.Drawing.Size(149, 21);
            this.cmbANDDCommunicationType.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Communication Type";
            // 
            // txtANDDDeviceName
            // 
            this.txtANDDDeviceName.Location = new System.Drawing.Point(130, 19);
            this.txtANDDDeviceName.Name = "txtANDDDeviceName";
            this.txtANDDDeviceName.Size = new System.Drawing.Size(149, 20);
            this.txtANDDDeviceName.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Device Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEDDTestDevice);
            this.groupBox2.Controls.Add(this.txtEDDIpAddress);
            this.groupBox2.Controls.Add(this.btnEDDDone);
            this.groupBox2.Controls.Add(this.txtEDDPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEDDIpPort);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbEDDCommunicationType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEDDDeviceName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtEDDDeviceID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(303, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 206);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Device Details";
            // 
            // btnEDDTestDevice
            // 
            this.btnEDDTestDevice.Location = new System.Drawing.Point(123, 176);
            this.btnEDDTestDevice.Name = "btnEDDTestDevice";
            this.btnEDDTestDevice.Size = new System.Drawing.Size(75, 23);
            this.btnEDDTestDevice.TabIndex = 18;
            this.btnEDDTestDevice.Text = "Test Device";
            this.btnEDDTestDevice.UseVisualStyleBackColor = true;
            this.btnEDDTestDevice.Click += new System.EventHandler(this.btnEDDTestDevice_Click);
            // 
            // txtEDDIpAddress
            // 
            this.txtEDDIpAddress.Location = new System.Drawing.Point(130, 98);
            this.txtEDDIpAddress.Name = "txtEDDIpAddress";
            this.txtEDDIpAddress.Size = new System.Drawing.Size(149, 20);
            this.txtEDDIpAddress.TabIndex = 16;
            // 
            // btnEDDDone
            // 
            this.btnEDDDone.Location = new System.Drawing.Point(204, 176);
            this.btnEDDDone.Name = "btnEDDDone";
            this.btnEDDDone.Size = new System.Drawing.Size(75, 23);
            this.btnEDDDone.TabIndex = 15;
            this.btnEDDDone.Text = "Done";
            this.btnEDDDone.UseVisualStyleBackColor = true;
            this.btnEDDDone.Click += new System.EventHandler(this.btnEDDDone_Click);
            // 
            // txtEDDPassword
            // 
            this.txtEDDPassword.Location = new System.Drawing.Point(130, 150);
            this.txtEDDPassword.Name = "txtEDDPassword";
            this.txtEDDPassword.Size = new System.Drawing.Size(149, 20);
            this.txtEDDPassword.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password";
            // 
            // txtEDDIpPort
            // 
            this.txtEDDIpPort.Location = new System.Drawing.Point(130, 124);
            this.txtEDDIpPort.Name = "txtEDDIpPort";
            this.txtEDDIpPort.Size = new System.Drawing.Size(149, 20);
            this.txtEDDIpPort.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "IP Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IP Address";
            // 
            // cmbEDDCommunicationType
            // 
            this.cmbEDDCommunicationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEDDCommunicationType.FormattingEnabled = true;
            this.cmbEDDCommunicationType.Location = new System.Drawing.Point(130, 71);
            this.cmbEDDCommunicationType.Name = "cmbEDDCommunicationType";
            this.cmbEDDCommunicationType.Size = new System.Drawing.Size(149, 21);
            this.cmbEDDCommunicationType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Communication Type";
            // 
            // txtEDDDeviceName
            // 
            this.txtEDDDeviceName.Location = new System.Drawing.Point(130, 45);
            this.txtEDDDeviceName.Name = "txtEDDDeviceName";
            this.txtEDDDeviceName.Size = new System.Drawing.Size(149, 20);
            this.txtEDDDeviceName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Device Name";
            // 
            // txtEDDDeviceID
            // 
            this.txtEDDDeviceID.Location = new System.Drawing.Point(130, 19);
            this.txtEDDDeviceID.Name = "txtEDDDeviceID";
            this.txtEDDDeviceID.ReadOnly = true;
            this.txtEDDDeviceID.Size = new System.Drawing.Size(149, 20);
            this.txtEDDDeviceID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gdvDeviceDetails);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 245);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // gdvDeviceDetails
            // 
            this.gdvDeviceDetails.AllowUserToAddRows = false;
            this.gdvDeviceDetails.AllowUserToDeleteRows = false;
            this.gdvDeviceDetails.AllowUserToOrderColumns = true;
            this.gdvDeviceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvDeviceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDeviceDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnDeviceID,
            this.clmnDeviceName,
            this.clmnCommunicationType,
            this.clmnIPAddress,
            this.clmnIPPort,
            this.clmnPassword});
            this.gdvDeviceDetails.Location = new System.Drawing.Point(6, 19);
            this.gdvDeviceDetails.Name = "gdvDeviceDetails";
            this.gdvDeviceDetails.ReadOnly = true;
            this.gdvDeviceDetails.RowHeadersVisible = false;
            this.gdvDeviceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvDeviceDetails.Size = new System.Drawing.Size(564, 220);
            this.gdvDeviceDetails.TabIndex = 0;
            this.gdvDeviceDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvDeviceDetails_CellClick);
            // 
            // clmnDeviceID
            // 
            this.clmnDeviceID.DataPropertyName = "deviceID";
            this.clmnDeviceID.HeaderText = "Device ID";
            this.clmnDeviceID.Name = "clmnDeviceID";
            this.clmnDeviceID.ReadOnly = true;
            // 
            // clmnDeviceName
            // 
            this.clmnDeviceName.DataPropertyName = "name";
            this.clmnDeviceName.HeaderText = "Device Name";
            this.clmnDeviceName.Name = "clmnDeviceName";
            this.clmnDeviceName.ReadOnly = true;
            // 
            // clmnCommunicationType
            // 
            this.clmnCommunicationType.DataPropertyName = "comType";
            this.clmnCommunicationType.HeaderText = "Com. Type";
            this.clmnCommunicationType.Name = "clmnCommunicationType";
            this.clmnCommunicationType.ReadOnly = true;
            // 
            // clmnIPAddress
            // 
            this.clmnIPAddress.DataPropertyName = "ipAddress";
            this.clmnIPAddress.HeaderText = "IP Address";
            this.clmnIPAddress.Name = "clmnIPAddress";
            this.clmnIPAddress.ReadOnly = true;
            // 
            // clmnIPPort
            // 
            this.clmnIPPort.DataPropertyName = "ipPort";
            this.clmnIPPort.HeaderText = "IP Port";
            this.clmnIPPort.Name = "clmnIPPort";
            this.clmnIPPort.ReadOnly = true;
            // 
            // clmnPassword
            // 
            this.clmnPassword.DataPropertyName = "password";
            this.clmnPassword.HeaderText = "Password";
            this.clmnPassword.Name = "clmnPassword";
            this.clmnPassword.ReadOnly = true;
            // 
            // frmFingerPrintDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 513);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFingerPrintDevices";
            this.Text = "Finger Print Devices";
            this.Load += new System.EventHandler(this.frmFingerPrintDevices_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmFingerPrintDevices_MouseDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvDeviceDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnANDDTestDevice;
        private System.Windows.Forms.TextBox txtANDDIpAddress;
        private System.Windows.Forms.Button btnANDDAddNew;
        private System.Windows.Forms.TextBox txtANDDPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtANDDIpPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbANDDCommunicationType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtANDDDeviceName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEDDTestDevice;
        private System.Windows.Forms.TextBox txtEDDIpAddress;
        private System.Windows.Forms.Button btnEDDDone;
        private System.Windows.Forms.TextBox txtEDDPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEDDIpPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEDDCommunicationType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEDDDeviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEDDDeviceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gdvDeviceDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDeviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCommunicationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnIPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnIPPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPassword;
    }
}