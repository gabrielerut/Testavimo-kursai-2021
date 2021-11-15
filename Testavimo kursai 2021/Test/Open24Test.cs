using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testavimo_kursai_2021.Page;

namespace Testavimo_kursai_2021.Test
{
    class Open24Test
    {
        private static Open24LoginPage _page;


        [OneTimeSetUp]
        public static void SetUp()
        {
            Iwebdriver driver = new CromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            _page = new Open24LoginPage(driver);
        }
        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }
        [TestCase("gabbriele89@hotmail.com", "Testavimokodas", "Mano duomenys", TestName = "LogIn successfull")]
        public void TestValidLogIn(string firstInput, string secondInput, string result)
        {
            Open24LoginPage page = new Open24LoginPage(driver);
            page.InsertBothsInput(firstInput, secondInput);
            page.ClickLogInButton();
            page.CheckLogInResult(result);
        }
    }
}
