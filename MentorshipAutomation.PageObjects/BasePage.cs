using System;
using MentorshipAutomation.Base;
using MentorshipAutomation.PageObjects.Containers;
using MentorshipAutomation.PageObjects.Pages;
using OpenQA.Selenium;

namespace MentorshipAutomation.PageObjects
{
    public class BasePage
    {
        #region Properties

        public virtual string PageTitle => WebDriver.GetDriver().Title ?? string.Empty;


        public virtual string PagePath => string.Empty;


        public virtual string PageUrl => TestConstants.BaseUrl + PagePath;

        protected IWebDriver Driver = WebDriver.GetDriver();

        #endregion

        #region Web Elements
        protected MainMenuContainer MainMenu => new MainMenuContainer();
        #endregion


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
