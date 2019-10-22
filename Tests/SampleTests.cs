using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace DotNetSeleniumBoilerplate.Tests
{
    [TestClass]
    public class SampleTests
    {
        private string SAMPLE_EXPRESS_APP_URL = "http://localhost:3000";

        private IWebDriver driver;

        [TestInitialize]
        public void TestInitialize()
        {
            driver = null;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            driver.Quit();
        }

        [TestMethod]
        public void SampleTestOpensSampleExpressAppChrome()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(SAMPLE_EXPRESS_APP_URL);
        }

        [TestMethod]
        public void SampleTestOpensSampleExpressAppEdge()
        {
            driver = new EdgeDriver();
            driver.Navigate().GoToUrl(SAMPLE_EXPRESS_APP_URL);
        }
    }
}
