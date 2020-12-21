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
        FilterInfoCollection MijnFilterInfoCollection;
        VideoCaptureDevice MijnDevice;
        BarcodeReader Reader = new BarcodeReader();
        Timer MijnTimer = new Timer();
        SettingsForm settingsForm = new SettingsForm();

        public SettingsForm()
        {
            InitializeComponent();
            MijnFilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo DeFilterInfo in MijnFilterInfoCollection)
            {
                cboxInputs.Items.Add(DeFilterInfo.Name);
                MijnDevice = new VideoCaptureDevice();
            }
            try
            {
                cboxInputs.SelectedIndex = 0;
            }
            catch (Exception)
            {
                lblComment.Text = "Geen Webcam";
            }
        }

        private void btnCloseSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
