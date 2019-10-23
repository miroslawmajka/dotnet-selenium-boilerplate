using DotNetSeleniumBoilerplate.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DotNetSeleniumBoilerplate.PageObjects
{
    public class IndexPage : SampleExpressAppPage
    {
        private string MORE_TEXT_BUTTON_SELECTOR = "#btnShowMoreText";

        public IndexPage(SeleniumConfig config): base(config)
        {

        }

        public IndexPage ClickMoreTextButton()
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

            IWebElement moreTextButton = null;

            wait.Until(d =>
            {
                moreTextButton = d.FindElement(By.Id(MORE_TEXT_BUTTON_SELECTOR));

                return moreTextButton.Displayed && moreTextButton.Enabled;
            });

            moreTextButton.Click();

            return this;
        }
    }
}
