using System;
using System.Collections.Generic;
using System.Linq;
using BDD_SpecFlow.PageObjects;
using TechTalk.SpecFlow;

namespace BDD_SpecFlow.StepDefinitions
{
    [Binding]
    public class MenuNavigationSteps : TextFixture
    {

        [Given(@"I navigate to the the Watch page")]
        public void GivenINavigateToTheTheWatchPage()
        {
            Header header = new Header(driver, wait);
            header.OpenToWatchPage();
        }

    }
}
