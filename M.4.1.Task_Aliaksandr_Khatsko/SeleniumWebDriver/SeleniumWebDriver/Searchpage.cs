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
    public class Searchpage
    {
        public static void SearhItem(IWebDriver objDriver, string keys)
        {
            objDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            objDriver.FindElement(By.Id(SearchPageLocators.searchField_ID)).SendKeys(keys);
            objDriver.FindElement(By.Id(SearchPageLocators.searchBtn_ID)).Click();
        }
    }
}
