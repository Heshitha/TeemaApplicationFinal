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
    public partial class frmSalaryLoanRequest : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmSalaryLoanRequest()
        {
            InitializeComponent();
        }

        private void frmSalaryLoanRequest_Load(object sender, EventArgs e)
        {
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
        }

        private void frmSalaryLoanRequest_MouseDown(object sender, MouseEventArgs e)
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
                cmbSubDepartment.DataBindings.Clear();
                cmbSubDepartment.Enabled = false;
                fillLoanGridView();
            }
        }

        private void fillLoanGridView()
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

            bool Approved = chbApproved.Checked;
            bool Finished = chbFinished.Checked;
            bool unApproved = chbUnApproved.Checked;
            bool unFinished = chbUnFinished.Checked;

            if (!Approved && !unApproved && !unFinished && !Finished)
            {
                Utilities.ShowInformationBox("You haven't checked any filters before search. This will give you the employees who didn't requested any loans. If you want employees who have loans, Please check the check boxes.");
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("Name");
            dt.Columns.Add("LoanID");
            dt.Columns.Add("RequestedAmount");
            dt.Columns.Add("DeductionAmount");
            dt.Columns.Add("NumberOfMonth");
            dt.Columns.Add("IsApproved");

            foreach (Employee emp in lstEmployee)
            {
                var salLoans = emp.SalaryLoans;
                if (salLoans.Count == 0)
                {
                    dt.Rows.Add(emp.TokenNo, emp.Name, "No Loan Requested.", "", "", "", "");
                }
                else
                {
                    foreach (SalaryLoan sl in salLoans)
                    {
                        bool isSlApproved = sl.IsApproved.Value;
                        bool isSlFinished = sl.RequestedAmount.Value <= (from x in sl.SalaryLoanInstallments select x.Amount).Sum().Value ? true : false;

                        double installmentAmount = (sl.TotalFromEPFSalary + sl.DayWagesAmount + sl.FixedIncentiveAmount).Value;

                        if (Approved && isSlApproved)
                        {
                            if (Finished && isSlFinished)
                            {
                                dt.Rows.Add(emp.TokenNo, emp.Name, sl.SalaryLoanID, sl.RequestedAmount, installmentAmount, sl.NoOfInstallment.Value, "True");
                            }
                            if (unFinished && !isSlFinished)
                            {
                                dt.Rows.Add(emp.TokenNo, emp.Name, sl.SalaryLoanID, sl.RequestedAmount, installmentAmount, sl.NoOfInstallment.Value, "True");
                            }
                        }

                        if (unApproved && !isSlApproved)
                        {
                            if (unFinished && !isSlFinished)
                            {
                                dt.Rows.Add(emp.TokenNo, emp.Name, sl.SalaryLoanID, sl.RequestedAmount, installmentAmount, sl.NoOfInstallment.Value, "False");
                            }
                        }
                    }
                }
            }

            gdvLoanDetails.DataSource = dt;
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLoanGridView();
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

        private void chbFinished_CheckedChanged(object sender, EventArgs e)
        {
            fillLoanGridView();
        }

        private void chbUnFinished_CheckedChanged(object sender, EventArgs e)
        {
            fillLoanGridView();
        }

        private void chbApproved_CheckedChanged(object sender, EventArgs e)
        {
            fillLoanGridView();
        }

        private void chbUnApproved_CheckedChanged(object sender, EventArgs e)
        {
            fillLoanGridView();
        }

        private void resetForm()
        {
            chbApproved.Checked = true;
            chbFinished.Checked = true;
            chbUnApproved.Checked = true;
            chbUnFinished.Checked = true;

            txtEmployeeName.Text = string.Empty;
            txtDesignation.Text = string.Empty;
            txtNIC_No.Text = string.Empty;
            txtEPF_No.Text = string.Empty;
            txtToken_No.Text = string.Empty;

            resetCSLTextBoxes();

            txtRequested_Amount.Text = "0";
            txtTotalFromEPFSalary.Text = "0";
            txtDayWages.Text = "0";
            txtFixedIncentiveAllowance.Text = "0";
            txtDeductionAmountinMonth.Text = "0";
            txtNumber_of_Month.Text = "0";

            fillLoanGridView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void resetCSLTextBoxes()
        {
            txtCSLLoanID.Text = string.Empty;
            txtCSLRequestedAmount.Text = string.Empty;
            txtCSLStartingDate.Text = string.Empty;
            txtCSLEpfSalary.Text = "0";
            txtCSLDayWages.Text = "0";
            txtCSLFixedIncentiveAllowance.Text = "0";
            txtCSLInstallmentAmount.Text = "0";
            txtCSLNumberOfMonths.Text = "0";
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string tokenNo = gdvLoanDetails.SelectedRows[0].Cells[0].Value.ToString();
                Employee emp = db.Employees.Where(em => em.TokenNo.Equals(tokenNo)).SingleOrDefault();

                bool hasUnfinishedLoan = false;
                int unfinishedLoanId = 0;

                foreach (SalaryLoan sl in (from x in emp.SalaryLoans where x.IsApproved.Value == true select x))
                {
                    double installmentTotal = (from x in sl.SalaryLoanInstallments select x.Amount).Sum().Value;
                    if (installmentTotal < sl.RequestedAmount)
                    {
                        hasUnfinishedLoan = true;
                        unfinishedLoanId = sl.SalaryLoanID;
                    }
                }

                if (hasUnfinishedLoan)
                {
                    Utilities.ShowErrorBox("You have unfinshed loan. Loan No : " + unfinishedLoanId + ".\r\nYou can only have one loan at a time. So please finish unfinished loans and request another loan.");
                }
                else
                {
                    SalaryLoan salLoan = new SalaryLoan
                    {
                        Employee = emp,
                        RequestedAmount = Utilities.getDoubleValueFromTextBox(txtRequested_Amount),
                        RequestedDate = dtpStarting_Date.Value,
                        NoOfInstallment = Utilities.getIntValueFromTextBox(txtNumber_of_Month),
                        DayWagesAmount = Utilities.getDoubleValueFromTextBox(txtDayWages),
                        TotalFromEPFSalary = Utilities.getDoubleValueFromTextBox(txtTotalFromEPFSalary),
                        FixedIncentiveAmount = Utilities.getDoubleValueFromTextBox(txtFixedIncentiveAllowance),
                        IsApproved = false,
                        CreatedBy = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = 1,
                        ModifiedDate = DateTime.Now,
                    };

                    db.SalaryLoans.InsertOnSubmit(salLoan);
                    db.SubmitChanges();
                    Utilities.ShowInformationBox("Successfully requested a loan.");
                }
            }
            catch (Exception ex)
            {
                Utilities.ShowExceptionBox(ex.Message);
            }
        }
    }
}
