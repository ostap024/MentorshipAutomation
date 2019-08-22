using System;
using System.Collections.Generic;
using System.Text;
using MentorshipAutomation.Base;
using MentorshipAutomation.Base.Elements;
using OpenQA.Selenium;

namespace MentorshipAutomation.PageObjects.Pages
{
    public class MyAccount : BasePage
    { 
        public override string PagePath => "controller=my-account";
    }
}
