namespace TeemaApplication
{
    partial class frmEditUserAccount
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
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxAccountDetails = new System.Windows.Forms.GroupBox();
            this.cmbPriviledge = new System.Windows.Forms.ComboBox();
            this.lblPriviledge = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.gbxAccountDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(6, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(232, 31);
            this.lblFormTopic.TabIndex = 14;
            this.lblFormTopic.Text = "Edit User Account";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxAccountDetails
            // 
            this.gbxAccountDetails.Controls.Add(this.cmbPriviledge);
            this.gbxAccountDetails.Controls.Add(this.lblPriviledge);
            this.gbxAccountDetails.Controls.Add(this.lblUserName);
            this.gbxAccountDetails.Controls.Add(this.txtUserName);
            this.gbxAccountDetails.Controls.Add(this.lblName);
            this.gbxAccountDetails.Controls.Add(this.txtName);
            this.gbxAccountDetails.Location = new System.Drawing.Point(12, 43);
            this.gbxAccountDetails.Name = "gbxAccountDetails";
            this.gbxAccountDetails.Size = new System.Drawing.Size(260, 98);
            this.gbxAccountDetails.TabIndex = 17;
            this.gbxAccountDetails.TabStop = false;
            // 
            // cmbPriviledge
            // 
            this.cmbPriviledge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriviledge.FormattingEnabled = true;
            this.cmbPriviledge.Items.AddRange(new object[] {
            "View Only",
            "View And Insert Only",
            "View, Insert And Edit"});
            this.cmbPriviledge.Location = new System.Drawing.Point(103, 71);
            this.cmbPriviledge.Name = "cmbPriviledge";
            this.cmbPriviledge.Size = new System.Drawing.Size(151, 21);
            this.cmbPriviledge.TabIndex = 8;
            // 
            // lblPriviledge
            // 
            this.lblPriviledge.AutoSize = true;
            this.lblPriviledge.Location = new System.Drawing.Point(6, 74);
            this.lblPriviledge.Name = "lblPriviledge";
            this.lblPriviledge.Size = new System.Drawing.Size(53, 13);
            this.lblPriviledge.TabIndex = 7;
            this.lblPriviledge.Text = "Priviledge";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 48);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(103, 45);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(151, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 2;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(87, 147);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(103, 23);
            this.btnResetPassword.TabIndex = 19;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // frmEditUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxAccountDetails);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditUserAccount";
            this.Text = "Edit User Account";
            this.gbxAccountDetails.ResumeLayout(false);
            this.gbxAccountDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxAccountDetails;
        private System.Windows.Forms.ComboBox cmbPriviledge;
        private System.Windows.Forms.Label lblPriviledge;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnResetPassword;
    }
}