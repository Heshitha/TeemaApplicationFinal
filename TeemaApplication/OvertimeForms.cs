using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeemaApplication.Classes;
using TeemaApplication.Datasets;
using TeemaApplication.Reports;

namespace TeemaApplication
{
    public partial class frmOvertimeForms : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmOvertimeForms()
        {
            InitializeComponent();
        }

        private void frmOvertimeForms_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmOvertimeForms_Load(object sender, EventArgs e)
        {
            fillcmbFormNo();
        }

        private void fillcmbFormNo()
        {
            cmbFormNo.DisplayMember = "OTID";
            cmbFormNo.ValueMember = "OTID";
            cmbFormNo.DataSource = db.OverTimeRecords.ToList();
        }

        private void cmbFormNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            OverTimeRecord oTRec = (OverTimeRecord)cmbFormNo.SelectedItem;
            OvertimeEmployeeDetail firstRec = oTRec.OvertimeEmployeeDetails.FirstOrDefault();
            if (firstRec != null)
            {
                txtBranch.Text = firstRec.Employee.Department.Branch.BranchName;
                txtDepartment.Text = firstRec.Employee.Department.DepartmentName;
                txtSubDepartment.Text = firstRec.Employee.IsAssignedToSubDepartment ? firstRec.Employee.SubDepartment.SubDepartmentName : "Not Assigned";
            }

            txtOvertimeDate.Text = oTRec.OvertimeDate.ToString("dd - MMMM - yyyy");
            DateTimeFormatInfo dtfi = DateTimeFormatInfo.CurrentInfo;
            Calendar calender = dtfi.Calendar;
            txtWeek.Text = calender.GetWeekOfYear(DateTime.Now, dtfi.CalendarWeekRule, dtfi.FirstDayOfWeek).ToString();
            txtDay.Text = DateTime.Now.DayOfWeek.ToString();
            txtSupervisor.Text = oTRec.Supervisor;
            txtReason.Text = oTRec.Reason;

            DataTable dt = new DataTable();
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("Name");
            dt.Columns.Add("Operation");
            dt.Columns.Add("NormalFrom");
            dt.Columns.Add("ShiftTo");
            dt.Columns.Add("OTFrom");
            dt.Columns.Add("OTTo");

            foreach (OvertimeEmployeeDetail x in oTRec.OvertimeEmployeeDetails)
            {
                try
                {
                    if (oTRec.ApprovedBy != null)
                    {
                        string Operation = x.Operation;
                        string NormalFrom = x.StartFrom.Value.ToString("HHmm");
                        string ShiftTo = x.ShiftTo.Value.ToString("HHmm");
                        string OTFrom = x.OTFrom.Value.ToString("HHmm");
                        string OTTo = x.OTTo.Value.ToString("HHmm");

                        dt.Rows.Add(x.Employee.TokenNo, x.Employee.Name, Operation, NormalFrom, ShiftTo, OTFrom, OTTo);
                    }
                    else
                    {
                        dt.Rows.Add(x.Employee.TokenNo, x.Employee.Name, "", "", "", "", "");
                    }
                }
                catch (Exception)
                {
                    
                }
            }

            dgvEmployeeDetails.DataSource = dt;
        }

        private void btnPrintForm_Click(object sender, EventArgs e)
        {
            OverTimeRecord otrec = (OverTimeRecord)cmbFormNo.SelectedItem;
            OvertimeReportDataSet otds = new OvertimeReportDataSet();
            OvertimeReportDataSet.OvertimeDetailsRow otRow = otds.OvertimeDetails.NewOvertimeDetailsRow();
            otRow.FormNo = otrec.OTID;
            otRow.Date = otrec.OvertimeDate;
            DateTimeFormatInfo dtfi = DateTimeFormatInfo.CurrentInfo;
            Calendar calender = dtfi.Calendar;
            otRow.Week = calender.GetWeekOfYear(otrec.OvertimeDate, dtfi.CalendarWeekRule, dtfi.FirstDayOfWeek);
            otRow.Day = otrec.OvertimeDate.DayOfWeek.ToString();
            otRow.Supervisor = otrec.Supervisor;
            otRow.Reason = otrec.Reason;
            otRow.CreatedBy = otrec.UserAccount1.Name;
            otRow.CreatedDate = otrec.CreatedDate;
            otRow.ModifiedBy = otrec.UserAccount2.Name;
            otRow.ModifiedDate = otrec.ModifiedDate;
            otRow.ApprovedBy = otrec.ApprovedBy != null ? otrec.UserAccount.Name : "Not Approved";
            if (otrec.ApprovedBy != null) { otRow.ApprovedDate = otrec.ApprovedDate.Value; }

            otds.OvertimeDetails.AddOvertimeDetailsRow(otRow);

            int count = 0;

            foreach (OvertimeEmployeeDetail x in otrec.OvertimeEmployeeDetails)
            {
                count++;
                OvertimeReportDataSet.OvertimeEmployeeDetailsRow otedRow = otds.OvertimeEmployeeDetails.NewOvertimeEmployeeDetailsRow();
                otedRow.FormNo = x.OTID;
                otedRow.SerialNo = count;
                otedRow.TokenNo = x.Employee.TokenNo.ToString();
                otedRow.Name = x.Employee.Name;
                if (!string.IsNullOrEmpty(x.Operation)) { otedRow.Operation = x.Operation; }
                if (x.StartFrom != null) { otedRow.NormalFrom = x.StartFrom.Value; }
                if (x.ShiftTo != null) { otedRow.ShiftTo = x.ShiftTo.Value; }
                if (x.OTFrom != null) { otedRow.OTFrom = x.OTFrom.Value; }
                if (x.OTTo != null) { otedRow.OTTo = x.OTTo.Value; }

                otds.OvertimeEmployeeDetails.AddOvertimeEmployeeDetailsRow(otedRow);
            }

            OverTimeRequestForm rpt = new OverTimeRequestForm();
            rpt.SetDataSource(otds);
            frmReportViewer frm = new frmReportViewer(rpt);
            frm.ShowDialog();
        }
    }
}
