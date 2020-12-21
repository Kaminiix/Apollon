using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;


namespace TestCam
{
    public partial class Appolon : Form
    {
        public static FilterInfoCollection MijnFilterInfoCollection;
        public static VideoCaptureDevice MijnDevice;
        BarcodeReader Reader = new BarcodeReader();
        Timer MijnTimer = new Timer();
        SettingsForm settingsForm = new SettingsForm();

        Image SettingsDark = Image.FromFile(@"..\..\Icons\SettingsBold_Dark.png");
        Image SettingsLight = Image.FromFile(@"..\..\Icons\SettingsBold.png");
        private void Appolon_Load(object sender, EventArgs e)
        {
        }
        public Appolon()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //MijnDevice = new VideoCaptureDevice(MijnFilterInfoCollection[cboxInputs.SelectedIndex].MonikerString);
            MijnDevice.NewFrame += MijnDevice_NewFrame;
            MijnDevice.Start();
            MijnTimer.Tick += MijnTimer_Tick;
            //interval du timer
            MijnTimer.Interval = 500;
            MijnTimer.Start();
        }

        private void MijnTimer_Tick(object sender, EventArgs e)
        {
            if (lblComment.Text == "Tick")
            {
                lblComment.Text = "Tack";
            }
            else
            {
                lblComment.Text = "Tick";
            }

            pictureBox2.Image = pbox.Image;

            try
            {
                lblResult.Text = Reader.Decode((Bitmap)pictureBox2.Image).ToString();
            }
            catch (Exception)
            {
                lblComment.Text = "Geen QRcode";
            }
        }

        private void MijnDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbox.Image = (Bitmap)eventArgs.Frame.Clone();
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (MijnDevice.IsRunning)
            {
                MijnDevice.Stop();
            }
            MijnTimer.Stop();
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image = (Bitmap)pbox.Image.Clone();
            //lblComment.Text = Reader.Decode((Bitmap)pbox.Image.Clone()).ToString();
        }

        /*
        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
            MijnFilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo DeFilterInfo in MijnFilterInfoCollection)
            {
                settingsForm.cboxInputs.Items.Add(DeFilterInfo.Name);
                MijnDevice = new VideoCaptureDevice();
            }

            try
            {
                settingsForm.cboxInputs.SelectedIndex = 0;
            }
            catch (Exception)
            {
                lblComment.Text = "Geen Webcam";
            }
        }
        */

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
            MijnFilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo DeFilterInfo in MijnFilterInfoCollection)
            {
                settingsForm.cboxInputs.Items.Add(DeFilterInfo.Name);
                MijnDevice = new VideoCaptureDevice();
            }

            try
            {
                settingsForm.cboxInputs.SelectedIndex = 0;
            }
            catch (Exception)
            {
                lblComment.Text = "Geen Webcam";
            }
        }

       

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.Image = SettingsLight;

        }

       

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.Image = SettingsDark;

        }
    }
}
