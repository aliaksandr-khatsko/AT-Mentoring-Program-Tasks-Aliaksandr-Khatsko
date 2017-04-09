using System;
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
                try
                {
                    WatchPage watch = new WatchPage(driver, wait);
                    watch.AddToCartFromWatchPage();
                }
                catch (Exception ex)
                {
                    logger.Error("[When I press Add To Cart button] step is failed", ex);
                    ScreenShotTaker.TakeScreenshot(driver);
                }
                
            }

            
    }
}
