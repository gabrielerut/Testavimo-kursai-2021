using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testavimo_kursai_2021
{
    class ND2_DevelopersBrowser
    {
        [Test]
        public static void TestChromeDriver()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent"; 
            chrome.Quit();
        }
        [Test]
        public static void TestFirefoxDriver()
        {
            IWebDriver firefox = new FirefoxDriver();
            firefox.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent/"; 
            firefox.Quit();
        }
    }
}
