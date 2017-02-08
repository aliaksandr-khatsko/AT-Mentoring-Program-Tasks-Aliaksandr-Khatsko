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
            LogInPage logInPage = new LogInPage(driver, wait);
            logInPage.OpenURL();
            HomePage homePage = logInPage.OpenHomePage();
            Assert.Multiple(() =>
            {
                
                Assert.That(homePage.SearchField.Displayed, Is.EqualTo(true), "Search Field is not available");
                Assert.That(homePage.SearchFieldBtn.Displayed, Is.EqualTo(true), "Search Field button is not available");
                Assert.That(homePage.Header.Displayed, Is.EqualTo(true), "Header is not available");
            });
        }

        [Test]
        public void B_Test_GoToSearchPage()
        {
            DynamicWidgetMenu dynamicWidgetMenu = new DynamicWidgetMenu(driver, wait);
            SearchPage searchPage = dynamicWidgetMenu.OpenSearchPage();
            Assert.Multiple(() =>
            {
                Assert.That(searchPage.SearchField.Displayed, Is.EqualTo(true), "Search Field is not available");
                Assert.That(searchPage.SearchButton.Displayed, Is.EqualTo(true), "Search Button is not available");
                Assert.That(searchPage.RefineSearchPanel.Text.Contains("Refine Search"), Is.EqualTo(true), "Refine Search Panel does not contain 'Refine Search' text");
                Assert.That(searchPage.SortingPanel.Displayed, Is.EqualTo(true), "Sorting Panel is not available");
                Assert.That(searchPage.StartOverLink.Displayed, Is.EqualTo(true), "Start Over link is not available");
            });
        }

        [Test]
        public void C_Test_SearchWithQuotes()
        {
            SearchPage searchPage = new SearchPage(driver, wait);
            searchPage.SearhItem();
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(spinner));
            Assert.Multiple(() =>
            {
                Assert.That(searchPage.TestCustomizableBtn.Displayed, Is.EqualTo(true), "Customize button is not available for test template");
                Assert.That(searchPage.Matches.Text.Contains("(1)"), Is.EqualTo(true), "Matches are not equal 1");
            });
        }

        [Test]
        public void D_Test_SaveCustomization()
        {
            SearchPage searchPage = new SearchPage(driver, wait);
            CustomizationPage customizationPage = searchPage.CustomizeOrder();
            wait.Until(ExpectedConditions.ElementIsVisible(inlinePreview));
            customizationPage.ClickNextBtn();
            wait.Until(ExpectedConditions.ElementIsVisible(inlinePreview));
            customizationPage.ClickNextBtn();
            wait.Until(ExpectedConditions.ElementIsVisible(inlinePreview));
            CustomizationPreviewPage customizationPreviewPage = customizationPage.ClickNextBtn();
            CustomizationOrderDetailsPage customizationOrderDetailsPage = customizationPreviewPage.AcceptCustomizationPreview();
            RefText = DateTime.Now.ToString() + "Saved_Order_Name_For_Test";
            customizationOrderDetailsPage.FillInRef(RefText);
            BasketPage basketPage = customizationOrderDetailsPage.SaveCustomization();
            Assert.That(basketPage.ReadyToOrderTable.Text.Contains(RefText), Is.EqualTo(true));
        }

        [Test]
        public void E_Test_OrderFromBusket()
        {
            BasketPage basketPage = new BasketPage(driver, wait);
            ConfirmationPage confirmationPage = basketPage.PlaceOrderLink();
            Assert.Multiple(() =>
            {
                Assert.That(confirmationPage.RefName.Text.Contains(RefText), Is.EqualTo(true), "Reference name for test template is not found");
                Assert.That(confirmationPage.CompletedOrderText.Text.Contains("Completed"), Is.EqualTo(true), "Status is not completed");
                Assert.That(confirmationPage.DownloadNowLink.Displayed, Is.EqualTo(true), "Download link is not available");
            });

        }

    }
}
