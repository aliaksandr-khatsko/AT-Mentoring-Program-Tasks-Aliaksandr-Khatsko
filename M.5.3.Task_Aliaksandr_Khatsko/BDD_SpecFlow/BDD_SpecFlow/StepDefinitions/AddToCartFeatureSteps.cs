using System;
using System.Collections;
using System.Threading;
using BDD_SpecFlow.PageObjects;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist.ValueRetrievers;

namespace BDD_SpecFlow
{
    [Binding]
    public class AddToCartFeatureSteps:TextFixture
    {
        [Given(@"I logged in as a user")]
        public void GivenILoggedInAsAUser()
        {
            GlobalPage globalPage = new GlobalPage(driver, wait);
            globalPage.OpenURL();
            LogInPage logInPage = globalPage.OpenLogInPage();
            logInPage.OpenHomePage(new User());
        }


        [Given(@"I am on the Item page for the FirstItem")]
        public void GivenIAmOnTheItemPageForTheFirstItem()
        {
            HomePage homePage = new HomePage(driver, wait);
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(homePage.openLable));
            SearchResultsPage srchResultsPage = homePage.SearchByKeys("171617306540");
            srchResultsPage.OpenHatItemPage();
        }

        [When(@"I press Add To Cart button")]
        [Scope(Tag = "ItemPage")]
        public void WhenIPressAddToCartButton()
        {
            ItemPage itemPage = new ItemPage(driver, wait);
            itemPage.AddToCartFromItemPage();
        }

        [Then(@"the Cart page should be opened")]
        public void ThenTheCartPageShouldBeOpened()
        {
            CartPage cartPage = new CartPage(driver, wait);
            if (cartPage.Header.Text.Contains("Ваша корзина"))
            {
                Console.WriteLine("Cart page is opened");
            }
            else
            {
                Console.WriteLine("Test FAILED: Cart page is NOT opened");
            }
            
        }

        [Then(@"the FirstItem should be added to cart")]
        public void ThenTheFirstItemShouldBeAddedToCart()
        {
            CartPage cartPage = new CartPage(driver, wait);
            if (cartPage.HatItemTitle.Displayed)
            {
                Console.WriteLine("Test PASSED: Hat item has been added to Cart");
            }
            else
            {
                Console.WriteLine("Hat item is not available on the Cart page");
                throw new Exception("Test FAILED");
            }
            
        }

        [Then(@"the SecondItem should be added to cart")]
        public void ThenTheSecondItemShouldBeAddedToCart()
        {
            CartPage cartPage = new CartPage(driver, wait);
            if (cartPage.ScarfItemTitle.Displayed)
            {
                Console.WriteLine("Test PASSED: Scarf item has been added to Cart");
            }
            else
            {
                Console.WriteLine("Scarf item is not available on the Cart page");
                throw new Exception("Test FAILED");
            }

        }


        [Given(@"FirstItem is already added to cart")]
        public void GivenFirstItemIsAlreadyAddedToCart()
        {
            HomePage homePage = new HomePage(driver, wait);
            SearchResultsPage srchResultsPage = homePage.SearchByKeys("171617306540");
            ItemPage itemPage = srchResultsPage.OpenHatItemPage();
            itemPage.AddToCartFromItemPage();
        }

        [Given(@"I am on the Item page for the SecondItem")]
        public void GivenIAmOnTheItemPageForTheSecondItem()
        {
            HomePage homePage = new HomePage(driver, wait);
            SearchResultsPage srchResultsPage = homePage.SearchByKeys("122013079618");
            srchResultsPage.OpenScarfItemPage();
        }

        [Given(@"an item added to watch list")]
        public void GivenAnItemAddedToWatchList()
        {
            HomePage homePage = new HomePage(driver, wait);
            SearchResultsPage srchResultsPage = homePage.SearchByKeys("171617306540");
            ItemPage itemPage = srchResultsPage.OpenHatItemPage();
            itemPage.LookAfterItem();
        }

       [Given(@"I am on the Watch page")]
        public void GivenIAmOnTheWatchPage()
        {
            Header header = new Header(driver, wait);
            header.OpenToWatchPage();
        }

        [When(@"I press Added To Cart link")]
        public void WhenIPressAddedToCartLink()
        {
            ItemPage itemPage = new ItemPage(driver, wait);
            itemPage.NavigateToCartByAddedToCartLink();
        }

        [Given(@"I set up the quantity (.*)")]
        public void GivenISetUpTheQuantity(string qty)
        {
            ItemPage itemPage = new ItemPage(driver, wait);
            itemPage.FillInQty(qty);
        }

        [Then(@"the item should be added to cart with correct quantity (.*)")]
        public void ThenTheItemShouldBeAddedToCartWithCorrectQuantity(string qty)
        {
            CartPage cartPage = new CartPage(driver, wait);
            if (cartPage.HatItemQty.GetAttribute("value")==qty)
            {
                Console.WriteLine("Test PASSED: Item has been added to Cart with correct quantity");
            }
            else
            {
                Console.WriteLine("QTY is not equal {0} text", qty);
                throw new Exception("Test FAILED");
            }
         }

        [Given(@"Cart is empty")]
        public void GivenCartIsEmpty()
        {
            Header header = new Header(driver, wait);
            CartPage cartPage = header.OpenToCartPage();
            bool var1 = cartPage.DeleteLinkTestHat.Displayed;
            try
            {
                switch (var1)
                {
                    case false:
                        break;
                    case true:
                        cartPage.DeleteHatFromCart();
                        break;
                }
            }
            catch (NoSuchElementException)
            {
                
            }
            

           

            bool var2 = cartPage.DeleteLinkTestScarf.Displayed;
            try
            {
                switch (var2)
                {
                    case false:
                        break;
                    case true:
                        cartPage.DeleteScarfFromCart();
                        break;
                    default:
                        break;
                }
            }
            catch (NoSuchElementException)
            {
                
            }
            


            //if (!cartPage.EmptyCart.Text.Contains("Ваша корзина пуста, но вы можете положить в нее какой-нибудь товар."))
            //{
            //    cartPage.DeleteScarfFromCart();
            //}

        }

        [Given(@"Watch list is empty")]
        public void GivenWatchListIsEmpty()
        {
            Header header = new Header(driver, wait);
            WatchPage watchPage = header.OpenToWatchPage();
            bool var = watchPage.WatchListSubTitle.Text.Contains("В списке отслеживания нет сохраненных товаров.");
            switch (var)
            {
                case false:
                    watchPage.DeleteAllItemsFromWatch();
                    break;
                case true:
                    break;
                default:
                    break;
            }
        }


        
    }
}
