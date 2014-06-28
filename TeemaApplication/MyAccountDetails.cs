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
    public partial class frmMyAccountDetails : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
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
    }
}
