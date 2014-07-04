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
    public partial class frmMyAccountDetails : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public frmMyAccountDetails()
        {
            InitializeComponent();
        }

        private void frmMyAccountDetails_Load(object sender, EventArgs e)
        {
            UserAccount userAccount = db.UserAccounts.Where(us => us.UserID == LoginDetails.LoggedUsedID).SingleOrDefault();
            txtUserID.Text = userAccount.UserID.ToString();
            txtName.Text = userAccount.Name;
            txtUserName.Text = userAccount.UserName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                if (DialogResult.Yes == Utilities.ShowWarningBox("You are about to change your login details. Do you want to proceed?"))
                {
                    UserAccount userAccount = db.UserAccounts.Where(us => us.UserID == LoginDetails.LoggedUsedID).SingleOrDefault();
                    userAccount.UserName = txtUserName.Text;
                    if (txtPassword.Text != "")
                    {
                        userAccount.Password = txtPassword.Text;
                    }
                    db.SubmitChanges();
                    Utilities.ShowInformationBox("You have successfully change your login details");
                    this.Dispose();
                }
            }
            else
            {
                Utilities.ShowErrorBox("Password and confirm password is mismatched.");
            }
        }

        private void gbxAccountDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmMyAccountDetails_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
