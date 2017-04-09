using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace BDD_SpecFlow
{
    public sealed class BaseFactories
    {
        private static IWebDriver driver;

        private static WebDriverWait wait;

        private static log4net.ILog logger;

        private static readonly object syncRoot = new Object();

        public static IWebDriver CreateDriver()
        {
            driver = new ChromeDriver();
            return driver;
        }

        public static IWebDriver GetDriverInstance
        {
            get { lock (syncRoot) return driver ?? CreateDriver(); }
            private set { }
        }

        private static WebDriverWait CreateDriverWait()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            return wait;
        }

        public static WebDriverWait GetWaitInstance
        {
            get { lock (syncRoot) return wait ?? CreateDriverWait(); }
            private set { }
        }

        private static log4net.ILog CreateLogger()
        {
            logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            return logger;
        }

        public static log4net.ILog GetLoggerInstance
        {
            get { lock (syncRoot) return logger ?? CreateLogger(); }
            private set { }
        }
    }
}
