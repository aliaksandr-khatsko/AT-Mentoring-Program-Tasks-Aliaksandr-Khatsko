using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDD_SpecFlow.PageObjects;

namespace BDD_SpecFlow
{
    public class ItemPage:BasePage
    {
        //Ititialize page
        public ItemPage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {

        }

        //Objects for the Item page
        [FindsBy(How = How.Id, Using = "isCartBtn_btn")]
        public IWebElement AddToCartBtn { get; set; }

        [FindsBy(How = How.Id, Using = "qtyTextBox")]
        public IWebElement QtyTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "watchLink")]
        public IWebElement WatchLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='w1-4-_lmsg']//a[@href='http://my.ebay.com/ws/eBayISAPI.dll?MyEbayBeta&CurrentPage=MyeBayNextWatching&ssPageName=STRK:ME:LNLK:MEWAX']")]
        public IWebElement WatchPageLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='atcLnk']")]
        public IWebElement AddedToCartLable { get; set; }


        public void LookAfterItem()
        {
            WatchLink.Click();
        }

        public void FillInQty(string number)
        {
            QtyTextBox.Clear();
            QtyTextBox.SendKeys(number);
        }

        public WatchPage NavigateToWatchPage()
        {
            WatchPageLink.Click();
            return new WatchPage(driver, wait);
        }

        public CartPage AddToCartFromItemPage()
        {
            AddToCartBtn.Click();
            return new CartPage(driver, wait);
        }

        public CartPage NavigateToCartByAddedToCartLink()
        {
            AddedToCartLable.Click();
            return new CartPage(driver, wait);
        }


    }
}
