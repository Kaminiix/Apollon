﻿using System;
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
using System.IO;
using Newtonsoft.Json;


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
        internal static bool AutosaveEnabled = false;

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
                bool newLeeling = true;
                foreach (leerling DeLeerling in LijstLeerlingen)
                {
                    if (DeLeerling.GetID() == TestLeerling.GetID())
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

                    //AUTO SAVE
                    if (AutosaveEnabled)
                    {
                        string Data = JsonConvert.SerializeObject(LijstLeerlingen, Formatting.Indented);
                        File.WriteAllText(@"..\..\AutosaveData.json", Data);
                    }


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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
            settingsForm.lbCameras.Items.Clear();
            MijnFilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo DeFilterInfo in MijnFilterInfoCollection)
            {
                settingsForm.lbCameras.Items.Add(DeFilterInfo.Name);
                MijnDevice = new VideoCaptureDevice();
            }

            try
            {
                settingsForm.lbCameras.SelectedIndex = 0;
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

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (Appolon.MijnDevice != null)
            {
                if (!MijnDevice.IsRunning)
                {

                    //MijnDevice = new VideoCaptureDevice(MijnFilterInfoCollection[cboxInputs.SelectedIndex].MonikerString);
                    MijnDevice.NewFrame += MijnDevice_NewFrame;
                    MijnDevice.Start();
                    MijnTimer.Tick += MijnTimer_Tick;
                    MijnTimer.Start();
                    btnPower.Image = PowerOn;
                    //DataGridLeerlingen.Visible = true;
                }
                else
                {
                    btnPower.Image = PowerOff;
                    MijnDevice.Stop();
                    MijnTimer.Stop();
                }
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

            foreach (char Letter in charInput)
            {
                if (!KlasStarted)
                {
                    if (!VoornaamStarted)
                    {
                        if (Letter != ';')
                        {
                            strNaam += Letter;
                        }
                        else
                        {
                            VoornaamStarted = true;
                        }
                    }
                    else
                    {
                        if (Letter != ';')
                        {
                            strVoornaam += Letter;
                        }
                        else
                        {
                            KlasStarted = true;
                        }
                    }
                }
                else
                {
                    strKlas += Letter;
                }
            }
            return new leerling(strVoornaam,strNaam, strKlas);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Data = JsonConvert.SerializeObject(LijstLeerlingen, Formatting.Indented);
            File.WriteAllText(@"..\..\Data.json", Data);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"..\..\AutosaveData.json"))
            {
                string LoadingData = File.ReadAllText(@"..\..\AutosaveData.json");
                LijstLeerlingen = JsonConvert.DeserializeObject<List<leerling>>(LoadingData);
                DataGridLeerlingen.Rows.Clear();
                foreach (leerling EenLeerling in LijstLeerlingen)
                {
                    DataGridLeerlingen.Rows.Add(EenLeerling.Naam, EenLeerling.Voornaam,
                        EenLeerling.Klas, EenLeerling.GetID());
                }
            }
            else
            {
                lblResult.Text = "Autosave does not exist";
            }
        }
    }
}