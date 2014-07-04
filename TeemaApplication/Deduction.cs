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
                        dt.Rows.Add(emp.TokenNo, emp.Name, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                    }
                    else
                    {
                        double total = ded.Payee + ded.StampDuty + ded.Meals + ded.WelfareShop + ded.WelfareContribution + ded.WelfareLoan + ded.BankSaving + ded.MedicalIns + ded.Misc + ded.OtherDeduction;

                        dt.Rows.Add(emp.TokenNo, emp.Name, ded.Payee.ToString("0.00"), ded.StampDuty.ToString("0.00"), ded.Meals.ToString("0.00"), ded.WelfareShop.ToString("0.00"), ded.WelfareContribution.ToString("0.00"), ded.WelfareLoan.ToString("0.00"), ded.BankSaving.ToString("0.00"), ded.MedicalIns.ToString("0.00"), ded.Misc.ToString("0.00"), ded.OtherDeduction.ToString("0.00"), total.ToString("0.00"));
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
    }
}
