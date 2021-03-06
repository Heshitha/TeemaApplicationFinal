﻿using System;
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
    public partial class frmApproveOvertime : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmApproveOvertime()
        {
            InitializeComponent();
        }

        private void ApproveOvertime_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void fillcmbFormNo()
        {
            cmbFormNo.DisplayMember = "OTID";
            cmbFormNo.ValueMember = "OTID";
            cmbFormNo.DataSource = db.OverTimeRecords.Where(ot => ot.ApprovedBy == null).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmApproveOvertime_Load(object sender, EventArgs e)
        {
            fillcmbFormNo();
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
                dt.Rows.Add(x.Employee.TokenNo, x.Employee.Name, "", "", "", "", "");
            }

            dgvEmployeeDetails.DataSource = dt;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            OverTimeRecord oTRec = (OverTimeRecord)cmbFormNo.SelectedItem;
            if (oTRec.ApprovedBy != null)
            {
                if (checkIfDataGridViewFilledCorrectly(oTRec.OvertimeDate))
                {
                    oTRec.ApprovedBy = LoginDetails.LoggedUsedID;
                    oTRec.ApprovedDate = DateTime.Now;
                    oTRec.ModifiedBy = LoginDetails.LoggedUsedID;
                    oTRec.ModifiedDate = DateTime.Now;

                    foreach (DataGridViewRow row in dgvEmployeeDetails.Rows)
                    {
                        int tokenNo = Convert.ToInt32(row.Cells["clmnTokenNo"].Value.ToString().Trim());
                        OvertimeEmployeeDetail otdetail = oTRec.OvertimeEmployeeDetails.Where(ot => ot.Employee.TokenNo == tokenNo).SingleOrDefault();

                        string shiftStartText = row.Cells["clmnNormalFrom"].Value.ToString();
                        string shiftEndText = row.Cells["clmnShiftTo"].Value.ToString();
                        string otStartText = row.Cells["clmnOTFrom"].Value.ToString();
                        string otEndText = row.Cells["clmnOTTo"].Value.ToString();
                        string Operation = row.Cells["clmnOperation"].Value.ToString();

                        DateTime shiftStart = generateDateTimeInstanceFromTime(shiftStartText, oTRec.OvertimeDate);
                        DateTime shiftEnd = generateDateTimeInstanceFromTime(shiftEndText, oTRec.OvertimeDate);
                        DateTime otStart = generateDateTimeInstanceFromTime(otStartText, oTRec.OvertimeDate);
                        DateTime otEnd = generateDateTimeInstanceFromTime(otEndText, oTRec.OvertimeDate);

                        otdetail.Operation = Operation;
                        otdetail.StartFrom = shiftStart;
                        otdetail.ShiftTo = shiftEnd;
                        otdetail.OTFrom = otStart;
                        otdetail.OTTo = otEnd;
                        otdetail.ModifiedBy = LoginDetails.LoggedUsedID;
                        otdetail.ModifiedDate = DateTime.Now;
                    }

                    db.SubmitChanges();
                    Utilities.ShowInformationBox("You have successfully approved over time details.");
                }
                else
                {
                    Utilities.ShowErrorBox("Looks like you have to fill details in table. Please make sure that operation field is requiered and time must be enterd as 24h format. Eg : 7.30 PM must be 1930.");
                }
            }
            else
            {
                Utilities.ShowErrorBox("You have already approved this overtime request.");
            }

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

        private bool checkIfDataGridViewFilledCorrectly(DateTime date)
        {
            bool result = true;
            foreach (DataGridViewRow row in dgvEmployeeDetails.Rows)
            {
                try
                {
                    string shiftStartText = row.Cells["clmnNormalFrom"].Value.ToString();
                    string shiftEndText = row.Cells["clmnShiftTo"].Value.ToString();
                    string otStartText = row.Cells["clmnOTFrom"].Value.ToString();
                    string otEndText = row.Cells["clmnOTTo"].Value.ToString();
                    string Operation = row.Cells["clmnOperation"].Value.ToString();

                    DateTime shiftStart = generateDateTimeInstanceFromTime(shiftStartText, date);
                    DateTime shiftEnd = generateDateTimeInstanceFromTime(shiftEndText, date);
                    DateTime otStart = generateDateTimeInstanceFromTime(otStartText, date);
                    DateTime otEnd = generateDateTimeInstanceFromTime(otEndText, date);

                    if (string.IsNullOrEmpty(Operation.Trim()))
                    {
                        result = false;
                    }
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            return result;
        }

        private DateTime generateDateTimeInstanceFromTime(string TimeText, DateTime overtimeDate)
        {
            int HourHalf = Convert.ToInt32(TimeText.Substring(0, 2));
            int MinuteHalf = Convert.ToInt32(TimeText.Substring(2, 2));

            DateTime dateTimeInstance = new DateTime(overtimeDate.Year, overtimeDate.Month, overtimeDate.Day, HourHalf, MinuteHalf, 0);
            return dateTimeInstance;
        }
    }
}
