using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebDriver
{
    public class HomePage:BasePage
    {
        //Ititialize page
        public HomePage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {
                
        }

        //Objects for the HomePage page
        [FindsBy(How = How.Id, Using = "header")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.Id, Using = "SearchTerm")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.Id, Using = "FindButton")]
        public IWebElement SearchFieldBtn { get; set; }

    }
}
