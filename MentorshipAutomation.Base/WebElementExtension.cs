using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MentorshipAutomation.Base
{
    public static class WebElementExtension
    {
        public static void MoveTo(this IWebElement element)
        {
            Actions action = new Actions(DriverManager.Current.GetDriver);
            action.MoveToElement(element).Perform();
        }
    }
}
