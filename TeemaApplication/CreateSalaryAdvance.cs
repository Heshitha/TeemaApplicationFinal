using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeemaApplication.Classes;
using TeemaApplication.Datasets;

namespace TeemaApplication
{
    public partial class CreateSalaryAdvance : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();
        public CreateSalaryAdvance()
        {
            InitializeComponent();
        }

        private void CreateSalaryAdvance_Load(object sender, EventArgs e)
        {
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
           
        }

        private void CreateSalaryAdvance_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
   
        private void FillEmployeesBySubDepartment()
        {
            SubDepartment subdepartment = (SubDepartment)cmbSubDepartment.SelectedItem;
            DataTable dt = new DataTable();
            dt.Columns.Add("Entitled", typeof(bool));
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("Name");

            foreach (Employee employee in subdepartment.Employees)
            {
                dt.Rows.Add(false, employee.TokenNo, employee.Name);
            }

            dgvEmployeeDetails.DataSource = dt;
        }

        private void FillEmployeesByDepartment()
        {
            Department department = (Department)cmbDepartment.SelectedItem;
            DataTable dt = new DataTable();
            dt.Columns.Add("Entitled", typeof(bool));
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("Name");

            foreach (Employee employee in department.Employees)
            {
                dt.Rows.Add(false, employee.TokenNo, employee.Name);
            }

            dgvEmployeeDetails.DataSource = dt;
        }

        private void cmbWorkingBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilities.fillDepartmentComboBox((Branch)cmbWorkingBranch.SelectedItem, cmbDepartment);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                FillEmployeesByDepartment();
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
                FillEmployeesByDepartment();
            }
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillEmployeesBySubDepartment();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SalaryAdvance saladv = new SalaryAdvance
            {
                SalaryMonth = dtpSalaryMonth.Value,
                RequestDate = System.DateTime.Today,
                Department = (Department)cmbDepartment.SelectedItem,

                CreatedBy = LoginDetails.LoggedUsedID,
                CreatedDate = DateTime.Now,
                ModifiedBy = LoginDetails.LoggedUsedID,
                ModifiedDate = DateTime.Now

            };

            db.SalaryAdvances.InsertOnSubmit(saladv);
            db.SubmitChanges();

            foreach (DataGridViewRow row in dgvEmployeeDetails.Rows)
            {
                if (Convert.ToBoolean(row.Cells["clmnEntitled"].Value.ToString()) == true)
                {
                    try
                    {
                        string tokenNo = row.Cells["clmnTokenNo"].Value.ToString().Trim();
                        Employee employee = db.Employees.Where(emp => emp.TokenNo.Equals(tokenNo)).Single();
                        //string shiftStartText = row.Cells["clmnStartFrom"].Value.ToString();
                        //string shiftEndText = row.Cells["clmnShiftTo"].Value.ToString();
                        //string otStartText = row.Cells["clmnOTFrom"].Value.ToString();
                        //string otEndText = row.Cells["clmnOTTo"].Value.ToString();
                        //string Operation = row.Cells["clmnOperation"].Value.ToString();

                        //DateTime shiftStart = generateDateTimeInstanceFromTime(shiftStartText);
                        //DateTime shiftEnd = generateDateTimeInstanceFromTime(shiftEndText);
                        //DateTime otStart = generateDateTimeInstanceFromTime(otStartText);
                        //DateTime otEnd = generateDateTimeInstanceFromTime(otEndText);

                        SalaryAdvanceEmployeeDetail saladvempdet = new SalaryAdvanceEmployeeDetail
                        {
                            SalaryAdvance = saladv,

                        };

                        //  db.OvertimeEmployeeDetails.InsertOnSubmit(overEmpDet);
                        db.SubmitChanges();

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
       

    }
}
