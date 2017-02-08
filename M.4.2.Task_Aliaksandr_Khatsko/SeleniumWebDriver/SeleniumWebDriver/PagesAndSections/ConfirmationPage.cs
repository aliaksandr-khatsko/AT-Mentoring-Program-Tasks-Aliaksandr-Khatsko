using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver
{
    public class ConfirmationPage:BasePage
    {
        //Ititialize page
        public ConfirmationPage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {
                
        }

        //Objects for the ConfirmationPage page
        [FindsBy(How = How.XPath, Using = ".//*[@id='orderDetailsItems']//span[@class='CompletedOrderFlash']")]
        public IWebElement CompletedOrderText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='orderDetailsItems']//a[text()='Download Now' and @class='SunshineLinkText']")]
        public IWebElement DownloadNowLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='orderDetailsItems']//div[@class='orderDetailsItemLeft']/p/span[1]")]
        public IWebElement RefName { get; set; }
    }
}
