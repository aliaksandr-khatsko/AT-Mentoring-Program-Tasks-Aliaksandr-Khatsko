using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;



namespace SeleniumWebDriver
{
    

    public class SearchPage:BasePage
    {
        //Ititialize page
        public SearchPage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {
                
        }

        //Objects for the SearchPage page
        [FindsBy(How = How.CssSelector, Using = ".results-loading-spinner")]
        public IWebElement CentredSpinner { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='searchResultsTotalFound']")]
        public IWebElement Matches { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='searchFilterContainer']")]
        public IWebElement RefineSearchPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='searchbutton']")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='searchterm']")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='resultsBarContainer']")]
        public IWebElement SortingPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='startOver']")]
        public IWebElement StartOverLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='a5dd15d0-9d46-4a41-a603-a706013fb23e']//div[@class='tacticAction tactic-action-btn']/a[@href='/msc/Customize/Index/a5dd15d0-9d46-4a41-a603-a706013fb23e']")]
        public IWebElement TestCustomizableBtn { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ca9f9053-1d9b-4368-91e2-a7180097e4f7']//a[@href='/msc/Customize/Index/a5dd15d0-9d46-4a41-a603-a706013fb23e']/span")]
        public IWebElement TestCustomizableLBBtn { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='a5dd15d0-9d46-4a41-a603-a706013fb23e']//span[@class='ellipsis_text']")]
        public IWebElement TestCustomizableLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='lbContainer']//div[@class='lb-toggle']")]
        public IWebElement LbContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='lbContainer']//div[@class='lb-count-info']")]
        public IWebElement LbCountner { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='lbContainer']//span[@class='lb-actions-title']")]
        public IWebElement LbActionArrow { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='lbContainer']//li[@class='clear-action']/a")]
        public IWebElement ClearLb { get; set; }

        public const string SearchKeys = "'QA Alex AutoTest Please Do Not Delete Or Edit'";

        public By spinner = By.CssSelector(".results-loading-spinner");

        public By lightBoxSpinner = By.CssSelector(".lightboxSpinner");

        public By lightBoxCounterSpinner = By.CssSelector(".lb-count spinner");

        //public By searchFieldLocator = By.Id("searchterm");

        public void SearhItem()
        {
            Actions act = new Actions(driver);
            SearchField.SendKeys(SearchKeys);
            //SearchButton.Click();
            act.MoveToElement(SearchField).SendKeys(Keys.Enter).Perform();

        }

        public void MovetoLB()
        {
            Actions act = new Actions(driver);
            if (LbCountner.Text.Contains("0"))
            {
                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                act.ClickAndHold(TestCustomizableLink).MoveToElement(LbContainer).Release(LbContainer).Build().Perform();
            }
            else
            {
                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                SearchPage searchPage = new SearchPage(driver, wait);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.backgroundColor = '" + "yellow" + "'", LbCountner);
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", ClearLb);
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(searchPage.lightBoxCounterSpinner));
                act.ClickAndHold(TestCustomizableLink).MoveToElement(LbContainer).Release(LbContainer).Build().Perform();
            }

        }

        public CustomizationPage CustomizeOrderFromLB()
        {
            TestCustomizableLink.Click();
            return new CustomizationPage(driver, wait);
        }

    }
}
