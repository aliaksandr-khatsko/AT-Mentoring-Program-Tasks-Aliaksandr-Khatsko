using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver
{
    public class MerckLoginPage : LoginPageDecorator
    {

        public MerckLoginPage(BaseLogInPage page, IWebDriver driver, WebDriverWait wait)
            : base(page, driver, wait)
        {
        }

        public override void OpenURL()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["merckURL"]);
        }

        public override HomePage OpenHomePage(BaseUser user)
        {
            var _user = (MerckUser)user;
            CompanyId.SendKeys(_user.CompanyId(new UserConfiguration()));
            UserId.SendKeys(_user.UserId(new UserConfiguration()));
            PasswordId.SendKeys(_user.Password(new UserConfiguration()));
            LoginBtn.Click();
            return new HomePage(driver, wait);
        }

        public override HomePage OpenHomePage()
        {
            MerckUser user = new MerckUser();
            CompanyId.SendKeys(user.CompanyId(new UserConfiguration()));
            UserId.SendKeys(user.UserId(new UserConfiguration()));
            PasswordId.SendKeys(user.Password(new UserConfiguration()));
            LoginBtn.Click();
            return new HomePage(driver, wait);
        }

    }
}
