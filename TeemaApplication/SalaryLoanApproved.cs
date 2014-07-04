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
    public partial class frmSalaryLoanApproved : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmSalaryLoanApproved()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmSalaryLoanApproved_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmSalaryLoanApproved_Load(object sender, EventArgs e)
        {
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
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
                cmbSubDepartment.DataBindings.Clear();
                cmbSubDepartment.Enabled = false;
                fillLoanGridView();
            }
        }

        private void fillLoanGridView()
        {
            bool isUnapprovedOnly = chbUnApprovedOnly.Checked;

            System.Data.Linq.EntitySet<Employee> lstEmployee = new System.Data.Linq.EntitySet<Employee>();

            if (chbSearchFromSubDepartment.Checked)
            {
                lstEmployee = ((SubDepartment)cmbSubDepartment.SelectedItem).Employees;
            }
            else
            {
                lstEmployee = ((Department)cmbDepartment.SelectedItem).Employees;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("Name");
            dt.Columns.Add("LoanID");
            dt.Columns.Add("RequestedAmount");
            dt.Columns.Add("InstallmentAmount");
            dt.Columns.Add("NoOfInstallment");
            dt.Columns.Add("IsApproved");

            foreach (Employee emp in lstEmployee)
            {
                foreach (SalaryLoan sl in emp.SalaryLoans)
                {
                    double loanInstallment = (sl.TotalFromEPFSalary + sl.DayWagesAmount + sl.FixedIncentiveAmount).Value;

                    if (isUnapprovedOnly)
                    {
                        if (sl.IsApproved.Value == false)
                        {
                            dt.Rows.Add(emp.TokenNo, emp.Name, sl.SalaryLoanID, sl.RequestedAmount, loanInstallment, sl.NoOfInstallment, sl.IsApproved.ToString());
                        }
                    }
                    else
                    {
                        dt.Rows.Add(emp.TokenNo, emp.Name, sl.SalaryLoanID, sl.RequestedAmount, loanInstallment, sl.NoOfInstallment, sl.IsApproved.ToString());
                    }
                }
            }
            gdvLoanList.DataSource = dt;
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
                fillLoanGridView();
            }
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLoanGridView();
        }

        private void chbUnApprovedOnly_CheckedChanged(object sender, EventArgs e)
        {
            fillLoanGridView();
        }

        private void gdvLoanList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int loanID = Convert.ToInt32(gdvLoanList.SelectedRows[0].Cells[2].Value.ToString());
                SalaryLoan salLoan = db.SalaryLoans.Where(sl => sl.SalaryLoanID == loanID).SingleOrDefault();
                Employee emp = salLoan.Employee;

                txtEmployeeName.Text = emp.Name;
                txtDesignation.Text = emp.Designation.Designation1;
                txtNIC_No.Text = emp.NICNo;
                txtEPF_No.Text = emp.EPFNo;
                txtToken_No.Text = emp.TokenNo.ToString();

                txtLoanID.Text = salLoan.SalaryLoanID.ToString();
                txtRequestedAmount.Text = salLoan.RequestedAmount.Value.ToString("0.00");
                txtStartingDate.Text = salLoan.RequestedDate.Value.ToString("dd-MM-dddd");
                txtEpfSalary.Text = salLoan.TotalFromEPFSalary.Value.ToString("0.00");
                txtDayWages.Text = salLoan.DayWagesAmount.Value.ToString("0.00");
                txtFixedIncentiveAllowance.Text = salLoan.FixedIncentiveAmount.Value.ToString("0.00");

                double installmentAmount = (salLoan.TotalFromEPFSalary + salLoan.DayWagesAmount + salLoan.FixedIncentiveAmount).Value;
                txtInstallmentAmount.Text = installmentAmount.ToString("0.00");
                txtNumberOfMonths.Text = salLoan.NoOfInstallment.Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            
                try
                {
                    int loanID = Convert.ToInt32(gdvLoanList.SelectedRows[0].Cells[2].Value.ToString());
                    SalaryLoan salLoan = db.SalaryLoans.Where(sl => sl.SalaryLoanID == loanID).SingleOrDefault();

                    salLoan.IsApproved = true;
                    salLoan.ApprovedBy = 1;
                    salLoan.ApprovedDate = DateTime.Now;
                    salLoan.ModifiedBy = 1;
                    salLoan.ModifiedDate = DateTime.Now;

                    db.SubmitChanges();
                    Utilities.ShowInformationBox("Successfully approved the selected loan.");
                    resetForm();
                }
                catch (Exception)
                {

                }

        }

        private void resetForm()
        {
            txtEmployeeName.Text = string.Empty;
            txtDesignation.Text = string.Empty;
            txtNIC_No.Text = string.Empty;
            txtEPF_No.Text = string.Empty;
            txtToken_No.Text = string.Empty;

            txtLoanID.Text = string.Empty;
            txtRequestedAmount.Text = string.Empty;
            txtStartingDate.Text = string.Empty;
            txtEpfSalary.Text = "0";
            txtDayWages.Text = "0";
            txtFixedIncentiveAllowance.Text = "0";

            txtInstallmentAmount.Text = "0";
            txtNumberOfMonths.Text = "0";

            fillLoanGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }
    }
}
