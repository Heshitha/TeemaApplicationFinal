using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
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
    public partial class frmDeduction : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmDeduction()
        {
            InitializeComponent();
        }

        private void frmDeduction_Load(object sender, EventArgs e)
        {
            cmbYear.SelectedIndex = cmbYear.Items.IndexOf(DateTime.Today.Year.ToString());
            cmbMonth.SelectedIndex = DateTime.Today.Month - 1;
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
        }

        private void frmDeduction_MouseDown(object sender, MouseEventArgs e)
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
                fillDeductionDataGrid();
            }
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilities.fillDepartmentComboBox((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
        }

        private void fillDeductionDataGrid()
        {
            try
            {
                EntitySet<Employee> lstEmployee = new EntitySet<Employee>();

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
                dt.Columns.Add("Payee");
                dt.Columns.Add("StampDuty");
                dt.Columns.Add("Meals");
                dt.Columns.Add("WelfareShop");
                dt.Columns.Add("WelfareContribution");
                dt.Columns.Add("WelfareLoan");
                dt.Columns.Add("BankSaving");
                dt.Columns.Add("MedicalInsurance");
                dt.Columns.Add("BankLoan");
                dt.Columns.Add("Misc");
                dt.Columns.Add("AddDeduction");
                dt.Columns.Add("Total");

                int year = Convert.ToInt32(cmbYear.Text);
                int month = Convert.ToInt32(cmbMonth.SelectedIndex) + 1;

                foreach (Employee emp in lstEmployee)
                {
                    Deduction ded = emp.Deductions.Where(de => de.Year == year && de.Month == month).FirstOrDefault();
                    if (ded == null)
                    {
                        dt.Rows.Add(emp.TokenNo, emp.Name, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    }
                    else
                    {
                        double total = ded.Payee + ded.StampDuty + ded.Meals + ded.WelfareShop + ded.WelfareContribution + ded.WelfareLoan + ded.BankSaving + ded.MedicalIns + ded.Misc + ded.OtherDeduction + ded.BankLoan;

                        dt.Rows.Add(emp.TokenNo, emp.Name, ded.Payee.ToString("0.00"), ded.StampDuty.ToString("0.00"), ded.Meals.ToString("0.00"), ded.WelfareShop.ToString("0.00"), ded.WelfareContribution.ToString("0.00"), ded.WelfareLoan.ToString("0.00"), ded.BankSaving.ToString("0.00"), ded.MedicalIns.ToString("0.00"), ded.BankLoan.ToString("0.00"), ded.Misc.ToString("0.00"), ded.OtherDeduction.ToString("0.00"), total.ToString("0.00"));
                    }
                }

                gdvDeduction.DataSource = dt;
                
            }
            catch (Exception)
            {
            }
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDeductionDataGrid();
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
                fillDeductionDataGrid();
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDeductionDataGrid();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDeductionDataGrid();
        }

        private void gdvDeduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int tokenNo = Convert.ToInt32(gdvDeduction.Rows[e.RowIndex].Cells["clmnTokenNo"].Value.ToString());
            Employee employee = db.Employees.Where(em => em.TokenNo == tokenNo).SingleOrDefault();
            int year = Convert.ToInt32(cmbYear.Text);
            int month = cmbMonth.SelectedIndex + 1;

            txtEmployeeName.Text = employee.Name;
            txtDesignation.Text = employee.Designation.Designation1;
            txtNIC_No.Text = employee.NICNo;
            txtEPF_No.Text = employee.EPFNo;
            txtToken_No.Text = employee.TokenNo.ToString();

            Deduction deduction = employee.Deductions.Where(de => de.Year == year && de.Month == month).SingleOrDefault();
            if (deduction != null)
            {
                txtPayee.Text = deduction.Payee.ToString("0.00");
                txtStamp_Duty.Text = deduction.StampDuty.ToString("0.00");
                txtMeals.Text = deduction.Meals.ToString("0.00");
                txtWelfareShop.Text = deduction.WelfareShop.ToString("0.00");
                txtWelfareCon.Text = deduction.WelfareContribution.ToString("0.00");
                txtW_loan.Text = deduction.WelfareLoan.ToString("0.00");
                txtBankSaving.Text = deduction.BankSaving.ToString("0.00");
                txtMedical_Ins.Text = deduction.MedicalIns.ToString("0.00");
                txtBankLoan.Text = deduction.BankLoan.ToString("0.00");
                txtMisc.Text = deduction.Misc.ToString("0.00");
                txtAddDeduction.Text = deduction.OtherDeduction.ToString("0.00");

                double totalValue = deduction.Payee + deduction.StampDuty + deduction.Meals + deduction.WelfareShop + deduction.WelfareContribution + deduction.WelfareLoan + deduction.BankSaving + deduction.MedicalIns + deduction.BankLoan + deduction.Misc + deduction.OtherDeduction;

                txtTotal.Text = totalValue.ToString("0.00");
            }
            else
            {
                resetDeductionTextBoxes();
            }
        }

        private void resetDeductionTextBoxes()
        {
            txtPayee.Text = "0";
            txtStamp_Duty.Text = "0";
            txtMeals.Text = "0";
            txtWelfareShop.Text = "0";
            txtWelfareCon.Text = "0";
            txtW_loan.Text = "0";
            txtBankSaving.Text = "0";
            txtMedical_Ins.Text = "0";
            txtBankLoan.Text = "0";
            txtMisc.Text = "0";
            txtAddDeduction.Text = "0";
            txtTotal.Text = "0";
        }

        private void resetEmployeeDetailsTectBoxes()
        {
            txtEmployeeName.Clear();
            txtDesignation.Clear();
            txtNIC_No.Clear();
            txtEPF_No.Clear();
            txtToken_No.Clear();
        }

        private void calculateTotalDeductionValue()
        {
            double payee = Utilities.getDoubleValueFromTextBox(txtPayee);
            double stampDuty = Utilities.getDoubleValueFromTextBox(txtStamp_Duty);
            double meals = Utilities.getDoubleValueFromTextBox(txtMeals);
            double welfareShop = Utilities.getDoubleValueFromTextBox(txtWelfareShop);
            double welfareContribution = Utilities.getDoubleValueFromTextBox(txtWelfareCon);
            double welfareLoan = Utilities.getDoubleValueFromTextBox(txtW_loan);
            double bankSaving = Utilities.getDoubleValueFromTextBox(txtBankSaving);
            double medicalInsurance = Utilities.getDoubleValueFromTextBox(txtMedical_Ins);
            double bankLoan = Utilities.getDoubleValueFromTextBox(txtBankLoan);
            double misc = Utilities.getDoubleValueFromTextBox(txtMisc);
            double addDeduction = Utilities.getDoubleValueFromTextBox(txtAddDeduction);

            double totalValue = payee + stampDuty + meals + welfareShop + welfareContribution + welfareLoan + bankSaving + medicalInsurance + bankLoan + misc + addDeduction;
            txtTotal.Text = totalValue.ToString("0.00");
        }

        private void txtPayee_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtPayee);
            calculateTotalDeductionValue();
        }

        private void txtStamp_Duty_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtStamp_Duty);
            calculateTotalDeductionValue();
        }

        private void txtMeals_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtMeals);
            calculateTotalDeductionValue();
        }

        private void txtWelfareShop_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtWelfareShop);
            calculateTotalDeductionValue();
        }

        private void txtWelfareCon_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtWelfareCon);
            calculateTotalDeductionValue();
        }

        private void txtW_loan_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtW_loan);
            calculateTotalDeductionValue();
        }

        private void txtBankSaving_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtBankSaving);
            calculateTotalDeductionValue();
        }

        private void txtMedical_Ins_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtMedical_Ins);
            calculateTotalDeductionValue();
        }

        private void txtBankLoan_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtBankLoan);
            calculateTotalDeductionValue();
        }

        private void txtMisc_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtMisc);
            calculateTotalDeductionValue();
        }

        private void txtAddDeduction_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtAddDeduction);
            calculateTotalDeductionValue();
        }

        private void btnUpsate_Click(object sender, EventArgs e)
        {
            try
            {
                int tokenNo = Convert.ToInt32(gdvDeduction.SelectedRows[0].Cells["clmnTokenNo"].Value.ToString());
                Employee employee = db.Employees.Where(em => em.TokenNo == tokenNo).SingleOrDefault();
                int year = Convert.ToInt32(cmbYear.Text);
                int month = cmbMonth.SelectedIndex + 1;

                Deduction deduction = employee.Deductions.Where(de => de.Year == year && de.Month == month).SingleOrDefault();
                if (deduction != null)
                {
                    deduction.Payee = Utilities.getDoubleValueFromTextBox(txtPayee);
                    deduction.StampDuty = Utilities.getDoubleValueFromTextBox(txtStamp_Duty);
                    deduction.Meals = Utilities.getDoubleValueFromTextBox(txtMeals);
                    deduction.WelfareShop = Utilities.getDoubleValueFromTextBox(txtWelfareShop);
                    deduction.WelfareContribution = Utilities.getDoubleValueFromTextBox(txtWelfareCon);
                    deduction.WelfareLoan = Utilities.getDoubleValueFromTextBox(txtW_loan);
                    deduction.BankSaving = Utilities.getDoubleValueFromTextBox(txtBankSaving);
                    deduction.MedicalIns = Utilities.getDoubleValueFromTextBox(txtMedical_Ins);
                    deduction.BankLoan = Utilities.getDoubleValueFromTextBox(txtBankLoan);
                    deduction.Misc = Utilities.getDoubleValueFromTextBox(txtMisc);
                    deduction.OtherDeduction = Utilities.getDoubleValueFromTextBox(txtAddDeduction);
                    deduction.ModifiedBy = LoginDetails.LoggedUsedID;
                    deduction.ModifiedDate = DateTime.Now;
                }
                else
                {
                    deduction = new Deduction
                    {
                        Employee = employee,
                        Year = year,
                        Month = month,
                        Payee = Utilities.getDoubleValueFromTextBox(txtPayee),
                        StampDuty = Utilities.getDoubleValueFromTextBox(txtStamp_Duty),
                        Meals = Utilities.getDoubleValueFromTextBox(txtMeals),
                        WelfareShop = Utilities.getDoubleValueFromTextBox(txtWelfareShop),
                        WelfareContribution = Utilities.getDoubleValueFromTextBox(txtWelfareCon),
                        WelfareLoan = Utilities.getDoubleValueFromTextBox(txtW_loan),
                        BankSaving = Utilities.getDoubleValueFromTextBox(txtBankSaving),
                        MedicalIns = Utilities.getDoubleValueFromTextBox(txtMedical_Ins),
                        BankLoan = Utilities.getDoubleValueFromTextBox(txtBankLoan),
                        Misc = Utilities.getDoubleValueFromTextBox(txtMisc),
                        OtherDeduction = Utilities.getDoubleValueFromTextBox(txtAddDeduction),
                        CreatedBy = LoginDetails.LoggedUsedID,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = LoginDetails.LoggedUsedID,
                        ModifiedDate = DateTime.Now,
                    };

                    db.Deductions.InsertOnSubmit(deduction);
                }

                db.SubmitChanges();
                Utilities.ShowInformationBox("Deductions saved successfully.");
                fillDeductionDataGrid();
                resetDeductionTextBoxes();
                resetEmployeeDetailsTectBoxes();
            }
            catch (Exception ex)
            {
                Utilities.ShowExceptionBox(ex.Message);
            }
        }
    }
}
