using System;
using System.Collections.Generic;
using System.Text;
using MentorshipAutomation.Base;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MentorshipAutomation.Test
{
    public class BaseTest
    {
        protected Driver Driver => DriverManager.Current;

        [OneTimeSetUp]
        public void SetUp()
        {
            DriverManager.Current = Driver.GetFor(BrowserType.Chrome);
            Driver.MaximizeWindow();
            Driver.GoToUrl(TestConstants.BaseUrl);
           // WebDriver.GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
