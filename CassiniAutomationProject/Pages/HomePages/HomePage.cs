using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CassiniAutomationProject.Pages
{
    public static class HomePage
    {

        [FindsBy(How = How.CssSelector, Using = "a[data-eventaction='Register'")]
        private static readonly IWebElement registerLink;

        public static void Register()
        {
            registerLink.Click();
        }

        public static void AboutUs()
        {

        }

        public static void ContactUs()
        {

        }
    }
}
