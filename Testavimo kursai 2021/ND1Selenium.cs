using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testavimo_kursai_2021
{
    class ND1Selenium
    {

        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); // naudojama beveik visuose testuose del stabilumo
            wait.Until(d => popUp.Displayed);
            popUp.Click();
        }


        [OneTimeTearDown]
        public static void TearDown()
        {
            // _driver.Quit();
        }

        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a + b = NaN")]
        public static void TestSeleniumPage1(string firstName, string secondName, string result)
        {
            //Thread.Sleep(5000);
            //IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            //popUp.Click();
            IWebElement inputField1 = _driver.FindElement(By.Id("sum1"));
            IWebElement inputField2 = _driver.FindElement(By.Id("sum2"));
            inputField1.Clear();
            inputField1.SendKeys(firstName);
            inputField2.Clear();
            inputField2.SendKeys(secondName);
            _driver.FindElement(By.CssSelector("#gettotal > button")).Click();
            IWebElement resultFromPage = _driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(result, resultFromPage.Text, "Rezultatas neatsirado");

        }
    }
}
       