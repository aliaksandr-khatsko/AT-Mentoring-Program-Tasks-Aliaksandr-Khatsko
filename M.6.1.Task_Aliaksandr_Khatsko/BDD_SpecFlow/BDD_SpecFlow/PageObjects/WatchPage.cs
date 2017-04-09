using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDD_SpecFlow.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace BDD_SpecFlow
{
    public class WatchPage:BasePage
    {
        //Ititialize page
        public WatchPage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {

        }

        //Objects for the Watch page
        [FindsBy(How = How.XPath, Using = ".//*[@id='watchlist']//a[@aria-describedby='m1438-171617306540-0-' and @class='saction addToCart']")]
        public IWebElement HatAddToCartLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='watchlist']//a[@href='http://cart.payments.ebay.com/sc/add?item=292040084166&atc=true&srt=01000100000050d816af13da5b2dd2ca7224ad001d403e20899837282d50ae9bc078f2144e99dd7051103785f6cc9229efe25237e338de415bba5693186900bb8ca194e4032eecb398b75aed0637007af2f105565a901f&_trksid=p2055119.m1438.l2671']")]
        public IWebElement CarAddToCartLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@class='list-bulk-actions ']//input[@title='Чтобы провести сравнение или удалить товары, выберите все товары']")]
        public IWebElement SelectAllCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='watchlist']//div[@class='list-bulk-actions ']//a[@class='btn btn-s btn-ter bulk-delete']")]
        public IWebElement DeleteAllBtn { get; set; }

        [FindsBy(How = How.Id, Using = "delCustpBtnSave")]
        public IWebElement ConfirmDeleteBtn { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='watchlist']//span[text()='В списке отслеживания нет сохраненных товаров. ' and @class='sub-title']")]
        public IWebElement WatchListSubTitle { get; set; }

        

        public void DeleteAllItemsFromWatch()
        {
            SelectAllCheckBox.Click();
            DeleteAllBtn.Click();
            ConfirmDeleteBtn.Click();
        }

        public CartPage AddToCartFromWatchPage()
        {
            HatAddToCartLink.Click();
            return new CartPage(driver, wait);
        }
    }
}
