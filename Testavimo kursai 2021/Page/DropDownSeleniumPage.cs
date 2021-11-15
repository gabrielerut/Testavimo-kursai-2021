using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testavimo_kursai_2021.Page
{
    public class DropDownSeleniumPage : BasePage
    {
        private const string PageAddress = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
        private const string ResultText = "Day selected :- ";
        private IWebElement ResultTextElement => Driver.FindElement(By.CssSelector(".selected-value"));
        private IWebDriver FirstSelectedElement => Driver.FindElement(By.Id("printMe"));
        private SelectElement DropDown => new SelectElement(Driver.FindElement(By.Id("select - demo")));
        private SelectElement MultiDropDown => new SelectElement(Driver.FindElement(By.Id("multi-select")));
        public DropDownSeleniumPage(IWebDriver webDriver) : base(webDriver)
        {
            Driver.Url = PageAddress;
        }
        public DropDownSeleniumPage SelectFromDropdpwnByText(string text)
        {
            DropDown.SelectByText(text);
            return this;
        }

        internal object SelectFromMultiDropDownValue(string firstValue, string secondValue)
        {
            Actions action = new Actions(Driver);
            MultiDropDown.SelectByValue(firstValue);
            action.KeyDown(Keys.Control);
            MultiDropDown.SelectByValue(secondValue);
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            return this;
        }

        public DropDownSeleniumPage SelectFromDropdpwnByValue(string text)
        {
            DropDown.SelectByValue(text);
            return this;
        }
        public DropDownSeleniumPage VerifyResult(string selectedDay)
        {
            Assert.IsTrue(ResultTextElement.Text.Equals(ResultText + selectedDay), $"Result is wrong, not {selectedDay}");
            return this;
        }
        public DropDownSeleniumPage SelectFromMultiDropDownByValue(string value)
        {
            MultiDropDown.SelectByValue(value);
            return this;
        }
        public DropDownSeleniumPage SelectFromMultipleDropDownByValue(List<string> listOfStates)
        {
            MultiDropDown.DeselectAll();
            Actions action = new Actions(Driver);
            action.KeyDown(Keys.LeftControl);
            foreach (string state in listOfStates)
            {
                foreach (IWebElement option in MultiDropDown.Options)
                {
                    if (state.Equals(option.GetAttribute("value")))
                    {
                        action.Click(option);
                        break;
                    }
                }
            }
            action.KeyUp(Keys.LeftControl);
            action.Build().Perform();
            action.Click(FirstSelectedElement);
            action.Build().Perform();
            return this;
        }
    }
}
