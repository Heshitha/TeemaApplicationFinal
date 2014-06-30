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
using RealandAPI;
using TeemaApplication.Classes;
using TeemaApplication.Datasets;
using TeemaApplication.Reports;

namespace TeemaApplication
{
    public partial class frmLoadAttenadanceDetails : Form
    {
        TeemaDBDataContext db = new TeemaDBDataContext();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmLoadAttenadanceDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLoadAttenadanceDetails_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmLoadAttenadanceDetails_Load(object sender, EventArgs e)
        {
            fillcmbMachineID();
            fillcmbMachineName();
        }

        private void fillcmbMachineID()
        {
            cmbMachineID.ValueMember = "DeviceID";
            cmbMachineID.DisplayMember = "DeviceID";
            cmbMachineID.DataSource = db.FingerPrintDivices;
        }

        private void fillcmbMachineName()
        {
            cmbMachineName.ValueMember = "DeviceID";
            cmbMachineName.DisplayMember = "DeviceName";
            cmbMachineName.DataSource = db.FingerPrintDivices;
        }

        private void cmbMachineID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FingerPrintDivice device = (FingerPrintDivice)cmbMachineID.SelectedItem;
            txtConnectionMode.Text = device.CommunicationType.Value == 1 ? "TCP / IP" : "USB";
        }

        private void cmbMachineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FingerPrintDivice device = (FingerPrintDivice)cmbMachineName.SelectedItem;
            txtConnectionMode.Text = device.CommunicationType.Value == 1 ? "TCP / IP" : "USB";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FingerPrintDivice fpd = (FingerPrintDivice)cmbMachineID.SelectedItem;
                Device device = new ZDFinger
                {
                    Communication = fpd.CommunicationType.Value,
                    IpAddress = fpd.IPAddress,
                    IpPort = fpd.IPPort.Value,
                    Password = fpd.Password.Value
                };

                List<Record> lstRec = new List<Record>();

                if (device.OpenCommunication())
                {
                    lstRec = device.GetAllRecords();
                    device.CloseCommunication();
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("Clock");
                dt.Columns.Add("DIN");
                dt.Columns.Add("VerifyMode");

                foreach (Record r in lstRec)
                {
                    string mode = string.Empty;
                    switch (r.VerifyMode)
                    {
                        case 1025:
                            mode = "In";
                            break;
                        case 1281:
                            mode = "Out";
                            break;
                        case 1:
                            mode = "Duty On";
                            break;
                        case 257:
                            mode = "Duty Off";
                            break;
                        case 513:
                            mode = "Overtime On";
                            break;
                        case 769:
                            mode = "Overtime Off";
                            break;
                        default:
                            mode = "Default Mode";
                            break;
                    }
                    dt.Rows.Add(r.Clock, r.DIN, mode);
                }
                dgvAttendanceDetails.DataSource = dt;
            }
            catch (Exception ex)
            {
                Utilities.ShowExceptionBox(ex.Message);
            }
        }

        private void btnSaveRecords_Click(object sender, EventArgs e)
        {
            try
            {
                FingerPrintDivice fpd = (FingerPrintDivice)cmbMachineID.SelectedItem;
                Device device = new ZDFinger
                {
                    Communication = fpd.CommunicationType.Value,
                    IpAddress = fpd.IPAddress,
                    IpPort = fpd.IPPort.Value,
                    Password = fpd.Password.Value
                };

                List<Record> lstRec = new List<Record>();

                if (device.OpenCommunication())
                {
                    lstRec = device.GetAllRecords();
                    device.CloseCommunication();
                }
                pbSavingProgress.Minimum = 0;
                pbSavingProgress.Maximum = lstRec.Count;
                int progressBar = 0;

                foreach (Record rec in lstRec)
                {
                    progressBar++;
                    pbSavingProgress.Value = progressBar;
                    string mode = string.Empty;
                    switch (rec.VerifyMode)
                    {
                        case 1025:
                            mode = "In";
                            break;
                        case 1281:
                            mode = "Out";
                            break;
                        case 1:
                            mode = "Duty On";
                            break;
                        case 257:
                            mode = "Duty Off";
                            break;
                        case 513:
                            mode = "Overtime On";
                            break;
                        case 769:
                            mode = "Overtime Off";
                            break;
                        default:
                            mode = "Default Mode";
                            break;
                    }
                    Employee empl = db.Employees.Where(em => em.TokenNo.Equals(rec.DIN.ToString())).SingleOrDefault();
                    if (empl != null)
                    {
                        EmployeeAttendance empAtt = db.EmployeeAttendances.Where(emAt => (emAt.DateAndTime == rec.Clock) && (emAt.Mode.Equals(mode))).SingleOrDefault();
                        if (empAtt == null)
                        {
                            empAtt = new EmployeeAttendance
                            {
                                Employee = empl,
                                Mode = mode,
                                DateAndTime = rec.Clock,
                                CreatedBy = 1,
                                CreatedDate = DateTime.Now,
                                ModifiedBy = 1,
                                ModifiedDate = DateTime.Now,
                            };

                            db.EmployeeAttendances.InsertOnSubmit(empAtt);
                            db.SubmitChanges();
                        }
                    }
                }
                Utilities.ShowInformationBox("Successfully saved attendance details.");
            }
            catch (Exception ex)
            {
                Utilities.ShowExceptionBox(ex.Message);
            }
        }
    }
}
