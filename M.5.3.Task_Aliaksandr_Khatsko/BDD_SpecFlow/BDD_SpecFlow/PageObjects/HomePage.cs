using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace BDD_SpecFlow
{
    public class HomePage:BasePage
    {
        public HomePage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {}

        //Objects for the Home page
        [FindsBy(How = How.XPath, Using = ".//*[@id='gh-ac']")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.Id, Using = "gh-btn")]
        public IWebElement SearchBtn { get; set; }

        public By openLable = By.XPath(".//*[@id='pd-overlay']");

        public SearchResultsPage SearchByKeys(string searchKey)
        {
            SearchField.SendKeys(searchKey);
            SearchBtn.Click();
            return new SearchResultsPage(driver, wait);
        }

    }
}
