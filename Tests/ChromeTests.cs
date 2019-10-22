using DotNetSeleniumBoilerplate.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotNetSeleniumBoilerplate.Tests
{
    [TestClass]
    public class ChromeTests: SampleExpressAppTest
    {
        protected override IWebDriver GetDriver()
        {
            return new ChromeDriver();
        }

        [TestMethod]
        public void SampleExpressAppOpensInChrome()
        {
            var indexPage = new IndexPage(Driver);

            indexPage.Open();
        }
    }
}
