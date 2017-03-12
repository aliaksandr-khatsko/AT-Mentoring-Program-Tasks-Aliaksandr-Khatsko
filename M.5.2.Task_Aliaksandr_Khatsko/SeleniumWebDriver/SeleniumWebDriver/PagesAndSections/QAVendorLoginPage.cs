using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Configuration;


namespace SeleniumWebDriver
{
    public class QAVendorLoginPage : LoginPageDecorator
    {

        public QAVendorLoginPage(BaseLogInPage page, IWebDriver driver, WebDriverWait wait)
            : base(page, driver, wait)
        {

        }

        public override void OpenURL()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["qaVendorURL"]);
        }

        public override HomePage OpenHomePage(BaseUser user)
        {
            var _user = (QAVendorUser) user;
            CompanyId.SendKeys(_user.CompanyId(new UserConfiguration()));
            UserId.SendKeys(_user.UserId(new UserConfiguration()));
            PasswordId.SendKeys(_user.Password(new UserConfiguration()));
            LoginBtn.Click();
            return new HomePage(driver, wait);
        }

        public override HomePage OpenHomePage()
        {
            QAVendorUser user = new QAVendorUser();
            CompanyId.SendKeys(user.CompanyId(new UserConfiguration()));
            UserId.SendKeys(user.UserId(new UserConfiguration()));
            PasswordId.SendKeys(user.Password(new UserConfiguration()));
            LoginBtn.Click();
            return new HomePage(driver, wait);
        }

    }
}
