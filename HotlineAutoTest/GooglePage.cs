using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotlineAutoTest.pages
{
    public class GooglePage:PageObject
    {
        IWebDriver driver = new FirefoxDriver();

        [FindsBy(How = How.CssSelector, Using = "#lst-ib")]
        private IWebElement searchField;

        public GooglePage(IWebDriver driver):base(driver)
        {
            Url = "https://www.google.com.ua/";
        }

        public override void ToUrl(string _url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void SendRequest(string _text)
        {
            searchField.SendKeys(_text);
        }

    }
}
