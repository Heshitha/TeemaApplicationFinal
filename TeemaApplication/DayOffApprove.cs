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
    public partial class frmDayOffApprove : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmDayOffApprove()
        {
            InitializeComponent();
        }

        private void frmDayOffApprove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void loaddayoffsgrid()
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
            dt.Columns.Add("DayOffID");
            dt.Columns.Add("LeaveDate");
            dt.Columns.Add("Approve", typeof(bool));

            foreach (Employee em in employeeList)
            {
                foreach (DayOffRecord pe in em.DayOffRecords.Where(pl => pl.DayOffFrom.Value.Year == Convert.ToInt32(cmbYear.SelectedItem) && pl.DayOffFrom.Value.Month <= (cmbMonth.SelectedIndex) + 1))
                {
                    if (chbUnApprovedOnly.Checked)
                    {
                        if (pe.ApprovedBy == null)
                        {
                            dt.Rows.Add(em.TokenNo, em.Name, pe.DayOffID, pe.DayOffFrom.Value.ToString("dd-MM-yyyy"), false);
                        }

                    }
                    else
                    {
                        bool isapproved = pe.ApprovedBy != null ? true : false;
                        dt.Rows.Add(em.TokenNo, em.Name, pe.DayOffID, pe.DayOffFrom.Value.ToString("dd-MM-yyyy"), isapproved);
                    }
                }

            }
            dgvLeavesapplied.DataSource = dt;
        }

        private void frmDayOffApprove_Load(object sender, EventArgs e)
        {
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
            cmbYear.SelectedIndex = cmbYear.Items.IndexOf(DateTime.Today.Year.ToString());
            cmbMonth.SelectedIndex = DateTime.Today.Month - 1;
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
                loaddayoffsgrid();
            }
            
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
                loaddayoffsgrid();
            }
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddayoffsgrid();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddayoffsgrid();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddayoffsgrid();
        }

        private void chbUnApprovedOnly_CheckedChanged(object sender, EventArgs e)
        {
            loaddayoffsgrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvLeavesapplied_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillEmployeeDetailsgrpbox();
        }

        private void fillEmployeeDetailsgrpbox()
        {

            int tokenid = Convert.ToInt32(dgvLeavesapplied.SelectedRows[0].Cells[0].Value.ToString());

            Employee data = (from emp in db.Employees
                             where emp.TokenNo == tokenid
                             select emp).SingleOrDefault();


            txtEmployeeName.Text = data.Name;
            txtDesignation.Text = data.Designation.Designation1;
            txtNICNo.Text = data.NICNo;
            txtEPFNO.Text = data.EPFNo;
            txtTokenNo.Text = data.TokenNo.ToString();

            // fill leave deatails textboxes

            int id = Convert.ToInt32(dgvLeavesapplied.SelectedRows[0].Cells[2].Value);

            DayOffRecord pre = (from en in db.DayOffRecords
                                where en.DayOffID == id
                                select en).SingleOrDefault();

            txtLeaveAppliedDate.Text = pre.CreatedDate.Value.ToString("dd-MM-yyyy");
            txtLeaveDate.Text = pre.DayOffFrom.Value.ToString("dd-MM-yyyy");
            txtLeaveReason.Text = pre.DayOffReason;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            submitapproval();
            loaddayoffsgrid();
        }

        private void submitapproval()
        {
            try
            {
                foreach (DataGridViewRow row in dgvLeavesapplied.Rows)
                {
                    DataGridViewCheckBoxCell checkCell = row.Cells[4] as DataGridViewCheckBoxCell;
                    bool IsApproved = (checkCell != null && checkCell.Value != null && true == (bool)checkCell.Value);

                    int leaveID = Convert.ToInt32(row.Cells[2].Value);
                    DayOffRecord perslvrec = db.DayOffRecords.Where(sa => sa.DayOffID == leaveID).SingleOrDefault();
                    if (IsApproved)
                    {
                        perslvrec.ApprovedBy = 1;
                        perslvrec.ModifiedBy = 1;
                        perslvrec.ModifiedDate = DateTime.Now;
                    }
                    else
                    {
                        perslvrec.ApprovedBy = null;
                        perslvrec.ModifiedBy = 1;
                        perslvrec.ModifiedDate = DateTime.Now;
                    }
                    db.SubmitChanges();
                }
                Utilities.ShowInformationBox("Successfully Saved.");
            }
            catch (Exception e)
            {
                Utilities.ShowExceptionBox(e.Message);
            }
        }
    }
}
