using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace MentorshipAutomation.Base
{
    internal static class WaitConditions
    {
        public static Func<IWebDriver, IWebElement> ElementExists(By locator)
        {
            return driver => driver.FindElement(locator);
        }

        public static Func<IWebDriver, ReadOnlyCollection<IWebElement>> ElementsExists(By locator)
        {
            return driver => driver.FindElements(locator);
        }
    }
}
