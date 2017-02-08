using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumWebDriver
{
    [TestFixture]
    public class TestEndToEnd:BaseTestClass
    {
        
        string RefText;
        By spinner = By.CssSelector(".results-loading-spinner");
        By inlinePreview = By.XPath(".//div[@id='studio_inlinepreview_jpeg']/img");


        [Test]
        public void A_Test_LogInToPortal()
        {
            //driver = new ChromeDriver(@"D:\ATMentoring\AT_Mentoring_Tasks\M.4.2.Task_Aliaksandr_Khatsko\SeleniumWebDriver\packages\Selenium.WebDriver.ChromeDriver.2.27.0\driver\");
                        
            LogInPage logInPage = new LogInPage(driver);
            logInPage.OpenURL();
            HomePage homePage = logInPage.OpenHomePage();
            Assert.Multiple(() =>
            {
                
                Assert.That(homePage.SearchField.Displayed, Is.EqualTo(true));
                Assert.That(homePage.SearchFieldBtn.Displayed, Is.EqualTo(true));
                Assert.That(homePage.Header.Displayed, Is.EqualTo(true));
            });
        }

        [Test]
        public void B_Test_GoToSearchPage()
        {
            DynamicWidgetMenu dynamicWidgetMenu = new DynamicWidgetMenu(driver);
            dynamicWidgetMenu.OpenSearchPage();
            SearchPage searchPage = new SearchPage(driver);
            Assert.Multiple(() =>
            {
                Assert.That(searchPage.SearchField.Displayed, Is.EqualTo(true));
                Assert.That(searchPage.SearchButton.Displayed, Is.EqualTo(true));
                Assert.That(searchPage.RefineSearchPanel.Text.Contains("Refine Search"), Is.EqualTo(true));
                Assert.That(searchPage.SortingPanel.Displayed, Is.EqualTo(true));
                Assert.That(searchPage.StartOverLink.Displayed, Is.EqualTo(true));
            });
        }

        [Test]
        public void C_Test_SearchWithQuotes()
        {
            SearchPage searchPage = new SearchPage(driver);
            searchPage.SearhItem();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(spinner));
            Assert.Multiple(() =>
            {
                Assert.That(searchPage.TestCustomizableBtn.Displayed, Is.EqualTo(true));
                Assert.That(searchPage.Matches.Text.Contains("(1)"), Is.EqualTo(true));
            });
        }

        [Test]
        public void D_Test_SaveCustomization()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            SearchPage searchPage = new SearchPage(driver);
            CustomizationPage customizationPage = new CustomizationPage(driver);
            CustomizationPreviewPage customizationPreviewPage = new CustomizationPreviewPage(driver);
            CustomizationOrderDetailsPage customizationOrderDetailsPage = new CustomizationOrderDetailsPage(driver);
            BasketPage basketPage = new BasketPage(driver);
            searchPage.CustomizeOrder();
            wait.Until(ExpectedConditions.ElementIsVisible(inlinePreview));
            customizationPage.ClickNextBtn();
            wait.Until(ExpectedConditions.ElementIsVisible(inlinePreview));
            customizationPage.ClickNextBtn();
            wait.Until(ExpectedConditions.ElementIsVisible(inlinePreview));
            customizationPage.ClickNextBtn();
            customizationPreviewPage.AcceptCustomizationPreview();
            RefText = DateTime.Now.ToString() + "Saved_Order_Name_For_Test";
            customizationOrderDetailsPage.FillInRef(RefText);
            customizationOrderDetailsPage.SaveCustomization();
            Assert.That(basketPage.ReadyToOrderTable.Text.Contains(RefText), Is.EqualTo(true));
        }

        [Test]
        public void E_Test_OrderFromBusket()
        {
            BasketPage basketPage = new BasketPage(driver);
            ConfirmationPage confirmationPage = new ConfirmationPage(driver);
            basketPage.PlaceOrderLink();
            Assert.Multiple(() =>
            {
                Assert.That(confirmationPage.RefName.Text.Contains(RefText), Is.EqualTo(true));
                Assert.That(confirmationPage.CompletedOrderText.Text.Contains("Completed"), Is.EqualTo(true));
                Assert.That(confirmationPage.DownloadNowLink.Displayed, Is.EqualTo(true));
            });

            driver.Close();
        }

    }
}
