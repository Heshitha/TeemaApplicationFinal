﻿namespace TeemaApplication
{
    partial class frmUserAccountList
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
            this.gbxUserAccountList = new System.Windows.Forms.GroupBox();
            this.dgvUserAccountList = new System.Windows.Forms.DataGridView();
            this.clmnUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPriviledge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxUserAccountList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAccountList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(228, 31);
            this.lblFormTopic.TabIndex = 13;
            this.lblFormTopic.Text = "User Account List";
            // 
            // gbxUserAccountList
            // 
            this.gbxUserAccountList.Controls.Add(this.dgvUserAccountList);
            this.gbxUserAccountList.Location = new System.Drawing.Point(13, 44);
            this.gbxUserAccountList.Name = "gbxUserAccountList";
            this.gbxUserAccountList.Size = new System.Drawing.Size(526, 335);
            this.gbxUserAccountList.TabIndex = 14;
            this.gbxUserAccountList.TabStop = false;
            // 
            // dgvUserAccountList
            // 
            this.dgvUserAccountList.AllowUserToAddRows = false;
            this.dgvUserAccountList.AllowUserToDeleteRows = false;
            this.dgvUserAccountList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserAccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserAccountList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnUserID,
            this.clmnName,
            this.clmnUserName,
            this.clmnPriviledge});
            this.dgvUserAccountList.Location = new System.Drawing.Point(7, 20);
            this.dgvUserAccountList.Name = "dgvUserAccountList";
            this.dgvUserAccountList.ReadOnly = true;
            this.dgvUserAccountList.RowHeadersVisible = false;
            this.dgvUserAccountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserAccountList.Size = new System.Drawing.Size(513, 309);
            this.dgvUserAccountList.TabIndex = 0;
            this.dgvUserAccountList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserAccountList_CellClick);
            // 
            // clmnUserID
            // 
            this.clmnUserID.DataPropertyName = "UserID";
            this.clmnUserID.HeaderText = "User ID";
            this.clmnUserID.Name = "clmnUserID";
            this.clmnUserID.ReadOnly = true;
            // 
            // clmnName
            // 
            this.clmnName.DataPropertyName = "Name";
            this.clmnName.HeaderText = "Name";
            this.clmnName.Name = "clmnName";
            this.clmnName.ReadOnly = true;
            // 
            // clmnUserName
            // 
            this.clmnUserName.DataPropertyName = "UserName";
            this.clmnUserName.HeaderText = "User Name";
            this.clmnUserName.Name = "clmnUserName";
            this.clmnUserName.ReadOnly = true;
            // 
            // clmnPriviledge
            // 
            this.clmnPriviledge.DataPropertyName = "Priviledge";
            this.clmnPriviledge.HeaderText = "Priviledge";
            this.clmnPriviledge.Name = "clmnPriviledge";
            this.clmnPriviledge.ReadOnly = true;
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
            this.btnClose.Location = new System.Drawing.Point(509, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 29;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUserAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 391);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbxUserAccountList);
            this.Controls.Add(this.lblFormTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserAccountList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account List";
            this.Load += new System.EventHandler(this.frmUserAccountList_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUserAccountList_MouseDown);
            this.gbxUserAccountList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAccountList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTopic;
        private System.Windows.Forms.GroupBox gbxUserAccountList;
        private System.Windows.Forms.DataGridView dgvUserAccountList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPriviledge;
        private System.Windows.Forms.Button btnClose;
    }
}