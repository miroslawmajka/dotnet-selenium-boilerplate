using DotNetSeleniumBoilerplate.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetSeleniumBoilerplate.Tests
{
    [TestClass]
    public class EntryPageSampleElementTest: SampleExpressAppTest
    {
        [TestMethod]
        public void SampleElementContainsDesiredText()
        {
            var indexPage = new IndexPage(Config);

            indexPage.Open();
        }
    }
}
