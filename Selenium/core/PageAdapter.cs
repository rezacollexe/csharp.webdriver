using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.core.browsers;

namespace Selenium.core
{
    public sealed class PageAdapter<T> : IPage where T : IWebDriver
    {
        private readonly BrowserAdapter<T> _browser;
        private readonly T _driver;

        public PageAdapter(BrowserAdapter<T> browser)
        {
            _browser = browser;
            _driver = browser.Driver;
        }

        public string Title => _driver.Title;
        public string PageSource => _driver.PageSource;
        public string CurrentWindowHandle => _driver.CurrentWindowHandle;
        public ReadOnlyCollection<string> WindowHandles => _driver.WindowHandles;

        public void GoToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public IEnumerable<IWebElement> FindElements(By by)
        {
            return _driver.FindElements(by);
        }

        public void NavigateBack()
        {
            _driver.Navigate().Back();
        }

        public void Refresh()
        {
            _driver.Navigate().Refresh();
        }

        public void Close()
        {
            _driver.Close();
        }

        public void Quit()
        {
            _driver.Quit();
        }

      
        ReadOnlyCollection<IWebElement> ISearchContext.FindElements(By by)
        {

            var _timeoutInSeconds = Config.TimeOutWaiting;
            if (_timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(_timeoutInSeconds));
                return wait.Until(drv => drv.FindElements(by));
            }
            return _driver.FindElements(by);
            //return _driver.FindElements(by);
        }

        public IOptions Manage()
        {
            return _driver.Manage();
        }

        public INavigation Navigate()
        {
            return _driver.Navigate();
        }

        public ITargetLocator SwitchTo()
        {
            return _driver.SwitchTo();
        }

        public string Url { get; set; }

        public void Dispose()
        {
            _driver.SwitchTo();
        }

       

        public IWebElement FindElement(By by, int timeoutInSeconds=50)
        {
            var _timeoutInSeconds = timeoutInSeconds;
            if (_timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(_timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return _driver.FindElement(by);
        }

        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }
    }
}