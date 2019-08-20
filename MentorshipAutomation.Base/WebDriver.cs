using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;

namespace MentorshipAutomation.Base
{
    public static class WebDriver
    {
        private static IWebDriver _driver;

        public static IWebDriver GetDriver()
        {
            return _driver ?? (_driver = new ChromeDriver());
        }

        public static void Reset()
        {
            if (_driver == null) return;
            _driver.Quit();
            _driver = null;
        }
    }
}
