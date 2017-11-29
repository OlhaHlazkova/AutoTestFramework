using AutoTest.webdriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace AutoTest.pages
{
    public class GooglePage:BasePage
    {
        private static readonly By GoogleLabel = By.Id("hplogo");
        private static string StartUrl; 

        public GooglePage() : base(GoogleLabel, "Google search page")
        {
            StartUrl = "https://www.google.com.ua/";
        }

        private readonly BaseElement searchField = new BaseElement(By.Id("lst-ib"));
        private readonly BaseElement searchButton = new BaseElement(By.CssSelector("span.ds:nth-child(1) > span:nth-child(1) > input:nth-child(1)"));

        private void GoToStartUrl()
        {
            Browser.NavigateTo(StartUrl);
        }

        public ResultPage GoToResultPage()
        {
            this.GoToStartUrl();
            this.searchField.SendKeys("Вікіпедія");
            this.searchButton.Click();
            return new ResultPage();
        }
    }
}
