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
using TeemaApplication.Classes;
using TeemaApplication.Datasets;
using TeemaApplication.Reports;

namespace TeemaApplication
{
    public partial class frmAttendanceReport : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmAttendanceReport()
        {
            InitializeComponent();
        }

        private void AttendanceReport_Load(object sender, EventArgs e)
        {
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
        }

        private void AttendanceReport_MouseDown(object sender, MouseEventArgs e)
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

        private void fillDataGridView()
        {
            try
            {
                System.Data.Linq.EntitySet<Employee> lstEmployee = new System.Data.Linq.EntitySet<Employee>();

                if (chbSearchFromSubDepartment.Checked)
                {
                    lstEmployee = ((SubDepartment)cmbSubDepartment.SelectedItem).Employees;
                }
                else
                {
                    lstEmployee = ((Department)cmbDepartment.SelectedItem).Employees;
                }

                DateTime dt = DateTime.Today;

                DateTime startDate = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
                DateTime endDate = new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59);

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("EPFNo");
                dataTable.Columns.Add("TokenNo");
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("DutyOnTime");
                dataTable.Columns.Add("DutyOffTime");
                dataTable.Columns.Add("Mode");

                foreach (Employee emp in lstEmployee)
                {
                    try
                    {
                        DateTime enteredTime = emp.EmployeeAttendances.Where(at => at.DateAndTime.Value >= startDate && at.DateAndTime.Value <= endDate).FirstOrDefault().DateAndTime.Value;
                        DateTime leaveTime = emp.EmployeeAttendances.Where(at => at.DateAndTime.Value >= startDate && at.DateAndTime.Value <= endDate && at.Mode == "Out").FirstOrDefault().DateAndTime.Value;
                        dataTable.Rows.Add(emp.EPFNo, emp.TokenNo, emp.Name, enteredTime.ToString("HH:mm"), leaveTime.ToString("HH:mm"), "Working Day");
                    }
                    catch (Exception)
                    {

                    }
                }

                dgvAttendanceDetails.DataSource = dataTable;
            }
            catch (Exception)
            {
                
            }
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
                fillDataGridView();
            }
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        private void dtpDateTime_ValueChanged(object sender, EventArgs e)
        {
            fillDataGridView();
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
                fillDataGridView();
            }
        }

        private void btnPrintForm_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.Linq.EntitySet<Employee> lstEmployee = new System.Data.Linq.EntitySet<Employee>();

                if (chbSearchFromSubDepartment.Checked)
                {
                    lstEmployee = ((SubDepartment)cmbSubDepartment.SelectedItem).Employees;
                }
                else
                {
                    lstEmployee = ((Department)cmbDepartment.SelectedItem).Employees;
                }

                DateTime dt = DateTime.Today;

                DateTime startDate = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
                DateTime endDate = new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59);

                AttendanceManagementDataSet amds = new AttendanceManagementDataSet();
                int i = 0;
                foreach (Employee emp in lstEmployee)
                {
                    try
                    {
                        DateTime enteredTime = emp.EmployeeAttendances.Where(at => at.DateAndTime.Value >= startDate && at.DateAndTime.Value <= endDate).FirstOrDefault().DateAndTime.Value;
                        DateTime leaveTime = emp.EmployeeAttendances.Where(at => at.DateAndTime.Value >= startDate && at.DateAndTime.Value <= endDate && at.Mode == "Out").FirstOrDefault().DateAndTime.Value;
                        //dataTable.Rows.Add(emp.EPFNo, emp.TokenNo, emp.Name, enteredTime.ToString("HH:mm"), leaveTime.ToString("HH:mm"), "Working Day");
                        i++;
                        amds.DailyAttendanceDetails.AddDailyAttendanceDetailsRow(i, emp.TokenNo, Convert.ToInt32(emp.EPFNo), emp.Name, startDate, enteredTime, leaveTime, "Working Day");
                    }
                    catch (Exception)
                    {

                    }
                }

                Reports.AttendanceReport rpt = new Reports.AttendanceReport();
                rpt.SetDataSource(amds);
                frmReportViewer frm = new frmReportViewer(rpt);
                frm.ShowDialog();
                
            }
            catch (Exception)
            {

            }
        }
    }
}
