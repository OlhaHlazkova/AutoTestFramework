using HotlineAutoTest.webdriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace HotlineAutoTest.pages
{
    public class HotLinePage:BasePage
    {
        //private static readonly By HotlineLabel = By.ClassName("cell-6");
        private static readonly By LanguageUkraineLabel = By.ClassName("js-change-language");
        private static string StartUrl;    

        public HotLinePage() : base(LanguageUkraineLabel, "Hotline page")
        {
            StartUrl = "http://hotline.ua";            
        }

        public void GoToStartUrl()
        {
            Browser.NavigateTo(StartUrl);
        }        

        public void ChangeLanguageToUkrainian()
        {
            BaseElement Language = new BaseElement(LanguageUkraineLabel);
            Language.WaitForIsVisible();
            Language.Click();
        }

        private static readonly BaseElement TextFromPage = new BaseElement(By.XPath("/html/body/header/div[1]/div/div/div[1]/div/div[2]/div/div[3]/div/div/span[2]"));

        public bool IsTextUkrainian()
        {

            if (TextFromPage.Equals("Каталог товарів"))
            {
                return true;
            }
            else
            {
                return false;
            }                
        }

        private static readonly BaseElement SmartPhonesMenu = new BaseElement(By.CssSelector("li.level-1:nth-child(15) > a:nth-child(1)"));

        public SmartPhonesPage GoToSmartPhonesPage()
        {
            SmartPhonesMenu.Click();
            return new SmartPhonesPage();
        }
    }
    
}