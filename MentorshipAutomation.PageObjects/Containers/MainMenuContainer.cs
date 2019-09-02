using MentorshipAutomation.Base;
using MentorshipAutomation.Base.Elements;
using OpenQA.Selenium;

namespace MentorshipAutomation.PageObjects.Containers
{
    public class MainMenuContainer
    {
        public ButtonElement Login => new ButtonElement(Search.ClassName("login")); 

        public ButtonElement Logout => new ButtonElement(Search.ClassName("logout"));

        public ButtonElement MyAccount => new ButtonElement(Search.ClassName("account"));

        public ButtonElement Women => new ButtonElement(Search.XPath("//div[@id='block_top_menu']//ul//a[@title='Women']"));

        public ButtonElement ContactUs => new ButtonElement(Search.XPath("//div[@id='contact-link']/a"));

        public CartContainer CartContainer => new CartContainer();
    }
}
