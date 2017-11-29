using AutoTest.webdriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.pages
{
    public class UniversalChargesPage:BasePage
    {
        private static readonly By LanguageUkraineLabel = By.ClassName("js-change-language");
        //private static string StartUrl;

        public UniversalChargesPage() : base(LanguageUkraineLabel, "UniversalCharges page")
        {

        }
    }
}
