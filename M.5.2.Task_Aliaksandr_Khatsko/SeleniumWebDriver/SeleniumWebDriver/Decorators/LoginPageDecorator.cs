using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebDriver
{
    public abstract class LoginPageDecorator:BaseLogInPage
    {
        private BaseLogInPage page;

        public LoginPageDecorator(BaseLogInPage page, IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {
            this.page = page;
        }

    }
}
