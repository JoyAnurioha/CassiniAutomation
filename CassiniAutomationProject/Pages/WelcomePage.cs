using CassiniAutomationProject.Utilities;
using OpenQA.Selenium;
using System;

namespace CassiniAutomationProject.Pages
{
    public class WelcomePage
    {
        private IWebDriver webDriver;

        //Locators
        private By myAccountBtn = By.XPath("//*[@id='root']/div/div[1]/div/div/div[2]/div/div/button[1]/span[2]");

        private By logoutBtn = By.XPath("//*[@id='root']/div/div[1]/div/div/div[2]/div/div/button[2]/span");

        private By pageTitle = By.XPath("//h1[text()='Welcome to Ieso']");
        private By pageHeader = By.XPath("//h3[text()='Ieso online therapy is free on the NHS']");


        public WelcomePage(IWebDriver driver)
        {
            webDriver = driver;
        }


        public void VerifyLogout()
        {
            webDriver.FindElement(logoutBtn).Click();           
        }

        public void VerifyMyAccountBtn()
        {
            webDriver.FindElement(myAccountBtn).Click();
        }

        public bool IsElementPresent()
        {
            try
            {
                Wait.WaitTillElementIsVisible(webDriver, pageTitle);
                Wait.WaitTillElementIsVisible(webDriver, pageHeader);
                webDriver.FindElement(pageTitle);
                webDriver.FindElement(pageHeader);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }
    }
}
