using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.webdriver
{
    public class BrowserFactory
    {
        public enum BrowserType
        {
            Chrome,
            Firefox            
        }

        public static IWebDriver GetDriver(BrowserType type, int timeOutSec)
        {
            IWebDriver driver = null;

            switch(type)
            {
                case BrowserType.Firefox:
                   {
                        var service = FirefoxDriverService.CreateDefaultService();
                        var options = new FirefoxOptions();
                        driver = new FirefoxDriver(service, options, TimeSpan.FromSeconds(timeOutSec));
                        break;
                   }
                case BrowserType.Chrome:
                   {
                        var service = ChromeDriverService.CreateDefaultService();
                        var options = new ChromeOptions();
                        options.AddArgument("disable-infobars");
                        driver = new ChromeDriver(service, options, TimeSpan.FromSeconds(timeOutSec));
                        break;
                   }                
            }
            return driver;
        }
    }
}
