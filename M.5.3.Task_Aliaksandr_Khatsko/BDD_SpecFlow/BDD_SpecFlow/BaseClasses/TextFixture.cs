using System;
using System.Threading;
using BDD_SpecFlow.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace BDD_SpecFlow
{
    [Binding]
    public class TextFixture:BaseFactories
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = GetDriverInstance;
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            wait = GetWaitInstance;
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
