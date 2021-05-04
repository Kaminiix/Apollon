using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Firefox;
using TestCam;

namespace Apollon
{
    public partial class SmartschoolForm : Form
    {
        public SmartschoolForm()
        {
            InitializeComponent();
        }

        List<leerling> Lijstleerlingen = new List<leerling>();
        


        public void SendData()
        {
            Lijstleerlingen = Lijstleerlingen.OrderBy(leerling => leerling.Klas).ToList<leerling>();



        }


        private void UpdateDataGrid()
        {
            DataGridLeerlingen.Rows.Clear();
            foreach (leerling l in Lijstleerlingen)
            {
                //DataGridLeerlingen.Rows.Add(l.)
            }



            /*
             DataGridLeerlingen.Rows.Clear();
            StripProgressBar.Maximum = LijstLeerlingen.Count;
            foreach (leerling EenLeerling in LijstLeerlingen)
            {
                StripProgressBar.Maximum = LijstLeerlingen.Count;
                DataGridLeerlingen.Rows.Add(EenLeerling.Naam, EenLeerling.Voornaam, EenLeerling.Klas,
                    EenLeerling.Reden, EenLeerling.Telaatkomst.ToString("HH:mm"), EenLeerling.GetID());
            }
            */
        }

    }
}
