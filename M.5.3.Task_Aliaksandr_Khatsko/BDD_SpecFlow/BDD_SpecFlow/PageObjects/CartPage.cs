using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace BDD_SpecFlow.PageObjects
{
    public class CartPage:BasePage
    {
        //Ititialize page
        public CartPage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {

        }

        //Objects for the Cart page
        [FindsBy(How = How.XPath, Using = ".//*[text()='Удалить' and @aria-describedby='171617306540_title']")]
        public IWebElement DeleteLinkTestHat { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='171617306540_title']")]
        public IWebElement HatItemTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@data-itemid='171617306540']//input[@class='ff-ds3 fs12 qtyTextBox']")]
        public IWebElement HatItemQty { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@data-itemid='292040084166']//input[@class='ff-ds3 fs12 qtyTextBox']")]
        public IWebElement CarItemQty { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[text()='Удалить' and @aria-describedby='122013079618_title']")]
        public IWebElement DeleteLinkTestScarf { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='122013079618_title']")]
        public IWebElement ScarfItemTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='PageTitle']/h1[@class='mb15 nowrap']")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='empty-sc']//div[@class='fw-b']")]
        public IWebElement EmptyCart { get; set; }
        

        public void DeleteHatFromCart()
        {
            DeleteLinkTestHat.Click();
        }

        public void DeleteScarfFromCart()
        {
            DeleteLinkTestScarf.Click();
        }
    }
}
