using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_SpecFlow
{
    public class GlobalPage:BasePage
    {
        //Ititialize page
        public GlobalPage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {}

        //Objects for the Global page
        [FindsBy(How = How.XPath, Using = ".//*[@id='gh-ug']//a[@href='https://signin.ebay.com/ws/eBayISAPI.dll?SignIn&ru=http%3A%2F%2Fwww.ebay.com%2F']")]
        public IWebElement LoginLink { get; set; }


        public void OpenURL()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["url"]);
        }

        public LogInPage OpenLogInPage()
        {
            LoginLink.Click();
            return new LogInPage(driver, wait);
        }
    }
}
