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
using TeemaApplication.Reports;
using RealandAPI;

namespace TeemaApplication
{
    public partial class frmFingerPrintDevices : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmFingerPrintDevices()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmFingerPrintDevices_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void fillCommunicationType(ComboBox comboBox)
        {
            List<communicationType> lstComType = new List<communicationType>();
            communicationType comType01 = new communicationType
            {
                CommunicationValue = 1,
                CommunicationText = "TCP / IP"
            };
            lstComType.Add(comType01);
            communicationType comType02 = new communicationType
            {
                CommunicationValue = 2,
                CommunicationText = "USB"
            };
            lstComType.Add(comType02);

            comboBox.DisplayMember = "CommunicationText";
            comboBox.ValueMember = "CommunicationValue";
            comboBox.DataSource = lstComType;
        }

        private void frmFingerPrintDevices_Load(object sender, EventArgs e)
        {
            fillCommunicationType(cmbANDDCommunicationType);
            fillCommunicationType(cmbEDDCommunicationType);
        }

        private static void TestDevice(int communicationType, string ipAddress, int ipPort, int password)
        {
            Device d = new ZDFinger();
            d.Communication = communicationType;
            d.IpAddress = ipAddress;
            d.IpPort = ipPort;
            d.Password = password;

            bool result = d.OpenCommunication();
            d.CloseCommunication();

            if (result)
            {
                Utilities.ShowInformationBox("Test succeed.");
            }
            else
            {
                Utilities.ShowErrorBox("Error occured. Plese re check conectivity, Ip Address, Ip Port and Password.");
            }
        }

        private void btnANDDTestDevice_Click(object sender, EventArgs e)
        {
            int communicationType = (int)cmbANDDCommunicationType.SelectedValue;
            string ipAddress = validateIP(txtANDDIpAddress) ? txtEDDIpAddress.Text : "0.0.0.0";
            int ipPort = Convert.ToInt32(txtANDDIpPort.Text);
            int password = Convert.ToInt32(txtANDDPassword.Text);

            TestDevice(communicationType, ipAddress, ipPort, password);
        }

        private bool validateIP(TextBox textBox)
        {
            string address = textBox.Text;
            string[] splitedAddr = address.Split('.');
            if (splitedAddr.Length == 4)
            {
                foreach (string str in splitedAddr)
                {
                    if (str.Trim().Length > 3)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnEDDTestDevice_Click(object sender, EventArgs e)
        {
            int communicationType = (int)cmbEDDCommunicationType.SelectedValue;
            string ipAddress = validateIP(txtEDDIpAddress) ? txtEDDIpAddress.Text : "0.0.0.0";
            int ipPort = Convert.ToInt32(txtEDDIpPort.Text);
            int password = Convert.ToInt32(txtEDDPassword.Text);

            TestDevice(communicationType, ipAddress, ipPort, password);
        }
    }

    public class communicationType
    {
        public int CommunicationValue { get; set; }
        public string CommunicationText { get; set; }
    }
}
