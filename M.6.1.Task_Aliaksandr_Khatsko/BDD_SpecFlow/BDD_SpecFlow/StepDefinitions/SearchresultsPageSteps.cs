using System;
using BDD_SpecFlow.Utils;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace BDD_SpecFlow.StepDefinitions
{
    [Binding]
    public class SearchresultsPageSteps:TextFixture
    {
        [Given(@"I navigate to the Item page for the FirstItem")]
        public void GivenINavigateTheItemPageForTheFirstItem()
        {
            try
            {
                HomePage homePage = new HomePage(driver, wait);
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(homePage.openLable));
                SearchResultsPage srchResultsPage = homePage.SearchByKeys("171617306540");
                srchResultsPage.OpenHatItemPage();
            }
            catch (Exception ex)
            {
                logger.Error("[Given I navigate to the Item page for the FirstItem] step is failed", ex);
                ScreenShotTaker.TakeScreenshot(driver);
            }
            
        }

        [Given(@"I navigate to the Item page for the SecondItem")]
        public void GivenINavigateToTheItemPageForTheSecondItem()
        {
            try
            {
                HomePage homePage = new HomePage(driver, wait);
                SearchResultsPage srchResultsPage = homePage.SearchByKeys("122013079618");
                srchResultsPage.OpenScarfItemPage();
            }
            catch (Exception ex)
            {
                logger.Error("[Given I navigate to the Item page for the SecondItem] step is failed", ex);
                ScreenShotTaker.TakeScreenshot(driver);
            }
            
        }


    }
}
