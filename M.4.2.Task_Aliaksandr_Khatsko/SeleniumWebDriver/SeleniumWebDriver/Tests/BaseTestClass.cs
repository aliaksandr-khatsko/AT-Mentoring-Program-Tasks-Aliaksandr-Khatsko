using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System;

namespace SeleniumWebDriver
{
    [TestFixture]
    public class BaseTestClass
    {
        public static IWebDriver driver;

        //[OneTimeSetUp]
        //public static void SetUpTestRun()
        //{
        //    driver = BasePage.GetDriverInstance;
        //}

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
               
    }
}
