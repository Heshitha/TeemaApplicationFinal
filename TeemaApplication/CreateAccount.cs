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

namespace TeemaApplication
{
    public partial class frmCreateAccount : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int priviledge = 3 - cmbPriviledge.SelectedIndex;
                UserAccount userAcount = new UserAccount
                {
                    Name = txtName.Text,
                    UserName = txtUserName.Text,
                    Password = txtUserName.Text,
                    Priviledge = priviledge
                };
                db.UserAccounts.InsertOnSubmit(userAcount);
                db.SubmitChanges();
                Utilities.ShowInformationBox("You have successfully saved the information.");
                this.Dispose();
            }
            catch (Exception ex)
            {
                Utilities.ShowExceptionBox(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

        private void frmCreateAccount_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
