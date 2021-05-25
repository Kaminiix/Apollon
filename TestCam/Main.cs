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
using System.IO;
using Newtonsoft.Json;
using System.Net;
using Apollon;

namespace Main
{
    public partial class Apollon : Form
    {
        public static FilterInfoCollection MijnFilterInfoCollection;
        public static VideoCaptureDevice MijnDevice;
        BarcodeReader Reader = new BarcodeReader();
        internal static Timer MijnTimer = new Timer();
        SettingsForm settingsForm = new SettingsForm();
        SmartschoolForm smartschoolForm = new SmartschoolForm();
        List<leerling> LijstLeerlingen = new List<leerling>();
        List<string> LijstReden = new List<string>();
        internal static bool AutosaveEnabled = false;
        internal static bool DevmodeEnabled = false;
        internal static bool IsStarted = false;
        internal static bool IsReden = false;
        internal static string SavePath = "";
        internal static string strRedenPath = "";
        bool blUnsavedWork = false;

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
        Image UserAdd = Image.FromFile(@"..\..\Icons\UserAdd.png");
        Image UserAddDarker = Image.FromFile(@"..\..\Icons\UserAddDarker.png");
        Image Add = Image.FromFile(@"..\..\Icons\Add.png");
        Image AddHover = Image.FromFile(@"..\..\Icons\AddHover.png");
        Image Smartschool = Image.FromFile(@"..\..\Icons\SmartschoolBtn.png");
        Image SmartschoolColor = Image.FromFile(@"..\..\Icons\SmartschoolBtnColor.png");
        Image SaveModificationRed = Image.FromFile(@"..\..\Icons\SaveModificationRed.png");
        Image SaveModificationGreen = Image.FromFile(@"..\..\Icons\SaveModificationGreen.png");
        Image Undo = Image.FromFile(@"..\..\Icons\Undo.png");
        Image UndoDark = Image.FromFile(@"..\..\Icons\UndoDark.png");
        Image Remove = Image.FromFile(@"..\..\Icons\Remove.png");
        Image RemoveHover = Image.FromFile(@"..\..\Icons\RemoveHover.png");

        private void Appolon_Load(object sender, EventArgs e)
        {

        }
        public Apollon()
        {
            InitializeComponent();
        }

        private void MijnTimer_Tick(object sender, EventArgs e)
        {
            //Devmode
            lblComment.Visible = DevmodeEnabled;
            lblResult.Visible = DevmodeEnabled;
            //Make a copy of the frame on the picturebox on the right
            Image TickFrame = pbox.Image;
            //pictureBox2.Image = pbox.Image;

            //Try to read the qr code through the frame
            try
            {
                leerling TestLeerling = MakeLeerling(Reader.Decode((Bitmap)TickFrame).ToString());
                TestLeerling.Reden = "Te laat";
                bool newLeeling = true;
                foreach (leerling DeLeerling in LijstLeerlingen)
                {   // Check through all existing Leerlingen if the ID
                    // already exist which in theory should be unique
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

                lblResult.Text = Reader.Decode((Bitmap)TickFrame).ToString();
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
                strRedenPath = SavePath + @"\reden.txt";
                lbReden.Items.Clear();
                foreach (string eenReden in ImportReden(strRedenPath))
                {
                    lbReden.Items.Add(eenReden);
                    LijstReden.Add(eenReden);
                }
                lblError.Text = "Reden imported";
            }
            else if (LijstReden.Count == 0)
            {   //No reden.txt found open FolderDialog to find directory to 
                if (MessageBox.Show("Do you have a reden.txt to import?", "No reden.txt found",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MijnFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (MijnFileDialog.FileName.Contains("Reden.txt") == true)
                        {
                            strRedenPath = MijnFileDialog.FileName;
                            //SavePath = MijnBrowserDialog.SelectedPath;

                            foreach (string eenReden in ImportReden(strRedenPath))
                            {
                                lbReden.Items.Add(eenReden);
                                LijstReden.Add(eenReden);
                            }
                            IsReden = true;
                            lblError.Text = "Reden imported";
                        }
                        else
                        {
                            MessageBox.Show("Selecteer een Reden.txt file.");
                        }
                    }
                }
            }

            if (IsReden==true)
            {

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
                        btnAddLln.Visible = true;
                        btnRedenRemove.Visible = true;
                        lbReden.Visible = true;
                        pbox.Location = new Point(134, 14);
                    }
                    else
                    {
                        IsStarted = false;
                        btnPower.Image = PowerOff;
                        MijnDevice.Stop();
                        MijnTimer.Stop();
                        btnAddLln.Visible = false;
                        btnRedenRemove.Visible = false;
                        lbReden.Visible = false;
                        pbox.Location = new Point(214, 12);

                    }
                }
                else
                {
                    MessageBox.Show("Configuration not made yet");
                    MijnFilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    foreach (FilterInfo EenFilterInfo in MijnFilterInfoCollection)
                    { //Auto selects a capture device if one is starting with usb
                      // if 3 first letters are USB
                        if (EenFilterInfo.Name.Substring(0, 3) == "USB")
                        {
                            MijnDevice = new VideoCaptureDevice(EenFilterInfo.MonikerString);
                        }
                    }
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
            return new leerling(strVoornaam, strNaam, strKlas);
        }

        static public List<string> ImportReden(string strInputPath)
        {
            List<string> ListReden = new List<string>();
            char[] Chars = File.ReadAllText(strInputPath).ToCharArray();
            string strWord = "";
            foreach (char Letter in Chars)
            {
                if (Letter != ';')
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


        private void btnSettings_Click(object sender, EventArgs e)
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
                if (MijnBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string Data = JsonConvert.SerializeObject(LijstLeerlingen, Formatting.Indented);
                    File.WriteAllText(MijnBrowserDialog.SelectedPath + @"/Data.json", Data);
                    lblError.Text = "Data exported to " + MijnBrowserDialog.SelectedPath + @"\Data.json";
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (MijnFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (MijnFileDialog.FileName.Contains("Data.json") == true) {
                    lblError.Text = "";
                    string LoadingData = File.ReadAllText(MijnFileDialog.FileName);
                    LijstLeerlingen = JsonConvert.DeserializeObject<List<leerling>>(LoadingData);
                    /*
                    LijstLeerlingen.Clear();
                    foreach (leerling l in JsonConvert.DeserializeObject<List<leerling>>(LoadingData))
                    {
                        LijstLeerlingen.Add(new leerling(l.Voornaam,l.Naam,l.Klas,l.Telaatkomst));
                    }
                    */
                    UpdateDataGrid();
                }
                else
                {
                    MessageBox.Show("Selecteer een Data.json file.");
                }
            }
        }
        private void lbReden_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LijstLeerlingen[DataGridLeerlingen.SelectedRows].Reden = lbReden.Items[Convert.ToInt32(DataGridLeerlingen.SelectedRows)].ToString();
            if (lbReden.SelectedIndex > -1)
            {

                if (LijstReden[lbReden.SelectedIndex] == "Andere")
                {
                    txtbReden.Visible = true;
                    btnReden.Visible = true;
                    btnRedenAdd.Visible = true;
                    lbReden.Size = new Size(115, 134);
                }
                else
                {
                    txtbReden.Visible = false;
                    btnReden.Visible = false;
                    btnRedenAdd.Visible = false;
                    lbReden.Size = new Size(115, 238);

                }

                foreach (DataGridViewRow Row in DataGridLeerlingen.SelectedRows)
                {
                    if (LijstLeerlingen.Count != 0) //disable modifing reden if there arent leerlingen yet
                    {
                        //LijstLeerlingen[Row.Index].Reden = lbReden.SelectedItem.ToString();
                        if (LijstReden[lbReden.SelectedIndex] == "Andere")
                        {
                        }
                        else
                        {
                            LijstLeerlingen[Row.Index].Reden = LijstReden[lbReden.SelectedIndex];
                        }
                    }
                }

                UpdateDataGrid();
                lblError.Text = "Reden Changed";
            }
        }
        private void btnMakeLln_Click(object sender, EventArgs e)
        {
            if (txtbNaamInput.Text == "")
            {
                lblError.Text = "Naam Input empty";
            }
            else if (txtbVoornaamInput.Text == "")
            {
                lblError.Text = "Voornaam Input empty";
            }
            else if (txtbKlasInput.Text == "")
            {
                lblError.Text = "Klas Input empty";
            }
            else
            {
                lblError.Text = "";

                txtbNaamInput.Text = txtbNaamInput.Text.Substring(0, 1).ToUpper() + txtbNaamInput.Text.Substring(1);
                txtbVoornaamInput.Text = txtbVoornaamInput.Text.Substring(0, 1).ToUpper() + txtbVoornaamInput.Text.Substring(1);


                if (MessageBox.Show("Wil je (" + txtbNaamInput.Text + " " + txtbVoornaamInput.Text + " " + txtbKlasInput.Text + ") toevoegen?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    leerling Testleerling = new leerling(txtbVoornaamInput.Text, txtbNaamInput.Text, txtbKlasInput.Text);
                    bool newLeerling = true;
                    //Check if leerling is already in list
                    foreach (leerling DeLeerling in LijstLeerlingen)
                    {   // Check through all existing Leerlingen if the ID already exist which in theory should be unique
                        if (DeLeerling.GetID() == Testleerling.GetID())
                            newLeerling = false;
                    }
                    if (newLeerling)
                    {
                        LijstLeerlingen.Add(new leerling(txtbVoornaamInput.Text, txtbNaamInput.Text, txtbKlasInput.Text));
                        //AUTO SAVE
                        if (AutosaveEnabled)
                        { // Write data to json file
                            File.WriteAllText(SavePath + @"/AutosaveData.json",
                                JsonConvert.SerializeObject(LijstLeerlingen, Formatting.Indented));
                        }
                        UpdateDataGrid();
                        txtbKlasInput.Clear();
                        txtbNaamInput.Clear();
                        txtbVoornaamInput.Clear();
                    }
                }
            }
        }

        public void UpdateDataGrid()
        {
            DataGridLeerlingen.Rows.Clear();
            StripProgressBar.Maximum = LijstLeerlingen.Count;
            foreach (leerling EenLeerling in LijstLeerlingen)
            {
                StripProgressBar.Maximum = LijstLeerlingen.Count;
                DataGridLeerlingen.Rows.Add(EenLeerling.Naam, EenLeerling.Voornaam, EenLeerling.Klas,
                    EenLeerling.Reden, EenLeerling.Telaatkomst.ToString("HH:mm"), EenLeerling.GetID());
            }
        }

      /*  
        Animations
        Color ColorDark = Color.FromArgb(50, 51, 69);
        Color ColorDarker = Color.FromArgb(57, 58, 78);
      */
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
        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.Image = SettingsDark;
        }
        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.Image = SettingsLight;
        }
        private void btnAddLln_MouseEnter(object sender, EventArgs e)
        {
            btnAddLln.Image = UserAddDarker;
        }
        private void btnAddLln_MouseLeave(object sender, EventArgs e)
        {
            btnAddLln.Image = UserAdd;
        }
        private void btnMakeLln_MouseEnter(object sender, EventArgs e)
        {
            btnMakeLln.Image = AddHover;
        }
        private void btnMakeLln_MouseLeave(object sender, EventArgs e)
        {
            btnMakeLln.Image = Add;
        }
        private void btnSmartschool_MouseEnter(object sender, EventArgs e)
        {
            btnSmartschool.Image = SmartschoolColor;
        }
        private void btnSmartschool_MouseLeave(object sender, EventArgs e)
        {
            btnSmartschool.Image = Smartschool;

        }
        private void DataGridLlnState_MouseEnter(object sender, EventArgs e)
        {
            DataGridLlnState.Image = SaveModificationGreen;
        }
        private void DataGridLlnState_MouseLeave(object sender, EventArgs e)
        {
            DataGridLlnState.Image = SaveModificationRed;
        }
        private void btnUndo_MouseLeave(object sender, EventArgs e)
        {
            btnUndo.Image = Undo;
        }
        private void btnUndo_MouseEnter(object sender, EventArgs e)
        {
            btnUndo.Image = UndoDark;
        }
        private void btnRedenAdd_MouseEnter(object sender, EventArgs e)
        {
            btnRedenAdd.Image = AddHover;
        }
        private void btnRedenAdd_MouseLeave(object sender, EventArgs e)
        {
            btnRedenAdd.Image = Add;
        }
        private void btnRedenRemove_MouseEnter(object sender, EventArgs e)
        {
            btnRedenRemove.Image = RemoveHover;
        }
        private void btnRedenRemove_MouseLeave(object sender, EventArgs e)
        {
            btnRedenRemove.Image = Remove;
        }
        //    /\
        //   /  \
        //    ||    <= HOVER ANIMATIONS
        //    ||

        private void btnAddLln_Click(object sender, EventArgs e)
        {
            if (btnMakeLln.Visible)
            {
                btnMakeLln.Visible = false;
                txtbKlasInput.Visible = false;
                txtbNaamInput.Visible = false;
                txtbVoornaamInput.Visible = false;
                lblUserAddPlaceHolder.Visible = false;
            }
            else
            {
                btnMakeLln.Visible = true;
                txtbKlasInput.Visible = true;
                txtbNaamInput.Visible = true;
                txtbVoornaamInput.Visible = true;
                lblUserAddPlaceHolder.Visible = true;
            }
        }


        private void btnSmartschool_Click(object sender, EventArgs e)
        {
            smartschoolForm = new SmartschoolForm();
            smartschoolForm.Lijstleerlingen = LijstLeerlingen;
            smartschoolForm.Show();
            smartschoolForm.UpdateGrid(LijstLeerlingen);
        }

        private void DataGridLeerlingen_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            blUnsavedWork = true;
            lblSave.Visible = true;
            DataGridLlnState.Visible = true;
            btnUndo.Visible = true;
            lblUndo.Visible = true;
            DataGridLlnState.Image = SaveModificationRed;
        }

        private void DataGridLlnState_Click(object sender, EventArgs e)
        {
            if (blUnsavedWork)
            {

                for (int i = 0; i < DataGridLeerlingen.Rows.Count; i++)
                {
                    LijstLeerlingen[i].Voornaam = DataGridLeerlingen.Rows[i].Cells[1].Value.ToString();
                    LijstLeerlingen[i].Naam = DataGridLeerlingen.Rows[i].Cells[0].Value.ToString();
                    LijstLeerlingen[i].Klas = DataGridLeerlingen.Rows[i].Cells[2].Value.ToString();
                    LijstLeerlingen[i].Reden = DataGridLeerlingen.Rows[i].Cells[3].Value.ToString();
                }

                /* Bad way because making a new leerling would reset the DateTime var
                LijstLeerlingen.Clear();
                for (int i = 0; i < DataGridLeerlingen.Rows.Count; i++)
                {   //make a new leerling from each row in datagridleerlingen
                    LijstLeerlingen.Add(new leerling(DataGridLeerlingen.Rows[i].Cells[1].Value.ToString(),
                        DataGridLeerlingen.Rows[i].Cells[0].Value.ToString(),
                        DataGridLeerlingen.Rows[i].Cells[2].Value.ToString()));
                    LijstLeerlingen[i].Reden = DataGridLeerlingen.Rows[i].Cells[3].Value.ToString();
                }
                */

                //AUTO SAVE
                if (AutosaveEnabled)
                { // Write data to json file
                    File.WriteAllText(SavePath + @"/AutosaveData.json",
                        JsonConvert.SerializeObject(LijstLeerlingen, Formatting.Indented));
                }

                blUnsavedWork = false;
                btnUndo.Visible = false;
                lblUndo.Visible = false;
                DataGridLlnState.Visible = false;
                lblSave.Visible = false;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
            blUnsavedWork = false;
            btnUndo.Visible = false;
            lblUndo.Visible = false;
        }

        private void btnReden_Click(object sender, EventArgs e)
        {
            //LijstLeerlingen[DataGridLeerlingen.SelectedRows].Reden = lbReden.Items[Convert.ToInt32(DataGridLeerlingen.SelectedRows)].ToString();
            foreach (DataGridViewRow Row in DataGridLeerlingen.SelectedRows)
            {
                if (LijstLeerlingen.Count != 0) //disable modifing reden if there arent leerlingen yet
                {
                    LijstLeerlingen[Row.Index].Reden = txtbReden.Text;
                }
            }

            txtbReden.Clear();
            UpdateDataGrid();
            lblError.Text = "Reden Changed";
        }

        private void btnRedenAdd_Click(object sender, EventArgs e)
        {
            if (txtbReden.Text !="")
            {
                File.WriteAllText(strRedenPath, File.ReadAllText(strRedenPath) + txtbReden.Text + ';');
                lbReden.Items.Clear();
                LijstReden.Add(txtbReden.Text);
                foreach (string eenReden in ImportReden(strRedenPath))
                {
                    lbReden.Items.Add(eenReden);
                    LijstReden.Add(eenReden);
                }
                lblError.Text = "Reden added";
            }
        }
        private void btnRedenRemove_Click(object sender, EventArgs e)
        {
            if (lbReden.SelectedIndex>0)
            {
                string strReden = "";
                List<string> ListReden = new List<string>();
                char[] Chars = File.ReadAllText(strRedenPath).ToCharArray();
                string strWord = "";
                foreach (char Letter in Chars)
                {
                    if (Letter != ';')
                    {
                        strWord += Letter;
                    }
                    else
                    {
                        if (strWord != LijstReden[lbReden.SelectedIndex])
                        {
                            ListReden.Add(strWord);
                            strReden += strWord + ";";
                        }
                        lblError.Text = strReden;
                        strWord = "";
                    }
                }
                lbReden.Items.Clear();
                foreach (string eenReden in ListReden)
                {
                    lbReden.Items.Add(eenReden);
                    LijstReden.Add(eenReden);
                }
                File.WriteAllText(strRedenPath, strReden);
            }
        }
    }
}