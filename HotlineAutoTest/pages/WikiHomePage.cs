using HotlineAutoTest.webdriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotlineAutoTest.pages
{
    public class WikiHomePage: BasePage
    {
        private static readonly By WikiLabel = By.ClassName("mw-wiki-logo");
        private static string StartUrl;

        public WikiHomePage() : base(WikiLabel, "Wikipedia home page")
        {
            StartUrl = "https://uk.wikipedia.org";
        }   
        
        public void GoToUrl()
        {
            Browser.NavigateTo(StartUrl);
        }

        private static readonly BaseElement CurrentEventsLink = new BaseElement(By.XPath("//a[@title='Список поточних подій']"));

        public CurrentEventsPage GoToCurrenEventsPage()
        {
            CurrentEventsLink.Click();
            return new CurrentEventsPage();
        }

        private static readonly BaseElement SearchField = new BaseElement(By.Id("searchInput"));

        public FoundPage SearchTheText(String text)
        {
            SearchField.SendKeys(text);
            SearchField.SendKeys(Keys.Enter);
            return new FoundPage();
        }

        /*
        private static DateTime CurrentDate = DateTime.Today;
        private static By DayMont =  By.XPath("//table/tbody/tr/td[2]/div/a[1]");
        private static By Year = By.XPath("//table/tbody/tr/td[2]/div/a[2]");

        public bool CheckCurrentDate()
        {
            String TodayDate = CurrentDate.GetDateTimeFormats()[0];
            String CurrentDay = TodayDate.Split('/')[1];
            int CurrentMonth = Int32.Parse(TodayDate.Split('/')[0]);
            String CurrentYear = TodayDate.Split('/')[2];

            String DM = DayMonth.GetText();                      
            String Day = DM.Split(' ')[0];
            String Month = DM.Split(' ')[1];
            String Y = Year.GetText();
            int MonthNum = 13;

            String[] MonthsUkr = { "січня", "", "", "", "", "", "", "", "", "жовтня", "листопада", "грудня"};

            for(int i=0; i<12; i++)
            {
                if(MonthsUkr[i].Equals(Month))
                {
                    MonthNum = i + 1;
                }
            }

            if ((CurrentDay.Equals(Day)) && (CurrentMonth==MonthNum) && (CurrentYear.Equals(Y)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
    }
}
