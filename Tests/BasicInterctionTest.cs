using DotNetSeleniumBoilerplate.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetSeleniumBoilerplate.Tests
{
    [TestClass]
    [TestCategory("EntryPageSampleElementTest")]
    public class EntryPageSampleElementTest: SampleExpressAppTest
    {
        [TestMethod]
        public void SampleElementContainsDesiredText()
        {
            var indexPage = new IndexPage(TestConfig);

            indexPage.Open();
        }
    }
}
