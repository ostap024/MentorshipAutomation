using MentorshipAutomation.Base;
using MentorshipAutomation.Base.Elements;
using OpenQA.Selenium;

namespace MentorshipAutomation.PageObjects.Containers
{
    public class MainMenuContainer
    {
        public ButtonElement Login => new ButtonElement(WebDriver.GetDriver().FindElement(By.ClassName("login")));

        public ButtonElement Logout => new ButtonElement(WebDriver.GetDriver().FindElement(By.ClassName("logout")));

        public ButtonElement MyAccount => new ButtonElement(WebDriver.GetDriver().FindElement(By.ClassName("account")));

        public ButtonElement ContactUs => new ButtonElement(WebDriver.GetDriver().FindElement(By.XPath("//div[@id='contact-link']/a")));

        public CartContainer CartContainer => new CartContainer();
    }
}
