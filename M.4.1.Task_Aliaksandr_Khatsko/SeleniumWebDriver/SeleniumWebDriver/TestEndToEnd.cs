using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System;
using SeleniumWebDriver.Locators;


namespace SeleniumWebDriver
{
    [TestFixture]
    public class TestEndToEnd:BaseTestClass
    {
        public IWebDriver driver = new ChromeDriver(@"D:\ATMentoring_Tasks_Repositories\Task4\SeleniumWebDriverTask1\packages\Selenium.WebDriver.ChromeDriver.2.27.0\driver\");
        string RefText;
        By spinner = By.CssSelector(".results-loading-spinner");
        By inlinePreview = By.XPath(".//div[@id='studio_inlinepreview_jpeg']/img");


        [Test]
        public void A_Test_LogInToPortal()
        {
            
            LogInPage.LogIn(driver);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(true, driver.FindElement(By.Id(HomePageLocators.searchField_ID)).Displayed);
                Assert.AreEqual(true, driver.FindElement(By.Id(HomePageLocators.searchFieldBtn_ID)).Displayed);
                Assert.AreEqual(true, driver.FindElement(By.XPath(HomePageLocators.searchMenuItem_XPath)).Displayed);
            });
        }

        [Test]
        public void B_Test_GoToSearchPage()
        {
            HomePage.OpenSearchPage(driver);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(true, driver.FindElement(By.Id(SearchPageLocators.searchField_ID)).Displayed);
                Assert.AreEqual(true, driver.FindElement(By.Id(SearchPageLocators.searchBtn_ID)).Displayed);
                Assert.AreEqual(true, driver.FindElement(By.XPath(SearchPageLocators.refineSearchPanel_XPath)).Text.Contains("Refine Search"));
                Assert.AreEqual(true, driver.FindElement(By.XPath(SearchPageLocators.sortingPanel_XPath)).Displayed);
                Assert.AreEqual(true, driver.FindElement(By.XPath(SearchPageLocators.startOverLink_XPath)).Displayed);
            });
        }

        [Test]
        public void C_Test_SearchWithQuotes()
        {
            Searchpage.SearhItem(driver, "'QA Alex AutoTest Please Do Not Delete Or Edit'");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(spinner));
            Assert.Multiple(() =>
            {
                Assert.AreEqual(true, driver.FindElement(By.XPath(SearchPageLocators.testCustomizableBtn_XPath)).Displayed);
                Assert.AreEqual(true, driver.FindElement(By.XPath(SearchPageLocators.matches_XPath)).Text.Contains("(1)"));
            });
        }

        [Test]
        public void D_Test_SaveCustomization()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            SaveOrderCustomization.CustomizeOrder(driver, SearchPageLocators.testCustomizableBtn_XPath);
            wait.Until(ExpectedConditions.ElementIsVisible(inlinePreview));
            SaveOrderCustomization.ClickNextBtn(driver);
            wait.Until(ExpectedConditions.ElementIsVisible(inlinePreview));
            SaveOrderCustomization.ClickNextBtn(driver);
            wait.Until(ExpectedConditions.ElementIsVisible(inlinePreview));
            SaveOrderCustomization.ClickNextBtn(driver);
            SaveOrderCustomization.AcceptCustomizationPreview(driver);
            RefText = DateTime.Now.ToString() + "Saved_Order_Name_For_Test";
            SaveOrderCustomization.FillInRef(driver, RefText);
            SaveOrderCustomization.SaveOrder(driver);
            Assert.AreEqual(true, driver.FindElement(By.XPath(BasketLocators.readyToOrderTable_XPath)).Text.Contains(RefText));
        }

        [Test]
        public void E_Test_OrderFromBusket()
        {
            BasketPage.PlaceOrderLink(driver);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(true, driver.FindElement(By.XPath(ConfirmationPageLocators.refName_XPath)).Text.Contains(RefText));
                Assert.AreEqual(true, driver.FindElement(By.XPath(ConfirmationPageLocators.completedOrderText_XPath)).Text.Contains("Completed"));
                Assert.AreEqual(true, driver.FindElement(By.XPath(ConfirmationPageLocators.downloadNowLink_XPath)).Displayed);
            });

            driver.Close();
        }

    }
}
