using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using SeleniumWebDriver.Locators;
using System;

namespace SeleniumWebDriver
{
    public class HomePage
    {
        public static void OpenSearchPage(IWebDriver objDriver)
        {
            objDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            objDriver.FindElement(By.XPath(HomePageLocators.searchMenuItem_XPath)).Click();
        }

    }
}
