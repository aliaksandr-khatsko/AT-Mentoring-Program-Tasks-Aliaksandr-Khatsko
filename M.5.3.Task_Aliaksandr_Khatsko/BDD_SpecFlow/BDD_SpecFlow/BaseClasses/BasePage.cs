using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace BDD_SpecFlow
{
    public abstract class BasePage
    {
        public IWebDriver driver;

        public WebDriverWait wait;

        public BasePage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            PageFactory.InitElements(driver, this);

        }
    }
}
