using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using MentorshipAutomation.Base;
using MentorshipAutomation.Base.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
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
    public static class WebDriver
    {
        private static IWebDriver _driver;

        public static IWebDriver GetDriver()
        {
            return _driver ?? (_driver =
                       new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
        }

        public static void Reset()
        {
            if (_driver == null) return;
            _driver.Quit();
            _driver = null;
        }
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
            _javaScriptExecutor = (IJavaScriptExecutor)driver;
        }

        public static Driver GetFor(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return new Driver(new ChromeDriver());

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


        public string Url
        {
            get => _wrapper.Url;
            set => _wrapper.Url = value;
        }

        #endregion Properties



        internal IWebElement FindElement(Search search)
        {
            var element = _wait.Until(WaitConditions.ElementExists(search.Wrapper));
            return element;
        }

        /// <summary>
        /// Maximizes the current window if it is not already maximized.
        /// </summary>
        public void MaximizeWindow()
        {
            _wrapper.Manage().Window.Maximize();

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

    public static class DriverManager
    {
        private static readonly Dictionary<int, Driver> Instances = new Dictionary<int, Driver>();

        public static Driver Current
        {
            get
            {
                if (!Instances.ContainsKey(Thread.CurrentThread.ManagedThreadId))
                {
                    throw new Exception("Driver instance was not created");
                }

                return Instances[Thread.CurrentThread.ManagedThreadId];
            }
            set => Instances[Thread.CurrentThread.ManagedThreadId] = value;
        }
    }

    public static class ElementFactory
    {

        public static T Create<T>(Search search) where T : HtmlElement, new()
        {
            var element = new T {SearchWrapper = search};
            return element;
        }
    }

    public class Search
    {
        internal readonly By Wrapper;

        private Search(By wrapper)
        {
            Wrapper = wrapper;
        }

        public static Search ClassName(string className)
        {
            var search = By.ClassName(className);
            return new Search(search);
        }

        public static Search CssSelector(string cssSelector)
        {
            var search = By.CssSelector(cssSelector);
            return new Search(search);
        }

        public static Search Id(string id)
        {
            var search = By.Id(id);
            return new Search(search);
        }

        public static Search LinkText(string linkText)
        {
            var search = By.LinkText(linkText);
            return new Search(search);
        }

        public static Search Name(string name)
        {
            var search = By.Name(name);
            return new Search(search);
        }

        public static Search PartialLinkText(string partialLinkText)
        {
            var search = By.PartialLinkText(partialLinkText);
            return new Search(search);
        }

        public static Search TagName(string tagName)
        {
            var search = By.TagName(tagName);
            return new Search(search);
        }

        public static Search XPath(string xPath)
        {
            var search = By.XPath(xPath);
            return new Search(search);
        }

        public override string ToString() => Wrapper.ToString();
    }
    public abstract class Element
    {

        internal Search SearchWrapper;
        internal IWebElement Wrapper => DriverManager.Current.FindElement(SearchWrapper);

        #region Properties

        public string InnerText => Wrapper.Text;

        #endregion Properties

        #region Methods

        public void Click()
        {
            Wrapper.Click();
        }

        #endregion Methods
    }


    internal static class WaitConditions
    {
        public static Func<IWebDriver, IWebElement> ElementExists(By locator)
        {
            return driver => driver.FindElement(locator);
        }
    }
}


