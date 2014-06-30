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
    public partial class frmAddPieceRate : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmAddPieceRate()
        {
            InitializeComponent();
        }

        private void frmAddPieceRate_MouseDown(object sender, MouseEventArgs e)
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

        private void frmAddPieceRate_Load(object sender, EventArgs e)
        {
            Utilities.fillBranchComboBox(db, cmbWorkingBranch);
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

                List<Employee> lstEmployees = ((Department)cmbDepartment.SelectedItem).Employees.Where(em => em.IsPieceRateApply).ToList();

                List<Employee> lstAllEmployees = ((Department)cmbDepartment.SelectedItem).Employees.ToList();

                fillEmployeeDetailsForEnterPieceUnitsForEmployees(lstEmployees);
                filldgvEnterAverageRateForEmployees(lstAllEmployees);
            }
        }

        private void fillEmployeeDetailsForEnterPieceUnitsForEmployees(List<Employee> employeeList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Entitled", typeof(bool));
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("Name");
            dt.Columns.Add("PieceRate", typeof(double));
            dt.Columns.Add("Measure");
            dt.Columns.Add("Payement", typeof(double));

            foreach (Employee x in employeeList)
            {
                dt.Rows.Add(false, x.TokenNo, x.Name, 0, "", 0);
            }

            dgvEnterPieceUnitsForEmployees.DataSource = dt;
        }

        private void filldgvEnterAverageRateForEmployees(List<Employee> employeeList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Entitled", typeof(bool));
            dt.Columns.Add("TokenNo");
            dt.Columns.Add("Name");

            foreach (Employee x in employeeList)
            {
                dt.Rows.Add(false, x.TokenNo, x.Name);
            }

            dgvEnterAverageRateForEmployees.DataSource = dt;
        }

        private void cmbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Employee> lstEmployees = ((SubDepartment)cmbSubDepartment.SelectedItem).Employees.Where(em => em.IsPieceRateApply).ToList();

            List<Employee> lstAllEmployees = ((Department)cmbDepartment.SelectedItem).Employees.ToList();

            fillEmployeeDetailsForEnterPieceUnitsForEmployees(lstEmployees);

            filldgvEnterAverageRateForEmployees(lstAllEmployees);
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

                List<Employee> lstEmployees = ((Department)cmbDepartment.SelectedItem).Employees.Where(em => em.IsPieceRateApply).ToList();

                List<Employee> lstAllEmployees = ((Department)cmbDepartment.SelectedItem).Employees.ToList();

                fillEmployeeDetailsForEnterPieceUnitsForEmployees(lstEmployees);

                filldgvEnterAverageRateForEmployees(lstAllEmployees);
            }
        }

        private void dgvEnterPieceUnitsForEmployees_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                double unitRate = Utilities.getDoubleValueFromTextBox(txtPieceUnitRate);
                double pieceQty = Convert.ToDouble(dgvEnterPieceUnitsForEmployees.Rows[e.RowIndex].Cells[3].Value);
                double payment = unitRate * pieceQty;
                dgvEnterPieceUnitsForEmployees.Rows[e.RowIndex].Cells[5].Value = payment;
            }
            calculateAveragePaymentDetails();
        }

        private void calculateAveragePaymentDetails()
        {
            double totalPiecesCount = 0;
            int numberOfWorkers = 0;
            double unitRate = Utilities.getDoubleValueFromTextBox(txtPieceUnitRate);

            foreach (DataGridViewRow x in dgvEnterPieceUnitsForEmployees.Rows)
            {
                DataGridViewCheckBoxCell chkCell = x.Cells[0] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(chkCell.Value))
                {
                    numberOfWorkers++;
                    totalPiecesCount += Convert.ToDouble(x.Cells[3].Value);
                }
            }

            double totalValue = totalPiecesCount * unitRate;
            double avaragePayement = totalValue / numberOfWorkers;

            txtTotalPiecesCount.Text = totalPiecesCount.ToString("0.00");
            txtTotalValue.Text = totalValue.ToString("0.00");
            txtNumberOfWorkers.Text = numberOfWorkers.ToString();
            txtAvragePayement.Text = avaragePayement.ToString("0.00");
        }

        private void dgvEnterPieceUnitsForEmployees_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Utilities.ShowErrorBox("Please enter correct values for fields in table.");
        }

        private void txtPieceUnitRate_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainDoubleValue(txtPieceUnitRate);
            double unitRate = Utilities.getDoubleValueFromTextBox(txtPieceUnitRate);
            foreach (DataGridViewRow x in dgvEnterPieceUnitsForEmployees.Rows)
            {
                double pieceQty = Convert.ToDouble(x.Cells[3].Value);
                double payment = unitRate * pieceQty;
                x.Cells[5].Value = payment;
            }
            calculateAveragePaymentDetails();
        }

        private void txtPieceRateCatagory_Leave(object sender, EventArgs e)
        {
            Utilities.checkIfContainText(txtPieceRateCatagory);
        }

        private void txtPieceUnitMeasure_Leave(object sender, EventArgs e)
        {
            if (Utilities.checkIfContainText(txtPieceUnitMeasure))
            {
                foreach (DataGridViewRow x in dgvEnterPieceUnitsForEmployees.Rows)
                {
                    x.Cells[4].Value = txtPieceUnitMeasure.Text;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Department department = (Department)cmbDepartment.SelectedItem;

            PieceRateDetail pieceDetail = new PieceRateDetail
            {
                Date = dtpEnteredDate.Value,
                Catagory = txtPieceRateCatagory.Text,
                MeasuredUnit = txtPieceUnitMeasure.Text,
                UnitRate = Utilities.getDoubleValueFromTextBox(txtPieceUnitRate),
                Department = department,
                CreatedBy = LoginDetails.LoggedUsedID,
                CreatedDate = DateTime.Now,
                ModifiedBy = LoginDetails.LoggedUsedID,
                ModifiedDate = DateTime.Now
            };

            db.PieceRateDetails.InsertOnSubmit(pieceDetail);
            db.SubmitChanges();

            foreach (DataGridViewRow x in dgvEnterPieceUnitsForEmployees.Rows)
            {
                if (Convert.ToBoolean(x.Cells[0].Value))
                {
                    double pieceQty = Convert.ToDouble(x.Cells[3].Value);
                    if (pieceQty != 0)
                    {
                        int tokenNo = Convert.ToInt32(x.Cells[1].Value);
                        Employee employee = department.Employees.Where(em => em.TokenNo == tokenNo).SingleOrDefault();
                        EnteredPieceRateForEmployee epre = new EnteredPieceRateForEmployee
                        {
                            PieceRateDetail = pieceDetail,
                            Employee = employee,
                            PieceQty = pieceQty
                        };

                        db.EnteredPieceRateForEmployees.InsertOnSubmit(epre);
                        db.SubmitChanges();
                    }
                }
            }

            foreach (DataGridViewRow x in dgvEnterPieceUnitsForEmployees.Rows)
            {
                if (Convert.ToBoolean(x.Cells[0].Value))
                {
                    int tokenNo = Convert.ToInt32(x.Cells[1].Value);
                    Employee employee = department.Employees.Where(em => em.TokenNo == tokenNo).SingleOrDefault();
                    AvaragePieceRateForEmployee apre = new AvaragePieceRateForEmployee
                    {
                        PieceRateDetail = pieceDetail,
                        Employee = employee
                    };

                    db.AvaragePieceRateForEmployees.InsertOnSubmit(apre);
                    db.SubmitChanges();
                }
            }
            Cursor.Current = Cursors.Default;
            Utilities.ShowInformationBox("Piece rate details saved successfully.");
        }

        private void btnPrintForm_Click(object sender, EventArgs e)
        {
            
        }
    }
}
