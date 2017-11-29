using HotlineAutoTest.webdriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotlineAutoTest.pages
{
    public class CurrentEventsPage: BasePage
    {
        private static readonly By WikiCurrentLabel = By.Id("firstHeading");        

        public CurrentEventsPage() : base(WikiCurrentLabel, "Wikipedia - Current events page")
        {            
        }

        private static readonly BaseElement OctoberEventsLink = new BaseElement(By.XPath("//a[@title='Жовтень 2017']"));

        public WikiMonthEventsPage GoToMonthEventsPage()
        {
            OctoberEventsLink.Click();
            return new WikiMonthEventsPage();
        }
    }
}
