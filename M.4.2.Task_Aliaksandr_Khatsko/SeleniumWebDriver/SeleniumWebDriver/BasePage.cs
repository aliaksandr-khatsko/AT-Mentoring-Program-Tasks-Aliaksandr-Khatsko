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
    public abstract class BasePage
    {
        public IWebDriver driver;

        //public WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            //this.wait = wait;
            PageFactory.InitElements(driver, this);
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
        }



    //    public static IWebDriver CreateDriver()
    //    {
    //        driver = new ChromeDriver();
    //        return driver;
    //    }

    //    public IWebDriver GetDriverInstance
    //    {
    //        get { return driver ?? CreateDriver(); }
    //        private set { }
    //    }

    //    private WebDriverWait CreateDriverWait()
    //    {
    //        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
    //        return wait;
    //    }

    //    public WebDriverWait GetWaitInstance
    //    {
    //        get { return wait ?? CreateDriverWait(); }
    //        private set { }
    //    }

    }
}
