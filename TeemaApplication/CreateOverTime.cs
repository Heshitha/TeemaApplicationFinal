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
using System.Globalization;

namespace TeemaApplication
{
    public partial class frmCreateOverTime : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        EmployeeDataSet ds = new EmployeeDataSet();

        int overtimeID = 0;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmCreateOverTime()
        {
            InitializeComponent();
        }

        private void frmCreateOverTime_Load(object sender, EventArgs e)
        {
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
            DateTimeFormatInfo dtfi = DateTimeFormatInfo.CurrentInfo;
            Calendar calender = dtfi.Calendar;
            txtWeek.Text = calender.GetWeekOfYear(DateTime.Now, dtfi.CalendarWeekRule, dtfi.FirstDayOfWeek).ToString();
            txtDay.Text = DateTime.Now.DayOfWeek.ToString();
            
        }

        private void frmCreateOverTime_MouseDown(object sender, MouseEventArgs e)
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

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilities.fillDepartmentComboBox((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chbSearchFromSubDepartment.Checked)
            {
                Utilities.fillSubDepartmentComboBox((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
                cmbSubDepartment.Enabled = true;
            }
            else
            {
                cmbSubDepartment.Enabled = false;
                cmbSubDepartment.DataBindings.Clear();
                FillEmployeesByDepartment();
            }
        }

        private void chbSearchFromSubDepartment_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSearchFromSubDepartment.Checked)
            {
                Utilities.fillSubDepartmentComboBox((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
                cmbSubDepartment.Enabled = true;
            }
            else
            {
                cmbSubDepartment.Enabled = false;
                cmbSubDepartment.DataBindings.Clear();
                FillEmployeesByDepartment();
            }
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillEmployeesBySubDepartment();
        }

        private void FillEmployeesBySubDepartment()
        {
            SubDepartment subdepartment = (SubDepartment)cmbSubDepartment.SelectedItem;
            DataTable dt = new DataTable();
            dt.Columns.Add("Entitled", typeof(bool));
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("Name");

            foreach (Employee employee in subdepartment.Employees)
            {
                dt.Rows.Add(false, employee.TokenNo, employee.Name);
            }

            dgvEmployeeDetails.DataSource = dt;
        }

        private void FillEmployeesByDepartment()
        {
            Department department = (Department)cmbDepartment.SelectedItem;
            DataTable dt = new DataTable();
            dt.Columns.Add("Entitled", typeof(bool));
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("Name");

            foreach (Employee employee in department.Employees)
            {
                dt.Rows.Add(false, employee.TokenNo, employee.Name);
            }

            dgvEmployeeDetails.DataSource = dt;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (true)
            {
                int overTimeType = 0;
                if (cmbType.Text == "Single")
                {
                    overTimeType = 1;
                }
                else if (cmbType.Text == "Double")
                {
                    overTimeType = 2;
                }
                else if (cmbType.Text == "Triple")
                {
                    overTimeType = 3;
                }
                OverTimeRecord otRecord = new OverTimeRecord
                    {
                        OvertimeDate = dtpOvertimeDate.Value,
                        Supervisor = txtSupervisor.Text,
                        Reason = txtReason.Text,
                        Type = overTimeType,
                        CreatedBy = LoginDetails.LoggedUsedID,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = LoginDetails.LoggedUsedID,
                        ModifiedDate = DateTime.Now
                    };

                db.OverTimeRecords.InsertOnSubmit(otRecord);
                db.SubmitChanges();

                foreach (DataGridViewRow row in dgvEmployeeDetails.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["clmnEntitled"].Value.ToString()) == true)
                    {
                        try
                        {
                            string tokenNo = row.Cells["clmnTokenNo"].Value.ToString().Trim();
                            Employee employee = db.Employees.Where(emp => emp.TokenNo.Equals(tokenNo)).Single();
                            //string shiftStartText = row.Cells["clmnStartFrom"].Value.ToString();
                            //string shiftEndText = row.Cells["clmnShiftTo"].Value.ToString();
                            //string otStartText = row.Cells["clmnOTFrom"].Value.ToString();
                            //string otEndText = row.Cells["clmnOTTo"].Value.ToString();
                            //string Operation = row.Cells["clmnOperation"].Value.ToString();

                            //DateTime shiftStart = generateDateTimeInstanceFromTime(shiftStartText);
                            //DateTime shiftEnd = generateDateTimeInstanceFromTime(shiftEndText);
                            //DateTime otStart = generateDateTimeInstanceFromTime(otStartText);
                            //DateTime otEnd = generateDateTimeInstanceFromTime(otEndText);

                            OvertimeEmployeeDetail overEmpDet = new OvertimeEmployeeDetail
                            {
                                OverTimeRecord = otRecord,
                                Employee = employee,
                                //Operation = Operation,
                                //StartFrom = shiftStart,
                                //ShiftTo = shiftEnd,
                                //OTFrom = otStart,
                                //OTTo = otEnd,
                                CreatedBy = LoginDetails.LoggedUsedID,
                                CreatedDate = DateTime.Now,
                                ModifiedBy = LoginDetails.LoggedUsedID,
                                ModifiedDate = DateTime.Now
                            };

                            db.OvertimeEmployeeDetails.InsertOnSubmit(overEmpDet);
                            db.SubmitChanges();

                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }

                Utilities.ShowInformationBox("You have successfully created overtime request. Press print form button to get the printed copy.");
                btnPrintForm.Enabled = true;
                overtimeID = otRecord.OTID;
                txtFormNo.Text = otRecord.OTID.ToString();
            }
            else
            {
                Utilities.ShowErrorBox("Looks like you have to fill details in table. Please make sure that operation field is requiered and time must be enterd as 24h format. Eg : 7.30 PM must be 1930.");
            }
        }

        private DateTime generateDateTimeInstanceFromTime(string TimeText)
        {
            int HourHalf = Convert.ToInt32(TimeText.Substring(0,2));
            int MinuteHalf = Convert.ToInt32(TimeText.Substring(2,2));

            DateTime overtimeDate = dtpOvertimeDate.Value;
            DateTime dateTimeInstance = new DateTime(overtimeDate.Year, overtimeDate.Month, overtimeDate.Day, HourHalf, MinuteHalf, 0);
            return dateTimeInstance;
        }

        private void btnPrintForm_Click(object sender, EventArgs e)
        {
            OverTimeRecord otrec = db.OverTimeRecords.Where(otrc => otrc.OTID == overtimeID).Single();
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
                //otedRow.Operation = x.Operation;
                //otedRow.NormalFrom = x.StartFrom;
                //otedRow.ShiftTo = x.ShiftTo;
                //otedRow.OTFrom = x.OTFrom;
                //otedRow.OTTo = x.OTTo;

                otds.OvertimeEmployeeDetails.AddOvertimeEmployeeDetailsRow(otedRow);
            }

            OverTimeRequestForm rpt = new OverTimeRequestForm();
            rpt.SetDataSource(otds);
            frmReportViewer frm = new frmReportViewer(rpt);
            frm.ShowDialog();
        }

        private void dtpOvertimeDate_ValueChanged(object sender, EventArgs e)
        {
            DateTimeFormatInfo dtfi = DateTimeFormatInfo.CurrentInfo;
            Calendar calender = dtfi.Calendar;
            txtWeek.Text = calender.GetWeekOfYear(dtpOvertimeDate.Value, dtfi.CalendarWeekRule, dtfi.FirstDayOfWeek).ToString();
            txtDay.Text = dtpOvertimeDate.Value.DayOfWeek.ToString();
        }

        private void txtSupervisor_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainText(txtSupervisor);
        }

        private void txtReason_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainText(txtReason);
        }

        private bool checkIfDataGridViewFilledCorrectly()
        {
            bool result = true;
            foreach (DataGridViewRow row in dgvEmployeeDetails.Rows)
            {
                if (Convert.ToBoolean(row.Cells["clmnEntitled"].Value.ToString()) == true)
                {
                    try
                    {
                        string shiftStartText = row.Cells["clmnStartFrom"].Value.ToString();
                        string shiftEndText = row.Cells["clmnShiftTo"].Value.ToString();
                        string otStartText = row.Cells["clmnOTFrom"].Value.ToString();
                        string otEndText = row.Cells["clmnOTTo"].Value.ToString();
                        string Operation = row.Cells["clmnOperation"].Value.ToString();

                        DateTime shiftStart = generateDateTimeInstanceFromTime(shiftStartText);
                        DateTime shiftEnd = generateDateTimeInstanceFromTime(shiftEndText);
                        DateTime otStart = generateDateTimeInstanceFromTime(otStartText);
                        DateTime otEnd = generateDateTimeInstanceFromTime(otEndText);

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
            }
            return result;
        }
    }
}
