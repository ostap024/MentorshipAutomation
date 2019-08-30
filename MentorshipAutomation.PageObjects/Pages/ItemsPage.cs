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
            var productsIWebElements = WebDriver.GetDriver().FindElements(By.XPath("//div[@class='product-container']"));
            List<ProductContainer> products = new List<ProductContainer>();
            foreach (var product in productsIWebElements)
            {
                products.Add(new ProductContainer(product));
            }

            foreach (var product in products)
            {
                product.MoveTo();
                Thread.Sleep(500);
                product.AddToCart.Click();
                var cartLayer = new CartLayer();
                cartLayer.ContinueShopping.Click();
            }
        }

        public void GoToProduct()
        {
            var productsIWebElements = WebDriver.GetDriver().FindElements(By.XPath("//div[@class='product-container']"));
            var product = new ProductContainer(productsIWebElements.First());

            product.MoveTo();
            Thread.Sleep(500);
            product.More.Click();

        }
    }
}
