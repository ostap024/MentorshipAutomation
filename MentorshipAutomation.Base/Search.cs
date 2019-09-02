using OpenQA.Selenium;

namespace MentorshipAutomation.Base
{
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
}
