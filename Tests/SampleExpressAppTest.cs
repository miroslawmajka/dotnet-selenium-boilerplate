using dotenv.net;
using DotNetSeleniumBoilerplate.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Edge;
using System;

namespace DotNetSeleniumBoilerplate.Tests
{
    public abstract class SampleExpressAppTest
    {
        protected SeleniumConfig Config { get; private set; }

        public SampleExpressAppTest()
        {
            DotEnv.Config(false);
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Config = new SeleniumConfig
            {
                Driver = GetDriver(Environment.GetEnvironmentVariable("BROWSER")),
                BaseUrl = Environment.GetEnvironmentVariable("BASE_URL")
            };
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Config.Driver.Quit();
        }

        private IWebDriver GetDriver(string browserName)
        {
            // TODO: implement map with defined browsers
            //var edgeDriver = new EdgeDriver();

            return new ChromeDriver();
        }
    }
}
