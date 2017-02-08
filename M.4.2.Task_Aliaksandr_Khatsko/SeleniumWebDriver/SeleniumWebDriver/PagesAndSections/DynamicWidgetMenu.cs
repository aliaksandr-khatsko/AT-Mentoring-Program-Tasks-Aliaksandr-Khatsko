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
    class DynamicWidgetMenu:BasePage
    {

        //Ititialize page
        public DynamicWidgetMenu(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {
                
        }

        //Objects for the DynamicWidgetMenu page
        [FindsBy(How = How.XPath, Using = ".//*[@id='levelMenu']//a[@href='/msc/Search']")]
        public IWebElement SearchMenuItem { get; set; }


        public SearchPage OpenSearchPage()
        {
            SearchMenuItem.Click();
            return new SearchPage(driver, wait);
        }
        
    }
}
