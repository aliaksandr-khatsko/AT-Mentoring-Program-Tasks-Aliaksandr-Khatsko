using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace BDD_SpecFlow.PageObjects
{
    public class Header:BasePage
    {
        //Ititialize page
        public Header(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {

        }

        //Objects for the Header
        [FindsBy(How = How.XPath, Using = ".//*[@id='gh-cart-n']")]
        public IWebElement FullCartQty { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='gh-cart-i']")]
        public IWebElement CartIcon { get; set; }
        

        [FindsBy(How = How.XPath, Using = ".//*[@id='gh-eb-My-o']//a[@href='http://www.ebay.com/myb/WatchList']")]
        public IWebElement WatchLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='gh-logo']")]
        public IWebElement EbayLogo { get; set; }
        
        

        public WatchPage OpenToWatchPage()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", WatchLink);
            return new WatchPage(driver, wait);
        }

        public CartPage OpenToCartPage()
        {
            CartIcon.Click();
            return new CartPage(driver, wait);
        }

        public HomePage OpenToHomePage()
        {
            EbayLogo.Click();
            return new HomePage(driver, wait);
        }

   }
}
