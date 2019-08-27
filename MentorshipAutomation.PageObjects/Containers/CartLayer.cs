using System;
using System.Collections.Generic;
using System.Text;
using MentorshipAutomation.Base;
using MentorshipAutomation.Base.Elements;
using OpenQA.Selenium;

namespace MentorshipAutomation.PageObjects.Containers
{
    public class CartLayer
    {
        public ButtonElement Close => new ButtonElement(WebDriver.GetDriver().FindElement(By.ClassName("cross")));

        public ButtonElement ContinueShopping => new ButtonElement(WebDriver.GetDriver().FindElement(
            By.XPath("//div[@id='layer_cart']//div[@class = 'button-container']/span[@title='Continue shopping']")));

        public ButtonElement ProceedToCheckout => new ButtonElement(WebDriver.GetDriver().FindElement(
            By.XPath("//div[@id='layer_cart']//div[@class = 'button-container']/a[contains(@href,'controller=order')]")));
    }
}
