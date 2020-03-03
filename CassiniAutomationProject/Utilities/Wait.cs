using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace CassiniAutomationProject.Utilities
{
    public class Wait
    {
        public static void WaitTillElementIsVisible(IWebDriver driver, By elementLocator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(elementLocator));
        }

        public static void WaitTillElementIsClickable(IWebDriver driver, By elementLocator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elementLocator));
        }
    }
}
