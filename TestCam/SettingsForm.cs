using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCam
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnCloseSettings_Click(object sender, EventArgs e)
        {
            if (Appolon.MijnDevice != null)
            {
                //Appolon.MijnDevice = new AForge.Video.DirectShow.VideoCaptureDevice(Appolon.MijnFilterInfoCollection[cboxInputs.SelectedIndex].MonikerString);
                Appolon.MijnDevice = new AForge.Video.DirectShow.VideoCaptureDevice(Appolon.MijnFilterInfoCollection[lbCameras.SelectedIndex].MonikerString);
                Appolon.MijnTimer.Interval = Convert.ToInt32(txtbRefreshRate.Value);
            }
                  
            this.Hide();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
