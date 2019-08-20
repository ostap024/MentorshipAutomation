using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MentorshipAutomation.Base
{
    public static class WebDriver
    {
        private static IWebDriver _driver;

        public static IWebDriver GetDriver()
        {
            return _driver ?? (_driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
        }

        public static void Reset()
        {
            if (_driver == null) return;
            _driver.Quit();
            _driver = null;
        }
    }
}
