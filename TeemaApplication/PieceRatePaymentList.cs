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
    public partial class frmPieceRatePaymentList : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmPieceRatePaymentList()
        {
            InitializeComponent();
        }

        private void frmPieceRatePaymentList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmPieceRatePaymentList_Load(object sender, EventArgs e)
        {
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
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
                cmbSubDepartment.DataBindings.Clear();
                cmbSubDepartment.Enabled = false;
                fillPieceRateDetails();
                fillAvaragePieceRateDetails();
            }
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilities.fillDepartmentComboBox((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
        }

        private void fillPieceRateDetails()
        {
            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Today;
            if (rdbDepartmentMonthlyReport.Checked)
            {
                DateTime dt = dtpSelectedDate.Value;
                startDate = new DateTime(dt.Year, dt.Month, 1);
                endDate = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
            }
            else if(rdbDepartmentDailyReport.Checked)
            {
                DateTime dt = dtpSelectedDate.Value;
                startDate = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
                endDate = new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59);
            }

            System.Data.Linq.EntitySet<Employee> lstEmployee = new System.Data.Linq.EntitySet<Employee>();
            

            if (chbSearchFromSubDepartment.Checked)
            {
                lstEmployee = ((SubDepartment)cmbSubDepartment.SelectedItem).Employees;
            }
            else
            {
                lstEmployee = ((Department)cmbDepartment.SelectedItem).Employees;
            }

            var records = from x in lstEmployee
                          join y in db.EnteredPieceRateForEmployees on x.EmployeeID equals y.EmployeeID
                          where y.PieceRateDetail.Date >= startDate && y.PieceRateDetail.Date <= endDate
                          group y by new{ x.EmployeeID, x.Name, x.TokenNo } into g
                          select new
                          {
                              g.Key.TokenNo,
                              g.Key.Name,
                              TotalValue = g.Sum(s => s.PieceQty*s.PieceRateDetail.UnitRate).Value.ToString("0.00")
                          };

            DataTable datatable = new DataTable();
            datatable.Columns.Add("TokenNo");
            datatable.Columns.Add("Name");
            datatable.Columns.Add("TotalValue");

            foreach (var rec in records)
            {
                datatable.Rows.Add(rec.TokenNo, rec.Name, rec.TotalValue);
            }

            dgvPieceRateDetails.DataSource = datatable;
        }

        private void fillAvaragePieceRateDetails()
        {
            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Today;
            if (rdbDepartmentMonthlyReport.Checked)
            {
                DateTime dt = dtpSelectedDate.Value;
                startDate = new DateTime(dt.Year, dt.Month, 1);
                endDate = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
            }
            else if (rdbDepartmentDailyReport.Checked)
            {
                DateTime dt = dtpSelectedDate.Value;
                startDate = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
                endDate = new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59);
            }

            System.Data.Linq.EntitySet<Employee> lstEmployee = new System.Data.Linq.EntitySet<Employee>();


            if (chbSearchFromSubDepartment.Checked)
            {
                lstEmployee = ((SubDepartment)cmbSubDepartment.SelectedItem).Employees;
            }
            else
            {
                lstEmployee = ((Department)cmbDepartment.SelectedItem).Employees;
            }

            var records = from x in lstEmployee
                          join y in db.AvaragePieceRateForEmployees on x.EmployeeID equals y.EmployeeID
                          where y.PieceRateDetail.Date >= startDate && y.PieceRateDetail.Date <= endDate
                          group y by new { x.EmployeeID, x.Name, x.TokenNo } into g
                          select new
                          {
                              g.Key.TokenNo,
                              g.Key.Name,
                              TotalValue = g.Sum(s => s.AvaragePayment).Value.ToString("0.00")
                          };

            DataTable datatable = new DataTable();
            datatable.Columns.Add("TokenNo");
            datatable.Columns.Add("Name");
            datatable.Columns.Add("TotalValue");

            foreach (var rec in records)
            {
                datatable.Rows.Add(rec.TokenNo, rec.Name, rec.TotalValue);
            }

            dgvAveragePieceRateDetails.DataSource = datatable;
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPieceRateDetails();
            fillAvaragePieceRateDetails();
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
                cmbSubDepartment.DataBindings.Clear();
                cmbSubDepartment.Enabled = false;
                fillPieceRateDetails();
                fillAvaragePieceRateDetails();
            }
        }

        private void dtpSelectedDate_ValueChanged(object sender, EventArgs e)
        {
            fillPieceRateDetails();
            fillAvaragePieceRateDetails();
        }

        private void rdbDepartmentMonthlyReport_CheckedChanged(object sender, EventArgs e)
        {
            fillPieceRateDetails();
            fillAvaragePieceRateDetails();
        }

        private void rdbDepartmentDailyReport_CheckedChanged(object sender, EventArgs e)
        {
            fillPieceRateDetails();
            fillAvaragePieceRateDetails();
        }

        private void btnPrintForm_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void printPieceRateReport()
        {
            PieceRateReportDataSet prds = new PieceRateReportDataSet();

            

            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Today;
            if (rdbDepartmentMonthlyReport.Checked)
            {
                DateTime dt = dtpSelectedDate.Value;
                startDate = new DateTime(dt.Year, dt.Month, 1);
                endDate = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
            }
            else if (rdbDepartmentDailyReport.Checked)
            {
                DateTime dt = dtpSelectedDate.Value;
                startDate = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
                endDate = new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59);
            }

            System.Data.Linq.EntitySet<Employee> lstEmployee = new System.Data.Linq.EntitySet<Employee>();


            if (chbSearchFromSubDepartment.Checked)
            {
                lstEmployee = ((SubDepartment)cmbSubDepartment.SelectedItem).Employees;
            }
            else
            {
                lstEmployee = ((Department)cmbDepartment.SelectedItem).Employees;
            }

            var AverageRecords = from x in lstEmployee
                                 join y in db.AvaragePieceRateForEmployees on x.EmployeeID equals y.EmployeeID
                                 where y.PieceRateDetail.Date >= startDate && y.PieceRateDetail.Date <= endDate
                                 group y by new { x.EmployeeID, x.Name, x.TokenNo } into g
                                 select new
                                 {
                                     g.Key.TokenNo,
                                     g.Key.Name,
                                     TotalValue = g.Sum(s => s.AvaragePayment).Value.ToString("0.00")
                                 };


            var EnteredRecords = from x in lstEmployee
                                 join y in db.EnteredPieceRateForEmployees on x.EmployeeID equals y.EmployeeID
                                 where y.PieceRateDetail.Date >= startDate && y.PieceRateDetail.Date <= endDate
                                 group y by new { x.EmployeeID, x.Name, x.TokenNo } into g
                                 select new
                                 {
                                     g.Key.TokenNo,
                                     g.Key.Name,
                                     TotalValue = g.Sum(s => s.PieceQty * s.PieceRateDetail.UnitRate).Value.ToString("0.00")
                                 };
        }
    }
}
