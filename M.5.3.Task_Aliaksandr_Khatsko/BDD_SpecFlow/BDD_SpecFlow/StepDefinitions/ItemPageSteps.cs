using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD_SpecFlow.PageObjects
{
    [Binding]
    public class ItemPageSteps : TextFixture
    {
        [Given(@"I set up the quantity (.*)")]
        public void GivenISetUpTheQuantity(string qty)
        {
            ItemPage itemPage = new ItemPage(driver, wait);
            itemPage.FillInQty(qty);
        }

        [Given(@"an item added to watch list")]
        public void GivenAnItemAddedToWatchList()
        {
            HomePage homePage = new HomePage(driver, wait);
            SearchResultsPage srchResultsPage = homePage.SearchByKeys("171617306540");
            ItemPage itemPage = srchResultsPage.OpenHatItemPage();
            itemPage.LookAfterItem();
        }


        [Given(@"I press Add To Cart button on the Item page")]
        public void GivenIPressAddToCartButtonOnTheItemPage()
        {
            ItemPage itemPage = new ItemPage(driver, wait);
            itemPage.AddToCartFromItemPage();
        }

        [When(@"I press Add To Cart button on the Item page")]
        public void WhenIPressAddToCartButtonOnTheItemPage()
        {
            ItemPage itemPage = new ItemPage(driver, wait);
            itemPage.AddToCartFromItemPage();
        }

        [When(@"I press Added To Cart link on the Item page")]
        public void WhenIPressAddedToCartLinkOnTheItemPage()
        {
            ItemPage itemPage = new ItemPage(driver, wait);
            itemPage.NavigateToCartByAddedToCartLink();
        }


    }
}
