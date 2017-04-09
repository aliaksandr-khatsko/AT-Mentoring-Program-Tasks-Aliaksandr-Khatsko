using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace BDD_SpecFlow
{
    [Binding]
    public class TextFixture
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;
        public static log4net.ILog logger;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = BaseFactories.GetDriverInstance;
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            wait = BaseFactories.GetWaitInstance;
            logger = BaseFactories.GetLoggerInstance;
        }
        
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            driver.Quit();
        }

    }
}
