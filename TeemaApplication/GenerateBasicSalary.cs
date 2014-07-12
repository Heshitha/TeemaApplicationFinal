using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
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
    public partial class frmGenerateBasicSalary : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmGenerateBasicSalary()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmGenerateBasicSalary_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmGenerateBasicSalary_Load(object sender, EventArgs e)
        {
            cmbYear.SelectedIndex = cmbYear.Items.IndexOf(DateTime.Today.Year.ToString());
            cmbMonth.SelectedIndex = DateTime.Today.Month - 1;
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
        }

        private void cmbLeaveYear_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            }
        }

        private void btnGenerateSalary_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GenerateSalaryDataSet gsds = new GenerateSalaryDataSet();

            EntitySet<Employee> lstEmployee = new EntitySet<Employee>();
            if (chbSearchFromSubDepartment.Checked)
            {
                lstEmployee = ((SubDepartment)cmbSubDepartment.SelectedItem).Employees;
            }
            else
            {
                lstEmployee = ((Department)cmbDepartment.SelectedItem).Employees;
            }

            int year = Convert.ToInt32(cmbYear.Text);
            int month = cmbMonth.SelectedIndex + 1;

            DateTime startDate = new DateTime(year, month, 1, 0, 0, 0);
            DateTime endDate = new DateTime(year, month, DateTime.DaysInMonth(year, month), 23, 59, 59);

            double singleOTRate = Utilities.getDoubleValueFromTextBox(txtSingleOTRate);
            double doubleOTRate = Utilities.getDoubleValueFromTextBox(txtDoubleOTRate);
            double tripleOTRate = Utilities.getDoubleValueFromTextBox(txtTripleOTRate);

            foreach (Employee emp in lstEmployee)
            {
                try
                {
                    double? NPDaysCount = (from pl in emp.PersonalLeaveRecords
                                           where pl.LeaveDate >= startDate && pl.LeaveDate <= endDate && pl.IsNoPay.Value == true
                                           select pl.LeaveValue).Sum();

                    double? PaidLeave = (from pl in emp.PersonalLeaveRecords
                                         where pl.LeaveDate >= startDate && pl.LeaveDate <= endDate && pl.IsNoPay.Value == true
                                         select pl.LeaveValue).Sum();

                    GenerateSalaryDataSet.SalaryDetailsRow detailsRow = gsds.SalaryDetails.NewSalaryDetailsRow();

                    detailsRow.TokenNo = emp.TokenNo.ToString();
                    detailsRow.EPFNo = emp.EPFNo;
                    detailsRow.EmployeeName = emp.Name;
                    detailsRow.Designation = emp.Designation.Designation1;
                    detailsRow.EmployeeCatarogy = emp.EmployeeCatagory;
                    detailsRow.EmployeeGrade = emp.EmployeeGrade;
                    detailsRow.BasicSalary = emp.SalaryDetail.BasicSalary.ToString("0.00");
                    detailsRow.BudgetedAllowance = emp.SalaryDetail.BudgetAllowance.ToString("0.00");
                    detailsRow.Total = (emp.SalaryDetail.BasicSalary + emp.SalaryDetail.BudgetAllowance).ToString("0.00");
                    detailsRow.NPDays = NPDaysCount != null ? NPDaysCount.Value.ToString() : "0";
                    detailsRow.PaidLeaveDays = PaidLeave != null ? PaidLeave.Value.ToString() : "0";



                    gsds.SalaryDetails.AddSalaryDetailsRow(detailsRow);
                }
                catch (Exception)
                {
                }
            }

            dgvGeneratedSalary.DataSource = gsds.SalaryDetails;

            Cursor.Current = Cursors.Default;
        }
    }
}
