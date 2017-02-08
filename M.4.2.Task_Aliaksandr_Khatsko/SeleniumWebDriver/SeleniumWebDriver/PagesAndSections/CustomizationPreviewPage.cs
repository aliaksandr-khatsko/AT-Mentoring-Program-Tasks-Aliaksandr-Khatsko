﻿using System.Text;
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
    public class CustomizationPreviewPage:BasePage
    {
        //Ititialize page
        public CustomizationPreviewPage(IWebDriver driver)
            : base(driver)
        {
                
        }

        //Objects for the CustomizationPreviewPage page
        [FindsBy(How = How.XPath, Using = ".//*[@id='contentContainer']//img[contains(@src, '/Sunshine/IT_en-us/AcceptAndContinueButton.gif')]")]
        public IWebElement AcceptCustomizationPreviewBtn { get; set; }

        public CustomizationOrderDetailsPage AcceptCustomizationPreview()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            AcceptCustomizationPreviewBtn.Click();
            return new CustomizationOrderDetailsPage(driver);
        }

    }
}
