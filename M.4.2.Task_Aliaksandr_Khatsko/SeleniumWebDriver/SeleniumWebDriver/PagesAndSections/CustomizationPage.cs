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
    public class CustomizationPage:BasePage
    {
        //Ititialize page
        public CustomizationPage(IWebDriver driver)
            : base(driver)
        {
                
        }

        //Objects for the CustomizationPage page
        [FindsBy(How = How.XPath, Using = ".//div[@id='studio_inlinepreview_jpeg']/img")]
        public IWebElement InlinePreview { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='studio_navigation_button_next']")]
        public IWebElement NextBtn { get; set; }


        public void ClickNextBtn()
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            NextBtn.Click();
        }

        

    }
}
