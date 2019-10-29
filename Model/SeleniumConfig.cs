using OpenQA.Selenium;

namespace DotNetSeleniumBoilerplate.Model
{
    public class SeleniumTestConfig
    {
        public IWebDriver Driver { get; set; }
        public string BaseUrl { get; set; }
    }
}
