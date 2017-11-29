using OpenQA.Selenium;
using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace AutoTest.webdriver
{
    public class BasePage
    {
        protected By TitleLocator;
        protected string title;
        public static string titleForm;

        protected BasePage(By TitleLocator, string title)
        {
            this.TitleLocator = TitleLocator;
            this.title = titleForm = title;
        }

        public void AssertIsOpen()
        {
            var label = new BaseElement(this.TitleLocator, this.title);

            label.WaitForIsVisible();
        }

    }
}
