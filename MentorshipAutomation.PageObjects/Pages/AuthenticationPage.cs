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

        public InputElement Email => new InputElement(Search.Id("email"));

        public InputElement Password => new InputElement(Search.Id("passwd"));

        public ButtonElement SingIn => new ButtonElement(Search.Id("SubmitLogin"));

        public MyAccount Login(string email, string password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
            SingIn.Click();
            return new MyAccount();
        }
    }
}
