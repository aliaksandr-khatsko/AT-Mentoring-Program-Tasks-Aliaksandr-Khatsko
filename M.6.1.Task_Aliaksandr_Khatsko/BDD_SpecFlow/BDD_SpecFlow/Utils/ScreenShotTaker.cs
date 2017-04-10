using System;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System.IO;

namespace BDD_SpecFlow.Utils
{
    public class ScreenShotTaker:TextFixture
    {
        public static void TakeScreenshot(IWebDriver driver)
        {
            Screenshot source = ((ITakesScreenshot)driver).GetScreenshot();
            string fileName = DateTime.Now.ToString("yyyy-MM-dd hh_mm_ss") + ".png";
            string screenshotPath = Path.Combine(Environment.CurrentDirectory, @"BDD_SpecFlow\Screenshots\", fileName);
            try
            {

                source.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
                
            }
            catch (Exception ex)
            {
                logger.Error("Screenshot is not created", ex);
            }

            logger.Info("Screenshot is saved in the ../../Screenshots");

        }
        
    }
}
