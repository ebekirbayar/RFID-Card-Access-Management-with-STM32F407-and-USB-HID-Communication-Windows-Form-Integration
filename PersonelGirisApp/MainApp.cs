using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using UsbLibrary;
using ZedGraph;
using System.IO;



namespace PersonelGiris
{
    public partial class MainApp : Form
    {
        byte[] ReceivingData = new byte[65];
        byte[] SendingData = new byte[65];

        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            firstConnection();
        }

        private void toolS_baglan_ButtonClick(object sender, EventArgs e)
        {
            secondConnection();
        }

        public void firstConnection()
        {
            this.devicePort.ProductId = Int32.Parse("7D0", System.Globalization.NumberStyles.HexNumber);
            this.devicePort.VendorId = Int32.Parse("3E9", System.Globalization.NumberStyles.HexNumber);
            devicePort.CheckDevicePresent();

            if (this.devicePort.SpecifiedDevice != null)
            {
                this.devicePort.SpecifiedDevice.SendData(SendingData);
            }
        }

        public void secondConnection()
        {
            this.devicePort.ProductId = Int32.Parse("7D0", System.Globalization.NumberStyles.HexNumber);
            this.devicePort.VendorId = Int32.Parse("3E9", System.Globalization.NumberStyles.HexNumber);
            devicePort.CheckDevicePresent();

            if (this.devicePort.SpecifiedDevice != null)
            {
                this.devicePort.SpecifiedDevice.SendData(SendingData);
            }
            else
            {
               // MessageBox.Show("Please Connect to the System", "Warning");
            }

        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            devicePort.RegisterHandle(Handle);
        }

        protected override void WndProc(ref Message m)
        {
            devicePort.ParseMessages(ref m);
            base.WndProc(ref m);
        }

        private void deviceConnection_OnSpecifiedDeviceArrived(object sender, EventArgs e)
        {
            toolStripStatusLabel1.ForeColor = Color.Green;
            toolStripStatusLabel1.Text = "Device Connection Established";
        }

        private void deviceConnection_OnSpecifiedDeviceRemoved(object sender, EventArgs e)
        {
            toolStripStatusLabel1.ForeColor = Color.Red;
            toolStripStatusLabel1.Text = "Device Connection Lost";
        }

        private void deviceConnection_OnDataRecieved(object sender, UsbLibrary.DataRecievedEventArgs args)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new DataRecievedEventHandler(deviceConnection_OnDataRecieved), new object[] { sender, args });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                ReceivingData = args.data;
                int soundData = ReceivingData[1] + ReceivingData[2] * 256;
                float soundLevel = soundData * 100f / 4095f;
                progressBarSES.Value = (int)soundLevel;
                labelSound.Text = $"{soundLevel:0}%";

                if (ReceivingData.Length > 3)
                {
                    
                    int dataValue = ReceivingData[4];

                    switch (dataValue)
                    {
                        case 0:
                            textBoxName.Clear();
                            textBoxSurname.Clear();
                            textBoxId.Clear();
                            buttonInfo.Text = "Personnel Expected";
                            buttonInfo.BackColor = Color.Yellow;
                            break;


                        case 1:
                            textBoxName.Text = "Bekir";
                            textBoxSurname.Text = "Bayar";
                            textBoxId.Text = "1123456789";
                            buttonInfo.Text = "Authorized Personnel";
                            buttonInfo.BackColor = Color.Green;
                            pictureBox.Image = Image.FromFile("Images\\bekirhan.jpg");
                            break;

                        case 2:
                            textBoxName.Text = "Mert";
                            textBoxSurname.Text = "Kaya";
                            textBoxId.Text = "1234554321";
                            buttonInfo.Text = "Authorized Personnel";
                            buttonInfo.BackColor = Color.Green;
                            pictureBox.Image = Image.FromFile("Images\\mert.jpg");
                            break;

                        case 3:
                            textBoxName.Text = "Jack";
                            textBoxSurname.Text = "Winston";
                            textBoxId.Text = "123456712";
                            buttonInfo.Text = "Authorized Personnel";
                            buttonInfo.BackColor = Color.Green;
                            pictureBox.Image = Image.FromFile("Images\\jack.jpg");
                            break;

                        default:
                            textBoxName.Clear();
                            textBoxSurname.Clear();
                            textBoxId.Clear();

                            buttonInfo.Text = "Unauthorized Personnel";
                            buttonInfo.BackColor = Color.Red;

                            MessageBox.Show("Unauthorized Personnel or Empty Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
            }
        }
        private void deviceConnection_OnDataSend(object sender, EventArgs e)
        {

        }

        private void deviceConnection_OnDeviceRemoved(object sender, EventArgs e)
        {
           // MessageBox.Show("Device Connection Lost", "Warning");
        }

        private void deviceConnection_OnDeviceArrived(object sender, EventArgs e)
        {
            firstConnection();
           // MessageBox.Show("Device Connection Established", "Warning");
        }


        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if (buttonLogin.Text == "Open Door")
            {
                buttonLogin.Text = "Close Door";
                buttonLogin.BackColor = Color.Red;
                SendingData[1] = 1;
            }
            else
            {
                buttonLogin.Text = "Open Door";
                buttonLogin.BackColor = Color.Green;
                SendingData[1] = 0;
            }

            if (this.devicePort.SpecifiedDevice != null)
            {
                this.devicePort.SpecifiedDevice.SendData(SendingData);
            }
            else
            {
                // MessageBox.Show("Please Connect to the System", "Warning");
            }
        }

        private void buttonAlarm_Click(object sender, EventArgs e)
        {
            if (buttonAlarm.Text == "Alarm")
            {
                buttonAlarm.Text = "Close";
                buttonAlarm.BackColor = Color.Yellow;
                SendingData[2] = 1;
            }
            else
            {
                buttonAlarm.Text = "Alarm";
                buttonAlarm.BackColor = Color.Red;
                SendingData[2] = 0;
            }



            if (this.devicePort.SpecifiedDevice != null)
            {
                this.devicePort.SpecifiedDevice.SendData(SendingData);
            }
            else
            {
              // MessageBox.Show("Please Connect to the System", "Warning");
            }
        }
    }
}
