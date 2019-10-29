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
        protected SeleniumTestConfig TestConfig { get; private set; }

        public SampleExpressAppTest()
        {
            DotEnv.Config(false);
        }

        [TestInitialize]
        public void TestInitialize()
        {
            TestConfig = new SeleniumTestConfig
            {
                Driver = GetDriver(Environment.GetEnvironmentVariable("BROWSER")),
                BaseUrl = Environment.GetEnvironmentVariable("BASE_URL")
            };
        }

        [TestCleanup]
        public void TestCleanup()
        {
            TestConfig.Driver.Quit();
        }

        private IWebDriver GetDriver(string browserName)
        {
            // TODO: implement map with defined browsers
            //var edgeDriver = new EdgeDriver();
            
            var chromeOptions = new ChromeOptions();

            bool isHeadlessChromeParsed;

            bool.TryParse(Environment.GetEnvironmentVariable("HEADLESS_CHROME"), out isHeadlessChromeParsed);

            if (isHeadlessChromeParsed)
            {
                chromeOptions.AddArguments(new string[] {
                    "--headless",
                    "--disable-gpu"
                });
            }

            return new ChromeDriver(chromeOptions);
        }
    }
}
