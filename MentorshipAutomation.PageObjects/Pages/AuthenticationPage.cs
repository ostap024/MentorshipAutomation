using System;
using System.Collections.Generic;
using System.Text;
using MentorshipAutomation.Base;
using MentorshipAutomation.Base.Elements;
using OpenQA.Selenium;

namespace MentorshipAutomation.PageObjects.Pages
{
    public class AuthenticationPage:BasePage
    {
        public override string PagePath => "controller=authentication";

        public InputElement Email => new InputElement(WebDriver.GetDriver().FindElement(By.Id("email")));

        public InputElement Password => new InputElement(WebDriver.GetDriver().FindElement(By.Id("passwd")));

        public ButtonElement SingIn => new ButtonElement(WebDriver.GetDriver().FindElement(By.Id("SubmitLogin")));

        public MyAccount Login(string email, string password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
            SingIn.Click();
            return new MyAccount();
        }
    }
}
