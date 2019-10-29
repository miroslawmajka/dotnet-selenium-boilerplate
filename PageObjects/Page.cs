using DotNetSeleniumBoilerplate.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DotNetSeleniumBoilerplate.PageObjects
{
    public abstract class Page
    {
        protected IWebDriver Driver { get; private set; }
        protected string BaseUrl { get; private set; }
        protected virtual string UrlPath => string.Empty;

        public Page(SeleniumTestConfig config)
        {
            Driver = config.Driver;
            BaseUrl = config.BaseUrl;
        }

        public Page Open()
        {
            Driver.Navigate().GoToUrl($"{BaseUrl}/{UrlPath}");

            return this;
        }

        protected WebDriverWait GetWaitForSeconds(double seconds)
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
        }
    }
}
