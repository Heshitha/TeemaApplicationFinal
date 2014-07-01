using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeemaApplication.Classes;

namespace TeemaApplication
{
    public partial class frmTeemaApplicationMain : Form
    {
        private int childFormNumber = 0;

        public frmTeemaApplicationMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddNewEmployee frm = new frmAddNewEmployee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmTeemaApplicationMain_Load(object sender, EventArgs e)
        {
            bool isLogged = false;
            for (int i = 0; i < 3; i++)
            {
                frmLogin frm = new frmLogin();
                DialogResult result = frm.ShowDialog(true);
                if (result == DialogResult.OK)
                {
                    frm.Dispose();
                    isLogged = true;
                    break;
                }
                else if (result == DialogResult.Cancel)
                {
                    if (DialogResult.Yes == Utilities.ShowWarningBox("You have hit cancel. Do you really want to quit from the application?"))
                    {
                        this.Dispose();
                        break;
                    }
                }
                frm.Dispose();
            }
            if (!isLogged)
            {
                Utilities.ShowUnAuthorizedAccessBox("You have tried three times to login. Please contact administrator and verify your login details.");
                this.Dispose();
            }
        }

        private void userAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMyAccountDetails frm = new frmMyAccountDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginDetails.Priviledge == 1)
            {
                frmCreateAccount frm = new frmCreateAccount();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Utilities.ShowUnAuthorizedAccessBox("You don't have authorization to perform this task.");
            }
        }

        private void viewAccountsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginDetails.Priviledge == 1)
            {
                frmUserAccountList frm = new frmUserAccountList();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                Utilities.ShowUnAuthorizedAccessBox("You don't have authorization to perform this task.");
            }
        }

        private void tsmiViewEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeList frm = new frmEmployeeList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void createOvertimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateOverTime frm = new frmCreateOverTime();
            frm.MdiParent = this;
            frm.Show();
        }

        private void approveOvertimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApproveOvertime frm = new frmApproveOvertime();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewOvertimeFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOvertimeForms frm = new frmOvertimeForms();
            frm.MdiParent = this;
            frm.Show();
        }

        private void createSalaryAdvanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateSalaryAdvance frm = new CreateSalaryAdvance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void enterPieceRateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPieceRate frm = new frmAddPieceRate();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pieceRatePaymentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPieceRatePaymentList frm = new frmPieceRatePaymentList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewFingerPrintDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFingerPrintDevices frm = new frmFingerPrintDevices();
            frm.MdiParent = this;
            frm.Show();
        }

        private void approveSalaryAdvanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApproveSalaryAdvance frm = new ApproveSalaryAdvance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loadAttendanceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoadAttenadanceDetails frm = new frmLoadAttenadanceDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewSecurityRoutineReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewSecurityRoutine frm = new frmViewSecurityRoutine();
            frm.MdiParent = this;
            frm.Show();
        }

        private void editGrantedLeavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddLeaves frm = new frmAddLeaves();
            frm.MdiParent = this;
            frm.Show();
        }

        private void applyLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeaveApply frm = new frmLeaveApply();
            frm.MdiParent = this;
            frm.Show();
        }

        private void approveLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeaveApplyApprove frm = new frmLeaveApplyApprove();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dayOffApplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDayOffApply frm = new frmDayOffApply();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
