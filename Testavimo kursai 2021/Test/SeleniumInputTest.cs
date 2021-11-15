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
    public class SeleniumInputTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            wait.Until(d => popUp.Displayed);
            popUp.Click();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }

        [Test]

        public void TestSeleniumInputFirstBlock()
        {
            SeleniumInputPage page = new SeleniumInputPage(_driver);
            string myText = "Labas";

            page.InsertText(myText);
            page.ClickShowMessageButton();
            page.CheckResult(myText);
        }

        [TestCase("2", "2", "4", TestName = "2 plius 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 plius 3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a plius b = NaN")]
        public void TestSeleniumInputSecondBlock(string firstInput, string secondInput, string result)
        {
            SeleniumInputPage page = new SeleniumInputPage(_driver);
            page.InsertBothsInput(firstInput, secondInput);
            page.ClickGetTotalButton();
            page.CheckSumResult(result);
        }

    }
}

