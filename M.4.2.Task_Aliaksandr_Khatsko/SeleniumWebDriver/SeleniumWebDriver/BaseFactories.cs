using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver
{
    public class BaseFactories
    {
        private static IWebDriver driver;

        private static WebDriverWait wait;

        public static IWebDriver CreateDriver()
        {
            driver = new ChromeDriver(@"D:\ATMentoring\AT_Mentoring_Tasks\M.4.2.Task_Aliaksandr_Khatsko\SeleniumWebDriver\packages\Selenium.WebDriver.ChromeDriver.2.27.0\driver\");
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
