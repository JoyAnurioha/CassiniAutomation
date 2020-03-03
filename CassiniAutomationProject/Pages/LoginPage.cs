using CassiniAutomationProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace CassiniAutomationProject.Pages
{
    public class LoginPage
   {

        private readonly IWebDriver webDriver;

        //Locators
        private By emailAddressTextField = By.Id("email");

        private By passwordTextField = By.Id("password");

        private By privacyPolicy = By.CssSelector("input[type='checkbox']");

        private By logInButton = By.CssSelector("button[type='submit']");

        private By pageTitle = By.CssSelector("h3[class='main-title']");

        public LoginPage(IWebDriver driver)
        {
            webDriver = driver;
        }     

        public void Login(string email, string password)
        {
            Wait.WaitTillElementIsVisible(webDriver, emailAddressTextField);
            Wait.WaitTillElementIsVisible(webDriver, passwordTextField);
            Wait.WaitTillElementIsClickable(webDriver, logInButton);

            webDriver.FindElement(emailAddressTextField).SendKeys(email);
            webDriver.FindElement(passwordTextField).SendKeys(password);
            webDriver.FindElement(logInButton).Click();

            // Wait for the new page to load after the click action
            Thread.Sleep(5000);
        }

        public void ResetPassword()
        { }
        
        public void ToggleRememberMe()
        { }
    }
}
