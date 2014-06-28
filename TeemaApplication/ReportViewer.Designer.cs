namespace TeemaApplication
{
    partial class frmReportViewer
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
            this.crytalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFormTopic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crytalReportViewer
            // 
            this.crytalReportViewer.ActiveViewIndex = -1;
            this.crytalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crytalReportViewer.CachedPageNumberPerDoc = 10;
            this.crytalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crytalReportViewer.Location = new System.Drawing.Point(12, 52);
            this.crytalReportViewer.Name = "crytalReportViewer";
            this.crytalReportViewer.ShowCloseButton = false;
            this.crytalReportViewer.ShowGroupTreeButton = false;
            this.crytalReportViewer.ShowLogo = false;
            this.crytalReportViewer.ShowParameterPanelButton = false;
            this.crytalReportViewer.Size = new System.Drawing.Size(841, 474);
            this.crytalReportViewer.TabIndex = 0;
            this.crytalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.btnClose.Location = new System.Drawing.Point(823, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 19;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFormTopic
            // 
            this.lblFormTopic.AutoSize = true;
            this.lblFormTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTopic.Location = new System.Drawing.Point(12, 9);
            this.lblFormTopic.Name = "lblFormTopic";
            this.lblFormTopic.Size = new System.Drawing.Size(186, 31);
            this.lblFormTopic.TabIndex = 18;
            this.lblFormTopic.Text = "Report Viewer";
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 538);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFormTopic);
            this.Controls.Add(this.crytalReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportViewer";
            this.Text = "Report Viewer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmReportViewer_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crytalReportViewer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFormTopic;
    }
}