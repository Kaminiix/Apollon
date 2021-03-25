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
using System.IO;
using Newtonsoft.Json;
using System.Net;


namespace TestCam
{
    public partial class Apollon : Form
    {
        public static FilterInfoCollection MijnFilterInfoCollection;
        public static VideoCaptureDevice MijnDevice;
        BarcodeReader Reader = new BarcodeReader();
        internal static Timer MijnTimer = new Timer();
        SettingsForm settingsForm = new SettingsForm();
        List<leerling> LijstLeerlingen = new List<leerling>();
        List<string> LijstReden = new List<string>();
        internal static bool AutosaveEnabled = false;
        internal static bool DevmodeEnabled = false;
        internal static bool IsStarted = false;
        internal static string SavePath = "";
        string RedenPath = "";


        //preload resource images
        Image SettingsDark = Image.FromFile(@"..\..\Icons\SettingsBold_Dark.png");
        Image SettingsLight = Image.FromFile(@"..\..\Icons\SettingsBold.png");
        Image PowerOn = Image.FromFile(@"..\..\Icons\PowerBtnRotated.png");
        Image PowerOff = Image.FromFile(@"..\..\Icons\PowerBtn.png");
        Image SaveLight = Image.FromFile(@"..\..\Icons\Save.png");
        Image SaveDark = Image.FromFile(@"..\..\Icons\SaveDarker.png");
        Image LoadLight = Image.FromFile(@"..\..\Icons\Load.png");
        Image LoadDark = Image.FromFile(@"..\..\Icons\LoadDarker.png");
        Image PowerBtnLight = Image.FromFile(@"..\..\Icons\PowerBtn.png");
        Image PowerBtnDark = Image.FromFile(@"..\..\Icons\PowerBtnDarker.png");
        Image PowerBtnRotatedLight = Image.FromFile(@"..\..\Icons\PowerBtnRotated.png");
        Image PowerBtnRotatedDark = Image.FromFile(@"..\..\Icons\PowerBtnRotatedDarker.png");


        private void Appolon_Load(object sender, EventArgs e)
        {

        }
        public Apollon()
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

            DataGridViewComboBoxColumn MijnComboBoxColumn = new DataGridViewComboBoxColumn();
            MijnComboBoxColumn.HeaderText = "Reden";
            MijnComboBoxColumn.DataSource = SavePath;
            DataGridLeerlingen.Columns.Add(MijnComboBoxColumn);
            lblError.Text = "Column made";
        }

        private void MijnTimer_Tick(object sender, EventArgs e)
        {
            //Devmode
            lblComment.Visible = DevmodeEnabled;
            lblResult.Visible = DevmodeEnabled;

            /*
            if (lblComment.Text == "Tick")
            {
                lblComment.Text = "Tack";
            }
            else
            {
                lblComment.Text = "Tick";
            }
            */

            //Make a copy of the frame on the picturebox on the right
            pictureBox2.Image = pbox.Image;

            //Try to read the qr code through the frame
            try
            {
                leerling TestLeerling = MakeLeerling(Reader.Decode((Bitmap)pictureBox2.Image).ToString());
                TestLeerling.Reden = "Te laat";
                bool newLeeling = true;
                foreach (leerling DeLeerling in LijstLeerlingen)
                {   // Check through all existing Leerlingen if the ID already exist which in theory should be unique
                    if (DeLeerling.GetID() == TestLeerling.GetID())
                        newLeeling = false;
                }
                if (newLeeling) // If the leerling is not yet in list
                {
                    LijstLeerlingen.Add(TestLeerling);
                    DataGridLeerlingen.Rows.Clear();
                    foreach (leerling EenLeerling in LijstLeerlingen)
                    {
                        DataGridLeerlingen.Rows.Add(EenLeerling.Naam, EenLeerling.Voornaam, EenLeerling.Klas,
                            EenLeerling.Reden, EenLeerling.Telaatkomst.ToString("HH:mm"), EenLeerling.GetID());
                    }

                    //AUTO SAVE
                    if (AutosaveEnabled)
                    { // Write data to json file
                        File.WriteAllText(SavePath + @"/AutosaveData.json",
                            JsonConvert.SerializeObject(LijstLeerlingen, Formatting.Indented));
                    }
                }

                lblResult.Text = Reader.Decode((Bitmap)pictureBox2.Image).ToString();
            }
            catch (Exception) //No QR code found within the frame
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
            { // Adds each cameras detected into the list in the settingsform
                settingsForm.lbCameras.Items.Add(DeFilterInfo.Name);
                MijnDevice = new VideoCaptureDevice();
            }

            try //Tries to select forhand the first webcam on the list
            {
                settingsForm.lbCameras.SelectedIndex = 0;
            }
            catch (Exception)
            {
                lblComment.Text = "Geen Webcam";
            }
        }
      

        private void Appolon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsStarted)
            {   // FIX for the system that still was using the webcam when the program was closed
                MijnDevice.Stop();
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            

            if (File.Exists(SavePath + @"\reden.txt"))
            {
                lbReden.Items.Clear();
                foreach (string eenReden in ImportReden(SavePath + @"/reden.txt"))
                {
                    lbReden.Items.Add(eenReden);
                    LijstReden.Add(eenReden);
                }
                lblError.Text = "Reden imported";
            }
            else if (LijstReden.Count == 0)
            {   //No reden.txt found open FolderDialog to find directory to 
                if (MessageBox.Show("Do you have a reden.txt to import?", "No reden.txt found", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MijnFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //SavePath = MijnBrowserDialog.SelectedPath;

                        foreach (string eenReden in ImportReden(MijnFileDialog.FileName))
                        {
                            lbReden.Items.Add(eenReden);
                            LijstReden.Add(eenReden);
                        }
                        lblError.Text = "Reden imported";
                    }
                }
                /*    DOWNLOAD reden.txt FROM THE INTERNET NOT WORKING YET !!
                else
                {
                    if (MessageBox.Show("Do you want to download the default one from the internet?",
                        "No reden.txt", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Please select the folder where you want to download the file") == DialogResult.OK)
                        {
                            if (MijnBrowserDialog.ShowDialog() == DialogResult.OK)
                            {
                                try
                                { //Download reden.txt from Github
                                    WebClient MijnWebClient = new WebClient();
                                    MijnWebClient.DownloadFile("https://cdn.discordapp.com/attachments/493374771812106260/821859873443807232/Reden.txt",
                                        MijnBrowserDialog.SelectedPath);
                                    // https://bit.ly/3bWfz8j MSDN
                                    SavePath = MijnBrowserDialog.SelectedPath;
                                    foreach (string Reden in ImportReden(SavePath + @"/reden.txt"))
                                    {
                                        lbReden.Items.Add(Reden);
                                    }
                                    lblError.Text = "Reden imported";
                                }
                                catch (Exception)
                                {
                                    throw;
                                }
                            }

                        }

                    }
                }
                */
            }


            if (Apollon.MijnDevice != null)
            {
                if (!MijnDevice.IsRunning)
                {
                    IsStarted = true;
                    MijnDevice.NewFrame += MijnDevice_NewFrame;
                    MijnDevice.Start();
                    MijnTimer.Tick += MijnTimer_Tick;
                    MijnTimer.Start();
                    btnPower.Image = PowerOn;
                }
                else
                {
                    IsStarted = false;
                    btnPower.Image = PowerOff;
                    MijnDevice.Stop();
                    MijnTimer.Stop();
                }
            }
            else
            {
                MessageBox.Show("Configuration not made yet");
                MijnFilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo EenFilterInfo in MijnFilterInfoCollection)
                { //Auto selects a capture device if one is starting with usb
                    // if 3 first letters are USB
                    if (EenFilterInfo.Name.Substring(0,3) == "USB")
                    {
                        MijnDevice = new VideoCaptureDevice(EenFilterInfo.MonikerString);
                    }
                }
            }
        }

        static public leerling MakeLeerling(string strInput)
        {   // Format: Naam;Voornaam;Klas
            char[] charInput = strInput.ToCharArray();
            string strNaam = "", strVoornaam = "", strKlas = "";
            bool KlasStarted = false, VoornaamStarted = false;

            foreach (char Letter in charInput)
            {
                if (!KlasStarted)
                    if (!VoornaamStarted)
                        if (Letter != ';')
                            strNaam += Letter;
                        else
                            VoornaamStarted = true;
                    else
                        if (Letter != ';')
                            strVoornaam += Letter;
                        else
                            KlasStarted = true;
                else
                    strKlas += Letter;
            }
            return new leerling(strVoornaam,strNaam, strKlas);
        }

        static public List<string> ImportReden(string strInputPath)
        {
            List<string> ListReden = new List<string>();
            char[] Chars = File.ReadAllText(strInputPath).ToCharArray();
            string strWord = "";
            foreach (char Letter in Chars)
            {
                if (Letter != ',')
                {
                    strWord += Letter;
                }
                else
                {
                    ListReden.Add(strWord);
                    strWord = "";
                }
            }

            return ListReden;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SavePath != "")
            {
                string Data = JsonConvert.SerializeObject(LijstLeerlingen, Formatting.Indented);
                File.WriteAllText(SavePath + @"/Data.json", Data);
                lblError.Text = "Data exported to " + SavePath + @"\Data.json";
                lblComment.Text = LijstLeerlingen[2].Reden;
            }
            else
            {
                lblComment.Text = "No such path selected";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            if (MijnFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblError.Text = "";
                string LoadingData = File.ReadAllText(MijnFileDialog.FileName);
                LijstLeerlingen = JsonConvert.DeserializeObject<List<leerling>>(LoadingData);
                DataGridLeerlingen.Rows.Clear();
                StripProgressBar.Maximum = LijstLeerlingen.Count;
                foreach (leerling EenLeerling in LijstLeerlingen)
                {
                    StripProgressBar.PerformStep();
                    DataGridLeerlingen.Rows.Add(EenLeerling.Naam, EenLeerling.Voornaam, EenLeerling.Klas,
                        EenLeerling.Reden, EenLeerling.Telaatkomst.ToString("HH:mm"), EenLeerling.GetID());
                }
            }

        /* OLD WAY bad because looking for autosavedata.json
            if (File.Exists(SavePath + @"/AutosaveData.json"))
            {
                lblError.Text = "";
                string LoadingData = File.ReadAllText(SavePath + @"/AutosaveData.json");
                LijstLeerlingen = JsonConvert.DeserializeObject<List<leerling>>(LoadingData);
                DataGridLeerlingen.Rows.Clear();
                StripProgressBar.Maximum = LijstLeerlingen.Count;
                foreach (leerling EenLeerling in LijstLeerlingen)
                {
                    StripProgressBar.PerformStep();
                    DataGridLeerlingen.Rows.Add(EenLeerling.Naam, EenLeerling.Voornaam,
                        EenLeerling.Klas, EenLeerling.Reden, EenLeerling.GetID());
                }
            }
            else
            {
                lblError.Text = "Autosave does not exist";
            }
        */

        }

        // Animations
        Color ColorDark = Color.FromArgb(50, 51, 69);
        Color ColorDarker = Color.FromArgb(57, 58, 78);

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.Image = SaveDark;
            pnlSave.BackColor = ColorDark;
        }
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.Image = SaveLight;
            pnlSave.BackColor = ColorDarker;
        }
        private void btnLoad_MouseEnter(object sender, EventArgs e)
        {
            btnLoad.Image = LoadDark;
            pnlLoad.BackColor = ColorDark;
        }
        private void btnLoad_MouseLeave(object sender, EventArgs e)
        {
            btnLoad.Image = LoadLight;
            pnlLoad.BackColor = ColorDarker;
        }
        private void btnPower_MouseEnter(object sender, EventArgs e)
        {
            pnlPower.BackColor = ColorDark;
            if (IsStarted)
                btnPower.Image = PowerBtnRotatedDark;
            else
                btnPower.Image = PowerBtnDark;
        }
        private void btnPower_MouseLeave(object sender, EventArgs e)
        {
            pnlPower.BackColor = ColorDarker;
            if (IsStarted)
                btnPower.Image = PowerBtnRotatedLight;
            else
                btnPower.Image = PowerBtnLight;
        }
        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.Image = SettingsDark;
            pnlSettings.BackColor = ColorDark;
        }
        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.Image = SettingsLight;
            pnlSettings.BackColor = ColorDarker;
        }
        private void lbReden_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LijstLeerlingen[DataGridLeerlingen.SelectedRows].Reden = lbReden.Items[Convert.ToInt32(DataGridLeerlingen.SelectedRows)].ToString();
            foreach (DataGridViewRow Row in DataGridLeerlingen.SelectedRows)
            {
                if (LijstLeerlingen.Count != 0) //disable modifing reden if there arent leerlingen yet
                {
                    //LijstLeerlingen[Row.Index].Reden = lbReden.SelectedItem.ToString();
                    LijstLeerlingen[Row.Index].Reden = LijstReden[lbReden.SelectedIndex];
                }
            }

            DataGridLeerlingen.Rows.Clear();
            foreach (leerling EenLeerling in LijstLeerlingen)
            {
                DataGridLeerlingen.Rows.Add(EenLeerling.Naam, EenLeerling.Voornaam, EenLeerling.Klas,
                    EenLeerling.Reden, EenLeerling.Telaatkomst.ToString("HH:mm"), EenLeerling.GetID());
            }
            lblError.Text = "Reden Changed";
        }
    }
}