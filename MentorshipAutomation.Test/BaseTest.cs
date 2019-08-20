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
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            WebDriver.Reset();
        }
    }
}
