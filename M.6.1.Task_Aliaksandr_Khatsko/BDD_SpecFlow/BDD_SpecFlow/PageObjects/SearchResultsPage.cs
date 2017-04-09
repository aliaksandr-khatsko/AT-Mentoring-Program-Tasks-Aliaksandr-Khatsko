using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace BDD_SpecFlow
{
    public class SearchResultsPage:BasePage
    {
        //Ititialize page
        public SearchResultsPage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {

        }

        //Objects for the SearchResultsPage page
        [FindsBy(How = How.XPath, Using = ".//*[@id='item27f53047ac']//img[@src='http://thumbs.ebaystatic.com/images/g/xBIAAOSwwTlUn0jn/s-l225.jpg']")]
        public IWebElement TestHatItem { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='item1c688bd842']//img[@src='http://thumbs.ebaystatic.com/images/g/rU8AAOSwbYZXXMpq/s-l225.jpg']")]
        public IWebElement TestScarfItem { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='item43fef20ac6']//img[@src='http://thumbs.ebaystatic.com/images/g/Z84AAOSwTM5YtGHx/s-l225.jpg']")]
        public IWebElement TestCarItem { get; set; }
        


        public ItemPage OpenHatItemPage()
        {
            TestHatItem.Click();
            return new ItemPage(driver, wait);
        }

        public ItemPage OpenScarfItemPage()
        {
            TestScarfItem.Click();
            return new ItemPage(driver, wait);
        }

        public ItemPage OpenCarItemPage()
        {
            TestCarItem.Click();
            return new ItemPage(driver, wait);
        }
    }
}
