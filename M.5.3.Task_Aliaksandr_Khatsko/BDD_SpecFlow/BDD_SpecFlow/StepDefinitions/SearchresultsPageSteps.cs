using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            HomePage homePage = new HomePage(driver, wait);
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(homePage.openLable));
            SearchResultsPage srchResultsPage = homePage.SearchByKeys("171617306540");
            srchResultsPage.OpenHatItemPage();
        }

        [Given(@"I navigate to the Item page for the SecondItem")]
        public void GivenINavigateToTheItemPageForTheSecondItem()
        {
            HomePage homePage = new HomePage(driver, wait);
            SearchResultsPage srchResultsPage = homePage.SearchByKeys("122013079618");
            srchResultsPage.OpenScarfItemPage();
        }


    }
}
