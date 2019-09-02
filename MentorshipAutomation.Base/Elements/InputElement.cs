using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MentorshipAutomation.Base.Elements
{
    public class InputElement:Element
    {
        public InputElement(Search searchWrapper) : base(searchWrapper)
        {
        }
        
        public virtual string Value => GetAttribute("value");

        public virtual void Clear()
        {
            WebElement.Click();
            WebElement.Clear();
        }

        public virtual void SendKeys(string value)
        {
            WebElement.SendKeys(value);
        }

        public void ClearAndType(string valueToSet)
        {
            if (!string.IsNullOrEmpty(Value))
                Clear();
            SendKeys(valueToSet);
        }
    }
}
