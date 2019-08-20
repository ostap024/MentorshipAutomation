using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using OpenQA.Selenium;

namespace MentorshipAutomation.Base.Elements
{
    public class HtmlElement
    {
        protected IWebDriver Driver => WebDriver.GetDriver();

        public IWebElement WebElement { get; }

        public HtmlElement(IWebElement element)
        {
            WebElement = element;
        }
        #region Attributes
        public virtual string Text => GetText();

        public virtual string TextContent => GetProperty("textContent");

        public virtual string Name => GetAttribute("name");

        public virtual string Id => GetAttribute("id");

        public virtual string Class => GetAttribute("class");

        public virtual string Style => GetAttribute("style");

        public virtual string Title => GetAttribute("title");

        public virtual string InnerHtml => GetProperty("innerHTML");

        public virtual string TagName => WebElement.TagName;

        public bool Enabled => WebElement.Enabled;

        public bool Disabled => !WebElement.Enabled;
        #endregion
        public void Submit()
        {
            WebElement.Submit();
        }

        public void Click()
        {
            WebElement.Click();
        }
        public string GetProperty(string propertyName)
        {
            return WebElement.GetProperty(propertyName);
        }

        protected string GetText()
        {
            return WebElement.Text;
        }
        public string GetAttribute(string attributeName)
        {
            return WebElement.GetAttribute(attributeName);
        }
    }
}
