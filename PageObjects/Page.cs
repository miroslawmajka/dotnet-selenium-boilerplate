using DotNetSeleniumBoilerplate.Model;
using OpenQA.Selenium;

namespace DotNetSeleniumBoilerplate.PageObjects
{
    public abstract class Page
    {
        protected IWebDriver Driver { get; private set; }
        protected string BaseUrl { get; private set; }
        protected virtual string UrlPath => string.Empty;

        public Page(SeleniumConfig config)
        {
            Driver = config.Driver;
            BaseUrl = config.BaseUrl;
        }

        public Page Open()
        {
            Driver.Navigate().GoToUrl($"{BaseUrl}/{UrlPath}");

            return this;
        }
    }
}
