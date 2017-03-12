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
    public class BasketPage:BasePage
    {
        //Ititialize page
        public BasketPage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {
                
        }

        //Objects for the Basket page
        [FindsBy(How = How.XPath, Using = ".//table[@class='SavedItemsTable']//div[1][@class='placeOrder']/a")]
        public IWebElement FirstOrderLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='readyList']")]
        public IWebElement ReadyToOrderTable { get; set; }


        public ConfirmationPage PlaceOrderLink()
        {
            FirstOrderLink.Click();
            return new ConfirmationPage(driver, wait);
        }
    }
}
