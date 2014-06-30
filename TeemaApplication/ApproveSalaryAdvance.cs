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
using TeemaApplication.Datasets;

namespace TeemaApplication
{
    public partial class ApproveSalaryAdvance : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public ApproveSalaryAdvance()
        {
            InitializeComponent();
        }

        private void ApproveSalaryAdvance_Load(object sender, EventArgs e)
        {
            fillcmbFormNo();
        }

        private void fillcmbFormNo()
        {
            cmbFormNo.DisplayMember = "SalaryAdvanceID";
            cmbFormNo.ValueMember = "SalaryAdvanceID";
            cmbFormNo.DataSource = db.SalaryAdvances.Where(SA => SA.ApprovedBy == null).ToList();
        }
    }
}
