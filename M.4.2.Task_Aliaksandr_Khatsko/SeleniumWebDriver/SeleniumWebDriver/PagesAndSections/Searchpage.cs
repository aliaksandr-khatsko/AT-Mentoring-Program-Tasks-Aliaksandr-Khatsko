using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebDriver
{
    public class SearchPage:BasePage
    {
        //Ititialize page
        public SearchPage(IWebDriver driver)
            : base(driver)
        {
                
        }

        //Objects for the SearchPage page
        [FindsBy(How = How.CssSelector, Using = ".results-loading-spinner")]
        public IWebElement CentredSpinner { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='searchResultsTotalFound']")]
        public IWebElement Matches { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='searchFilterContainer']")]
        public IWebElement RefineSearchPanel { get; set; }

        [FindsBy(How = How.Id, Using = "searchbutton")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "searchterm")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='resultsBarContainer']")]
        public IWebElement SortingPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='startOver']")]
        public IWebElement StartOverLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='a5dd15d0-9d46-4a41-a603-a706013fb23e']//div[@class='tacticAction tactic-action-btn']/a[@href='/msc/Customize/Index/a5dd15d0-9d46-4a41-a603-a706013fb23e']")]
        public IWebElement TestCustomizableBtn { get; set; }

        public const string SearchKeys = "'QA Alex AutoTest Please Do Not Delete Or Edit'";

        public void SearhItem()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            SearchField.SendKeys(SearchKeys);
            SearchButton.Click();
        }

        public CustomizationPage CustomizeOrder()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            TestCustomizableBtn.Click();
            return new CustomizationPage(driver);
        }

    }
}
