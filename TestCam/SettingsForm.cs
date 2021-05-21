using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;

namespace Main
{
    public partial class SettingsForm : Form
    {

        public SettingsForm()
        {
            InitializeComponent();
        }

        //Disable X button
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get{
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void btnCloseSettings_Click(object sender, EventArgs e)
        {
            if (Apollon.MijnDevice != null)
            {
                Apollon.MijnDevice = new VideoCaptureDevice(
                    Apollon.MijnFilterInfoCollection[lbCameras.SelectedIndex].MonikerString);
                Apollon.MijnTimer.Interval = Convert.ToInt32(txtbRefreshRate.Value);
            }

            Apollon.AutosaveEnabled = cbAutosave.Checked;
            Apollon.DevmodeEnabled = cBoxDev.Checked;
            
            this.Hide();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void cbAutosave_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutosave.Checked)
            {
                if (Apollon.SavePath == "")
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        Apollon.SavePath = folderBrowser.SelectedPath;
                    }
                }
            }
        }

        private void txtbPath_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                Apollon.SavePath = folderBrowser.SelectedPath;
                txtbPath.Text = Apollon.SavePath;
        }
    }
}
