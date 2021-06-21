using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.QrCode.Internal;
using ZXing.QrCode;
using System.Drawing.Imaging;
using ZXing.Rendering;
using System.Drawing;
using System.IO;
using OfficeOpenXml;
using System.Windows.Forms;


namespace QRGen
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ZXing.BarcodeWriter Wr = new ZXing.BarcodeWriter();
            var encOpties = new ZXing.Common.EncodingOptions()
            {
                Width = 500,
                Height = 500,
                Margin = 0,
                PureBarcode = false
            };


            List<leerling> Lijstleerlingen = new List<leerling>();
            OpenFileDialog OFD = new OpenFileDialog();
            Console.WriteLine("Please select the .xlsx file");
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                //byte[] file = File.ReadAllBytes(@"C:\Users\yassine.hattach\Desktop\leerlingen.xlsx");
                byte[] file = File.ReadAllBytes(OFD.FileName);
                using (MemoryStream s = new MemoryStream(file))
                {
                    using (ExcelPackage ex = new ExcelPackage(s))
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                        foreach (ExcelWorksheet w in ex.Workbook.Worksheets)
                        {
                            for (int i = w.Dimension.Start.Row; i < w.Dimension.End.Row; i++)
                            {
                                //Console.WriteLine(w.Cells[i,3].Value.ToString());

                                Lijstleerlingen.Add(new leerling(w.Cells[i, 2].Value.ToString()
                                    , w.Cells[i, 1].Value.ToString()
                                    , w.Cells[i, 3].Value.ToString()));

                            }
                        }
                    }
                }
            }
            Console.Clear();

            //QR CODE OPTIONS
            encOpties.Hints.Add(ZXing.EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            Wr.Renderer = new BitmapRenderer();
            Wr.Options = encOpties;
            Wr.Format = ZXing.BarcodeFormat.QR_CODE;

            Console.WriteLine("Please select the DBGB logo");
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                var logo = new Bitmap(OFD.FileName);
                FolderBrowserDialog FBD = new FolderBrowserDialog();
                Console.Clear();
                Console.WriteLine("Please select a folder where the pngs will be exported to");
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    Console.Clear();
                    foreach (leerling l in Lijstleerlingen)
                    {

                        string txt = l.Naam + ";" + l.Voornaam + ";" + l.Klas;
                        var img = Wr.Write(txt);

                        Graphics G = Graphics.FromImage(img);
                        G.DrawImage(logo, new PointF(150, 150));
                        Console.WriteLine("afbeelding (" + l.Naam + " " + l.Voornaam + ".png) gemaakt");
                        
                        img.Save(FBD.SelectedPath+ "/" + l.Klas + " " + l.Naam + " " + l.Voornaam + ".png", ImageFormat.Png);
                    } 
                }
            }
            
            /*
            FileInfo Fi = new FileInfo(@"../../leerlingen.xlsx");
            ExcelPackage P = new ExcelPackage(Fi);
            ExcelWorksheet W = P.Workbook.Worksheets.FirstOrDefault();
            for (int i = 1; i < W.Dimension.Rows; i++)
            {

                Console.WriteLine(W.Cells[i,2].Value.ToString());

                /*
                Lijstleerlingen.Add(new leerling(W.Cells[i,0].Value.ToString() 
                    ,W.Cells[i,1].Value.ToString()
                    ,W.Cells[i,2].Value.ToString())); 
            }

            
            foreach (leerling l in Lijstleerlingen)
            {
                Console.WriteLine();
                Console.WriteLine("##########################################");
                Console.WriteLine("         Toegevoegd aan lijst");
                Console.WriteLine("Naam: " + l.Naam);
                Console.WriteLine("Voornaam: " + l.Voornaam);
                Console.WriteLine("Klas: " + l.Klas);
            }
            */



            Console.ReadLine();           

        }
    }
}
