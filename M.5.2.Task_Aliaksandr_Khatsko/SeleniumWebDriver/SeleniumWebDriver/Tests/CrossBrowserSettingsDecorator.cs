using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System;
using OpenQA.Selenium.IE;

namespace SeleniumWebDriver
{
    //[TestFixture(typeof(FirefoxDriver))]
    [TestFixture(typeof(ChromeDriver))]
    //[TestFixture(typeof(InternetExplorerDriver))]
    [Parallelizable]
    public class BaseTestClass<TWebDriver> : BaseFactories<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;

        [OneTimeSetUp]
        public static void SetUpTestRun()
        {
            driver = GetDriverInstance();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            wait = GetWaitInstance;
        }

        [SetUp]
        public static void SetUpTest()
        {
            Console.WriteLine("Test Initialize");
        }

        [TearDown]
        public static void TearDownTest()
        {
            Console.WriteLine("Test TearDown");
        }

        [OneTimeTearDown]
        public static void TearDownTests()
        {
            driver.Close();
        }

    }
}
