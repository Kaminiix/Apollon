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

namespace TestCam
{
    public partial class Form1 : Form
    {
        FilterInfoCollection MijnFilterInfoCollection;
        VideoCaptureDevice MijnDevice;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MijnDevice = new VideoCaptureDevice(MijnFilterInfoCollection[cboxInputs.SelectedIndex].MonikerString);
            MijnDevice.NewFrame += MijnDevice_NewFrame;
            MijnDevice.Start();
        }

        private void MijnDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            MijnFilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo DeFilterInfo in MijnFilterInfoCollection)
            {
                cboxInputs.Items.Add(DeFilterInfo.Name);
                MijnDevice = new VideoCaptureDevice();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (MijnDevice.IsRunning)
            {
                MijnDevice.Stop();
            }
        }
    }
}
