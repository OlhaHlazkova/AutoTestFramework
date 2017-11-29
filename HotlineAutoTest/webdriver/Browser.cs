using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.webdriver
{
    public class Browser
    {
        private static Browser _currentInstance;
        private static IWebDriver _driver;
        public static BrowserFactory.BrowserType CurrentBrowser;
        public static int implwait;
        public static double TimeOutForElement;
        private static string _browser;

        private Browser()
        {
            InitParams();
            _driver = BrowserFactory.GetDriver(CurrentBrowser, implwait);
        }

        private static void InitParams()
        {
            implwait = Convert.ToInt32(Configuration.ElementTimeOut);
            TimeOutForElement = Convert.ToDouble(Configuration.ElementTimeOut);
            _browser = Configuration.Browser;
            Enum.TryParse(_browser, out CurrentBrowser);
        }

        public static Browser Instance => _currentInstance ?? (_currentInstance = new Browser());

        public static void WindowMaximize()
        {
            _driver.Manage().Window.Maximize();
        }

        public static void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public static IWebElement GetElement(BaseElement element)
        {
            return _driver.FindElement(element.Locator);
        }

        public static IWebDriver GetDriver()
        {
            return _driver;
        }

        public static void Quite()
        {
            _driver.Quit();
            _currentInstance = null;
            _driver = null;
            _browser = null;

        }
    }
}
