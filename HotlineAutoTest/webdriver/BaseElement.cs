using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium.Support.UI;

namespace HotlineAutoTest.webdriver
{
    public class BaseElement : IWebElement
    {
        protected string Name;
        public By Locator;
        protected IWebElement Element;

        public BaseElement(By locator, string name)
        {
            this.Locator = locator;            
            this.Name = name == "" ? this.GetText() : name;            
        }

        public BaseElement(By locator)
        {
            this.Locator = locator;
        }

        public string GetText()
        {
            this.WaitForIsVisible();
            return this.Element.Text;
        }    

        public IWebElement GetElement()
        {
            try
            {
                this.Element = Browser.GetDriver().FindElement(this.Locator);
            }
            catch (Exception)
            {
                throw;
            }
            return this.Element;
        }

        public void WaitForIsVisible()
        {
            new WebDriverWait(Browser.GetDriver(), TimeSpan.FromSeconds(Browser.TimeOutForElement)).Until(ExpectedConditions.ElementIsVisible(this.Locator));
        }

        public string TagName => throw new NotImplementedException();

        public string Text => throw new NotImplementedException();

        public bool Enabled => throw new NotImplementedException();

        public bool Selected => throw new NotImplementedException();

        public Point Location => throw new NotImplementedException();

        public Size Size => throw new NotImplementedException();

        public bool Displayed => throw new NotImplementedException();

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Click()
        {
            this.WaitForIsVisible();
            Browser.GetDriver().FindElement(this.Locator).Click();
        }

        public IWebElement FindElement(By by)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetCssValue(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string GetProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public void SendKeys(string text)
        {
            this.WaitForIsVisible();
            Browser.GetDriver().FindElement(this.Locator).SendKeys(text);
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }
    }
}
