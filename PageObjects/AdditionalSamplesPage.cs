using DotNetSeleniumBoilerplate.Model;

namespace DotNetSeleniumBoilerplate.PageObjects
{
    class AdditionalSamplesPage: SampleExpressAppPage
    {
        public AdditionalSamplesPage(SeleniumTestConfig config) : base(config)
        {

        }

        protected override string UrlPath => "additional-samples";
    }
}
