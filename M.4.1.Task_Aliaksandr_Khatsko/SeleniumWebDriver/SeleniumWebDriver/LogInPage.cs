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
    public class LogInPage
    {
        public static void LogIn(IWebDriver objDriver)
        {
            objDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            objDriver.Navigate().GoToUrl(LogInDetails.URL);
            objDriver.FindElement(By.Id(LogInPageLocators.companyID_ID)).SendKeys(LogInDetails.CompanyID);
            objDriver.FindElement(By.Id(LogInPageLocators.userID_ID)).SendKeys(LogInDetails.UserID);
            objDriver.FindElement(By.Id(LogInPageLocators.password_ID)).SendKeys(LogInDetails.Password);
            objDriver.FindElement(By.XPath(LogInPageLocators.logInBtn_XPath)).Click();

        }

    }
}
