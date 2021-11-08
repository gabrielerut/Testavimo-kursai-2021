using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testavimo_kursai_2021
{
    class VartuTechnika
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "http://vartutechnika.lt/";
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.Manage().Window.Maximize();
            _driver.FindElement(By.Id("cookiescript_close")).Click();
            
        }


        [OneTimeTearDown]
        public static void TearDown()
        {
            // _driver.Quit();
        }

        [TestCase("2000", "2000", true, false, "665.98€", TestName = "2000 + 2000 + Vartu automatika = 665.98€")]
        [TestCase("200", "200", false, true, "665.98€", TestName = "2000 + 2000 + Vartu automatika = 665.99€")]
        public static void TestVartuTechnikaPage(string width, string height, bool automatika, bool montavimas, string result)
        {
            IWebElement widthInput = _driver.FindElement(By.Id("doors_width"));
            widthInput.Clear();
            widthInput.SendKeys(width);
            IWebElement heightInput = _driver.FindElement(By.Id("doors_height"));
            heightInput.Clear();
            heightInput.SendKeys(height);
            IWebElement autoChekBox = _driver.FindElement(By.Id("automatika"));
                if (automatika != autoChekBox.Selected) //ar check boxas yra nepazymetas
                    autoChekBox.Click(); // jdei nepazy,etas tada clickinam
            IWebElement montavimoCheckBox = _driver.FindElement(By.Id("darbai"));
                if (montavimas != montavimoCheckBox.Selected)
                montavimoCheckBox.Click();
        }
    }
}
