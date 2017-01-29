using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using SeleniumWebDriver.Locators;
using System;


namespace SeleniumWebDriver
{
    public class SaveOrderCustomization
    {
        public static void CustomizeOrder(IWebDriver objDriver, string itemToCustomize)
        {
            objDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            objDriver.FindElement(By.XPath(itemToCustomize)).Click();
        }

        public static void ClickNextBtn(IWebDriver objDriver)
        {
            objDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            objDriver.FindElement(By.XPath(CustomizationLocators.nextBtn_XPath)).Click();
        }

        public static void AcceptCustomizationPreview(IWebDriver objDriver)
        {
            objDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            objDriver.FindElement(By.XPath(CustomizationLocators.acceptCustomizationPreviewBtn_XPath)).Click();
        }

        public static void SaveOrder(IWebDriver objDriver)
        {
            objDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            objDriver.FindElement(By.XPath(CustomizationLocators.saveOrderDetailsBtn_XPath)).Click();
        }

        public static void FillInRef(IWebDriver objDriver, string sendKey)
        {
            objDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            objDriver.FindElement(By.XPath(CustomizationLocators.refField_XPath)).Clear();
            objDriver.FindElement(By.XPath(CustomizationLocators.refField_XPath)).SendKeys(sendKey);
        }

    }
}
