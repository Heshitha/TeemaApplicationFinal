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
    public partial class frmLeaveApplyApprove : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmLeaveApplyApprove()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLeaveApplyApprove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmLeaveApplyApprove_Load(object sender, EventArgs e)
        {
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
            cmbYear.SelectedIndex = 5;
            setcurrentyear();
            setcurrentmonth();
        }

        private void setcurrentyear()
        {
            int currentyear = Convert.ToInt32(System.DateTime.Now.Year);

            int indexval = currentyear - 2014;

            cmbYear.SelectedIndex = indexval;
        }

        private void setcurrentmonth()
        {
            int currentmonth = (Convert.ToInt32(System.DateTime.Now.Month)) - 1;

            cmbMonth.SelectedIndex = currentmonth;
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
                cmbSubDepartment.DataBindings.Clear();
                cmbSubDepartment.Enabled = false;
                loadLeavesGrid();
            }
        }

        private void loadLeavesGrid()
        {
            System.Data.Linq.EntitySet<Employee> employeeList = new System.Data.Linq.EntitySet<Employee>();

            if (chbSearchFromSubDepartment.Checked)
            {
                employeeList = ((SubDepartment)cmbSubDepartment.SelectedItem).Employees;
            }
            else
            {
                employeeList = ((Department)cmbDepartment.SelectedItem).Employees;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("TokenID");
            dt.Columns.Add("Name");
            dt.Columns.Add("PersonalLeaveID");
            dt.Columns.Add("LeaveType");
            dt.Columns.Add("LeaveDate");
            dt.Columns.Add("Approve", typeof(bool));

            foreach (Employee em in employeeList)
            {
                foreach (PersonalLeaveRecord pe in em.PersonalLeaveRecords.Where(pl => pl.LeaveFrom.Value.Year == Convert.ToInt32(cmbYear.SelectedItem) && pl.LeaveFrom.Value.Month <= (cmbMonth.SelectedIndex) + 1))
                {
                    if (chbUnApprovedOnly.Checked)
                    {
                        if (pe.LeaveApprovedDept == null)
                        {
                            dt.Rows.Add(em.TokenNo, em.Name, pe.PersonalLeaveID, pe.LeaveType, pe.LeaveDate.Value.ToString("dd-MM-yyyy"), false);
                        }

                    }
                    else
                    {
                        bool isapproved = pe.LeaveApprovedDept != null ? true : false;
                        dt.Rows.Add(em.TokenNo, em.Name, pe.PersonalLeaveID, pe.LeaveType, pe.LeaveDate.Value.ToString("dd-MM-yyyy"), isapproved);
                    }
                }

            }
            dgvLeavesapplied.DataSource = dt;
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLeavesGrid();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLeavesGrid();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLeavesGrid();
        }

        private void chbUnApprovedOnly_CheckedChanged(object sender, EventArgs e)
        {
            loadLeavesGrid();
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
                cmbSubDepartment.DataBindings.Clear();
                cmbSubDepartment.Enabled = false;
                loadLeavesGrid();
            }
        }
    }
}
