using System;
using System.Collections.Generic;
using System.Text;
using MentorshipAutomation.Base;
using MentorshipAutomation.Base.Elements;
using OpenQA.Selenium;

namespace MentorshipAutomation.PageObjects.Containers
{
    public class CartContainer
    {
        public ButtonElement Cart => new ButtonElement(WebDriver.GetDriver()
            .FindElement(By.XPath("//div[@class='shopping_cart']//a[contains(@href,'controller=order')]")));

    }
}
