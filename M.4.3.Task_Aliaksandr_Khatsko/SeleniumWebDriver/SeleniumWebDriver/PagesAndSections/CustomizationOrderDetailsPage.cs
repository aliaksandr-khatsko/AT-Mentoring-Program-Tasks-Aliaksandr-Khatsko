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
    public class CustomizationOrderDetailsPage:BasePage
    {

        //Ititialize page
        public CustomizationOrderDetailsPage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait)
        {
                
        }

        //Objects for the CustomizationOrderDetailsPage page
        [FindsBy(How = How.XPath, Using = ".//*[@id='txtReference']")]
        public IWebElement RefField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='LowerButtons']//a[@id='btnSave']")]
        public IWebElement SaveOrderDetailsBtn { get; set; }

        public void FillInRef(string sendKey)
        {
            RefField.Clear();
            RefField.SendKeys(sendKey);
        }

        public BasketPage SaveCustomization()
        {
            SaveOrderDetailsBtn.Click();
            return new BasketPage(driver, wait);
        }

    }
}
