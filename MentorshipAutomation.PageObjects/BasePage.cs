﻿using System;
using MentorshipAutomation.Base;
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


        public void Login()
        {
            MainMenu.Login.Click();
        }
    }
}