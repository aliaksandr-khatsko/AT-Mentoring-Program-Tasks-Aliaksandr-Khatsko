using System;
using BDD_SpecFlow.Utils;
using TechTalk.SpecFlow;


namespace BDD_SpecFlow.PageObjects
{
    [Binding]
    public class ItemPageSteps : TextFixture
    {
        [Given(@"I set up the quantity (.*)")]
        public void GivenISetUpTheQuantity(string qty)
        {
            try
            {
                ItemPage itemPage = new ItemPage(driver, wait);
                itemPage.FillInQty(qty);
            }
            catch (Exception ex)
            {
                logger.Error("[Given I set up the quantity] step is failed", ex);
                ScreenShotTaker.TakeScreenshot(driver);
            }
            
        }

        [Given(@"an item added to watch list")]
        public void GivenAnItemAddedToWatchList()
        {
            try
            {
                HomePage homePage = new HomePage(driver, wait);
                SearchResultsPage srchResultsPage = homePage.SearchByKeys("171617306540");
                ItemPage itemPage = srchResultsPage.OpenHatItemPage();
                itemPage.LookAfterItem();
            }
            catch (Exception ex)
            {
                logger.Error("[Given an item added to watch list] step is failed", ex);
                ScreenShotTaker.TakeScreenshot(driver);
            }
            
        }


        [Given(@"I press Add To Cart button on the Item page")]
        public void GivenIPressAddToCartButtonOnTheItemPage()
        {
            try
            {
                ItemPage itemPage = new ItemPage(driver, wait);
                itemPage.AddToCartFromItemPage();
            }
            catch (Exception ex)
            {
                logger.Error("[Given I press Add To Cart button on the Item page] step is failed", ex);
                ScreenShotTaker.TakeScreenshot(driver);
            }
            
        }

        [When(@"I press Add To Cart button on the Item page")]
        public void WhenIPressAddToCartButtonOnTheItemPage()
        {
            try
            {
                ItemPage itemPage = new ItemPage(driver, wait);
                itemPage.AddToCartFromItemPage();
            }
            catch (Exception ex)
            {
                logger.Error("[When I press Add To Cart button on the Item page] step is failed", ex);
                ScreenShotTaker.TakeScreenshot(driver);
            }

        }

        [When(@"I press Added To Cart link on the Item page")]
        public void WhenIPressAddedToCartLinkOnTheItemPage()
        {
            try
            {
                ItemPage itemPage = new ItemPage(driver, wait);
                itemPage.NavigateToCartByAddedToCartLink();
            }
            catch (Exception ex)
            {
                logger.Error("[When I press Added To Cart link on the Item page] step is failed", ex);
                ScreenShotTaker.TakeScreenshot(driver);
            }
            
        }


    }
}
