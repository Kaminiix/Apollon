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
            Appolon.MijnDevice = new AForge.Video.DirectShow.VideoCaptureDevice(Appolon.MijnFilterInfoCollection[cboxInputs.SelectedIndex].MonikerString);
            this.Close();
        }
    }
}
