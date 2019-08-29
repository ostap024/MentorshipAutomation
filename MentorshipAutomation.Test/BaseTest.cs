using System;
using System.Collections.Generic;
using System.Text;
using MentorshipAutomation.Base;
using NUnit.Framework;

namespace MentorshipAutomation.Test
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            WebDriver.GetDriver().Manage().Window.Maximize();
            WebDriver.GetDriver().Navigate().GoToUrl(TestConstants.BaseUrl);
            WebDriver.GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            WebDriver.Reset();
        }
    }
}
