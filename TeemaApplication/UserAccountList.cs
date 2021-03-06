﻿using System;
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
    public partial class frmUserAccountList : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmUserAccountList()
        {
            InitializeComponent();
        }

        private void frmUserAccountList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UserID");
            dt.Columns.Add("Name");
            dt.Columns.Add("UserName");
            dt.Columns.Add("Priviledge");

            foreach (UserAccount x in db.UserAccounts)
            {
                string priviledge = "";
                if (x.Priviledge == 1)
                    priviledge = "View Insert And Edit";
                else if (x.Priviledge == 2)
                    priviledge = "View And Insert Only";
                else if (x.Priviledge == 3)
                    priviledge = "View Only";

                dt.Rows.Add(x.UserID, x.Name, x.UserName, priviledge);
            }

            dgvUserAccountList.DataSource = dt;
        }

        private void dgvUserAccountList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int userAccountID = Convert.ToInt32(dgvUserAccountList.Rows[e.RowIndex].Cells[0].Value.ToString());
                frmEditUserAccount frm = new frmEditUserAccount(userAccountID);
                //frm.MdiParent = this.MdiParent;
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmUserAccountList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
