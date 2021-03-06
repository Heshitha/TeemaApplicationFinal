﻿using System;
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
using TeemaApplication.Reports;

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


                        SalaryAdvanceEmployeeDetail saladvempdet = new SalaryAdvanceEmployeeDetail
                        {
                            SalaryAdvance = saladv,
                            Employee = employee,

                            CreatedBy = LoginDetails.LoggedUsedID,
                            CreatedDate = DateTime.Now,
                            ModifiedBy = LoginDetails.LoggedUsedID,
                            ModifiedDate = DateTime.Now

                        };

                        db.SalaryAdvanceEmployeeDetails.InsertOnSubmit(saladvempdet);
                        db.SubmitChanges();

                    }
                    catch (Exception ex)
                    {
                        Utilities.ShowExceptionBox(ex.Message);
                    }

                   
                }
            }
            Utilities.ShowInformationBox("You have successfully created Salary Advance request. Press print form button to get the printed copy.");
            btnPrintForm.Enabled = true;

            txtFormNo.Text = saladv.SalaryAdvanceID.ToString();
       
        }

        private void printform()
        {

            int formno = Utilities.getIntValueFromTextBox(txtFormNo);


            SalaryAdvance SalaryAdvance = db.SalaryAdvances.Where(sl => sl.SalaryAdvanceID == formno).SingleOrDefault();

            SalaryAdvanceDataSet SalaryAdvanceDataSet = new SalaryAdvanceDataSet();

            SalaryAdvanceDataSet.SalaryAdvanceDetailaRow SArow = SalaryAdvanceDataSet.SalaryAdvanceDetaila.NewSalaryAdvanceDetailaRow();

            SArow.ReportID = SalaryAdvance.SalaryAdvanceID;
            SArow.Department = SalaryAdvance.Department.DepartmentName;
            SArow.CreatedBy = SalaryAdvance.UserAccount.Name;
            SArow.CreatedDate = SalaryAdvance.CreatedDate.Value;
            SArow.ModifiedBy = SalaryAdvance.UserAccount1.Name;
            SArow.ModifiedDate = SalaryAdvance.ModifiedDate.Value;
            SArow.ApprovedBy = "-Not Approved-";
            

            SalaryAdvanceDataSet.SalaryAdvanceDetaila.AddSalaryAdvanceDetailaRow(SArow);

            foreach (SalaryAdvanceEmployeeDetail x in SalaryAdvance.SalaryAdvanceEmployeeDetails)
            {
                SalaryAdvanceDataSet.SalaryAdvanceEmployeeDetailsRow saemprow = SalaryAdvanceDataSet.SalaryAdvanceEmployeeDetails.NewSalaryAdvanceEmployeeDetailsRow();

                saemprow.ReportID = x.SalaryAdvanceID;
                saemprow.TokenNo = x.Employee.TokenNo;
                saemprow.EmployeeName = x.Employee.Name;

                SalaryAdvanceDataSet.SalaryAdvanceEmployeeDetails.AddSalaryAdvanceEmployeeDetailsRow(saemprow);

            }

            SalaryAdvanceReport rpt = new SalaryAdvanceReport();
            rpt.SetDataSource(SalaryAdvanceDataSet);

            frmReportViewer frm = new frmReportViewer(rpt);
            frm.ShowDialog();
        }

        private void btnPrintForm_Click(object sender, EventArgs e)
        {
            printform();
        }
    }
}
