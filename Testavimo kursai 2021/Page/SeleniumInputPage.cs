using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testavimo_kursai_2021.Page
{
    public class SeleniumInputPage
    {
        private static IWebDriver _driver;

        private IWebElement _inputField => _driver.FindElement(By.Id("user-message"));
        private IWebElement _button => _driver.FindElement(By.CssSelector("#get-input > button"));
        private IWebElement _result => _driver.FindElement(By.Id("display"));
        private IWebElement _firstInput => _driver.FindElement(By.Id("sum1"));
        private IWebElement _secondInput => _driver.FindElement(By.Id("sum2"));
        private IWebElement _getTotalButton => _driver.FindElement(By.CssSelector("#gettotal > button"));
        private IWebElement _resultFromPage => _driver.FindElement(By.Id("displayvalue"));
        public SeleniumInputPage (IWebDriver webDriver)
        {
            _driver = webDriver; 
        }

        public void Insertext(string text)
        {
            _firstInput.Clear();
            _firstInput.SendKeys(text);

        }

        internal void InsertText(string myText)
        {
            throw new NotImplementedException();
        }

        public void ClickShowMessageButton()
        {
            _button.Click();

        }

        public void CheckResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, _result.Text, "Rezultatas neatsirado");
        }
        public void InsertFirstInput(string text)
        {
            _firstInput.Clear();
            _firstInput.SendKeys(text);
        }

        internal void InsertBothsInput(string firstInput, string secondInput)
        {
            throw new NotImplementedException();
        }

        public void InsertSecondInput(string text)
        {
            _secondInput.Clear();
            _secondInput.SendKeys(text);
        }
        public void InsertBothInputs(string first, string second)
        {
            InsertFirstInput(first);
            InsertSecondInput(second);
        }
        public void ClickGetTotalButton()
        {
            _getTotalButton.Click();

        }
        public void CheckSumResult(string expectedResultSum)
        {
            Assert.AreEqual(expectedResultSum, _resultFromPage.Text, "Result is NOK");
        }
    }
}
