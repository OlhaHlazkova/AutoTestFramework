using AutoTest.webdriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.pages
{
    public class SmartPhonesPage:BasePage
    {
        private static readonly By LanguageUkraineLabel = By.ClassName("js-change-language");
        //private static string StartUrl;

        public SmartPhonesPage() : base(LanguageUkraineLabel, "SmartPhones page")
        {            
        }

        private static readonly BaseElement MenuAccesories = new BaseElement(By.CssSelector("li.item:nth-child(2) > span:nth-child(1)"));
        private static readonly BaseElement MenuChargers = new BaseElement(By.CssSelector("li.item:nth-child(2) > div:nth-child(2) > div:nth-child(1) > ul:nth-child(1) > li:nth-child(1) > a:nth-child(1)"));

        public void CheckMenuChargers ()
        {
            Actions actions = new Actions(Browser.GetDriver());
            actions.MoveToElement(MenuAccesories.GetElement()).Build().Perform();
            new WebDriverWait(Browser.GetDriver(), TimeSpan.FromSeconds(10));
            actions.MoveToElement(MenuAccesories.GetElement()).MoveToElement(MenuChargers.GetElement()).Click().Build().Perform();

            /*
            Actions builder = new Actions(Browser.GetDriver());
            new WebDriverWait(Browser.GetDriver(), TimeSpan.FromSeconds(10));

            Actions acc = builder.MoveToElement(MenuAccesories.GetElement()).Click()
                .MoveToElement(MenuChargers.GetElement()).Click();

            acc.Build().Perform();
            
            

            /*
            Actions charg = builder.MoveByOffset(200, -100).Click();   
            charg.Build().Perform();          
              */
            //Browser.NavigateTo("http://hotline.ua/mobile/zaryadnye-ustrojstva-dlya-mobilnyh-telefonov/");
        }



       
    }
}
