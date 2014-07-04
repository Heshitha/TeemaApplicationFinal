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
    public partial class frmSalaryLoanInstallmentList : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmSalaryLoanInstallmentList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmSalaryLoanInstallmentList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmSalaryLoanInstallmentList_Load(object sender, EventArgs e)
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
                fillcmbEmployeeName(((Department)cmbDepartment.SelectedItem).Employees, cmbEmployeeName);
                fillcmbTokenNo(((Department)cmbDepartment.SelectedItem).Employees, cmbTokenNo);
            }
        }

        private void fillcmbEmployeeName(System.Data.Linq.EntitySet<Employee> lstEmployee, ComboBox comboBox)
        {
            comboBox.ValueMember = "EmployeeID";
            comboBox.DisplayMember = "Name";
            comboBox.DataSource = lstEmployee;
        }

        private void fillcmbTokenNo(System.Data.Linq.EntitySet<Employee> lstEmployee, ComboBox comboBox)
        {
            comboBox.ValueMember = "EmployeeID";
            comboBox.DisplayMember = "TokenNo";
            comboBox.DataSource = lstEmployee;
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilities.fillDepartmentComboBox((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
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
                fillcmbEmployeeName(((Department)cmbDepartment.SelectedItem).Employees, cmbEmployeeName);
                fillcmbTokenNo(((Department)cmbDepartment.SelectedItem).Employees, cmbTokenNo);
            }
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcmbEmployeeName(((SubDepartment)cmbSubDepartment.SelectedItem).Employees, cmbEmployeeName);
            fillcmbTokenNo(((SubDepartment)cmbSubDepartment.SelectedItem).Employees, cmbTokenNo);
        }

        private void fillcmbLoanID(Employee employee, ComboBox comboBox)
        {
            comboBox.ValueMember = "SalaryLoanID";
            comboBox.DisplayMember = "SalaryLoanID";
            comboBox.DataSource = employee.SalaryLoans.Where(sl => sl.IsApproved.Value == true).ToList();
        }

        private void cmbTokenNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)cmbTokenNo.SelectedItem;
            txtDesignation.Text = emp.Designation.Designation1;
            fillcmbLoanID(emp, cmbLoanId);
        }

        private void cmbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)cmbEmployeeName.SelectedItem;
            txtDesignation.Text = emp.Designation.Designation1;
        }

        private void cmbLoanId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SalaryLoan salaryLoan = (SalaryLoan)cmbLoanId.SelectedItem;
                if (salaryLoan != null)
                {
                    RefreshFields(salaryLoan);
                }
                else
                {
                    txtRequestedAmount.Text = string.Empty;
                    txtStartingDate.Text = string.Empty;
                    txtEpfSalary.Text = string.Empty;
                    txtDayWages.Text = string.Empty;
                    txtFixedIncentiveAllowance.Text = string.Empty;
                    txtInstallmentAmount.Text = string.Empty;
                    txtNumberOfMonths.Text = string.Empty;
                    gdvInstallmentList.DataSource = null;
                    txtStatus.Text = string.Empty;
                }
            }
            catch (Exception)
            {
            }
        }

        private void RefreshFields(SalaryLoan salaryLoan)
        {
            txtRequestedAmount.Text = salaryLoan.RequestedAmount.Value.ToString("0.00");
            txtStartingDate.Text = salaryLoan.RequestedDate.Value.ToString("dd-MM-yyyy");
            txtEpfSalary.Text = salaryLoan.TotalFromEPFSalary.Value.ToString("0.00");
            txtDayWages.Text = salaryLoan.DayWagesAmount.Value.ToString("0.00");
            txtFixedIncentiveAllowance.Text = salaryLoan.FixedIncentiveAmount.Value.ToString("0.00");
            txtInstallmentAmount.Text = (salaryLoan.TotalFromEPFSalary + salaryLoan.DayWagesAmount + salaryLoan.FixedIncentiveAmount).Value.ToString("0.00");
            txtNumberOfMonths.Text = salaryLoan.NoOfInstallment.Value.ToString();

            double totalPayedInstallment = (from x in salaryLoan.SalaryLoanInstallments select x.Amount).Sum().Value;
            if (totalPayedInstallment >= salaryLoan.RequestedAmount.Value)
            {
                txtStatus.Text = "Finished";
            }
            else
            {
                txtStatus.Text = "Unfinished";
            }

            fillInstallmentTable(salaryLoan);
        }

        private void fillInstallmentTable(SalaryLoan salaryLoan)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("paymentDate");
            dt.Columns.Add("payment");

            foreach (SalaryLoanInstallment salLoanIns in salaryLoan.SalaryLoanInstallments)
            {
                dt.Rows.Add(salLoanIns.PayedDate.Value.ToString("dd-MM-yyyy"), salLoanIns.Amount.Value.ToString("0.00"));
            }

            gdvInstallmentList.DataSource = dt;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            SalaryLoan salLoan = (SalaryLoan)cmbLoanId.SelectedItem;
            double amount = Utilities.getDoubleValueFromTextBox(txtAmount);
            SalaryLoanInstallment salLoanIns = new SalaryLoanInstallment
            {
                SalaryLoan = salLoan,
                Amount = amount,
                PayedDate = DateTime.Now,
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                ModifiedBy = 1,
                ModifiedDate = DateTime.Now,
            };

            db.SalaryLoanInstallments.InsertOnSubmit(salLoanIns);
            db.SubmitChanges();
            RefreshFields(salLoan);
        }

        private void checkRemainingValue()
        {
            try
            {
                SalaryLoan salLoan = (SalaryLoan)cmbLoanId.SelectedItem;
                double amount = Utilities.getDoubleValueFromTextBox(txtAmount);
                double totalPayedInstallment = (from x in salLoan.SalaryLoanInstallments select x.Amount).Sum().Value;

                double remainingAmount = salLoan.RequestedAmount.Value - totalPayedInstallment;
                if (remainingAmount < amount)
                {
                    Utilities.ShowErrorBox("You only have to pay " + remainingAmount.ToString("0.00") + " for finish this loan.");
                    txtAmount.Text = remainingAmount.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmbLoanId_DataSourceChanged(object sender, EventArgs e)
        {
            dynamic item = cmbLoanId.DataSource;
            if (item.Count == 0)
            {
                txtRequestedAmount.Text = string.Empty;
                txtStartingDate.Text = string.Empty;
                txtEpfSalary.Text = string.Empty;
                txtDayWages.Text = string.Empty;
                txtFixedIncentiveAllowance.Text = string.Empty;
                txtInstallmentAmount.Text = string.Empty;
                txtNumberOfMonths.Text = string.Empty;
                gdvInstallmentList.DataSource = null;
                txtStatus.Text = string.Empty;
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            checkRemainingValue();
        }
    }
}
