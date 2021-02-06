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
using System.IO;
using Newtonsoft.Json;


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
        internal static bool AutosaveEnabled = false;
        internal static bool DevmodeEnabled = false;
        internal static bool IsStarted = false;
        internal static string SavePath = "";


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
            if (DevmodeEnabled)
            {
                lblComment.Visible = true;
                lblResult.Visible = true;
            }
            else
            {
                lblComment.Visible = false;
                lblResult.Visible = false;
            }

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
                TestLeerling.Reden = "Te laat";
                bool newLeeling = true;
                foreach (leerling DeLeerling in LijstLeerlingen)
                {
                    if (DeLeerling.GetID() == TestLeerling.GetID())
                        newLeeling = false;
                }
                if (newLeeling)
                {
                    LijstLeerlingen.Add(TestLeerling);
                    DataGridLeerlingen.Rows.Clear();
                    foreach (leerling EenLeerling in LijstLeerlingen)
                    {
                        DataGridLeerlingen.Rows.Add(EenLeerling.Naam, EenLeerling.Voornaam, EenLeerling.Klas, EenLeerling.Reden, EenLeerling.GetID());
                    }

                    //AUTO SAVE
                    if (AutosaveEnabled)
                    {
                        string Data = JsonConvert.SerializeObject(LijstLeerlingen, Formatting.Indented);
                        File.WriteAllText(SavePath + @"/AutosaveData.json", Data);
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
                MijnDevice.Stop();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            lbReden.Items.Clear();
            foreach (string Reden in ImportReden(@"C:\Users\Asiimov\Documents\Reden.txt"))
            {
                lbReden.Items.Add(Reden);
            }
            lblError.Text = "Column made";

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
                MijnFilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo EenFilterInfo in MijnFilterInfoCollection)
                {
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
            List<string> Reden = new List<string>();
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
                    Reden.Add(strWord);
                    strWord = "";
                }
            }

            return Reden;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SavePath != "")
            {
                string Data = JsonConvert.SerializeObject(LijstLeerlingen, Formatting.Indented);
                File.WriteAllText( SavePath + @"/Data.json", Data);
            }
            else
            {
                lblComment.Text = "Geen path enable auto save to chose a path";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

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
        }

        // Animations
        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.Image = SaveDark;
        }
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.Image = SaveLight;
        }
        private void btnLoad_MouseEnter(object sender, EventArgs e)
        {
            btnLoad.Image = LoadDark;
        }
        private void btnLoad_MouseLeave(object sender, EventArgs e)
        {
            btnLoad.Image = LoadLight;
        }
        private void btnPower_MouseEnter(object sender, EventArgs e)
        {
            if (IsStarted)
                btnPower.Image = PowerBtnRotatedDark;
            else
                btnPower.Image = PowerBtnDark;
        }
        private void btnPower_MouseLeave(object sender, EventArgs e)
        {
            if (IsStarted)
                btnPower.Image = PowerBtnRotatedLight;
            else
                btnPower.Image = PowerBtnLight;
        }

        private void lbReden_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LijstLeerlingen[DataGridLeerlingen.SelectedRows].Reden = lbReden.Items[Convert.ToInt32(DataGridLeerlingen.SelectedRows)].ToString();
            foreach (DataGridViewRow Row in DataGridLeerlingen.SelectedRows)
            {
                LijstLeerlingen[Row.Index].Reden = lbReden.SelectedItem.ToString();
            }

            DataGridLeerlingen.Rows.Clear();
            foreach (leerling EenLeerling in LijstLeerlingen)
            {
                DataGridLeerlingen.Rows.Add(EenLeerling.Naam, EenLeerling.Voornaam, EenLeerling.Klas, EenLeerling.Reden, EenLeerling.GetID());
            }
            lblError.Text = "Reden Changed";

        }
    }
}