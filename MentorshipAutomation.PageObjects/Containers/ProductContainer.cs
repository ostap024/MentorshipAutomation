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
    public class ProductContainer
    {


        public HtmlElement Product => new HtmlElement( WebDriver.GetDriver()
            .FindElement(By.XPath("//div[@class='product-container'][1]")));

        public ButtonElement  AddToCart => new ButtonElement(WebDriver.GetDriver()
            .FindElement(By.XPath("//div[@class='product-container']//div[@class='button-container']/a[@title='Add to cart'][1]")));

        public IWebElement ProductPrice => WebDriver.GetDriver()
            .FindElement(By.XPath("//div[@class='product-container']/div[@class='left-block']/div[@class='product-image-container']/div[@class='content_price']/span[@class='price product-price']"));

       
    }
}
