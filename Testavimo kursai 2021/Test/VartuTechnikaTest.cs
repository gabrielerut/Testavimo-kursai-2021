using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testavimo_kursai_2021.Page;

namespace Testavimo_kursai_2021.Test
{
    public class VartuTechnikaTest
    {
        private static VartuTechnikaPage _page;

        [OneTimeSetUp]
        public static void SetUp()
        {
            IWebDriver driver = new ChromeDriver();
            // _driver.Url = "http://vartutechnika.lt/";
            driver.Navigate().GoToUrl("http://vartutechnika.lt/");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("cookiescript_reject")).Click();
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            // _driver.Quit();
        }

        [TestCase("2000", "2000", true, false, "665.98€", TestName = "2000 x 2000 + Vartų automatika = 665.98€")]
        [TestCase("4000", "2000", true, true, "1006.43€", TestName = "4000 + 2000 + Vartu automatika + Vartu montavimo darbai = 1006.43€")]
        [TestCase("4000", "2000", false, false, "692.35€", TestName = "4000 + 2000 = 692.35€")]
        [TestCase("5000", "2000", false, true, "989.21€", TestName = "5000 + 2000 + Vartu montavimo darbai = 989.21€")]
        public void TestVartuTechnika(string width, string height, bool automatika, bool montavimoDarbai, string result)
        {
            VartuTechnikaPage page = new VartuTechnikaPage(Driver);
            page.InsertWidthAndHeight(width, height)
            .CheckAutomatikCheckbox(automatika)
            .CheckMontavimoDarbaiCheckbox(montavimoDarbai)
            .ClickCalcuteButton()
            .CheckResult(result);
        }
    }
}
