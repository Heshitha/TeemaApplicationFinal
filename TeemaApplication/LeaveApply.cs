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
    public partial class frmLeaveApply : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        Employee empdata = new Employee();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmLeaveApply()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchEmployee();
        }

        private void searchEmployee()
        {
            if (txtKeyWord.Text != "")
            {
                String Searchkey = Convert.ToString(txtKeyWord.Text);

                if (rbtNIC.Checked)
                {

                    empdata = (from emp in db.Employees
                               where emp.NICNo == Searchkey
                               select emp).SingleOrDefault();

                    if (empdata != null && empdata.NICNo == Searchkey)
                    {
                        GrantedLeave grntslvs = (from grntdlvs in empdata.GrantedLeaves
                                                 where grntdlvs.year == Convert.ToInt32(System.DateTime.Today.Year)
                                                 select grntdlvs).SingleOrDefault();


                        txtEmployeeName.Text = empdata.Name;
                        txtEPFno.Text = empdata.EPFNo;
                        txtBranch.Text = empdata.Department.Branch.BranchName;
                        txtDepartment.Text = empdata.Department.DepartmentName;
                        txtDesignation.Text = empdata.Designation.Designation1;
                        txtNicNo.Text = empdata.NICNo;
                        txtSubDepartment.Text = empdata.IsAssignedToSubDepartment ? empdata.SubDepartment.SubDepartmentName : "Not Assigned";
                        txtTokenNo.Text = empdata.TokenNo.ToString();

                        if (grntslvs != null && grntslvs.EmployeeID == empdata.EmployeeID)
                        {

                            txtLeavesEntitledAnnual.Text = grntslvs.Annual.ToString();
                            txtLeavesEntitledCasual.Text = grntslvs.Casual.ToString();
                        }

                        else
                        {
                            MessageBox.Show("Granted leaves not found..!");
                        }


                        double prsnlvrecannual = (from persn in empdata.PersonalLeaveRecords
                                                  where persn.LeaveDate.Value.Year == Convert.ToInt32(System.DateTime.Today.Year) && persn.LeaveType == "Annual"
                                                  select persn.LeaveValue).Sum().Value;

                        double prsnlvreccasual = (from persn in empdata.PersonalLeaveRecords
                                                  where persn.LeaveDate.Value.Year == Convert.ToInt32(System.DateTime.Today.Year) && persn.LeaveType == "Casual"
                                                  select persn.LeaveValue).Sum().Value;

                        double prsnlvrecother = (from persn in empdata.PersonalLeaveRecords
                                                 where persn.LeaveDate.Value.Year == Convert.ToInt32(System.DateTime.Today.Year) && persn.LeaveType == "Other"
                                                 select persn.LeaveValue).Sum().Value;


                        txtLeavesTakenAnnual.Text = prsnlvrecannual.ToString();
                        txtLeavesTakenCasual.Text = prsnlvreccasual.ToString();
                        txtLeavesTakenOther.Text = prsnlvrecother.ToString();

                        if (grntslvs != null)
                        {

                            Double annualentitled = Convert.ToDouble(grntslvs.Annual);
                            Double annualtaken = Convert.ToDouble(prsnlvrecannual);
                            Double balanceAnnual = annualentitled - annualtaken;
                            txtLeaveBalanceAnnual.Text = Convert.ToString(balanceAnnual);

                            Double casualentitled = Convert.ToDouble(grntslvs.Casual);
                            Double casualtaken = Convert.ToDouble(prsnlvreccasual);
                            Double balanceCasual = casualentitled - casualtaken;
                            txtLeaveBalanceCasual.Text = Convert.ToString(balanceCasual);
                        }



                    }
                    else
                    {
                        MessageBox.Show("Employee not found");
                    }

                }
                else if (rbtEPFNo.Checked)
                {

                    empdata = (from emp in db.Employees
                               where emp.EPFNo == Searchkey
                               select emp).SingleOrDefault();

                    if (empdata != null && empdata.EPFNo == Searchkey)
                    {
                        GrantedLeave grntslvs = (from grntdlvs in empdata.GrantedLeaves
                                                 where grntdlvs.year == Convert.ToInt32(System.DateTime.Today.Year)
                                                 select grntdlvs).SingleOrDefault();

                        txtEmployeeName.Text = empdata.Name;
                        txtEPFno.Text = empdata.EPFNo;
                        txtBranch.Text = empdata.Department.Branch.BranchName;
                        txtDepartment.Text = empdata.Department.DepartmentName;
                        txtDesignation.Text = empdata.Designation.Designation1;
                        txtNicNo.Text = empdata.NICNo;
                        txtSubDepartment.Text = empdata.IsAssignedToSubDepartment ? empdata.SubDepartment.SubDepartmentName : "Not Assigned";
                        txtTokenNo.Text = empdata.TokenNo.ToString();

                        if (grntslvs != null && grntslvs.EmployeeID == empdata.EmployeeID)
                        {

                            txtLeavesEntitledAnnual.Text = grntslvs.Annual.ToString();
                            txtLeavesEntitledCasual.Text = grntslvs.Casual.ToString();
                        }

                        double prsnlvrecannual = (from persn in empdata.PersonalLeaveRecords
                                                  where persn.LeaveDate.Value.Year == Convert.ToInt32(System.DateTime.Today.Year) && persn.LeaveType == "Annual"
                                                  select persn.LeaveValue).Sum().Value;

                        double prsnlvreccasual = (from persn in empdata.PersonalLeaveRecords
                                                  where persn.LeaveDate.Value.Year == Convert.ToInt32(System.DateTime.Today.Year) && persn.LeaveType == "Casual"
                                                  select persn.LeaveValue).Sum().Value;

                        double prsnlvrecother = (from persn in empdata.PersonalLeaveRecords
                                                 where persn.LeaveDate.Value.Year == Convert.ToInt32(System.DateTime.Today.Year) && persn.LeaveType == "Other"
                                                 select persn.LeaveValue).Sum().Value;


                        txtLeavesTakenAnnual.Text = prsnlvrecannual.ToString();
                        txtLeavesTakenCasual.Text = prsnlvreccasual.ToString();
                        txtLeavesTakenOther.Text = prsnlvrecother.ToString();

                        if (grntslvs != null)
                        {

                            Double annualentitled = Convert.ToDouble(grntslvs.Annual);
                            Double annualtaken = Convert.ToDouble(prsnlvrecannual);
                            Double balanceAnnual = annualentitled - annualtaken;
                            txtLeaveBalanceAnnual.Text = Convert.ToString(balanceAnnual);

                            Double casualentitled = Convert.ToDouble(grntslvs.Casual);
                            Double casualtaken = Convert.ToDouble(prsnlvreccasual);
                            Double balanceCasual = casualentitled - casualtaken;
                            txtLeaveBalanceCasual.Text = Convert.ToString(balanceCasual);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Employee not found");
                    }

                }
                else if (rbtTokenNo.Checked)
                {
                    int tokenNo = Convert.ToInt32(Searchkey);

                    empdata = (from emp in db.Employees
                               where emp.TokenNo == tokenNo
                               select emp).SingleOrDefault();

                    if (empdata != null && empdata.TokenNo == (tokenNo))
                    {
                        GrantedLeave grntslvs = (from grntdlvs in empdata.GrantedLeaves
                                                 where grntdlvs.year == Convert.ToInt32(System.DateTime.Today.Year)
                                                 select grntdlvs).SingleOrDefault();

                        txtEmployeeName.Text = empdata.Name;
                        txtEPFno.Text = empdata.EPFNo;
                        txtBranch.Text = empdata.Department.Branch.BranchName;
                        txtDepartment.Text = empdata.Department.DepartmentName;
                        txtDesignation.Text = empdata.Designation.Designation1;
                        txtNicNo.Text = empdata.NICNo;
                        txtSubDepartment.Text = empdata.IsAssignedToSubDepartment ? empdata.SubDepartment.SubDepartmentName : "Not Assigned";
                        txtTokenNo.Text = empdata.TokenNo.ToString();

                        if (grntslvs != null && grntslvs.EmployeeID == empdata.EmployeeID)
                        {

                            txtLeavesEntitledAnnual.Text = grntslvs.Annual.ToString();
                            txtLeavesEntitledCasual.Text = grntslvs.Casual.ToString();
                        }
                        double prsnlvrecannual = (from persn in empdata.PersonalLeaveRecords
                                                  where persn.LeaveDate.Value.Year == Convert.ToInt32(System.DateTime.Today.Year) && persn.LeaveType == "Annual"
                                                  select persn.LeaveValue).Sum().Value;

                        double prsnlvreccasual = (from persn in empdata.PersonalLeaveRecords
                                                  where persn.LeaveDate.Value.Year == Convert.ToInt32(System.DateTime.Today.Year) && persn.LeaveType == "Casual"
                                                  select persn.LeaveValue).Sum().Value;

                        double prsnlvrecother = (from persn in empdata.PersonalLeaveRecords
                                                 where persn.LeaveDate.Value.Year == Convert.ToInt32(System.DateTime.Today.Year) && persn.LeaveType == "Other"
                                                 select persn.LeaveValue).Sum().Value;


                        txtLeavesTakenAnnual.Text = prsnlvrecannual.ToString();
                        txtLeavesTakenCasual.Text = prsnlvreccasual.ToString();
                        txtLeavesTakenOther.Text = prsnlvrecother.ToString();

                        if (grntslvs != null)
                        {

                            Double annualentitled = Convert.ToDouble(grntslvs.Annual);
                            Double annualtaken = Convert.ToDouble(prsnlvrecannual);
                            Double balanceAnnual = annualentitled - annualtaken;
                            txtLeaveBalanceAnnual.Text = Convert.ToString(balanceAnnual);

                            Double casualentitled = Convert.ToDouble(grntslvs.Casual);
                            Double casualtaken = Convert.ToDouble(prsnlvreccasual);
                            Double balanceCasual = casualentitled - casualtaken;
                            txtLeaveBalanceCasual.Text = Convert.ToString(balanceCasual);
                        }
                    }
                    else
                    {
                        Utilities.ShowInformationBox("Employee not found");
                    }
                }
                else
                {
                    Utilities.ShowInformationBox("Please select a search method");
                }
            }
            else
            {
                Utilities.ShowInformationBox("Plese enter a Search Key to search");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLeaveApply_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            applyleave();
        }

        private void applyleave()
        {
            String leavetype;
            String OtherLeaveReason;
            String reasonforabsence;

            bool ispay;
            DateTime leavefrom;
            DateTime leaveto;
            TimeSpan numberofdays;
            int substituteid;
            String nameofsubstitue;

            if (rbtOther.Checked || rbtAnnual.Checked || rbtCasual.Checked)
            {
                if (rbtAnnual.Checked)
                {
                    leavetype = "Annual";
                }
                else if (rbtCasual.Checked)
                {
                    leavetype = "Casual";
                }
                else if (rbtOther.Checked)
                {

                    leavetype = "Other";
                }
                else
                {
                    leavetype = "Annual";
                }

                if (txtReasonsForAbsence.Text != "")
                {
                    reasonforabsence = txtReasonsForAbsence.Text;

                    //if (rbtFullDay.Checked)
                    //{
                    //    leavevalue = 1;
                    //}
                    //else
                    //{
                    //    leavevalue = 0.5F;
                    //}

                    if (rbtPay.Checked)
                    {
                        ispay = true;
                    }
                    else
                    {
                        ispay = false;
                    }

                    leavefrom = dtpLeaveFrom.Value;
                    leaveto = dtpLeaveTo.Value;


                    if (txtOtherLeaveDescription.Text != null)
                    {
                        OtherLeaveReason = txtOtherLeaveDescription.Text;
                    }
                    else
                    {
                        OtherLeaveReason = "";
                    }

                    if (txtSubstituteID.Text != "")
                    {

                        substituteid = Utilities.getIntValueFromTextBox(txtSubstituteID);

                        Employee empname = (from emp in db.Employees
                                            where emp.TokenNo == substituteid
                                            select emp).SingleOrDefault();

                        if (empname != null)
                        {
                            txtNameofSubstitue.Text = empname.Name;

                            PersonalLeaveRecord persnlvrec = new PersonalLeaveRecord();



                            persnlvrec.Employee = empdata;

                            if (rbtFullDay.Checked)
                            {
                                persnlvrec.LeaveValue = 1;
                            }
                            else if (rbtHalfday.Checked)
                            {
                                persnlvrec.LeaveValue = 0.5;
                            }
                            persnlvrec.LeaveType = leavetype;
                            persnlvrec.LeaveReason = reasonforabsence;
                            persnlvrec.LeaveDate = System.DateTime.Today;
                            persnlvrec.IsNoPay = ispay;
                            persnlvrec.LeaveFrom = leavefrom;

                            // check for full days and halfdays befor entering Leave To
                            if (rbtFullDay.Checked)
                            { persnlvrec.LeaveTo = leaveto; }
                            else { persnlvrec.LeaveTo = null; }

                            persnlvrec.OtherLeaveDescription = OtherLeaveReason;
                            persnlvrec.SubstituteID = substituteid.ToString();
                            persnlvrec.CreatedBy = LoginDetails.LoggedUsedID;
                            persnlvrec.CreatedDate = DateTime.Now;
                            persnlvrec.ModifiedBy = LoginDetails.LoggedUsedID;
                            persnlvrec.ModifiedDate = DateTime.Now;

                            db.PersonalLeaveRecords.InsertOnSubmit(persnlvrec);
                            db.SubmitChanges();

                            Utilities.ShowInformationBox("Leave applied successfully..!!");


                        }
                        else
                        {
                            Utilities.ShowErrorBox("Substitue employee not found..!!");
                        }
                    }
                    else
                    {
                        Utilities.ShowErrorBox("Please add a substitute token number..!!");
                    }

                }
                else
                {
                    Utilities.ShowErrorBox("Please add a Reason for absence");
                }



            }
            else
            {
                Utilities.ShowErrorBox("Please select a Leave Type");
            }


        }
    }
}
