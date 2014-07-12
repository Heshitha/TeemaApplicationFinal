using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeemaApplication.Datasets;
using TeemaApplication.Classes;
using TeemaApplication.Reports;

namespace TeemaApplication
{
    public partial class frmViewSecurityRoutine : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmViewSecurityRoutine()
        {
            InitializeComponent();
        }

        private void frmViewSecurityRoutine_Load(object sender, EventArgs e)
        {
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
        }

        private void frmViewSecurityRoutine_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Branch branch = (Branch)cmbWorkingBranch.SelectedItem;
            DateTime dt01 = dtpStartingDate.Value;
            DateTime dt02 = dtpEndDate.Value;

            DateTime startingDate = new DateTime(dt01.Year, dt01.Month, dt01.Day, 0, 0, 0);
            DateTime endingDate = new DateTime(dt02.Year, dt02.Month, dt02.Day, 23, 59, 59);

            var records = from x in db.EmployeeAttendances
                          where x.Employee.Department.Branch == branch && x.DateAndTime >= startingDate && x.DateAndTime <= endingDate && (x.Mode == "Go Out On" || x.Mode == "Go Out Off") && x.Employee.Designation.Designation1.ToLower().Contains("security")
                          select new
                          {
                              TokenNo = x.Employee.TokenNo,
                              Device = x.FingerPrintDivice.DeviceName,
                              Name = x.Employee.Name,
                              DateTime = x.DateAndTime.Value
                          };

            dgvRoutineDetails.DataSource = records.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtpStartingDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartingDate.Value;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartingDate.MaxDate = dtpEndDate.Value;
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            Branch branch = (Branch)cmbWorkingBranch.SelectedItem;
            DateTime dt01 = dtpStartingDate.Value;
            DateTime dt02 = dtpEndDate.Value;

            DateTime startingDate = new DateTime(dt01.Year, dt01.Month, dt01.Day, 0, 0, 0);
            DateTime endingDate = new DateTime(dt02.Year, dt02.Month, dt02.Day, 23, 59, 59);

            var records = from x in db.EmployeeAttendances
                          where x.Employee.Department.Branch == branch && x.DateAndTime >= startingDate && x.DateAndTime <= endingDate && (x.Mode == "Go Out On" || x.Mode == "Go Out Off") && x.Employee.Designation.Designation1.ToLower().Contains("security")
                          select new
                          {
                              TokenNo = x.Employee.TokenNo,
                              Device = x.FingerPrintDivice.DeviceName,
                              Name = x.Employee.Name,
                              DateTime = x.DateAndTime.Value
                          };

            SecurityRoutineReportDataset ds = new SecurityRoutineReportDataset();
            ds.SecurityReportMain.AddSecurityReportMainRow(1, startingDate, endingDate, branch.BranchName, LoginDetails.LoggedUserName, DateTime.Now);

            foreach (var rec in records)
            {
                ds.SecurityReportDetails.AddSecurityReportDetailsRow(1, rec.TokenNo, rec.Device, rec.Name, rec.DateTime);
            }

            SecurityRoutineReport rpt = new SecurityRoutineReport();
            rpt.SetDataSource(ds);

            frmReportViewer frm = new frmReportViewer(rpt);
            frm.ShowDialog();
        }
    }
}
