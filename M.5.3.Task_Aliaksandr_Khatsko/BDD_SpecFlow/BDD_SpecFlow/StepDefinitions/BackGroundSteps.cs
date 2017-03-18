using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            GlobalPage globalPage = new GlobalPage(driver, wait);
            globalPage.OpenURL();
            LogInPage logInPage = globalPage.OpenLogInPage();
            logInPage.OpenHomePage(new User());
        }

        [Given(@"Cart is empty")]
        public void GivenCartIsEmpty()
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

        [Given(@"Watch list is empty")]
        public void GivenWatchListIsEmpty()
        {
            WebElementChecker checker = new WebElementChecker();
            Header header = new Header(driver, wait);
            WatchPage watchPage = header.OpenToWatchPage();
            if (checker.IsElementPresented(watchPage.SelectAllCheckBox))
            {
                watchPage.DeleteAllItemsFromWatch();
            }
        }

    }
}
