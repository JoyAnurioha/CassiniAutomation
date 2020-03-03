using CassiniAutomationProject.Utilities;
using OpenQA.Selenium;
using System.Threading;

namespace CassiniAutomationProject.Pages
{
    public class RegisterPage
    {
        private readonly IWebDriver webDriver;

        //Locators
        private By emailAddressTextField = By.Id("email");

        private By passwordTextField = By.Id("password");

        private By privacyPolicy = By.CssSelector("input[type='checkbox']");

        private By registerButton = By.CssSelector("button[type='button']");

        public RegisterPage(IWebDriver driver)
        {
            webDriver = driver;
        }


        public void GoTo()
        {
            HomePage.Register();
        }

        public void RegisterNewUser(string email, string password, bool selectPrivacyPolicy = true)
        {
            Wait.WaitTillElementIsVisible(webDriver, emailAddressTextField);
            Wait.WaitTillElementIsVisible(webDriver, passwordTextField);
            Wait.WaitTillElementIsClickable(webDriver, registerButton);

            webDriver.FindElement(emailAddressTextField).SendKeys(email);
            webDriver.FindElement(passwordTextField).SendKeys(password);

            if (selectPrivacyPolicy) webDriver.FindElement(privacyPolicy).Click();

            webDriver.FindElement(registerButton).Click();

            // Wait for the new page to load after the click action
            Thread.Sleep(5000);
        }

    }
}

