using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MentorshipAutomation.PageObjects;
using NUnit.Framework;

namespace MentorshipAutomation.Test
{
    [TestFixture]
    public class CartTests:BaseTest
    {

        [Test]
        public void GoToOrderTest()
        {
            var page = new BasePage();

            page = page.GoToOrderPage();

            Assert.That(page.PageTitle, Is.EqualTo("Order - My Store"));
        }

        [Test]
        public void CartHoverTest()
        {
            var page = new BasePage();
            page.AddAllProductToCart();
            //page.MoveToCart();
            Thread.Sleep(5000);
        }
    }
}
