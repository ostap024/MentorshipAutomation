using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading;
using MentorshipAutomation.Base;
using MentorshipAutomation.Base.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace MentorshipAutomation.Base
{
    public enum BrowserType
    {
        Chrome,
        InternetExplorer,
        Firefox
    }

    public class Driver
    {
        private const int WaiterTimeoutInSeconds = 60;

        private readonly IWebDriver _wrapper;
        private readonly IWait<IWebDriver> _wait;
        private readonly IJavaScriptExecutor _javaScriptExecutor;

        private Driver(IWebDriver driver)
        {
            _wrapper = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WaiterTimeoutInSeconds));
            _wrapper.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _javaScriptExecutor = (IJavaScriptExecutor) driver;
        }

        public IWebDriver GetDriver => _wrapper;

        public static Driver GetFor(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return new Driver(
                        new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));

                case BrowserType.InternetExplorer:
                    return new Driver(new InternetExplorerDriver());

                case BrowserType.Firefox:
                    return new Driver(new FirefoxDriver());

                default:
                    throw new Exception("There is no such browser.");
            }
        }

        #region Properties

        public string PageSource => _wrapper.PageSource;

        public string Title => _wrapper.Title;

        public string Url
        {
            get => _wrapper.Url;
            set => _wrapper.Url = value;
        }

        #endregion Properties



        public IWebElement FindElement(Search search)
        {
            var element = _wait.Until(WaitConditions.ElementExists(search.Wrapper));
            return element;
        }

        public ReadOnlyCollection<IWebElement> FindElements(Search search)
        {
            var element = _wait.Until(WaitConditions.ElementsExists(search.Wrapper));
            return element;
        }

        /// <summary>
        /// Maximizes the current window if it is not already maximized.
        /// </summary>
        public void MaximizeWindow()
        {
            _wrapper.Manage().Window.Maximize();

        }

        public void GoToUrl(string Url)
        {
           _wrapper.Navigate().GoToUrl(TestConstants.BaseUrl);
        }

        /// <summary>
        /// Gets a object representing the image of the page on the screen.
        /// </summary>
        public Screenshot TakeScreenshot()
        {
            var screenshot = _wrapper.TakeScreenshot();
            return screenshot;
        }

        /// <summary>
        /// Quits this driver, closing every associated window.
        /// </summary>
        public void Quit()
        {
            _wrapper.Quit();
        }
    }
}


