using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testavimo_kursai_2021.Page
{
    public class BasePage
    {
        public static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
