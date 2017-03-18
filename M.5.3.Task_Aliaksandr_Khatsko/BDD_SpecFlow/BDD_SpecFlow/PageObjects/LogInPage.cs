using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
namespace BDD_SpecFlow
{
    public class LogInPage:BasePage
    {
        //Ititialize page
        public LogInPage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {

        }

        //Objects for the LogInPage page
        [FindsBy(How = How.XPath, Using = ".//*[@placeholder='Адрес эл. почты или логин' and @class='fld']")]
        public IWebElement LogInField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='fld' and @placeholder='Пароль']")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Id, Using = "sgnBt")]
        public IWebElement LoginBtn { get; set; }

        [FindsBy(How = How.Id, Using = "csi")]
        public IWebElement StayInSystemCheckBox { get; set; }


        public HomePage OpenHomePage(User user)
        {
            LogInField.SendKeys(user.LogIn(new UserConfiguration()));
            PasswordField.SendKeys(user.Password(new UserConfiguration()));
            StayInSystemCheckBox.Click();
            LoginBtn.Click();
            return new HomePage(driver, wait);
        }
         
    }
}