namespace TeemaApplication
{
    partial class frmTeemaApplicationMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddNewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overtimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOvertimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveOvertimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOvertimeFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryAdvanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSalaryAdvanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveSalaryAdvanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pieceRateCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterPieceRateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pieceRatePaymentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fingerPrintDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFingerPrintDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAttendanceDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSecurityRoutineReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSecurityRoutineByEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGrantedLeavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayOffApplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveDayOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryLoanRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryLoanApproveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanInstallmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.deductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmployee,
            this.tsmiUserAccount,
            this.overtimeToolStripMenuItem,
            this.salaryAdvanceToolStripMenuItem,
            this.pieceRateCalculationToolStripMenuItem,
            this.fingerPrintDevicesToolStripMenuItem,
            this.securityToolStripMenuItem,
            this.leaveToolStripMenuItem,
            this.dayOffToolStripMenuItem,
            this.salaryLoanToolStripMenuItem,
            this.deductionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1216, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tsmiEmployee
            // 
            this.tsmiEmployee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNewEmployee,
            this.tsmiViewEmployee});
            this.tsmiEmployee.Name = "tsmiEmployee";
            this.tsmiEmployee.Size = new System.Drawing.Size(71, 20);
            this.tsmiEmployee.Text = "Employee";
            // 
            // tsmiAddNewEmployee
            // 
            this.tsmiAddNewEmployee.Name = "tsmiAddNewEmployee";
            this.tsmiAddNewEmployee.Size = new System.Drawing.Size(178, 22);
            this.tsmiAddNewEmployee.Text = "Add New Employee";
            this.tsmiAddNewEmployee.Click += new System.EventHandler(this.tsmiAddNewEmployee_Click);
            // 
            // tsmiViewEmployee
            // 
            this.tsmiViewEmployee.Name = "tsmiViewEmployee";
            this.tsmiViewEmployee.Size = new System.Drawing.Size(178, 22);
            this.tsmiViewEmployee.Text = "View Employee List";
            this.tsmiViewEmployee.Click += new System.EventHandler(this.tsmiViewEmployee_Click);
            // 
            // tsmiUserAccount
            // 
            this.tsmiUserAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.createAccountToolStripMenuItem,
            this.viewAccountsListToolStripMenuItem});
            this.tsmiUserAccount.Name = "tsmiUserAccount";
            this.tsmiUserAccount.Size = new System.Drawing.Size(90, 20);
            this.tsmiUserAccount.Text = "User Account";
            this.tsmiUserAccount.Click += new System.EventHandler(this.userAccountsToolStripMenuItem_Click);
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.myAccountToolStripMenuItem.Text = "My Account";
            this.myAccountToolStripMenuItem.Click += new System.EventHandler(this.myAccountToolStripMenuItem_Click);
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // viewAccountsListToolStripMenuItem
            // 
            this.viewAccountsListToolStripMenuItem.Name = "viewAccountsListToolStripMenuItem";
            this.viewAccountsListToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.viewAccountsListToolStripMenuItem.Text = "View Accounts List";
            this.viewAccountsListToolStripMenuItem.Click += new System.EventHandler(this.viewAccountsListToolStripMenuItem_Click);
            // 
            // overtimeToolStripMenuItem
            // 
            this.overtimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOvertimeToolStripMenuItem,
            this.approveOvertimeToolStripMenuItem,
            this.viewOvertimeFormsToolStripMenuItem});
            this.overtimeToolStripMenuItem.Name = "overtimeToolStripMenuItem";
            this.overtimeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.overtimeToolStripMenuItem.Text = "Overtime";
            // 
            // createOvertimeToolStripMenuItem
            // 
            this.createOvertimeToolStripMenuItem.Name = "createOvertimeToolStripMenuItem";
            this.createOvertimeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.createOvertimeToolStripMenuItem.Text = "Create Overtime";
            this.createOvertimeToolStripMenuItem.Click += new System.EventHandler(this.createOvertimeToolStripMenuItem_Click);
            // 
            // approveOvertimeToolStripMenuItem
            // 
            this.approveOvertimeToolStripMenuItem.Name = "approveOvertimeToolStripMenuItem";
            this.approveOvertimeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.approveOvertimeToolStripMenuItem.Text = "Approve Overtime";
            this.approveOvertimeToolStripMenuItem.Click += new System.EventHandler(this.approveOvertimeToolStripMenuItem_Click);
            // 
            // viewOvertimeFormsToolStripMenuItem
            // 
            this.viewOvertimeFormsToolStripMenuItem.Name = "viewOvertimeFormsToolStripMenuItem";
            this.viewOvertimeFormsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewOvertimeFormsToolStripMenuItem.Text = "View Overtime Forms";
            this.viewOvertimeFormsToolStripMenuItem.Click += new System.EventHandler(this.viewOvertimeFormsToolStripMenuItem_Click);
            // 
            // salaryAdvanceToolStripMenuItem
            // 
            this.salaryAdvanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSalaryAdvanceToolStripMenuItem,
            this.approveSalaryAdvanceToolStripMenuItem});
            this.salaryAdvanceToolStripMenuItem.Name = "salaryAdvanceToolStripMenuItem";
            this.salaryAdvanceToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.salaryAdvanceToolStripMenuItem.Text = "Salary Advance";
            // 
            // createSalaryAdvanceToolStripMenuItem
            // 
            this.createSalaryAdvanceToolStripMenuItem.Name = "createSalaryAdvanceToolStripMenuItem";
            this.createSalaryAdvanceToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.createSalaryAdvanceToolStripMenuItem.Text = "Create Salary Advance";
            this.createSalaryAdvanceToolStripMenuItem.Click += new System.EventHandler(this.createSalaryAdvanceToolStripMenuItem_Click);
            // 
            // approveSalaryAdvanceToolStripMenuItem
            // 
            this.approveSalaryAdvanceToolStripMenuItem.Name = "approveSalaryAdvanceToolStripMenuItem";
            this.approveSalaryAdvanceToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.approveSalaryAdvanceToolStripMenuItem.Text = "Approve Salary Advance";
            this.approveSalaryAdvanceToolStripMenuItem.Click += new System.EventHandler(this.approveSalaryAdvanceToolStripMenuItem_Click);
            // 
            // pieceRateCalculationToolStripMenuItem
            // 
            this.pieceRateCalculationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterPieceRateDetailsToolStripMenuItem,
            this.pieceRatePaymentListToolStripMenuItem});
            this.pieceRateCalculationToolStripMenuItem.Name = "pieceRateCalculationToolStripMenuItem";
            this.pieceRateCalculationToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.pieceRateCalculationToolStripMenuItem.Text = "Piece Rate Calculation";
            // 
            // enterPieceRateDetailsToolStripMenuItem
            // 
            this.enterPieceRateDetailsToolStripMenuItem.Name = "enterPieceRateDetailsToolStripMenuItem";
            this.enterPieceRateDetailsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.enterPieceRateDetailsToolStripMenuItem.Text = "Enter Piece Rate Details";
            this.enterPieceRateDetailsToolStripMenuItem.Click += new System.EventHandler(this.enterPieceRateDetailsToolStripMenuItem_Click);
            // 
            // pieceRatePaymentListToolStripMenuItem
            // 
            this.pieceRatePaymentListToolStripMenuItem.Name = "pieceRatePaymentListToolStripMenuItem";
            this.pieceRatePaymentListToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.pieceRatePaymentListToolStripMenuItem.Text = "Piece Rate Payment List";
            this.pieceRatePaymentListToolStripMenuItem.Click += new System.EventHandler(this.pieceRatePaymentListToolStripMenuItem_Click);
            // 
            // fingerPrintDevicesToolStripMenuItem
            // 
            this.fingerPrintDevicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFingerPrintDevicesToolStripMenuItem,
            this.loadAttendanceDetailsToolStripMenuItem});
            this.fingerPrintDevicesToolStripMenuItem.Name = "fingerPrintDevicesToolStripMenuItem";
            this.fingerPrintDevicesToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.fingerPrintDevicesToolStripMenuItem.Text = "Finger Print Devices";
            // 
            // viewFingerPrintDevicesToolStripMenuItem
            // 
            this.viewFingerPrintDevicesToolStripMenuItem.Name = "viewFingerPrintDevicesToolStripMenuItem";
            this.viewFingerPrintDevicesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.viewFingerPrintDevicesToolStripMenuItem.Text = "View Finger Print Devices";
            this.viewFingerPrintDevicesToolStripMenuItem.Click += new System.EventHandler(this.viewFingerPrintDevicesToolStripMenuItem_Click);
            // 
            // loadAttendanceDetailsToolStripMenuItem
            // 
            this.loadAttendanceDetailsToolStripMenuItem.Name = "loadAttendanceDetailsToolStripMenuItem";
            this.loadAttendanceDetailsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.loadAttendanceDetailsToolStripMenuItem.Text = "Load Attendance Details";
            this.loadAttendanceDetailsToolStripMenuItem.Click += new System.EventHandler(this.loadAttendanceDetailsToolStripMenuItem_Click);
            // 
            // securityToolStripMenuItem
            // 
            this.securityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSecurityRoutineReportToolStripMenuItem,
            this.viewSecurityRoutineByEmployeeToolStripMenuItem});
            this.securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            this.securityToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.securityToolStripMenuItem.Text = "Security";
            // 
            // viewSecurityRoutineReportToolStripMenuItem
            // 
            this.viewSecurityRoutineReportToolStripMenuItem.Name = "viewSecurityRoutineReportToolStripMenuItem";
            this.viewSecurityRoutineReportToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.viewSecurityRoutineReportToolStripMenuItem.Text = "View Security Routine Report";
            this.viewSecurityRoutineReportToolStripMenuItem.Click += new System.EventHandler(this.viewSecurityRoutineReportToolStripMenuItem_Click);
            // 
            // viewSecurityRoutineByEmployeeToolStripMenuItem
            // 
            this.viewSecurityRoutineByEmployeeToolStripMenuItem.Name = "viewSecurityRoutineByEmployeeToolStripMenuItem";
            this.viewSecurityRoutineByEmployeeToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.viewSecurityRoutineByEmployeeToolStripMenuItem.Text = "View Security Routine By Employee";
            // 
            // leaveToolStripMenuItem
            // 
            this.leaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editGrantedLeavesToolStripMenuItem,
            this.applyLeaveToolStripMenuItem,
            this.approveLeaveToolStripMenuItem});
            this.leaveToolStripMenuItem.Name = "leaveToolStripMenuItem";
            this.leaveToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.leaveToolStripMenuItem.Text = "Leave";
            // 
            // editGrantedLeavesToolStripMenuItem
            // 
            this.editGrantedLeavesToolStripMenuItem.Name = "editGrantedLeavesToolStripMenuItem";
            this.editGrantedLeavesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.editGrantedLeavesToolStripMenuItem.Text = "Edit Granted Leaves";
            this.editGrantedLeavesToolStripMenuItem.Click += new System.EventHandler(this.editGrantedLeavesToolStripMenuItem_Click);
            // 
            // applyLeaveToolStripMenuItem
            // 
            this.applyLeaveToolStripMenuItem.Name = "applyLeaveToolStripMenuItem";
            this.applyLeaveToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.applyLeaveToolStripMenuItem.Text = "Apply Leave";
            this.applyLeaveToolStripMenuItem.Click += new System.EventHandler(this.applyLeaveToolStripMenuItem_Click);
            // 
            // approveLeaveToolStripMenuItem
            // 
            this.approveLeaveToolStripMenuItem.Name = "approveLeaveToolStripMenuItem";
            this.approveLeaveToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.approveLeaveToolStripMenuItem.Text = "Approve Leave";
            this.approveLeaveToolStripMenuItem.Click += new System.EventHandler(this.approveLeaveToolStripMenuItem_Click);
            // 
            // dayOffToolStripMenuItem
            // 
            this.dayOffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayOffApplyToolStripMenuItem,
            this.approveDayOffToolStripMenuItem});
            this.dayOffToolStripMenuItem.Name = "dayOffToolStripMenuItem";
            this.dayOffToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.dayOffToolStripMenuItem.Text = "Day Off";
            // 
            // dayOffApplyToolStripMenuItem
            // 
            this.dayOffApplyToolStripMenuItem.Name = "dayOffApplyToolStripMenuItem";
            this.dayOffApplyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dayOffApplyToolStripMenuItem.Text = "Day Off Apply";
            this.dayOffApplyToolStripMenuItem.Click += new System.EventHandler(this.dayOffApplyToolStripMenuItem_Click);
            // 
            // approveDayOffToolStripMenuItem
            // 
            this.approveDayOffToolStripMenuItem.Name = "approveDayOffToolStripMenuItem";
            this.approveDayOffToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.approveDayOffToolStripMenuItem.Text = "Approve Day Off";
            this.approveDayOffToolStripMenuItem.Click += new System.EventHandler(this.approveDayOffToolStripMenuItem_Click);
            // 
            // salaryLoanToolStripMenuItem
            // 
            this.salaryLoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaryLoanRequestToolStripMenuItem,
            this.salaryLoanApproveToolStripMenuItem,
            this.loanInstallmentToolStripMenuItem});
            this.salaryLoanToolStripMenuItem.Name = "salaryLoanToolStripMenuItem";
            this.salaryLoanToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.salaryLoanToolStripMenuItem.Text = "Salary Loan";
            // 
            // salaryLoanRequestToolStripMenuItem
            // 
            this.salaryLoanRequestToolStripMenuItem.Name = "salaryLoanRequestToolStripMenuItem";
            this.salaryLoanRequestToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.salaryLoanRequestToolStripMenuItem.Text = "Salary Loan Request";
            this.salaryLoanRequestToolStripMenuItem.Click += new System.EventHandler(this.salaryLoanRequestToolStripMenuItem_Click);
            // 
            // salaryLoanApproveToolStripMenuItem
            // 
            this.salaryLoanApproveToolStripMenuItem.Name = "salaryLoanApproveToolStripMenuItem";
            this.salaryLoanApproveToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.salaryLoanApproveToolStripMenuItem.Text = "Salary Loan Approve";
            this.salaryLoanApproveToolStripMenuItem.Click += new System.EventHandler(this.salaryLoanApproveToolStripMenuItem_Click);
            // 
            // loanInstallmentToolStripMenuItem
            // 
            this.loanInstallmentToolStripMenuItem.Name = "loanInstallmentToolStripMenuItem";
            this.loanInstallmentToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.loanInstallmentToolStripMenuItem.Text = "Loan Installment";
            this.loanInstallmentToolStripMenuItem.Click += new System.EventHandler(this.loanInstallmentToolStripMenuItem_Click);
            // 
            // deductionToolStripMenuItem
            // 
            this.deductionToolStripMenuItem.Name = "deductionToolStripMenuItem";
            this.deductionToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.deductionToolStripMenuItem.Text = "Deduction";
            this.deductionToolStripMenuItem.Click += new System.EventHandler(this.deductionToolStripMenuItem_Click);
            // 
            // frmTeemaApplicationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 561);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmTeemaApplicationMain";
            this.Text = "Employee Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeemaApplicationMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserAccount;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAccountsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overtimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOvertimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approveOvertimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOvertimeFormsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryAdvanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSalaryAdvanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pieceRateCalculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterPieceRateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pieceRatePaymentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fingerPrintDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFingerPrintDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approveSalaryAdvanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAttendanceDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSecurityRoutineReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSecurityRoutineByEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGrantedLeavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approveLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayOffApplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approveDayOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryLoanRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryLoanApproveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanInstallmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deductionToolStripMenuItem;
    }
}



