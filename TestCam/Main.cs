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
        internal static Timer MijnTimer = new Timer();
        SettingsForm settingsForm = new SettingsForm();
        List<leerling> LijstLeerlingen = new List<leerling>();

        //preload resource images
        Image SettingsDark = Image.FromFile(@"..\..\Icons\SettingsBold_Dark.png");
        Image SettingsLight = Image.FromFile(@"..\..\Icons\SettingsBold.png");
        Image PowerOn = Image.FromFile(@"..\..\Icons\PowerBtnRotated.png");
        Image PowerOff = Image.FromFile(@"..\..\Icons\PowerBtn.png");

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
                leerling TestLeerling = MakeLeerling(Reader.Decode((Bitmap)pictureBox2.Image).ToString());
                //lblResult.Text = Reader.Decode((Bitmap)pictureBox2.Image).ToString();
                bool newLeeling = true;
                for (int i = 0; i < LijstLeerlingen.Count; i++)
                {
                    if (LijstLeerlingen[i].GetID() == TestLeerling.GetID())
                    {
                        newLeeling = false;
                    }
                }
                if (newLeeling)
                {
                    LijstLeerlingen.Add(TestLeerling);
                    DataGridLeerlingen.Rows.Clear();
                    for (int i = 0; i < LijstLeerlingen.Count; i++)
                    {
                        DataGridLeerlingen.Rows.Add(LijstLeerlingen[i].Naam, LijstLeerlingen[i].Voornaam, LijstLeerlingen[i].Klas, LijstLeerlingen[i].GetID());
                    }

                    //lbLeerlingen.Items.Add(lblResult.Text);
                    //DataGridLeerlingen.Rows.Add(lblResult.Text, lblResult.Text, lblResult.Text);

                }
                lblResult.Text = Reader.Decode((Bitmap)pictureBox2.Image).ToString();

            }
            catch (Exception)
            {
                lblResult.Text = "Geen QRcode";
            }
        }

        private void MijnDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbox.Image = (Bitmap)eventArgs.Frame.Clone();   
        }


        private void btnTake_Click(object sender, EventArgs e)
        {
            //pictureBox2.Image = (Bitmap)pbox.Image.Clone();
            //lblComment.Text = Reader.Decode((Bitmap)pbox.Image.Clone()).ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
            settingsForm.lbCameras.Items.Clear();
            MijnFilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo DeFilterInfo in MijnFilterInfoCollection)
            {
                settingsForm.lbCameras.Items.Add(DeFilterInfo.Name);
                //settingsForm.cboxInputs.Items.Add(DeFilterInfo.Name);
                MijnDevice = new VideoCaptureDevice();
            }

            try
            {
                settingsForm.lbCameras.SelectedIndex = 0;
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

        private void Appolon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MijnDevice.IsRunning)
            {
                MijnDevice.Stop();
            }
        }

        int Switch = 0;

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (Appolon.MijnDevice != null)
            {
                if (Switch % 2 == 0)
                {

                    //MijnDevice = new VideoCaptureDevice(MijnFilterInfoCollection[cboxInputs.SelectedIndex].MonikerString);
                    MijnDevice.NewFrame += MijnDevice_NewFrame;
                    MijnDevice.Start();
                    MijnTimer.Tick += MijnTimer_Tick;
                    MijnTimer.Start();
                    btnPower.Image = PowerOn;
                }
                else
                {
                    btnPower.Image = PowerOff;
                    MijnDevice.Stop();
                    MijnTimer.Stop();
                }
                Switch++;
            }
            
        }

        static public leerling MakeLeerling(string strInput)
        {   // Format: Naam;Voornaam;Klas

            char[] charInput = strInput.ToCharArray();
            string strNaam = "";
            string strVoornaam = "";
            string strKlas = "";
            bool KlasStarted = false;
            bool VoornaamStarted = false;

            for (int i = 0; i < charInput.Length; i++)
            {
                if (!KlasStarted)
                {
                    if (!VoornaamStarted)
                    {
                        if (charInput[i] != ';')
                        {
                            strNaam += charInput[i];
                        }
                        else
                        {
                            VoornaamStarted = true;
                        }
                    }
                    else
                    {
                        if (charInput[i] != ';')
                        {
                            strVoornaam += charInput[i];
                        }
                        else
                        {
                            KlasStarted = true;
                        }
                    }
                }
                else
                {
                    strKlas += charInput[i];
                }
            }

            return new leerling(strVoornaam,strNaam, strKlas);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}