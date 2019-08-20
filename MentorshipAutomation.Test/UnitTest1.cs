using System.Linq;
using MentorshipAutomation.Base;
using MentorshipAutomation.PageObjects.Pages;
using NUnit.Framework;

namespace MentorshipAutomation.Test
{
    public class Tests:BaseTest
    {
        [Test]
        public void Test1()
        {
            var authenticationPage = new AuthenticationPage();
            WebDriver.GetDriver().Navigate().GoToUrl(authenticationPage.PageUrl);
            authenticationPage.Login("johnwick322@gmail.com", "qwerty");
        }
    }
}