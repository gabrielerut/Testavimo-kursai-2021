using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testavimo_kursai_2021
{
    class TestWebDriver
    {
        /*[Test]
        public static void TestChromeDriver()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "http://login.yahoo.com/"; // atidaro nurodyta narsykle
            //chrome.Quit(); uzdaro narsykle
        }
        //[Test]
        //public static void TestFirefoxDriver()
        //    //IWebDriver microsoftedge = new microsoftedgeDriver();
            //microsoftedge.Url = "http://login.yahoo.com/"; // atidaro nurodyta narsykle
            //microsoftedge.Quit();
       // }
        [Test]
        public static void TestYahooPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "http://login.yahoo.com/"; // atidaro nurodyta narsykle
            IWebElement loginInputField = chrome.FindElement(By.Id("login-username"));
            loginInputField.SendKeys("Test");
            //chrome.Quit(); uzdaro narsykle
        }
        [Test]
        public static void TestSeleniumPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = ""; // atidaro nurodyta narsykle, irasyti nuoroda
            IWebElement inputField = chrome.FindElement(By.Id("")); // irasyti id
            string myText = "Labas";
            inputField.SendKeys(myText);
            Thread.Sleep(5000);
            IWebElement popUp = chrome.FindElement(By.Id("at-cv-lightbox-close)"));
            popUp.Click();
            IWebElement button = chrome.FindElement(By.CssSelector("#get-unput > button"));
            button.Click();
            IWebElement result = chrome.FindElement(By.Id("display"));
            Assert.AreEqual(myText, result.Text, "Tekstas neatsirado");
            //chrome.Quit(); uzdaro narsykle
        }*/



    }
}
