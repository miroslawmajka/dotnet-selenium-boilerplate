using DotNetSeleniumBoilerplate.Model;

namespace DotNetSeleniumBoilerplate.PageObjects
{
    class AdditionalSamplesPage: SampleExpressAppPage
    {
        public AdditionalSamplesPage(SeleniumConfig config) : base(config)
        {

        }

        protected override string UrlPath => "additional-samples";
    }
}
