using System.Linq;
using MentorshipAutomation.Base;
using MentorshipAutomation.PageObjects;
using MentorshipAutomation.PageObjects.Pages;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;

namespace MentorshipAutomation.Test
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void SuccessLoginTest()
        {
            var page = new BasePage();
            page = page.GoToLoginPage()
                .Login("johnwick322@gmail.com", "qwerty");
            Assert.That(page.PageTitle, Is.EqualTo("My account - My Store"));
        }
    }
}