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
    public partial class frmAddNewEmployee : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        EmployeeDataSet ds = new EmployeeDataSet();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmAddNewEmployee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmAddNewEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmAddNewEmployee_Load(object sender, EventArgs e)
        {
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
            EmployeeUtilities.fillDesignationComboBox(db, cmbDesignation);
            dgvFixedIncentives.DataSource = ds.FixedIncentive;
            dgvVariableIncentive.DataSource = ds.VariableIncentive;
            cmbDateRateOfSalary.SelectedIndex = 0;
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilities.fillDepartmentComboBox((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilities.fillSubDepartmentComboBox((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
        }

        private void chbAssignToSubDepartment_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAssignToSubDepartment.Checked)
            {
                cmbSubDepartment.Enabled = true;
            }
            else
            {
                cmbSubDepartment.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Branch branch = EmployeeUtilities.SaveNewBranchIfNotExsists(db, cmbWorkingBranch);
                Department department = EmployeeUtilities.SaveNewDepartmentIfNotExsists(db, branch, cmbDepartment);
                SubDepartment subdepartment = null;
                if (chbAssignToSubDepartment.Checked)
                {
                    subdepartment = EmployeeUtilities.SaveNewSubDepartmentIfNotExisists(db, department, cmbSubDepartment);
                }
                Designation designation = EmployeeUtilities.SaveNewDesignationIfNotExists(db, cmbDesignation);

                Employee employee = new Employee
                {
                    Department = department,
                    SubDepartment = subdepartment,
                    Name = txtEmployeeName.Text,
                    Gender = rdbGenderMale.Checked ? "Male" : "Female",
                    Designation = designation,
                    TokenNo = Utilities.getIntValueFromTextBox(txtTokenNo),
                    EPFNo = txtEPFNo.Text,
                    NICNo = txtNICNo.Text,
                    DateOfAppointed = dtpDateOfAppointment.Value,
                    EmployeeCatagory = cmbEmployeeCatagory.Text,
                    EmployeeGrade = cmbEmployeeGrade.Text,
                    IsEPFApply = chbEPFEntitled.Checked,
                    IsPieceRateApply = chbPieceRate.Checked,
                    IsAssignedToSubDepartment = chbAssignToSubDepartment.Checked,
                    CreatedBy = LoginDetails.LoggedUsedID,
                    CreatedDate = DateTime.Now,
                    ModifiedBy = LoginDetails.LoggedUsedID,
                    ModifiedDate = DateTime.Now
                };

                db.Employees.InsertOnSubmit(employee);
                db.SubmitChanges();

                SalaryDetail salaryDetail = new SalaryDetail
                {
                    Employee = employee,
                    DateRateOfSalary = Convert.ToInt32(cmbDateRateOfSalary.Text),
                    DayRate = cmbEmployeeCatagory.Text.ToLower().Equals("day wages") ? Utilities.getDoubleValueFromTextBox(txtDayWagesDayRate) : 0,
                    EPFETFTotalSalary = cmbEmployeeCatagory.Text.ToLower().Equals("day wages") ? Utilities.getDoubleValueFromTextBox(txtDayWagesTotalEPFSalary) : Utilities.getDoubleValueFromTextBox(txtRecrumentTotalEPF),
                    BasicSalary = (!(cmbEmployeeCatagory.Text.ToLower().Equals("day wages"))) ? Utilities.getDoubleValueFromTextBox(txtBasicSalary) : 0,
                    BudgetAllowance = (!(cmbEmployeeCatagory.Text.ToLower().Equals("day wages"))) ? Utilities.getDoubleValueFromTextBox(txtBudgetAllowance) : 0,
                    CreatedBy = LoginDetails.LoggedUsedID,
                    CreatedDate = DateTime.Now,
                    ModifiedBy = LoginDetails.LoggedUsedID,
                    ModifiedDate = DateTime.Now
                };

                db.SalaryDetails.InsertOnSubmit(salaryDetail);
                db.SubmitChanges();

                List<FixedIncentiveAllowance> lstFixedIncentiveList = new List<FixedIncentiveAllowance>();

                FixedIncentiveAllowance fixIncAll = new FixedIncentiveAllowance
                {
                    Employee = employee,
                    Type = "Traveling / Attendace",
                    Value = Utilities.getDoubleValueFromTextBox(txtTravellingAttendance),
                    CreatedBy = LoginDetails.LoggedUsedID,
                    CreatedDate = DateTime.Now,
                    ModifiedBy = LoginDetails.LoggedUsedID,
                    ModifiedDate = DateTime.Now
                };

                lstFixedIncentiveList.Add(fixIncAll);

                foreach (DataGridViewRow x in dgvFixedIncentives.Rows)
                {
                    fixIncAll = new FixedIncentiveAllowance
                    {
                        Employee = employee,
                        Type = x.Cells[0].Value.ToString(),
                        Value = Convert.ToDouble(x.Cells[1].Value.ToString()),
                        CreatedBy = LoginDetails.LoggedUsedID,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = LoginDetails.LoggedUsedID,
                        ModifiedDate = DateTime.Now
                    };

                    lstFixedIncentiveList.Add(fixIncAll);
                }

                db.FixedIncentiveAllowances.InsertAllOnSubmit(lstFixedIncentiveList);
                db.SubmitChanges();

                db.VariableIncentiveAllowances.InsertOnSubmit(EmployeeUtilities.createNewVariableIncentive("Performance Incentive", txtPerformancePrecentage.Text, employee));
                db.VariableIncentiveAllowances.InsertOnSubmit(EmployeeUtilities.createNewVariableIncentive("Sales Incentive", txtSalesPrecentage.Text, employee));
                db.VariableIncentiveAllowances.InsertOnSubmit(EmployeeUtilities.createNewVariableIncentive("Product Incentive", txtProductPrecentage.Text, employee));
                db.VariableIncentiveAllowances.InsertOnSubmit(EmployeeUtilities.createNewVariableIncentive("Down Time Machine Break Down Incentive", txtDownTimeMatchineBreakDownPresentage.Text, employee));
                db.VariableIncentiveAllowances.InsertOnSubmit(EmployeeUtilities.createNewVariableIncentive("Machieving Maintence Incentive", txtMachievingMaintenancePresentage.Text, employee));
                db.VariableIncentiveAllowances.InsertOnSubmit(EmployeeUtilities.createNewVariableIncentive("Achieving Production Target Incentive", txtAchievingProductionTargetsPresentage.Text, employee));
                db.VariableIncentiveAllowances.InsertOnSubmit(EmployeeUtilities.createNewVariableIncentive("Mill Section Target Incentive", txtMillSectionTargetsPresentage.Text, employee));
                db.VariableIncentiveAllowances.InsertOnSubmit(EmployeeUtilities.createNewVariableIncentive("Hawail Section Production Incentive", txtHawailSectionProductionPresentage.Text, employee));
                db.VariableIncentiveAllowances.InsertOnSubmit(EmployeeUtilities.createNewVariableIncentive("Achieving Sales Target Incentive", txtAchievingSalesTargetsPresentage.Text, employee));
                db.VariableIncentiveAllowances.InsertOnSubmit(EmployeeUtilities.createNewVariableIncentive("Security Performance Incentive", txtSecurityPerformanceIncentivePresentage.Text, employee));

                foreach (DataGridViewRow x in dgvVariableIncentive.Rows)
                {
                    db.VariableIncentiveAllowances.InsertOnSubmit(EmployeeUtilities.createNewVariableIncentive(x.Cells[0].Value.ToString(), x.Cells[1].Value.ToString(), employee));
                }

                db.SubmitChanges();

                Utilities.ShowInformationBox("Successfully saved employee data.");
                this.Dispose();
            }
            catch (Exception ex)
            {
                Utilities.ShowExceptionBox(ex.Message);
            }
        }


        private void cmbDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDesignation_Leave(object sender, EventArgs e)
        {
            if (EmployeeUtilities.isSecurityEmployee(cmbDesignation))
            {
                cmbDateRateOfSalary.SelectedIndex = cmbDateRateOfSalary.Items.IndexOf("0");
            }
        }

        private void cmbEmployeeGrade_Leave(object sender, EventArgs e)
        {
            
        }

        private void cmbEmployeeCatagory_Leave(object sender, EventArgs e)
        {
            if (cmbEmployeeCatagory.Text.ToLower().Equals("day wages"))
            {
                txtBasicSalary.ReadOnly = true;
                txtBudgetAllowance.ReadOnly = true;
                txtRecrumentTotalEPF.ReadOnly = true;

                txtDayWagesDayRate.ReadOnly = false;
                txtDayWagesTotalEPFSalary.ReadOnly = false;
            }
            else
            {
                txtBasicSalary.ReadOnly = false;
                txtBudgetAllowance.ReadOnly = false;
                txtRecrumentTotalEPF.ReadOnly = false;

                txtDayWagesDayRate.ReadOnly = true;
                txtDayWagesTotalEPFSalary.ReadOnly = true;
            }
        }

        private void txtDayWagesTotalEPFSalary_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtDayWagesTotalEPFSalary);
            txtRecrumentTotalEPF.Text = txtDayWagesTotalEPFSalary.Text;
        }

        private void txtDayWagesDayRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDayWagesDayRate_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtDayWagesDayRate);
        }

        private void txtBasicSalary_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtBasicSalary);
        }

        private void txtBudgetAllowance_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtBudgetAllowance);
        }

        private void txtRecrumentTotalEPF_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtRecrumentTotalEPF);
            txtDayWagesTotalEPFSalary.Text = txtRecrumentTotalEPF.Text;
        }

        private void txtTravellingAttendance_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtTravellingAttendance);
        }

        private void txtFixedIncentiveValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFixedIncentiveValue_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtFixedIncentiveValue);
        }

        private void txtProductionSalesPerformanceTotalValue_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtProductionSalesPerformanceTotalValue);
            calculateProductionSalesPerformanceIncentives(txtProductionSalesPerformanceTotalValue);
        }

        private void txtPerformancePrecentage_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtPerformancePrecentage);
            calculateProductionSalesPerformanceIncentives(txtPerformancePrecentage);
        }

        private void txtSalesPrecentage_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtSalesPrecentage);
            calculateProductionSalesPerformanceIncentives(txtSalesPrecentage);
        }

        private void txtProductPrecentage_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtProductPrecentage);
            calculateProductionSalesPerformanceIncentives(txtProductPrecentage);
        }

        private void txtWorkshopIncentiveTotal_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtWorkshopIncentiveTotal);
            calculateWorkShopIncentives(txtWorkshopIncentiveTotal);
        }

        private void txtDownTimeMatchineBreakDownPresentage_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtDownTimeMatchineBreakDownPresentage);
            calculateWorkShopIncentives(txtDownTimeMatchineBreakDownPresentage);
        }

        private void txtMachievingMaintenancePresentage_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtMachievingMaintenancePresentage);
            calculateWorkShopIncentives(txtMachievingMaintenancePresentage);
        }

        private void txtAchievingProductionTargetsPresentage_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtAchievingProductionTargetsPresentage);
            calculateWorkShopIncentives(txtAchievingProductionTargetsPresentage);
        }

        private void txtMillSectionTargetsPresentage_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtMillSectionTargetsPresentage);
            calculateWorkShopIncentives(txtMillSectionTargetsPresentage);
        }

        private void txtHawailSectionProductionPresentage_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtHawailSectionProductionPresentage);
            calculateWorkShopIncentives(txtHawailSectionProductionPresentage);
        }

        private void txtAchievingSalesTargetsPresentage_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtAchievingSalesTargetsPresentage);
            calculateWorkShopIncentives(txtAchievingSalesTargetsPresentage);
        }

        private void txtSecurityPerformanceIncentivePresentage_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtSecurityPerformanceIncentivePresentage);
            calculateWorkShopIncentives(txtSecurityPerformanceIncentivePresentage);
        }

        private void txtVariableIncentivePrecentage_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtVariableIncentivePrecentage);
            calculateWorkShopIncentives(txtVariableIncentivePrecentage);
        }

        private void calculateProductionSalesPerformanceIncentives(TextBox textBox)
        {
            double TotalValueOfIncentives = Utilities.getDoubleValueFromTextBox(txtProductionSalesPerformanceTotalValue);
            double PerformancePrecentage = Utilities.getDoubleValueFromTextBox(txtPerformancePrecentage);
            double SalesPrecentage = Utilities.getDoubleValueFromTextBox(txtSalesPrecentage);
            double ProductPrecentage = Utilities.getDoubleValueFromTextBox(txtProductPrecentage);

            double PerformanceValue = TotalValueOfIncentives * (PerformancePrecentage / 100.0);
            double SalesValue = TotalValueOfIncentives * (SalesPrecentage / 100.0);
            double ProductValue = TotalValueOfIncentives * (ProductPrecentage / 100.0);

            txtPerformValue.Text = PerformanceValue.ToString("0.00");
            txtSalesValue.Text = SalesValue.ToString("0.00");
            txtProductValue.Text = ProductValue.ToString("0.00");

            if (PerformancePrecentage + SalesPrecentage + ProductPrecentage > 100)
            {
                Utilities.ShowErrorBox("Total of the precentages should be equel to 100");
                textBox.Focus();
            }
        }

        private void calculateWorkShopIncentives(TextBox textBox)
        {
            double workshopIncentiveTotal = Utilities.getDoubleValueFromTextBox(txtWorkshopIncentiveTotal);
            double downTimeMachineBreakDownsPrecentage = Utilities.getDoubleValueFromTextBox(txtDownTimeMatchineBreakDownPresentage);
            double machievingMaintenancePrecentage = Utilities.getDoubleValueFromTextBox(txtMachievingMaintenancePresentage);
            double achievingProductionTargetsPrecentage = Utilities.getDoubleValueFromTextBox(txtAchievingProductionTargetsPresentage);
            double millSectionTargetsPrecentage = Utilities.getDoubleValueFromTextBox(txtMillSectionTargetsPresentage);
            double hawailSectionProductionPrecentage = Utilities.getDoubleValueFromTextBox(txtHawailSectionProductionPresentage);
            double achievingSalesTargetPrecentage = Utilities.getDoubleValueFromTextBox(txtAchievingSalesTargetsPresentage);
            double securityPerformanceIncentivePrecentage = Utilities.getDoubleValueFromTextBox(txtSecurityPerformanceIncentivePresentage);

            double downTimeMachineBreakDownValue = workshopIncentiveTotal * (downTimeMachineBreakDownsPrecentage / 100.0);
            double machievingMaintenanceValue = workshopIncentiveTotal * (machievingMaintenancePrecentage / 100.0);
            double achievingProductionTargetsValue = workshopIncentiveTotal * (achievingProductionTargetsPrecentage / 100.0);
            double millSectionTargetsValue = workshopIncentiveTotal * (millSectionTargetsPrecentage / 100.0);
            double hawailSectionProductionValue = workshopIncentiveTotal * (hawailSectionProductionPrecentage / 100.0);
            double achievingSalesTargetValue = workshopIncentiveTotal * (achievingSalesTargetPrecentage / 100.0);
            double securityPerformanceIncentiveValue = workshopIncentiveTotal * (securityPerformanceIncentivePrecentage / 100.0);

            txtDownTimeMatchineBreakDownValue.Text = downTimeMachineBreakDownValue.ToString();
            txtMachievingMaintenanceValue.Text = machievingMaintenanceValue.ToString();
            txtAchievingProductionTargetsValue.Text = achievingProductionTargetsValue.ToString();
            txtMillSectionTargetsValue.Text = millSectionTargetsValue.ToString();
            txtHawailSectionProductionValue.Text = hawailSectionProductionValue.ToString();
            txtAchievingSalesTargetsValue.Text = achievingSalesTargetValue.ToString();
            txtSecurityPerformanceIncentiveValue.Text = securityPerformanceIncentiveValue.ToString();

            double totalOfPrecentages = downTimeMachineBreakDownsPrecentage + machievingMaintenancePrecentage + achievingProductionTargetsPrecentage + millSectionTargetsPrecentage + hawailSectionProductionPrecentage + achievingSalesTargetPrecentage + securityPerformanceIncentivePrecentage;

            if (totalOfPrecentages > 100)
            {
                Utilities.ShowErrorBox("Total of the precentages should be equel to 100");
                textBox.Focus();
            }
        }

        private void btnAddFixedIncentive_Click(object sender, EventArgs e)
        {
            if (Utilities.checkIfContainText(txtFixedIncentiveType))
            {
                string incentiveType = txtFixedIncentiveType.Text;
                double incentiveValue = Utilities.getDoubleValueFromTextBox(txtFixedIncentiveValue);
                ds.FixedIncentive.AddFixedIncentiveRow(incentiveType, incentiveValue);
                txtFixedIncentiveType.Text = "";
                txtFixedIncentiveValue.Text = "0";
            }
        }

        private void btnAddVari_Incentive_Click(object sender, EventArgs e)
        {
            if (Utilities.checkIfContainText(txtVariableIncentiveType))
            {
                string incentiveType = txtVariableIncentiveType.Text;
                double incentiveValue = Utilities.getDoubleValueFromTextBox(txtVariableIncentivePrecentage);
                ds.VariableIncentive.AddVariableIncentiveRow(incentiveType, incentiveValue);
                txtVariableIncentiveType.Text = "";
                txtVariableIncentivePrecentage.Text = "0";
            }
        }

        private void txtEmployeeName_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainText(txtEmployeeName);
        }

        private void txtTokenNo_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainText(txtTokenNo);
        }

        private void txtEPFNo_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainText(txtEPFNo);
        }

        private void txtNICNo_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainText(txtNICNo);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }
    }
}
