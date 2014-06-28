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
using TeemaApplication.Classes;
using TeemaApplication.Reports;

namespace TeemaApplication
{
    public partial class frmCreateOverTime : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();
        EmployeeDataSet ds = new EmployeeDataSet();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmCreateOverTime()
        {
            InitializeComponent();
        }

        private void frmCreateOverTime_Load(object sender, EventArgs e)
        {

        }

        private void frmCreateOverTime_MouseDown(object sender, MouseEventArgs e)
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
    }
}
