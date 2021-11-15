using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testavimo_kursai_2021.Page;

namespace Testavimo_kursai_2021.Test
{
    public class DropDownSeleniumTest
    {
        private static DropDownSeleniumPage _page;
        

        [OneTimeSetUp]
        public static void SetUp()
        {
            Iwebdriver driver = new CromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            _page = new DropDownSeleniumPage(driver);
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }
        [Test]
        public void TestDropDow()
        {
            _page.SelectFromDropdpwnByValue("Friday")
                .VerifyResult("Friday");
        }
        [Test]
        public void TestMultipleDropDown()
        {
            _page.SelectFromMultiDropDownValue("Ohio", "Florida")
                .ClickFirstSelectedButton();
                
        }
    }

}
