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
                                           where pl.LeaveFrom >= startDate && pl.LeaveTo <= endDate && pl.IsNoPay.Value == true
                                           select pl.LeaveValue).Sum();

                    double? PaidLeave = (from pl in emp.PersonalLeaveRecords
                                         where pl.LeaveFrom >= startDate && pl.LeaveTo <= endDate && pl.IsNoPay.Value == false
                                         select pl.LeaveValue).Sum();

                    int noPayValueCalcDate = emp.SalaryDetail.DateRateOfSalary;

                    if (emp.Designation.Designation1.ToLower().Contains("security"))
                    {
                        noPayValueCalcDate = DateTime.DaysInMonth(year, month);
                    }

                    double noPayDeductionValue = emp.SalaryDetail.BasicSalary / noPayValueCalcDate;
                    double noPayValue = NPDaysCount != null ? NPDaysCount.Value * noPayDeductionValue : 0;

                    var singleOTValues = (from x in emp.OvertimeEmployeeDetails
                                          where x.OverTimeRecord.Type == 1 && x.OverTimeRecord.ApprovedBy != null && x.OTFrom >= startDate && x.OTTo <= endDate
                                          select new
                                          {
                                              OTValue = (x.OTTo.Value.Subtract(x.OTFrom.Value).TotalHours)
                                          });

                    double singleOTHours = 0;
                    foreach (var x in singleOTValues)
                    {
                        singleOTHours += x.OTValue;
                    }

                    var doubleOTValues = (from x in emp.OvertimeEmployeeDetails
                                          where x.OverTimeRecord.Type == 2 && x.OverTimeRecord.ApprovedBy != null && x.OTFrom >= startDate && x.OTTo <= endDate
                                          select new
                                          {
                                              OTValue = (x.OTTo.Value.Subtract(x.OTFrom.Value).TotalHours)
                                          });

                    double doubleOTHours = 0;
                    foreach (var x in doubleOTValues)
                    {
                        doubleOTHours += x.OTValue;
                    }

                    var tripleOTValues = (from x in emp.OvertimeEmployeeDetails
                                          where x.OverTimeRecord.Type == 3 && x.OverTimeRecord.ApprovedBy != null && x.OTFrom >= startDate && x.OTTo <= endDate
                                          select new
                                          {
                                              OTValue = (x.OTTo.Value.Subtract(x.OTFrom.Value).TotalHours)
                                          });

                    double tripleOTHours = 0;
                    foreach (var x in tripleOTValues)
                    {
                        tripleOTHours += x.OTValue;
                    }

                    double totalOTAmount = (singleOTHours * singleOTRate) + (doubleOTHours * doubleOTRate) + (tripleOTHours * tripleOTRate);

                    var AveragePieceRate = (from x in emp.AvaragePieceRateForEmployees
                                            where x.PieceRateDetail.Date >= startDate && x.PieceRateDetail.Date <= endDate
                                            select x.AvaragePayment).Sum();

                    var EnteredPieceRate = (from x in emp.EnteredPieceRateForEmployees
                                            where x.PieceRateDetail.Date >= startDate && x.PieceRateDetail.Date <= endDate
                                            select (x.PieceQty * x.PieceRateDetail.UnitRate)).Sum();

                    double totalPieceRate = (AveragePieceRate != null ? AveragePieceRate.Value : 0) + (EnteredPieceRate != null ? EnteredPieceRate.Value : 0);

                    double grossSalary = (emp.SalaryDetail.BasicSalary + emp.SalaryDetail.BudgetAllowance) - noPayValue + totalOTAmount + totalPieceRate;

                    double totalSalaryAdvances = (from x in emp.SalaryAdvanceEmployeeDetails
                                                  where x.CreatedDate >= startDate && x.CreatedDate <= endDate
                                                  select x.RequestAmount).Sum().Value;

                    Deduction deduction = emp.Deductions.Where(de => de.Year == year && de.Month == month).SingleOrDefault();

                    double totalDeduction = 0;
                    if (deduction != null)
                    {
                        totalDeduction = (emp.SalaryDetail.EPFETFTotalSalary * 0.08) + deduction.Payee + deduction.StampDuty + deduction.Meals + deduction.WelfareShop + deduction.WelfareContribution + deduction.WelfareLoan + deduction.BankSaving + deduction.MedicalIns + deduction.BankLoan + deduction.Misc;
                    }

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
                    detailsRow.NoPayamount = noPayValue.ToString("0.00");
                    detailsRow.SalaryToEPFETF = emp.SalaryDetail.EPFETFTotalSalary.ToString("0.00");
                    detailsRow.OTNH = singleOTHours.ToString("0.00");
                    detailsRow.OTDH = doubleOTHours.ToString("0.00");
                    detailsRow.OTTH = tripleOTHours.ToString("0.00");
                    detailsRow.OTAmount = totalOTAmount.ToString("0.00");
                    detailsRow.PieceRate = totalPieceRate.ToString("0.00");
                    detailsRow.GrossSalary = grossSalary.ToString("0.00");
                    detailsRow.SalaryAdvnace = totalSalaryAdvances.ToString("0.00");
                    detailsRow.EPF8 = (emp.SalaryDetail.EPFETFTotalSalary * 0.08).ToString("0.00");
                    detailsRow.Payee = deduction != null ? deduction.Payee.ToString("0.00") : "0.00";
                    detailsRow.StampDuty = deduction != null ? deduction.StampDuty.ToString("0.00") : "0.00";
                    detailsRow.Meals = deduction != null ? deduction.Meals.ToString("0.00") : "0.00";
                    detailsRow.WelfareShop = deduction != null ? deduction.WelfareShop.ToString("0.00") : "0.00";
                    detailsRow.WelfareContribution = deduction != null ? deduction.WelfareContribution.ToString("0.00") : "0.00";
                    detailsRow.WelfareLoan = deduction != null ? deduction.WelfareLoan.ToString("0.00") : "0.00";
                    detailsRow.BankSaving = deduction != null ? deduction.BankSaving.ToString("0.00") : "0.00";
                    detailsRow.Medicalinsurance = deduction != null ? deduction.MedicalIns.ToString("0.00") : "0.00";
                    detailsRow.BankLoan = deduction != null ? deduction.BankLoan.ToString("0.00") : "0.00";
                    detailsRow.Misc = deduction != null ? deduction.Misc.ToString("0.00") : "0.00";
                    detailsRow.TotalDeduction = totalDeduction.ToString("0.00");
                    detailsRow.NetSalary = (grossSalary - totalDeduction).ToString("0.00");
                    detailsRow.RoundupBFSalary = ((grossSalary - totalDeduction) % 10).ToString("0.00");
                    detailsRow.RoundupCFSalary = ((grossSalary - totalDeduction) % 10).ToString("0.00");
                    detailsRow.NetPayment = ((grossSalary - totalDeduction) - ((grossSalary - totalDeduction) % 10)).ToString("0.00");
                    detailsRow.EPF12 = (emp.SalaryDetail.EPFETFTotalSalary * 0.12).ToString("0.00");
                    detailsRow.EPF3 = (emp.SalaryDetail.EPFETFTotalSalary * 0.03).ToString("0.00");

                    gsds.SalaryDetails.AddSalaryDetailsRow(detailsRow);
                }
                catch (Exception)
                {
                }
            }

            dgvGeneratedSalary.DataSource = gsds.SalaryDetails;

            Cursor.Current = Cursors.Default;
        }

        private void btnPrintSalaryReport_Click(object sender, EventArgs e)
        {
            BasicSalaryDetailsDataSet bsds = new BasicSalaryDetailsDataSet();

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

            BasicSalaryDetailsDataSet.BasicSalaryDetailsRow row = bsds.BasicSalaryDetails.NewBasicSalaryDetailsRow();
            row.ReportID = 1;
            row.SalaryPeriod = year + " - " + cmbMonth.Text;
            row.SalaryPeriodFrom = startDate;
            row.SalaryPeriodTo = endDate;
            row.Department = cmbDepartment.Text;
            row.SubDepartment = chbSearchFromSubDepartment.Checked ? cmbSubDepartment.Text : "Not Assigned";
            row.NoPayDayCalculation = 0;
            row.SingleOTRate = singleOTRate;
            row.DoubleOTRate = doubleOTRate;
            row.TribleOTRate = tripleOTRate;

            bsds.BasicSalaryDetails.AddBasicSalaryDetailsRow(row);


            foreach (Employee emp in lstEmployee)
            {
                try
                {
                    double? NPDaysCount = (from pl in emp.PersonalLeaveRecords
                                           where pl.LeaveFrom >= startDate && pl.LeaveTo <= endDate && pl.IsNoPay.Value == true
                                           select pl.LeaveValue).Sum();

                    double? PaidLeave = (from pl in emp.PersonalLeaveRecords
                                         where pl.LeaveFrom >= startDate && pl.LeaveTo <= endDate && pl.IsNoPay.Value == false
                                         select pl.LeaveValue).Sum();

                    int noPayValueCalcDate = emp.SalaryDetail.DateRateOfSalary;

                    if (emp.Designation.Designation1.ToLower().Contains("security"))
                    {
                        noPayValueCalcDate = DateTime.DaysInMonth(year, month);
                    }

                    double noPayDeductionValue = emp.SalaryDetail.BasicSalary / noPayValueCalcDate;
                    double noPayValue = NPDaysCount != null ? NPDaysCount.Value * noPayDeductionValue : 0;

                    var singleOTValues = (from x in emp.OvertimeEmployeeDetails
                                          where x.OverTimeRecord.Type == 1 && x.OverTimeRecord.ApprovedBy != null && x.OTFrom >= startDate && x.OTTo <= endDate
                                          select new
                                          {
                                              OTValue = (x.OTTo.Value.Subtract(x.OTFrom.Value).TotalHours)
                                          });

                    double singleOTHours = 0;
                    foreach (var x in singleOTValues)
                    {
                        singleOTHours += x.OTValue;
                    }

                    var doubleOTValues = (from x in emp.OvertimeEmployeeDetails
                                          where x.OverTimeRecord.Type == 2 && x.OverTimeRecord.ApprovedBy != null && x.OTFrom >= startDate && x.OTTo <= endDate
                                          select new
                                          {
                                              OTValue = (x.OTTo.Value.Subtract(x.OTFrom.Value).TotalHours)
                                          });

                    double doubleOTHours = 0;
                    foreach (var x in doubleOTValues)
                    {
                        doubleOTHours += x.OTValue;
                    }

                    var tripleOTValues = (from x in emp.OvertimeEmployeeDetails
                                          where x.OverTimeRecord.Type == 3 && x.OverTimeRecord.ApprovedBy != null && x.OTFrom >= startDate && x.OTTo <= endDate
                                          select new
                                          {
                                              OTValue = (x.OTTo.Value.Subtract(x.OTFrom.Value).TotalHours)
                                          });

                    double tripleOTHours = 0;
                    foreach (var x in tripleOTValues)
                    {
                        tripleOTHours += x.OTValue;
                    }

                    double totalOTAmount = (singleOTHours * singleOTRate) + (doubleOTHours * doubleOTRate) + (tripleOTHours * tripleOTRate);

                    var AveragePieceRate = (from x in emp.AvaragePieceRateForEmployees
                                            where x.PieceRateDetail.Date >= startDate && x.PieceRateDetail.Date <= endDate
                                            select x.AvaragePayment).Sum();

                    var EnteredPieceRate = (from x in emp.EnteredPieceRateForEmployees
                                            where x.PieceRateDetail.Date >= startDate && x.PieceRateDetail.Date <= endDate
                                            select (x.PieceQty * x.PieceRateDetail.UnitRate)).Sum();

                    double totalPieceRate = (AveragePieceRate != null ? AveragePieceRate.Value : 0) + (EnteredPieceRate != null ? EnteredPieceRate.Value : 0);

                    double grossSalary = (emp.SalaryDetail.BasicSalary + emp.SalaryDetail.BudgetAllowance) - noPayValue + totalOTAmount + totalPieceRate;

                    double totalSalaryAdvances = (from x in emp.SalaryAdvanceEmployeeDetails
                                                  where x.CreatedDate >= startDate && x.CreatedDate <= endDate
                                                  select x.RequestAmount).Sum().Value;

                    Deduction deduction = emp.Deductions.Where(de => de.Year == year && de.Month == month).SingleOrDefault();

                    double totalDeduction = 0;
                    if (deduction != null)
                    {
                        totalDeduction = (emp.SalaryDetail.EPFETFTotalSalary * 0.08) + deduction.Payee + deduction.StampDuty + deduction.Meals + deduction.WelfareShop + deduction.WelfareContribution + deduction.WelfareLoan + deduction.BankSaving + deduction.MedicalIns + deduction.BankLoan + deduction.Misc;
                    }

                    BasicSalaryDetailsDataSet.BasicSalaryEmployeeDetailsRow empDetailsRow = bsds.BasicSalaryEmployeeDetails.NewBasicSalaryEmployeeDetailsRow();

                    empDetailsRow.ReportID = 1;
                    empDetailsRow.TokenNo = emp.TokenNo;
                    empDetailsRow.EPFNo = Convert.ToInt32(emp.EPFNo);
                    empDetailsRow.EmployeeName = emp.Name;
                    empDetailsRow.Designation = emp.Designation.Designation1;
                    empDetailsRow.EmployeeCategory= emp.EmployeeCatagory;
                    empDetailsRow.EmployeeGrade = emp.EmployeeGrade;
                    empDetailsRow.BasicSalary = emp.SalaryDetail.BasicSalary;
                    empDetailsRow.BubgetAllowance = emp.SalaryDetail.BudgetAllowance;
                    empDetailsRow.Total = (emp.SalaryDetail.BasicSalary + emp.SalaryDetail.BudgetAllowance);
                    empDetailsRow.NPDays = NPDaysCount != null ? NPDaysCount.Value : 0;
                    empDetailsRow.PaidLeaveDays = PaidLeave != null ? PaidLeave.Value : 0;
                    empDetailsRow.NoPayAmount = noPayValue;
                    empDetailsRow._SalaryToEPF_ETF = emp.SalaryDetail.EPFETFTotalSalary;
                    empDetailsRow._OT_N_H = singleOTHours;
                    empDetailsRow._OT_D_H = doubleOTHours;
                    empDetailsRow._OT_T_H = tripleOTHours;
                    empDetailsRow.OTAmount = totalOTAmount;
                    empDetailsRow.PiceRate = totalPieceRate;
                    empDetailsRow.GrossSalary = grossSalary;
                    empDetailsRow.SalaryAdvance = totalSalaryAdvances;
                    empDetailsRow.EPF = (emp.SalaryDetail.EPFETFTotalSalary * 0.08);
                    empDetailsRow.Payee = deduction != null ? deduction.Payee : 0;
                    empDetailsRow.StampDuty = deduction != null ? deduction.StampDuty : 0;
                    empDetailsRow.Meals = deduction != null ? deduction.Meals : 0;
                    empDetailsRow.WelfareShop = deduction != null ? deduction.WelfareShop : 0;
                    empDetailsRow._WelfareCon_ = deduction != null ? deduction.WelfareContribution : 0;
                    empDetailsRow._W_loan = deduction != null ? deduction.WelfareLoan : 0;
                    empDetailsRow.BankSaving = deduction != null ? deduction.BankSaving : 0;
                    empDetailsRow.MedicalIns = deduction != null ? deduction.MedicalIns : 0;
                    empDetailsRow.BankLoan = deduction != null ? deduction.BankLoan : 0;
                    empDetailsRow.Misc = deduction != null ? deduction.Misc : 0;
                    empDetailsRow.TotalDeduction = totalDeduction;
                    empDetailsRow.NetSalary = (grossSalary - totalDeduction);
                    empDetailsRow._RoundUpB_FBal_ = ((grossSalary - totalDeduction) % 10);
                    empDetailsRow._RoundUpC_FBal_ = ((grossSalary - totalDeduction) % 10);
                    empDetailsRow.NetPayment = ((grossSalary - totalDeduction) - ((grossSalary - totalDeduction) % 10));
                    empDetailsRow._E_P_F = (emp.SalaryDetail.EPFETFTotalSalary * 0.12);
                    empDetailsRow._E_T_F = (emp.SalaryDetail.EPFETFTotalSalary * 0.03);

                    bsds.BasicSalaryEmployeeDetails.AddBasicSalaryEmployeeDetailsRow(empDetailsRow);
                }
                catch (Exception)
                {
                }
            }

            BasicSalaryReport rpt = new BasicSalaryReport();
            rpt.SetDataSource(bsds);
            frmReportViewer frm = new frmReportViewer(rpt);
            frm.ShowDialog();

        }
    }
}
