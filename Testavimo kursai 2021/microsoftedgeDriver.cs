using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Testavimo_kursai_2021
{
    internal class microsoftedgeDriver : IWebDriver
    {
        public string Url { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public string Title => throw new System.NotImplementedException();

        public string PageSource => throw new System.NotImplementedException();

        public string CurrentWindowHandle => throw new System.NotImplementedException();

        public ReadOnlyCollection<string> WindowHandles => throw new System.NotImplementedException();

        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public IWebElement FindElement(By by)
        {
            throw new System.NotImplementedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new System.NotImplementedException();
        }

        public IOptions Manage()
        {
            throw new System.NotImplementedException();
        }

        public INavigation Navigate()
        {
            throw new System.NotImplementedException();
        }

        public void Quit()
        {
            throw new System.NotImplementedException();
        }

        public ITargetLocator SwitchTo()
        {
            throw new System.NotImplementedException();
        }
    }
}