using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MentorshipAutomation.Base;
using MentorshipAutomation.PageObjects.Containers;
using OpenQA.Selenium;

namespace MentorshipAutomation.PageObjects.Pages
{
    public class ItemsPage : BasePage
    {
        public void AddAllProductToCart()
        {
            var products = DriverManager.Current.FindElements(Search.XPath("//div[@class='product-container']")).Select(product => new ProductContainer(product)).ToList();

            foreach (var product in products)
            {
                product.AddProductToCart();
                var cartLayer = new CartLayer();
                cartLayer.ContinueShopping.Click();
            }
        }

        public void GoToProduct()
        {
            var product = new ProductContainer(DriverManager.Current.FindElements(Search.XPath("//div[@class='product-container']")).First());

            product.AddProductToCart();
        }
    }
}
