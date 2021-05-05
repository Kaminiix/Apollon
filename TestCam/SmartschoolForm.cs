using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace Apollon
{
    public partial class SmartschoolForm : Form
    {
        public SmartschoolForm()
        {
            InitializeComponent();
        }

        public List<leerling> Lijstleerlingen = new List<leerling>();

        public void SendData()
        {
            Lijstleerlingen = Lijstleerlingen.OrderBy(leerling => leerling.Klas).ToList<leerling>();
            UpdateGrid(Lijstleerlingen);

            FirefoxDriver Browser = new FirefoxDriver();

            Browser.Navigate().GoToUrl("https://donboscogb.smartschool.be/login");


            //w.Until(driver => ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='js-btn-home topnav__btn topnav__btn--push-right']")));
            // WAIT FOR THE USER TO CONNECT TO SMARTSCHOOL (1MINUTE)
            WebDriverWait wait = new WebDriverWait(Browser, new TimeSpan(0, 2, 0));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("smscTopContainer")));

            Browser.Navigate().GoToUrl("https://donboscogb.smartschool.be/Presence");
            string TELAAT = " //body/div[contains(@class,'smscWindow no-gradient')]/div[contains(@class,'ui-dialog ui-corner-all ui-widget ui-widget-content ui-front ui-draggable')]/div[@id='smscDialogWindowPresenceCodeSelect']/div[contains(@class,'pv_codeselect_main')]/div[@id='codeSelector']/div[@id='code497']/div[1]";

            /*

            System.Threading.Thread.Sleep(3000);
            Browser.FindElement(By.XPath("//div[@id='smscSelect_classes']")).Click();
            Browser.FindElement(By.XPath("//input[contains(@type,'text')]")).SendKeys(Klas);
            System.Threading.Thread.Sleep(600);
            Browser.FindElement(By.XPath("//input[contains(@type,'text')]")).SendKeys(Keys.ArrowDown);
            Browser.FindElement(By.XPath("//input[contains(@type,'text')]")).SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(3000);
            Browser.FindElement(By.XPath("//div[@id='smscSelect_classes']")).Click();
            Browser.FindElement(By.XPath("//input[contains(@type,'text')]")).SendKeys(Klas);
            System.Threading.Thread.Sleep(600);
            Browser.FindElement(By.XPath("//input[contains(@type,'text')]")).SendKeys(Keys.ArrowDown);
            Browser.FindElement(By.XPath("//input[contains(@type,'text')]")).SendKeys(Keys.Enter);
             * */
            string lastKlas = "";

            
            foreach (leerling lln in Lijstleerlingen)
            {
                try
                {
                    if (lastKlas != lln.Klas)
                    {
                        System.Threading.Thread.Sleep(3000);
                        Browser.FindElement(By.XPath("//div[@id='smscSelect_classes']")).Click();
                        Browser.FindElement(By.XPath("//input[contains(@type,'text')]")).SendKeys(lln.Klas);
                        System.Threading.Thread.Sleep(600);
                        Browser.FindElement(By.XPath("//input[contains(@type,'text')]")).SendKeys("{DOWN}");
                        Browser.FindElement(By.XPath("//input[contains(@type,'text')]")).SendKeys("{ENTER}");

                        System.Threading.Thread.Sleep(3000);
                        Browser.FindElement(By.XPath("//div[@id='smscSelect_classes']")).Click();
                        Browser.FindElement(By.XPath("//input[contains(@type,'text')]")).SendKeys(lln.Klas);
                        System.Threading.Thread.Sleep(600);
                        Browser.FindElement(By.XPath("//input[contains(@type,'text')]")).SendKeys("{DOWN}");
                        Browser.FindElement(By.XPath("//input[contains(@type,'text')]")).SendKeys("{ENTER}");

                    }
                    System.Threading.Thread.Sleep(3000);

                    if (Browser.FindElement(By.XPath("//div[contains(text(),'" + lln.Voornaam + " " + lln.Naam + "')]")).Displayed)
                    {
                        lln.Sent = true;
                        Browser.FindElement(By.XPath("//div[contains(text(),'" + lln.Voornaam + " " + lln.Naam + "')]")).Click();
                        System.Threading.Thread.Sleep(500);
                        Browser.FindElement(By.XPath(TELAAT)).Click();
                        System.Threading.Thread.Sleep(500);
                        Browser.FindElement(By.Id("codeselect_motivation")).SendKeys(lln.Reden);
                    }
                }
                catch (Exception)
                {
                    lln.Sent = false;
                    throw;
                }
                UpdateGrid(Lijstleerlingen);
                lastKlas = lln.Klas;
            }
        }

        public void UpdateGrid(List<leerling> LijstInput)
        {
            DataGridLeerlingen.Rows.Clear();
            foreach (leerling l in LijstInput)
            {
                DataGridLeerlingen.Rows.Add(l.Sent, l.Naam, l.Voornaam, l.Klas, l.Reden, l.Telaatkomst.ToString("HH:mm"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendData();
        }
    }
}
