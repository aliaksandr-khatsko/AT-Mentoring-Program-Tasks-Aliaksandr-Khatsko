using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDD_SpecFlow.PageObjects;
using BDD_SpecFlow.Utils;
using TechTalk.SpecFlow;

namespace BDD_SpecFlow
{
    [Binding]
    public class CartPageSteps:TextFixture
    {
        

        [Then(@"the item should be added to cart with correct quantity (.*)")]
        public void ThenTheItemShouldBeAddedToCartWithCorrectQuantity(string qty)
        {
            CartPage cartPage = new CartPage(driver, wait);
            if (cartPage.HatItemQty.GetAttribute("value") == qty)
            {
                Console.WriteLine("Test PASSED: Item has been added to Cart with correct quantity");
            }
            else
            {
                Console.WriteLine("QTY is not equal {0} text", qty);
                throw new Exception("Test FAILED");
            }
        }

        [Then(@"the SecondItem should be added to cart")]
        public void ThenTheSecondItemShouldBeAddedToCart()
        {
            WebElementChecker checker = new WebElementChecker();
            CartPage cartPage = new CartPage(driver, wait);
            if (checker.IsElementPresented(cartPage.ScarfItemTitle))
            {
                Console.WriteLine("Test PASSED: Scarf item has been added to Cart");
            }
            else
            {
                Console.WriteLine("Scarf item is not available on the Cart page");
                throw new Exception("Test FAILED");
            }
        }

        [Then(@"the FirstItem should be added to cart")]
        public void ThenTheFirstItemShouldBeAddedToCart()
        {
            WebElementChecker checker = new WebElementChecker();
            CartPage cartPage = new CartPage(driver, wait);
            if (checker.IsElementPresented(cartPage.HatItemTitle))
            {
                Console.WriteLine("Test PASSED: Hat item has been added to Cart");
            }
            else
            {
                Console.WriteLine("Hat item is not available on the Cart page");
                throw new Exception("Test FAILED");
            }
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

    }
}
