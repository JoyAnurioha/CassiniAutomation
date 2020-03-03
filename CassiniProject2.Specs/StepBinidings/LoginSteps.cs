using AventStack.ExtentReports.Gherkin.Model;
using CassiniAutomationProject.Pages;
using CassiniAutomationProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace CassiniProject2.Specs.StepBinidings
{
    [Binding]
    public class LoginSteps : Steps
    {
        private readonly IWebDriver driver;
        private readonly LoginPage loginPage;
        private readonly WelcomePage welcomePage;

        public LoginSteps(IWebDriver webDriver)
        {
            driver = webDriver;
            loginPage = new LoginPage(driver);
            welcomePage = new WelcomePage(driver);
            driver.Manage().Window.Maximize();
        }

        [Given(@"I am on the Login page")]
        public void GivenIAmOnTheLoginPage()
        {
            driver.Navigate().GoToUrl(Utility.URL);
            Assert.IsTrue(driver.PageSource.Contains("Begin your journey"));
        }

        [When(@"I enter correct details and login")]
        public void WhenIEnterCorrectDetailsAndLogin(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.Login(data.email, data.password);
        }

        [Then(@"I should be navigated to the user account page")]
        public void ThenIShouldBeNavigatedToTheUserAccountPage()
        {
            Assert.IsTrue(welcomePage.IsElementPresent(), "The expectect element isn't present on the page");
        }

        [When(@"I enter incorrect login details ""(.*)"" ""(.*)""")]
        public void WhenIEnterIncorrectLoginDetails(string email, string password)
        {
            //Add random number to the email to avoid locking the account after several
            //attempts to login with same incorrect details
            Random rand = new Random();
            int randomNum = rand.Next();
            email = randomNum + email;

            loginPage.Login(email, password);
        }

        [Then(@"I should see an error ""(.*)"" displayed on the page")]
        public void ThenIShouldSeeAnErrorDisplayedOnThePage(string message)
        {
            Assert.IsTrue(driver.PageSource.Contains(message));
        }

        [When(@"I successfully login with my details")]
        [Obsolete]
        public void WhenISuccessfullyLoginWithMyDetails()
        {
            //create column header
            string[] columnHeader = { "email", "password" };
            string[] row = { Utility.Email, Utility.Password };

            var table = new Table(columnHeader);
            table.AddRow(row);

            // Reuse an existing step
            When("I enter correct details and login", table);
        }

        [Then(@"I should be able to logout")]
        public void ThenIShouldBeAbleToLogout()
        {
            welcomePage.VerifyLogout();
            Assert.IsTrue(driver.PageSource.Contains("You have been logged out"));
        }

        [Then(@"I should be able to view my profile")]
        public void ThenIShouldBeAbleToViewMyProfile()
        {
            welcomePage.VerifyMyAccountBtn();
            Assert.IsTrue(driver.PageSource.Contains("Your Profile"));
        }
    }
}
