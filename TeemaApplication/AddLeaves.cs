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
    public partial class frmAddLeaves : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmAddLeaves()
        {
            InitializeComponent();
        }

        private void frmAddLeaves_Load(object sender, EventArgs e)
        {
            cmbLeaveYear.SelectedIndex = cmbLeaveYear.Items.IndexOf(DateTime.Today.Year.ToString());
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
        }

        private void frmAddLeaves_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
                fillLeavesGrid();
            }
        }

        private void fillLeavesGrid()
        {
            System.Data.Linq.EntitySet<Employee> employeeSet = new System.Data.Linq.EntitySet<Employee>();

            if (chbSearchFromSubDepartment.Checked)
            {
                employeeSet = ((SubDepartment)cmbSubDepartment.SelectedItem).Employees;
            }
            else
            {
                employeeSet = ((Department)cmbDepartment.SelectedItem).Employees;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("TokenID");
            dt.Columns.Add("Name");
            dt.Columns.Add("EPFNo");
            dt.Columns.Add("AnnualLeaves");
            dt.Columns.Add("CasualLeaves");

            foreach (Employee emp in employeeSet)
            {
                GrantedLeave grnLeave = (from x in emp.GrantedLeaves
                                         where x.year == Convert.ToInt32(cmbLeaveYear.Text)
                                         select x).SingleOrDefault();
                if (grnLeave != null)
                {
                    dt.Rows.Add(emp.TokenNo, emp.Name, emp.EPFNo, grnLeave.Annual, grnLeave.Casual);
                }
                else
                {
                    dt.Rows.Add(emp.TokenNo, emp.Name, emp.EPFNo, "0", "0");
                }
            }

            dgvLeaves.DataSource = dt;
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLeavesGrid();
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
                fillLeavesGrid();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbLeaveYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                fillLeavesGrid();
            }
            catch (Exception)
            {

            }
        }

        private void fillEmployeeDetailsgrpbox()
        {
            int year = Convert.ToInt32(cmbLeaveYear.Text);

            int tokenid = Convert.ToInt32(dgvLeaves.SelectedRows[0].Cells[0].Value.ToString());

            Employee employee = db.Employees.Where(em => em.TokenNo == tokenid).SingleOrDefault();

            txtEmployeeName.Text = employee.Name;
            txtDesignation.Text = employee.Designation.Designation1;
            txtNICNo.Text = employee.NICNo;
            txtEPFNO.Text = employee.EPFNo;
            txtTokenNo.Text = employee.TokenNo.ToString();

            GrantedLeave grantedLeave = employee.GrantedLeaves.Where(gl => gl.year == year).SingleOrDefault();

            if (grantedLeave != null)
            {
                txtAnnual.Text = grantedLeave.Annual.Value.ToString();
                txtCasual.Text = grantedLeave.Casual.Value.ToString();
            }
            else
            {
                txtAnnual.Text = "0";
                txtCasual.Text = "0";
            }
        }

        private void dgvLeaves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillEmployeeDetailsgrpbox();
        }

        private void cleartextbox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void addLeaves()
        {
            if (dgvLeaves.SelectedRows.Count == 1)
            {

                int year = Convert.ToInt32(cmbLeaveYear.Text);
                int annual = Convert.ToInt32(txtAnnual.Text);
                int casual = Convert.ToInt32(txtCasual.Text);

                int tokenid = Convert.ToInt32(dgvLeaves.SelectedRows[0].Cells[0].Value.ToString());

                //Get Employee id using token number
                Employee employee = db.Employees.Where(emp => emp.TokenNo == tokenid).SingleOrDefault();


                GrantedLeave grantedLeave = employee.GrantedLeaves.Where(grl => grl.year == Convert.ToInt32(cmbLeaveYear.Text)).SingleOrDefault();



                if (grantedLeave == null)
                {
                    // insert to  granted leaves
                    grantedLeave = new GrantedLeave
                    {
                        Employee = employee,
                        year = year,
                        Annual = annual,
                        Casual = casual,
                        CreatedBy = LoginDetails.LoggedUsedID,
                        CreatedDate = DateTime.Now,
                        ModifiedBy = LoginDetails.LoggedUsedID,
                        ModifiedDate = DateTime.Now
                    };

                    db.GrantedLeaves.InsertOnSubmit(grantedLeave);
                    //reload grid view
                    //  fillcmbSubDepartment((Department)cmbDepartment.SelectedItem);
                }
                else
                {
                    grantedLeave.Annual = Convert.ToInt32(txtAnnual.Text);
                    grantedLeave.Casual = Convert.ToInt32(txtCasual.Text);
                }
                db.SubmitChanges();
            }
            else
            {
                Utilities.ShowInformationBox("Please select an Employee to add leaves");
            }
        }

        private void btnAddLeaves_Click(object sender, EventArgs e)
        {
            addLeaves();
            fillLeavesGrid();
            cleartextbox(grpEmployeeDetails);
        }
    }
}
