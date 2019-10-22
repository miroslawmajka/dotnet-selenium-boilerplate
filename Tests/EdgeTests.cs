using DotNetSeleniumBoilerplate.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace DotNetSeleniumBoilerplate.Tests
{
    [TestClass]
    public class EdgeTests : SampleExpressAppTest
    {
        protected override IWebDriver GetDriver()
        {
            return new EdgeDriver();
        }

        [TestMethod]
        public void SampleExpressAppOpensInEdge()
        {
            var samplExpressAppPage = new SampleExpressAppPage(Driver);

            samplExpressAppPage.Open();
        }
    }
}
