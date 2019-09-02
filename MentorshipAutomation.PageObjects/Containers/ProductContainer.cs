using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using MentorshipAutomation.Base;
using MentorshipAutomation.Base.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace MentorshipAutomation.PageObjects.Containers
{
    public class ProductContainer
    {
        private IWebElement _container;

        private IWebElement AddToCart =>
            _container.FindElement(
                By.XPath(".//div[@class='button-container']/a[1]"));


        private IWebElement More =>
            _container.FindElement(
                By.XPath(".//div[@class='button-container']/a[last()]"));


        private IWebElement ProductPrice =>
            _container.FindElement(
                By.XPath("./div[@class='left-block']/div[@class='product-image-container']/div[@class='content_price']/span[@class='price product-price']"));

        public ProductContainer(IWebElement container)
        {
            _container = container;
        }

        public void AddProductToCart()
        {
            _container.MoveTo();
            Thread.Sleep(500); //TODO use explicit wait
            AddToCart.Click();
        }
    }
}


//"//div[@id='uniform-layered_id_feature_11']//input"