using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeemaApplication.Datasets;
using TeemaApplication.Classes;
using System.Configuration;

namespace TeemaApplication
{
    public partial class frmLogin : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        public frmLogin()
        {
            InitializeComponent();
            Utilities.fillBranchComboBox(db, cmbBranch);
        }

        public DialogResult ShowDialog(bool flag)
        {
            DialogResult dialogResult = this.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                UserAccount useraccount = db.UserAccounts.Where(us => us.UserName.Equals(txtUserName.Text)).SingleOrDefault();
                if (useraccount != null && useraccount.Password.Equals(txtPassword.Text))
                {
                    LoginDetails.LoggedUserName = useraccount.Name;
                    LoginDetails.LoggedUsedID = useraccount.UserID;
                    LoginDetails.Priviledge = useraccount.Priviledge;
                    LoginDetails.Branch = (Branch)cmbBranch.SelectedItem;
                }
                else
                {
                    dialogResult = DialogResult.Retry;
                    Utilities.ShowErrorBox("Username or Password invalied. Please try again.");
                }
            }

            return dialogResult;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            bool isExternal = Convert.ToBoolean(ConfigurationSettings.AppSettings["Inhouse"]);
            if (!isExternal)
            {
                Utilities.ShowExceptionBox("Operating System Does Not Support For This Application. Please Optimize Your Application For " + Environment.OSVersion.VersionString + ". Please Contact Microsoft Authorized Reseller In Your Region For More Information.");

                this.Dispose();
            }
        }
    }
}
