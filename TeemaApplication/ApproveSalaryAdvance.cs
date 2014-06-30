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
            DataTable.Columns.Add("RequestedAmount");
            DataTable.Columns.Add("EPFSalary");
            DataTable.Columns.Add("DayWages");
            DataTable.Columns.Add("FixedInsentiveAllowance");
            DataTable.Columns.Add("VariableInsentiveAllowance");

            foreach (SalaryAdvanceEmployeeDetail x in SalaryAdvance.SalaryAdvanceEmployeeDetails)
            {
                DataTable.Rows.Add(x.Employee.TokenNo, x.Employee.Name, "", "", "", "", "");
            }
            dgvEmployeeDetails.DataSource = DataTable;
        }

        private void cmbFormNo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            fillemployeedetailsgrid();
        }
    }
}
