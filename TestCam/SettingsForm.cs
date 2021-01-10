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

namespace TestCam
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
            if (Appolon.MijnDevice != null)
            {
                //Appolon.MijnDevice = new AForge.Video.DirectShow.VideoCaptureDevice(Appolon.MijnFilterInfoCollection[cboxInputs.SelectedIndex].MonikerString);
                Appolon.MijnDevice = new VideoCaptureDevice(Appolon.MijnFilterInfoCollection[lbCameras.SelectedIndex].MonikerString);
                Appolon.MijnTimer.Interval = Convert.ToInt32(txtbRefreshRate.Value);
            }
            if (cbAutosave.Checked)
            {
                Appolon.AutosaveEnabled = true;
            }
            else
            {
                Appolon.AutosaveEnabled = false;
            }
            if (cBoxDev.Checked)
            {
                Appolon.DevmodeEnabled = true;
            }
            else
            {
                Appolon.DevmodeEnabled = false;
            }
            this.Hide();
   

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void cbAutosave_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutosave.Checked)
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    Appolon.SavePath = folderBrowser.SelectedPath;
                }
            }
        }
    }
}
