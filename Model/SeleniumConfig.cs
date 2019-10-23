using OpenQA.Selenium;

namespace DotNetSeleniumBoilerplate.Model
{
    public class SeleniumConfig
    {
        public IWebDriver Driver { get; set; }
        public string BaseUrl { get; set; }
    }
}
