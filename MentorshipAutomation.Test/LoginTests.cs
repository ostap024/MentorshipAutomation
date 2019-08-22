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
        [TestCase("johnwick322@gmail.com", "qwerty")]
        public void SuccessLoginTest(string email, string password)
        {
            var page = new BasePage();

            page = page.GoToLoginPage()
                .Login(email, password);

            Assert.That(page.PageTitle, Is.EqualTo("My account - My Store"));
        }

        [TearDown]
        public void AfterAll()
        {
            var page = new MyAccount();
            page.Logout();
        }
    }
}