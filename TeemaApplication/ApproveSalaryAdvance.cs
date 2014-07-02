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

namespace TeemaApplication
{
    public partial class ApproveSalaryAdvance : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        double requestedAmount = 0;
        double EPFSalary = 0;
        double DayWages = 0;
        double FixedInsentiveAllowance = 0;
        double VariableInsentiveAllowance = 0;

        public ApproveSalaryAdvance()
        {
            InitializeComponent();
        }

        private void ApproveSalaryAdvance_Load(object sender, EventArgs e)
        {
            fillcmbFormNo();
        }

        private void fillcmbFormNo()
        {
            cmbFormNo.DisplayMember = "SalaryAdvanceID";
            cmbFormNo.ValueMember = "SalaryAdvanceID";
            cmbFormNo.DataSource = db.SalaryAdvances.Where(SA => SA.ApprovedBy == null).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbFormNo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

       
        private void fillemployeedetailsgrid()
        {
            SalaryAdvance SalaryAdvance = (SalaryAdvance)cmbFormNo.SelectedItem;
            SalaryAdvanceEmployeeDetail SalaryAdvanceEmployeeDetail = SalaryAdvance.SalaryAdvanceEmployeeDetails.FirstOrDefault();

            if (SalaryAdvanceEmployeeDetail != null)
            {
                txtDepartment.Text = SalaryAdvanceEmployeeDetail.Employee.Department.DepartmentName;
                txtBranch.Text = SalaryAdvanceEmployeeDetail.Employee.Department.Branch.BranchName;

                if (SalaryAdvanceEmployeeDetail.Employee.IsAssignedToSubDepartment)
                txtSubDepartment.Text = SalaryAdvanceEmployeeDetail.Employee.SubDepartment.SubDepartmentName;
            }

            DataTable DataTable = new DataTable();
            DataTable.Columns.Add("TokenNo");
            DataTable.Columns.Add("Name");
            DataTable.Columns.Add("RequestAmount", typeof(double));
            DataTable.Columns.Add("EPFSal", typeof(double));
            DataTable.Columns.Add("DayWages", typeof(double));
            DataTable.Columns.Add("FixedInsentive", typeof(double));
            DataTable.Columns.Add("VariableInsentive", typeof(double));

            foreach (SalaryAdvanceEmployeeDetail x in SalaryAdvance.SalaryAdvanceEmployeeDetails)
            {
                DataTable.Rows.Add(x.Employee.TokenNo, x.Employee.Name, 0, 0, 0, 0, 0);
            }
            dgvEmployeeDetails.DataSource = DataTable;
        }

        private void cmbFormNo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            fillemployeedetailsgrid();
        }

        private void approvesalaryadvance()
        {
            bool gridval = true;
               SalaryAdvance SalaryAdvance = (SalaryAdvance)cmbFormNo.SelectedItem;
               if (SalaryAdvance.ApprovedBy != null)
                {
                   
                        SalaryAdvance.ApprovedBy = LoginDetails.LoggedUsedID;
                        SalaryAdvance.ApprovedDate = DateTime.Now;
                        SalaryAdvance.ModifiedBy = LoginDetails.LoggedUsedID;
                        SalaryAdvance.ModifiedDate = DateTime.Now;

                        foreach (DataGridViewRow row in dgvEmployeeDetails.Rows)
                        {
                            int tokenNo = Convert.ToInt32(row.Cells["clmnTokenNo"].Value.ToString().Trim());
                            SalaryAdvanceEmployeeDetail SalaryAdvanceEmployeeDetail = SalaryAdvance.SalaryAdvanceEmployeeDetails.Where(SA => SA.Employee.TokenNo == tokenNo).SingleOrDefault();

                             requestedAmount = Convert.ToDouble(row.Cells["clmnRequestedAmount"].Value);
                             EPFSalary = Convert.ToDouble(row.Cells["clmnEPFSalary"].Value);
                             DayWages = Convert.ToDouble(row.Cells["clmnDayWages"].Value);
                             FixedInsentiveAllowance = Convert.ToDouble(row.Cells["clmnFixedInsentiveAllowance"].Value);
                             VariableInsentiveAllowance = Convert.ToDouble(row.Cells["clmnVariableInsentiveAllowance"].Value);

                             if (requestedAmount == EPFSalary + DayWages + FixedInsentiveAllowance + VariableInsentiveAllowance)
                             {
                                 SalaryAdvanceEmployeeDetail.RequestAmount = requestedAmount;
                                 SalaryAdvanceEmployeeDetail.EPFSal = EPFSalary;
                                 SalaryAdvanceEmployeeDetail.DayWages = DayWages;
                                 SalaryAdvanceEmployeeDetail.FixedInsentive = FixedInsentiveAllowance;
                                 SalaryAdvanceEmployeeDetail.VariableInsentive = VariableInsentiveAllowance;
                                 SalaryAdvanceEmployeeDetail.ModifiedBy = LoginDetails.LoggedUsedID;
                                 SalaryAdvanceEmployeeDetail.ModifiedDate = DateTime.Now;
                             }
                             else
                             {
                                 gridval = false;
                             }
                           
                        }

                        if (gridval == true)
                        {
                            db.SubmitChanges();
                            Utilities.ShowInformationBox("You have successfully approved Salary Advance requests.");
                        }
                    
                }
                else
                {
                    Utilities.ShowErrorBox("You have already approved this Salary Advance request.");
                }

        }

        // check requested amount breakdown is equal to requested amount
       
    }
}
