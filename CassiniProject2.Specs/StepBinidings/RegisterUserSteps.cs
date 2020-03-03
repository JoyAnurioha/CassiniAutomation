using CassiniAutomationProject.Pages;
using CassiniAutomationProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace CassiniProject2.Specs.StepBinidings
{
    [Binding]
    public class RegisterUserSteps
    {
        private readonly IWebDriver driver;
        private readonly RegisterPage regPage;
        private readonly WelcomePage welcomePage;

        public RegisterUserSteps(IWebDriver webDriver)
        {
            driver = webDriver;
            driver.Manage().Window.Maximize();
            regPage = new RegisterPage(driver);
            welcomePage = new WelcomePage(driver);
        }

        [Given(@"I am on the Registration page")]
        public void GivenIAmOnTheRegistrationPage()
        {
            driver.Navigate().GoToUrl(Utility.URL);
            Assert.IsTrue(driver.Title.Contains("Sign In"), "The title of the page does not contain the expected text");
        }

        [When(@"I enter correct email format and password '(.*)' and signup")]
        public void WhenIEnterCorrectEmailFormatAndPasswordAndSignup(string password)
        {
            var email = Utility.GenerateEmail();
            regPage.RegisterNewUser(email, password);
        }

        [Then(@"I should be navigated to the Welcome page")]
        public void ThenIShouldBeNavigatedToTheWelcomePage()
        {
            Assert.IsTrue(welcomePage.IsElementPresent(), "The expected elements are not present on the page");
        }

        [When(@"I enter incorrect ""(.*)"" and incorrect ""(.*)"" and signup")]
        public void WhenIEnterIncorrectAndIncorrectAndSignup(string email, string password)
        {
            regPage.RegisterNewUser(email, password);
        }

        [Then(@"I should see error ""(.*)"" displayed on the page")]
        public void ThenIShouldSeeErrorDisplayedOnThePage(string message)
        {
            Assert.IsTrue(driver.PageSource.Contains(message));
        }

        [When(@"I enter correct email format and password ""(.*)"" without accepting privacy policy")]
        public void WhenIEnterCorrectEmailFormatAndPasswordWithoutAcceptingPrivacyPolicy(string password)
        {
            var email = Utility.GenerateEmail();
            regPage.RegisterNewUser(email, password, selectPrivacyPolicy: false);
        }

        [Then(@"I should see ""(.*)"" displayed on the page")]
        public void ThenIShouldSeeDisplayedOnThePage(string message)
        {
            Assert.IsTrue(driver.PageSource.Contains(message));
        }

        [When(@"I enter existing user details ""(.*)"" ""(.*)"" and signup")]
        public void WhenIEnterExistingUserDetailsAndSignup(string email, string password)
        {
            regPage.RegisterNewUser(email, password);
        }

        [Then(@"I should see the message ""(.*)"" displayed on the page")]
        public void ThenIShouldSeeTheMessageDisplayedOnThePage(string message)
        {
            Assert.IsTrue(driver.PageSource.Contains(message));
        }
    }
}
