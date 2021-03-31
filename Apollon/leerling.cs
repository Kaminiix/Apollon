using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollon
{
    class leerling
    {
        private string strVoornaam;
        private string strNaam;
        private string strKlas;
        private string strReden;
        private DateTime varTelaatkomst;
        private string strTelaatkomst;

        public leerling()
        {
            strVoornaam = "onbekend";
            strNaam = "onbekend";
            strKlas = "onbekend";
            varTelaatkomst = DateTime.Now;
        }

        /// <summary>
        /// Make Leerling
        /// </summary>
        /// <param name="strVoornaamInput"></param>
        /// <param name="strNaamInput"></param>
        /// <param name="strKlasInput"></param>
        public leerling(string strVoornaamInput, string strNaamInput, string strKlasInput)
        {
            strVoornaam = strVoornaamInput;
            strNaam = strNaamInput;
            strKlas = strKlasInput;
            strReden = "Te laat";
            varTelaatkomst = DateTime.Now;
            strTelaatkomst = varTelaatkomst.ToString("HH:mm");
        }
        public string Naam
        {
            get { return strNaam; }
            set { strNaam = value; }
        }

        public string Voornaam
        {
            get { return strVoornaam; }
            set { strVoornaam = value; }
        }
        public string Klas
        {
            get { return strKlas; }
            set { strKlas = value; }
        }
        public string Reden
        {
            get { return strReden; }
            set { strReden = value; }
        }
        public string TelaatkomstString
        {
            get { return strTelaatkomst; }
            set { strTelaatkomst = value; }
        }

        public DateTime Telaatkomst
        {
            get { return varTelaatkomst; }
            set { varTelaatkomst = value; }
        }

        public string GetID()
        {
            return strNaam.Substring(0, 3) + strVoornaam.Substring(0, 3) + strKlas.Substring(0, 1);
        }
        public string GetInfos()
        {
            return strNaam + " " + strVoornaam + " " + strKlas;
        }
    }
}

