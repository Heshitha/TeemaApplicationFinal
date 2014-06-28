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
    public partial class frmCreateAccount : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
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
    }
}
