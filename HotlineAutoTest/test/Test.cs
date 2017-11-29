using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using AutoTest.pages;
using AutoTest.webdriver;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace AutoTest
{
    [TestFixture]
    public class Test: BaseTest
    {
        public IWebDriver driver; 

        private string ConfigValue = ConfigurationManager.AppSettings["browser"];             
        
        //Go to Wikipedia page from Google search
        [Test]
        public void GoToWikiFromGoogleTest()
        {
            var Google = new GooglePage();
            Google.GoToResultPage();
            var ResultGoogle = new ResultPage();
            var Wiki = ResultGoogle.GoToWiki();
            Wiki.AssertIsOpen();
        }                   
        
        //Open Current Events on the Wikipedia site
        [Test]
        public void GoToCurrentEventsTest()
        {
            var Wiki = new WikiHomePage();
            Wiki.GoToUrl();
            var WikiCurrentEvents = Wiki.GoToCurrenEventsPage();
            WikiCurrentEvents.AssertIsOpen();
        }        

        //To search text "Баг", to check if needed page opened
        [Test]
        public void SearchTextTest()
        {
            var Wiki = new WikiHomePage();
            Wiki.GoToUrl();
            FoundPage Found = Wiki.SearchTheText("Bug");
            Found.AssertIsOpen(); //checking for text h1 "Баг"
        }   
    }
}

