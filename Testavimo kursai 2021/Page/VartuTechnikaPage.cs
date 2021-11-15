using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testavimo_kursai_2021.Page
{
    public class VartuTechnikaPage : BasePage
    {
        

        private IWebElement _widthInput => Driver.FindElement(By.Id("doors_width"));
        private IWebElement _heightInput => Driver.FindElement(By.Id("doors_height"));
        private IWebElement _autoCheckBox => Driver.FindElement(By.Id("automatika"));
        private IWebElement _montavimoCheckBox => Driver.FindElement(By.Id("darbai"));
        private IWebElement _calculateButton => Driver.FindElement(By.Id("calc_submit"));
        private IWebElement _resultBox => Driver.FindElement(By.CssSelector("#calc_result > div"));

        public VartuTechnikaPage(IWebDriver webdriver) : base(webdriver)
        { }
        public VartuTechnikaPage InsertWidth(string width)
        {
            _widthInput.Clear();
            _widthInput.SendKeys(width);
            return this;
        }
        public VartuTechnikaPage InsertHeight(string height)
        {
            _heightInput.Clear();
            _heightInput.SendKeys(height);
            return this;
        }

        public VartuTechnikaPage InsertWidthAndHeight(string width, string height)
        {
            InsertWidth(width);
            InsertHeight(height);
            return this;
        }

        internal object ClickCalculateButton()
        {
            throw new NotImplementedException();
        }

        public VartuTechnikaPage CheckAutomatikCheckbox(bool shouldBeChecked)
        {
            if (shouldBeChecked != _autoCheckBox.Selected)
                _autoCheckBox.Click();
            return this;
        }
        public VartuTechnikaPage CheckMontavimoDarbaiCheckbox(bool shouldBeChecked)
        {
            if (shouldBeChecked != _montavimoCheckBox.Selected)
                _montavimoCheckBox.Click();
            return this;
        }

        public VartuTechnikaPage ClickCalcuteButton()
        {
            _calculateButton.Click();
            return this;
        }

        private void WaitForResult()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => _resultBox.Displayed);
        }

        public VartuTechnikaPage CheckResult(string expectedResult)
        {
            WaitForResult();
            Assert.IsTrue(_resultBox.Text.Contains(expectedResult), $"Result is not the same, expected {expectedResult}, but was {_resultBox.Text}");
            return this;
        }
    }
}
