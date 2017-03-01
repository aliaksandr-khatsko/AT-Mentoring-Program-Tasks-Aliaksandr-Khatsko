using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebDriver
{
    public class LogInPage:BasePage
    {
        //Ititialize page
        public LogInPage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {
                
        }

        //Objects for the LogInPage page
        [FindsBy(How = How.Id, Using = "txtCompanyID")]
        public IWebElement CompanyId { get; set; }

        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement PasswordId { get; set; }

        [FindsBy(How = How.Id, Using = "txtUserID")]
        public IWebElement UserId { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='submitContainer']/input[@value='Login']")]
        public IWebElement LoginBtn { get; set; }

        public By companyIdLocator = By.Id("txtCompanyID");


        public void OpenURL()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
        }

        public HomePage OpenHomePage(User user)
        {

            CompanyId.SendKeys(user.CompanyId(new UserConfiguration()));
            UserId.SendKeys(user.UserId(new UserConfiguration()));
            PasswordId.SendKeys(user.Password(new UserConfiguration()));
            LoginBtn.Click();
            return new HomePage(driver, wait);
        }

    }
}
