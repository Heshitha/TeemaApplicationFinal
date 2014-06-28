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
    public partial class frmEmployeeList : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        TeemaDBDataContext db = new TeemaDBDataContext();

        public frmEmployeeList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmEmployeeList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void GetAllEmployees()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("Branch");
            dt.Columns.Add("Department");
            dt.Columns.Add("SubDepartment");

            foreach (Employee x in db.Employees)
            {
                string subdepartment = x.IsAssignedToSubDepartment ? x.SubDepartment.SubDepartmentName : "Not Assigned";
                dt.Rows.Add(x.Name, x.TokenNo, x.Department.Branch.BranchName, x.Department.DepartmentName, subdepartment);
            }

            dgvEmployees.DataSource = dt;
        }

        private void rdbAllEmployees_CheckedChanged(object sender, EventArgs e)
        {
            cmbBranch.Enabled = false;
            cmbDepartment.Enabled = false;
            cmbSubDepartment.Enabled = false;


            GetAllEmployees();
        }

        private void frmEmployeeList_Load(object sender, EventArgs e)
        {
            GetAllEmployees();
        }

        private void rdbSearchByBranch_CheckedChanged(object sender, EventArgs e)
        {
            cmbBranch.Enabled = true;
            cmbDepartment.Enabled = false;
            cmbSubDepartment.Enabled = false;


            Utilities.fillBranchComboBox(db, cmbBranch);
            GetEmployeesByBranch((Branch)cmbBranch.SelectedItem);
        }

        private void GetEmployeesByBranch(Branch branch)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("TokenNo");
                dt.Columns.Add("Branch");
                dt.Columns.Add("Department");
                dt.Columns.Add("SubDepartment");

                foreach (Department dept in branch.Departments)
                {
                    foreach (Employee x in dept.Employees)
                    {
                        string subdepartment = x.IsAssignedToSubDepartment ? x.SubDepartment.SubDepartmentName : "Not Assigned";
                        dt.Rows.Add(x.Name, x.TokenNo, x.Department.Branch.BranchName, x.Department.DepartmentName, subdepartment);
                    }
                }

                dgvEmployees.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEmployeesByBranch((Branch)cmbBranch.SelectedItem);
        }

        private void GetEmployeesByDepartment(Department department)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("TokenNo");
                dt.Columns.Add("Branch");
                dt.Columns.Add("Department");
                dt.Columns.Add("SubDepartment");

                foreach (Employee x in department.Employees)
                {
                    string subdepartment = x.IsAssignedToSubDepartment ? x.SubDepartment.SubDepartmentName : "Not Assigned";
                    dt.Rows.Add(x.Name, x.TokenNo, x.Department.Branch.BranchName, x.Department.DepartmentName, subdepartment);
                }

                dgvEmployees.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        private void rdbSearchByDepartment_CheckedChanged(object sender, EventArgs e)
        {
            cmbBranch.Enabled = true;
            cmbDepartment.Enabled = true;
            cmbSubDepartment.Enabled = false;

            

            Utilities.fillBranchComboBox(db, cmbBranch);
            Utilities.fillDepartmentComboBox((Branch)cmbBranch.SelectedItem, cmbDepartment);
            GetEmployeesByDepartment((Department)cmbDepartment.SelectedItem);
        }

        private void GetEmployeesBySubDepartment(SubDepartment subDepartment)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("TokenNo");
                dt.Columns.Add("Branch");
                dt.Columns.Add("Department");
                dt.Columns.Add("SubDepartment");

                foreach (Employee x in subDepartment.Employees)
                {
                    string subdepartment = x.IsAssignedToSubDepartment ? x.SubDepartment.SubDepartmentName : "Not Assigned";
                    dt.Rows.Add(x.Name, x.TokenNo, x.Department.Branch.BranchName, x.Department.DepartmentName, subdepartment);
                }

                dgvEmployees.DataSource = dt;
            }
            catch (Exception)
            {
            }
        }

        private void rdbSearchBySubDepartment_CheckedChanged(object sender, EventArgs e)
        {
            cmbBranch.Enabled = true;
            cmbDepartment.Enabled = true;
            cmbSubDepartment.Enabled = true;
            Utilities.fillBranchComboBox(db, cmbBranch);
            Utilities.fillDepartmentComboBox((Branch)cmbBranch.SelectedItem, cmbDepartment);
            Utilities.fillSubDepartmentComboBox((Department)cmbDepartment.SelectedItem, cmbSubDepartment);
            GetEmployeesBySubDepartment((SubDepartment)cmbSubDepartment.SelectedItem);
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEmployeesByDepartment((Department)cmbDepartment.SelectedItem);
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEmployeesBySubDepartment((SubDepartment)cmbSubDepartment.SelectedItem);
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tokenNo = dgvEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
            Employee employee = db.Employees.Where(emp => emp.TokenNo.Equals(tokenNo)).FirstOrDefault();
            if (employee != null)
            {
                frmEditEmployeeDetails frm = new frmEditEmployeeDetails(employee);
                frm.ShowDialog();
            }
        }
    }
}
