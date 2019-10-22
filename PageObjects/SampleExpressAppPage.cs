using OpenQA.Selenium;

namespace DotNetSeleniumBoilerplate.PageObjects
{
    public class SampleExpressAppPage : Page
    {
        protected override string BaseUrl => "http://localhost:3000";

        public SampleExpressAppPage(IWebDriver webDriver): base(webDriver)
        {

        }
    }
}
