using AutoTest.webdriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.pages
{
    public class FoundPage:BasePage
    {
        private static readonly By WikiFoundLabel = By.XPath("//h1[contains(.,'Баг')]");

        public FoundPage() : base(WikiFoundLabel, "Wikipedia - Month events page")
        {
        }
    }
}
