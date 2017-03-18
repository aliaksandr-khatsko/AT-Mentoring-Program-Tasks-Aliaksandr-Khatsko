using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace BDD_SpecFlow
{
    public class BaseFactories
    {
        private static IWebDriver driver;

        private static WebDriverWait wait;

        public static IWebDriver CreateDriver()
        {
            driver = new ChromeDriver(@"D:\ATMentoring_Tasks_Repositories\Task 5.3\BDD_SpecFlow\packages\Selenium.WebDriver.ChromeDriver.2.28.0\driver\");
            return driver;
        }

        public static IWebDriver GetDriverInstance
        {
            get { return driver ?? CreateDriver(); }
            private set { }
        }

        private static WebDriverWait CreateDriverWait()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            return wait;
        }

        public static WebDriverWait GetWaitInstance
        {
            get { return wait ?? CreateDriverWait(); }
            private set { }
        }
    }
}
