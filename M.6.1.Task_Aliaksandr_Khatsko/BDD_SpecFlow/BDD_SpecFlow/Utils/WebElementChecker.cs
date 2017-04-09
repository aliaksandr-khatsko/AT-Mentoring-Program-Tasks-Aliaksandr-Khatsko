using OpenQA.Selenium;

namespace BDD_SpecFlow.Utils
{
    public class WebElementChecker
    {
        public bool IsElementPresented(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
