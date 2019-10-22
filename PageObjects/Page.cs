using OpenQA.Selenium;

namespace DotNetSeleniumBoilerplate.PageObjects
{
    public abstract class Page
    {
        protected IWebDriver Driver { get; private set; }
        protected abstract string BaseUrl { get; }
        protected virtual string UrlPath => "";

        public Page(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public Page Open()
        {
            Driver.Navigate().GoToUrl($"{BaseUrl}/{UrlPath}");

            return this;
        }
    }
}
