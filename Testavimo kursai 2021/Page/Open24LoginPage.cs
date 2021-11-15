using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testavimo_kursai_2021.Page
{
    public class Open24LoginPage : BasePage
    {
        public const string PageAddress = "https://www.open24.lt/lt/mano-duomenys/mano-uzsakymai/";
        public Open24LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            Driver.Url = PageAddress;
        }
        private IWebElement UserEmail => Driver.FindElement(By.Id("login_email"));
        private IWebElement UserPassword => Driver.FindElement(By.Id("login_password"));
        private IWebElement LogInButton => Driver.FindElement(By.CssSelector("#login_form > button"));
        private IWebElement LogInResult => Driver.FindElement(By.CssSelector("#content_layout_plain > div.tab_navs > ul > li.active > a"));

        internal void InsertBothsInput(string firstInput, string secondInput)
        {
            throw new NotImplementedException();
        }

        internal void ClickLogInButton()
        {
            throw new NotImplementedException();
        }

        internal void CheckLogInResult(string result)
        {
            throw new NotImplementedException();
        }
    }
}
