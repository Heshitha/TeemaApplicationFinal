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
using TeemaApplication.Datasets;

namespace TeemaApplication
{
    public partial class frmEditUserAccount : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        UserAccount userAccount = new UserAccount();
        public frmEditUserAccount()
        {
            InitializeComponent();
        }

        public frmEditUserAccount(int userAccountID)
        {
            InitializeComponent();

            userAccount = db.UserAccounts.Where(us => us.UserID == userAccountID).SingleOrDefault();
            txtName.Text = userAccount.Name;
            txtUserName.Text = userAccount.UserName;
            cmbPriviledge.SelectedIndex = 3 - userAccount.Priviledge;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == Utilities.ShowWarningBox("Do you really want to change the details of this account?"))
                {
                    userAccount.Name = txtName.Text;
                    userAccount.UserName = txtUserName.Text;
                    userAccount.Priviledge = 3 - cmbPriviledge.SelectedIndex;

                    db.SubmitChanges();
                    Utilities.ShowInformationBox("You have successfully change the details of this account.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                Utilities.ShowErrorBox(ex.Message);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == Utilities.ShowWarningBox("Do you really need to reset this user's password to it's default value?"))
                {
                    userAccount.Password = userAccount.UserName;
                    db.SubmitChanges();
                    Utilities.ShowInformationBox("You have successfully change the details of this account.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                Utilities.ShowErrorBox(ex.Message);
            }
        }
    }
}
