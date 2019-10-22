using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace DotNetSeleniumBoilerplate.Tests
{
    public abstract class SampleExpressAppTest
    {
        protected string SampleExpressAppUrl => "http://localhost:3000";
        protected IWebDriver Driver { get; private set; }

        [TestInitialize]
        public void TestInitialize()
        {
            Driver = GetDriver();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Driver.Quit();
        }

        protected abstract IWebDriver GetDriver();
    }
}
