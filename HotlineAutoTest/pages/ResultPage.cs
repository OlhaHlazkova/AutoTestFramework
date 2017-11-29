using AutoTest.webdriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace AutoTest.pages
{
    public class ResultPage:BasePage
    {
        private static readonly By ResultLabel = By.CssSelector("#hdtb-msb");

        public ResultPage() : base(ResultLabel, "Google result page")
        {
        }              

        private readonly BaseElement link = new BaseElement(By.XPath("//a[contains(.,'Вікіпедія')]"));

        public WikiHomePage GoToWiki()
        {
            this.link.Click();
            return new WikiHomePage();
        }

        /*
        public HotLinePage GoToHotline ()
        {
            this.link.Click();
            return new HotLinePage();
        }
        */
    }
}
