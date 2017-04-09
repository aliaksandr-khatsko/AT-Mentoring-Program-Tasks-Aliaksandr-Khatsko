using System;
using BDD_SpecFlow.PageObjects;
using BDD_SpecFlow.Utils;
using TechTalk.SpecFlow;


namespace BDD_SpecFlow.StepDefinitions
{
    [Binding]
    public class MenuNavigationSteps : TextFixture
    {

        [Given(@"I navigate to the the Watch page")]
        public void GivenINavigateToTheTheWatchPage()
        {
            try
            {
                Header header = new Header(driver, wait);
                header.OpenToWatchPage();
            }
            catch (Exception ex)
            {
                logger.Error("[Given I navigate to the the Watch page] step is failed", ex);
                ScreenShotTaker.TakeScreenshot(driver);
            }
            
        }

    }
}
