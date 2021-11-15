using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testavimo_kursai_2021.Page
{
    public class SeleniumCheckBoxPage : BasePage
    {

        private const string PageAddress = "www.open24.lt";

        private IWebElement _oneCheckBox => Driver.FindElement(By.Id("isAgeSelected"));
        private IWebElement _text => Driver.FindElement(By.Id("txtAge"));
        private IWebElement _firstCheckbox => Driver.FindElement(By.Id("isAgeSelected"));
        private IReadOnlyCollection<IWebElement> _multipleCheckBoxList => _driver.FindElements(By.CssSelector(".cb1-element"));
        private IWebElement _button => Driver.FindElement(By.Id("check1"));

        public SeleniumCheckBoxPage(IWebDriver webDriver) : base(webDriver)
        {
            Driver.Url = PageAddress;
        }

        public SeleniumCheckBoxPage ClickOneCheckBox()
        {
            _oneCheckBox.Click();
            return this;
        }
        public SeleniumCheckBoxPage TestIfOneCheckBoxIsChecked(string expectedResult)
        {

            Assert.IsTrue(_text.Text.Equals(expectedResult), $"Result is not the same, expected { expectedResult}, but was { _text.Text}");
            return this;
        }
        public SeleniumCheckBoxPage ClickFirstCheckBox()
        {
            if (!_firstCheckbox.Selected)
                _firstCheckbox.Click();
            return this;
        }
        public SeleniumCheckBoxPage SelectAllCheckBoxes()
        {
            foreach (IWebElement element in _multipleCheckBoxList)
            {
                element.Click();
            }
            return this;
        }
        public SeleniumCheckBoxPage TestButtonValue(string expectedValue)
        {
            //GetWait().Until(ExpectedConditions.TextToBePresentElement(_Button, "Uncheck All");
            Assert.IsTrue(_button.GetProperty("value").Equals(expectedValue), $"The values are not the same");
            return this;
        }
        public SeleniumCheckBoxPage ClickButtonUncheckValue(string value)
        {
            if (_button.GetAttribute("value") == value)
            {
                _button.Click();
            }
            return this;
        }
        public SeleniumCheckBoxPage TestIfAllCheckBoxesAreUnchecked(string expectedValue)
        {
            int counter = 0;
            foreach (IWebElement element in _multipleCheckBoxList)
            {
                if (element.Selected)
                {
                    counter++;
                }
            }
            Assert.AreEqual(expectedValue, counter++, "Not all checkboxes are unchecked");
            return this;
        }

    }
}
