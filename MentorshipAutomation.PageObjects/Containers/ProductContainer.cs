using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MentorshipAutomation.Base;
using MentorshipAutomation.Base.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MentorshipAutomation.PageObjects.Containers
{
    public class ProductContainer:HtmlElement
    {
        public ButtonElement  AddToCart => new ButtonElement(WebElement.FindElement(
            By.XPath(".//div[@class='button-container']/a[1]")));

        public ButtonElement More => new ButtonElement(WebElement.FindElement(
            By.XPath(".//div[@class='button-container']/a[last()]")));

        public HtmlElement ProductPrice => new HtmlElement(WebElement.FindElement(
           By.XPath("./div[@class='left-block']/div[@class='product-image-container']/div[@class='content_price']/span[@class='price product-price']")));

        public ProductContainer(IWebElement element) : base(element)
        {
        }
    }
}
