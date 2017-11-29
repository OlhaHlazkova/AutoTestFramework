using AutoTest.webdriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.pages
{
    public class WikiMonthEventsPage: BasePage
    {
        private static readonly By WikiMonthLabel = By.XPath("//h1[contains(.,'Жовтень 2017')]");

        public WikiMonthEventsPage() : base(WikiMonthLabel, "Wikipedia - Month events page")
        {
        }

        //private static String text = "Українські політв\'язні Кремля Ахтем Чийгоз та Ільмі Умеров були звільнені та передані російською владою Туреччині";
                
    }
}
