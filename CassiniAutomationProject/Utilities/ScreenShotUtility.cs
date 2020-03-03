using OpenQA.Selenium;
using System;

namespace CassiniAutomationProject.Utilities
{
    public class ScreenShotUtility
    {

        public static string CaptureScreenshot(IWebDriver driver, String screenshotName, bool scenarioScreenshots = true)
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string screenshotPath;

            if (scenarioScreenshots)
            {
                screenshotPath = projectPath + "ErrorScreenshots\\";
            }

            else
            {
                screenshotPath = projectPath + "Screenshots\\";
            }

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            var fileName = screenshotName + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss") + ".png";

            try
            {
                screenShot.SaveAsFile(screenshotPath + fileName, ScreenshotImageFormat.Png);
                Console.WriteLine("Screenshot taken");
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error while taking screenshot" + e.Message);
            }

            return fileName;
        }

    }
}
