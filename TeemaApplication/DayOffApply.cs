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
    public partial class frmDayOffApply : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        Employee empdata = new Employee();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmDayOffApply()
        {
            InitializeComponent();
        }

        private void DayOffApply_MouseDown(object sender, MouseEventArgs e)
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
                        txtEPFNO.Text = empdata.EPFNo;
                        txtBranch.Text = empdata.Department.Branch.BranchName;
                        txtDepartment.Text = empdata.Department.DepartmentName;
                        txtDesignation.Text = empdata.Designation.Designation1;
                        txtNICNo.Text = empdata.NICNo;
                        txtSubDepartment.Text = empdata.IsAssignedToSubDepartment ? empdata.SubDepartment.SubDepartmentName : "Not Assigned";
                        txtTokenNo.Text = empdata.TokenNo.ToString();

                    }
                    else
                    {
                        Utilities.ShowErrorBox("Employee not found");
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
                        txtEPFNO.Text = empdata.EPFNo;
                        txtBranch.Text = empdata.Department.Branch.BranchName;
                        txtDepartment.Text = empdata.Department.DepartmentName;
                        txtDesignation.Text = empdata.Designation.Designation1;
                        txtNICNo.Text = empdata.NICNo;
                        txtSubDepartment.Text = empdata.IsAssignedToSubDepartment ? empdata.SubDepartment.SubDepartmentName : "Not Assigned";
                        txtTokenNo.Text = empdata.TokenNo.ToString();

                    }
                    else
                    {
                        Utilities.ShowErrorBox("Employee not found");
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
                        txtEPFNO.Text = empdata.EPFNo;
                        txtBranch.Text = empdata.Department.Branch.BranchName;
                        txtDepartment.Text = empdata.Department.DepartmentName;
                        txtDesignation.Text = empdata.Designation.Designation1;
                        txtNICNo.Text = empdata.NICNo;
                        txtSubDepartment.Text = empdata.IsAssignedToSubDepartment ? empdata.SubDepartment.SubDepartmentName : "Not Assigned";
                        txtTokenNo.Text = empdata.TokenNo.ToString();

                    }
                    else
                    {
                        Utilities.ShowErrorBox("Employee not found");
                    }

                }
                else
                {
                    Utilities.ShowErrorBox("Please select a search method");
                }


            }
            else
            {
                Utilities.ShowErrorBox("Plese enter a Search Key to search");
            }

        }

        private void adddayoffrequest()
        {
            if (txtTokenNo.Text != "")
            {
                int tokenNo = Utilities.getIntValueFromTextBox(txtTokenNo);

                empdata = (from emp in db.Employees
                           where emp.TokenNo == tokenNo
                           select emp).SingleOrDefault();

                DayOffRecord df = new DayOffRecord();

                df.EmployeeID = empdata.EmployeeID;
                df.DayOffReason = txtdayoffreason.Text;
                df.DayOffFrom = dtpLeaveDate.Value;
                df.CreatedBy = 1;
                df.CreatedDate = System.DateTime.Today;

                db.DayOffRecords.InsertOnSubmit(df);
                db.SubmitChanges();

                Utilities.ShowInformationBox("Day off request successfully applied..! ");
            }
            else
            { Utilities.ShowErrorBox("Please search an employee..!"); }
        }

        private void btndayoffapply_Click(object sender, EventArgs e)
        {
            adddayoffrequest();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtdayoffreason.Text = "";
            searchEmployee();
        }
    }
}
