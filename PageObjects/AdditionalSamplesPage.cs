using OpenQA.Selenium;

namespace DotNetSeleniumBoilerplate.PageObjects
{
    class AdditionalSamplesPage: SampleExpressAppPage
    {
        public AdditionalSamplesPage(IWebDriver webDriver): base(webDriver)
        {

        }

        protected override string UrlPath => "additional-samples";
    }
}
