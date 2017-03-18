using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD_SpecFlow.StepDefinitions
{
    [Binding]
    public class AddToCartFromWatchPageSpecificSteps:TextFixture
    {
        [When(@"I press Add To Cart button")]
        [Scope(Tag = "WatchPage")]
        public void WhenIPressAddToCartButton()
        {
            WatchPage watch = new WatchPage(driver, wait);
            watch.AddToCartFromWatchPage();
        }
    }
}
