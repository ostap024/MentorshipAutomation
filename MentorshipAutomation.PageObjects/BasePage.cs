using System;
using System.Collections.Generic;
using System.Threading;
using MentorshipAutomation.Base;
using MentorshipAutomation.PageObjects.Containers;
using MentorshipAutomation.PageObjects.Pages;
using OpenQA.Selenium;

namespace MentorshipAutomation.PageObjects
{
    public class BasePage
    {
        #region Properties

        public virtual string PageTitle => DriverManager.Current.Title ?? string.Empty;


        public virtual string PagePath => string.Empty;


        public virtual string PageUrl => TestConstants.BaseUrl + PagePath;


        #endregion

        #region Web Elements
        protected MainMenuContainer MainMenu => new MainMenuContainer();
        

        #endregion

        public OrderPage GoToOrderPage()
        {
            MainMenu.CartContainer.Cart.Click();
            return new OrderPage();
        }


        public ItemsPage GoToWomenItems()
        {
            MainMenu.Women.Click();
            return new ItemsPage();
        }

        public void MoveToCart()
        {
            MainMenu.CartContainer.Cart.MoveTo();
        }

        public AuthenticationPage GoToLoginPage()
        {
            MainMenu.Login.Click();
            return new AuthenticationPage();
        }

        public MyAccount GoToMyAccountPage()
        {
            MainMenu.MyAccount.Click();
            return new MyAccount();
        }

        public void Logout()
        {
            MainMenu.Logout.Click();
        }
    }
}
