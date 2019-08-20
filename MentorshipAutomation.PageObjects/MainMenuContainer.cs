using System;
using System.Collections.Generic;
using System.Text;
using MentorshipAutomation.Base;
using MentorshipAutomation.Base.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MentorshipAutomation.PageObjects
{
    public class MainMenuContainer
    {
        public ButtonElement Login => new ButtonElement(WebDriver.GetDriver().FindElement(By.ClassName("login")));
    }
}
