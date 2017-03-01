using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using System.IO;
using System.Configuration;

namespace SeleniumWebDriver
{
    public class BaseFactories<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private static IWebDriver driver;

        private static WebDriverWait wait;

        public static IWebDriver GetDriverInstance()
        {
            if (typeof(TWebDriver) == typeof(FirefoxDriver))
            {
                driver = GetFFDriverInstance;
            }
            else if (typeof(TWebDriver) == typeof(ChromeDriver))
            {
                driver = GetChromeDriverInstance;
            }
            else if (typeof(TWebDriver) == typeof(InternetExplorerDriver))
            {
                driver = GetIEDriverInstance;
            }

            return driver;
        }

        public static IWebDriver CreateChromeDriver()
        {
            driver = new ChromeDriver(@"D:\ATMentoring\AT_Mentoring_Tasks\M.4.2.Task_Aliaksandr_Khatsko\SeleniumWebDriver\packages\Selenium.WebDriver.ChromeDriver.2.27.0\driver\");
            //DesiredCapabilities capability = DesiredCapabilities.Chrome();
            //capability.SetCapability(CapabilityType.BrowserName, "chrome");
            //capability.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            //driver = new RemoteWebDriver(new Uri("http://192.168.1.2:5556/wd/hub"), capability);
            return driver;
        }

        public static IWebDriver GetChromeDriverInstance
        {
            get { return driver ?? CreateChromeDriver(); }
            private set { }
        }

        public static IWebDriver CreateFFDriver()
        {
            //var driverService = FirefoxDriverService.CreateDefaultService();
            //driverService.FirefoxBinaryPath = "C:\\Program Files\\Mozilla Firefox\\firefox.exe";
            //driver = new FirefoxDriver(driverService);
            Environment.SetEnvironmentVariable("webdriver.gecko.driver", @"D:\ATMentoring\AT_Mentoring_Tasks\M.4.3.Task_Aliaksandr_Khatsko\SeleniumWebDriver\SeleniumWebDriver\bin\Debug\wires.exe");
            DesiredCapabilities capability = DesiredCapabilities.Firefox();
            capability.SetCapability(CapabilityType.BrowserName, "firefox");
            capability.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Vista));
            capability.SetCapability("firefox_binary", "C:\\Program Files\\Mozilla Firefox\\firefox.exe");
            driver = new RemoteWebDriver(new Uri("http://192.168.1.2:5557/wd/hub"), capability);

            return driver;
        }

        public static IWebDriver GetFFDriverInstance
        {
            get { return driver ?? CreateFFDriver(); }
            private set { }
        }

        public static IWebDriver CreateIEDriver()
        {
            //InternetExplorerOptions options = new InternetExplorerOptions();
            //options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            //options.InitialBrowserUrl = LogInDetails.URL;
            //driver = new InternetExplorerDriver(options);
            DesiredCapabilities capability = DesiredCapabilities.InternetExplorer();
            capability.SetCapability(CapabilityType.BrowserName, "internet explorer");
            capability.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            capability.SetCapability("initialBrowserUrl", ConfigurationManager.AppSettings["URL"]);
            capability.SetCapability("ignoreProtectedModeSettings", true);
            driver = new RemoteWebDriver(new Uri("http://192.168.1.2:5555/wd/hub"), capability);
            return driver;
        }

        public static IWebDriver GetIEDriverInstance
        {
            get { return driver ?? CreateIEDriver(); }
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
