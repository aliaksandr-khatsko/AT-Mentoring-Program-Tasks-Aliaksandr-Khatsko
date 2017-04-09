using System;
using BDD_SpecFlow.PageObjects;
using BDD_SpecFlow.Utils;
using TechTalk.SpecFlow;


namespace BDD_SpecFlow.StepDefinitions
{
    [Binding]
    public class BackGroundSteps:TextFixture
    {


        [Given(@"I logged in as a user")]
        public void GivenILoggedInAsAUser()
        {
            try
            {
                GlobalPage globalPage = new GlobalPage(driver, wait);
                globalPage.OpenURL();
                LogInPage logInPage = globalPage.OpenLogInPage();
                logInPage.OpenHomePage(new User());
            }
            catch (Exception ex)
            {
                logger.Error("[Given I logged in as a user] step is failed", ex);
                ScreenShotTaker.TakeScreenshot(driver);
            }
            
        }

        [Given(@"Cart is empty")]
        public void GivenCartIsEmpty()
        {
            try
            {
                WebElementChecker checker = new WebElementChecker();
                Header header = new Header(driver, wait);
                CartPage cartPage = header.OpenToCartPage();
                if (checker.IsElementPresented(cartPage.DeleteLinkTestHat))
                {
                    cartPage.DeleteHatFromCart();
                }
                else if (checker.IsElementPresented(cartPage.DeleteLinkTestScarf))
                {
                    cartPage.DeleteScarfFromCart();
                }
            }
            catch (Exception ex)
            {
                logger.Error("[Given Cart is empty] step is failed", ex);
                ScreenShotTaker.TakeScreenshot(driver);
            }
            
        }

        [Given(@"Watch list is empty")]
        public void GivenWatchListIsEmpty()
        {
            try
            {
                WebElementChecker checker = new WebElementChecker();
                Header header = new Header(driver, wait);
                WatchPage watchPage = header.OpenToWatchPage();
                if (checker.IsElementPresented(watchPage.SelectAllCheckBox))
                {
                    watchPage.DeleteAllItemsFromWatch();
                }
            }
            catch (Exception ex)
            {
                logger.Error("[Given Watch list is empty] step is failed", ex);
                ScreenShotTaker.TakeScreenshot(driver);
            }
            
        }

    }
}
