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

namespace TeemaApplication
{
    public partial class frmEditEmployeeDetails : Form
    {
        int employeeID = 0;

        TeemaDBDataContext db = new TeemaDBDataContext();
        EmployeeDataSet ds = new EmployeeDataSet();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmEditEmployeeDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmEditEmployeeDetails_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public frmEditEmployeeDetails(Employee employee)
        {
            InitializeComponent();

            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
            Utilities.fillDepartmentComboBox((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
            Utilities.fillSubDepartmentComboBox((Department)cmbDepartment.SelectedItem, cmbSubDepartment);

            EmployeeUtilities.fillDesignationComboBox(db, cmbDesignation);

            employeeID = employee.EmployeeID;
            cmbWorkingBranch.SelectedItem = employee.Department.Branch;
            cmbDepartment.SelectedItem = employee.Department;
            cmbDepartment.Text = employee.Department.DepartmentName;
            chbAssignToSubDepartment.Checked = employee.IsAssignedToSubDepartment;
            cmbSubDepartment.Enabled = employee.IsAssignedToSubDepartment ? true : false;
            cmbSubDepartment.SelectedItem = employee.IsAssignedToSubDepartment ? employee.SubDepartment : null;
            txtEmployeeName.Text = employee.Name;
            rdbGenderMale.Checked = employee.Gender == "Male" ? true : false;
            rdbGenderFemale.Checked = employee.Gender == "Female" ? true : false;
            cmbDesignation.SelectedItem = employee.Designation;
            cmbDesignation.Text = employee.Designation.Designation1;
            txtTokenNo.Text = employee.TokenNo.ToString();
            txtEPFNo.Text = employee.EPFNo;
            txtNICNo.Text = employee.NICNo;
            dtpDateOfAppointment.Value = employee.DateOfAppointed;
            cmbEmployeeCatagory.Text = employee.EmployeeCatagory;
            cmbEmployeeGrade.Text = employee.EmployeeGrade;
            chbEPFEntitled.Checked = employee.IsEPFApply;
            chbPieceRate.Checked = employee.IsPieceRateApply;

            cmbDateRateOfSalary.Text = employee.SalaryDetail.DateRateOfSalary.ToString();
            cmbDateRateOfSalary.SelectedIndex = cmbDepartment.Items.IndexOf(employee.SalaryDetail.DateRateOfSalary.ToString());
            txtDayWagesDayRate.Text = employee.SalaryDetail.DayRate.ToString("0.00");
            txtDayWagesTotalEPFSalary.Text = employee.SalaryDetail.EPFETFTotalSalary.ToString("0.00");
            txtBasicSalary.Text = employee.SalaryDetail.BasicSalary.ToString("0.00");
            txtBudgetAllowance.Text = employee.SalaryDetail.BudgetAllowance.ToString("0.00");
            txtRecrumentTotalEPF.Text = employee.SalaryDetail.EPFETFTotalSalary.ToString("0.00");

            FixedIncentiveAllowance fixInc = employee.FixedIncentiveAllowances.Where(fix => fix.Type.Equals("Traveling / Attendace")).SingleOrDefault();
            txtTravellingAttendance.Text = fixInc != null ? fixInc.Value.ToString("0.00") : "0.00";

            var fixedIncentiveList = employee.FixedIncentiveAllowances.Where(fix => !(fix.Type.Equals("Traveling / Attendace")));
            foreach (FixedIncentiveAllowance x in fixedIncentiveList)
            {
                ds.FixedIncentive.AddFixedIncentiveRow(x.Type, x.Value);
            }
            dgvFixedIncentives.DataSource = ds.FixedIncentive;

            txtProductionSalesPerformanceTotalValue.Text = employee.SalaryDetail.ProductionSalesPerforValue != null ? employee.SalaryDetail.ProductionSalesPerforValue.Value.ToString("0.00") : "0.00";
            txtPerformancePrecentage.Text = getVariableIncentiveValue(employee, "Performance Incentive");
            txtSalesPrecentage.Text = getVariableIncentiveValue(employee, "Sales Incentive");
            txtProductPrecentage.Text = getVariableIncentiveValue(employee, "Product Incentive");

            txtWorkshopIncentiveTotal.Text = employee.SalaryDetail.WorkShopIncentiveValue != null ? employee.SalaryDetail.WorkShopIncentiveValue.Value.ToString("0.00") : "0.00";
            txtDownTimeMatchineBreakDownPresentage.Text = getVariableIncentiveValue(employee, "Down Time Machine Break Down Incentive");
            txtMachievingMaintenancePresentage.Text = getVariableIncentiveValue(employee, "Machieving Maintence Incentive");
            txtAchievingProductionTargetsPresentage.Text = getVariableIncentiveValue(employee, "Achieving Production Target Incentive");
            txtMillSectionTargetsPresentage.Text = getVariableIncentiveValue(employee, "Mill Section Target Incentive");
            txtHawailSectionProductionPresentage.Text = getVariableIncentiveValue(employee, "Hawail Section Production Incentive");
            txtAchievingSalesTargetsPresentage.Text = getVariableIncentiveValue(employee, "Achieving Sales Target Incentive");
            txtSecurityPerformanceIncentivePresentage.Text = getVariableIncentiveValue(employee, "Security Performance Incentive");

            employee.FixedIncentiveAllowances.Where(fix => !(fix.Type.Equals("Traveling / Attendace")));

            List<string> listOfKnownVaribaleIncentives = new List<string>();
            listOfKnownVaribaleIncentives.Add("Performance Incentive");
            listOfKnownVaribaleIncentives.Add("Sales Incentive");
            listOfKnownVaribaleIncentives.Add("Product Incentive");
            listOfKnownVaribaleIncentives.Add("Down Time Machine Break Down Incentive");
            listOfKnownVaribaleIncentives.Add("Machieving Maintence Incentive");
            listOfKnownVaribaleIncentives.Add("Achieving Production Target Incentive");
            listOfKnownVaribaleIncentives.Add("Mill Section Target Incentive");
            listOfKnownVaribaleIncentives.Add("Hawail Section Production Incentive");
            listOfKnownVaribaleIncentives.Add("Achieving Sales Target Incentive");
            listOfKnownVaribaleIncentives.Add("Security Performance Incentive");

            var variableIncentives = employee.VariableIncentiveAllowances.Where(varInc => !(listOfKnownVaribaleIncentives.Contains(varInc.Type)));

            foreach (VariableIncentiveAllowance x in variableIncentives)
            {
                ds.VariableIncentive.AddVariableIncentiveRow(x.Type, x.Value);
            }

            dgvVariableIncentive.DataSource = ds.VariableIncentive;

        }

        private string getVariableIncentiveValue(Employee employee, string incentiveType)
        {
            VariableIncentiveAllowance varIncentive = employee.VariableIncentiveAllowances.Where(vari => vari.Type.Equals(incentiveType)).SingleOrDefault();
            string value = varIncentive != null ? varIncentive.Value.ToString("0.00") : "0.00";
            return value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrintDetails_Click(object sender, EventArgs e)
        {
            Employee employee = db.Employees.Where(emp => emp.EmployeeID == employeeID).SingleOrDefault();

            EmployeeDataSet.EmployeeReportDetailsRow employeeRow = ds.EmployeeReportDetails.NewEmployeeReportDetailsRow();
            employeeRow.EmployeeID = employee.EmployeeID;
            employeeRow.WorkingBranch = employee.Department.Branch.BranchName;
            employeeRow.Department = employee.Department.DepartmentName;
            employeeRow.SubDepartment = employee.IsAssignedToSubDepartment ? employee.SubDepartment.SubDepartmentName : "Not Assigned";
            employeeRow.Name = employee.Name;
            employeeRow.Gender = employee.Gender;
            employeeRow.Designation = employee.Designation.Designation1;
            employeeRow.TokenNo = employee.TokenNo;
            employeeRow.EPFNo = employee.EPFNo;
            employeeRow.NICNo = employee.NICNo;
            employeeRow.DateOfAppointment = employee.DateOfAppointed;
            employeeRow.EmployeeCatagory = employee.EmployeeCatagory;
            employeeRow.EmployeeGrade = employee.EmployeeGrade;
            employeeRow.IsEPFEntitled = employee.IsEPFApply ? "Yes" : "No";
            employeeRow.IsPieceRateEntitled = employee.IsPieceRateApply ? "Yes" : "No";
            employeeRow.DateRateOfSalary = employee.SalaryDetail.DateRateOfSalary;
            employeeRow.DayRate = employee.SalaryDetail.DayRate;
            employeeRow.BasicSalary = employee.SalaryDetail.BasicSalary;
            employeeRow.BudgetAllowance = employee.SalaryDetail.BudgetAllowance;
            employeeRow.TotalSalaryForEPFETF = employee.SalaryDetail.EPFETFTotalSalary;
            employeeRow.CreatedBy = employee.UserAccount.Name;
            employeeRow.CreatedDate = employee.CreatedDate;
            employeeRow.ModifiedBy = employee.UserAccount1.Name;
            employeeRow.ModifiedDate = employee.ModifiedDate;
            employeeRow.GeneratedBy = LoginDetails.LoggedUserName;
            employeeRow.GeneratedDate = DateTime.Now;

            ds.EmployeeReportDetails.AddEmployeeReportDetailsRow(employeeRow);

            foreach (FixedIncentiveAllowance x in employee.FixedIncentiveAllowances)
            {
                EmployeeDataSet.FixedIncentiveReportDetailsRow row = ds.FixedIncentiveReportDetails.NewFixedIncentiveReportDetailsRow();
                row.EmployeeID = employee.EmployeeID;
                row.IncentiveType = x.Type;
                row.IncentiveValue = x.Value;

                ds.FixedIncentiveReportDetails.AddFixedIncentiveReportDetailsRow(row);
            }

            foreach (var x in employee.VariableIncentiveAllowances)
            {
                EmployeeDataSet.VariableIncentiveReportDetailsRow row = ds.VariableIncentiveReportDetails.NewVariableIncentiveReportDetailsRow();
                row.EmployeeID = employee.EmployeeID;
                row.IncentiveType = x.Type;
                row.IncentivePrecentage = x.Value;

                ds.VariableIncentiveReportDetails.AddVariableIncentiveReportDetailsRow(row);
            }

            EmployeeReport rpt = new EmployeeReport();
            rpt.SetDataSource(ds);
            rpt.Subreports["FixedIncentive"].SetDataSource(ds);
            rpt.Subreports["VariableIncentive"].SetDataSource(ds);
            frmReportViewer frm = new frmReportViewer(rpt);
            frm.ShowDialog();
        }
    }
}
