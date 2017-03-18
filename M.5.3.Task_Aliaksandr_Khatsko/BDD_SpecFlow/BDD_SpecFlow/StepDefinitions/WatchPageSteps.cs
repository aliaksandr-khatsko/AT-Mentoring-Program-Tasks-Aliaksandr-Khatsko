using BDD_SpecFlow.PageObjects;
using BDD_SpecFlow.Utils;
using TechTalk.SpecFlow;

namespace BDD_SpecFlow.StepDefinitions
{
    [Binding]
    public class WatchPageSteps : TextFixture
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
