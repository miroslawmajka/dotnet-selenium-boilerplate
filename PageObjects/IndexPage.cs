using DotNetSeleniumBoilerplate.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DotNetSeleniumBoilerplate.PageObjects
{
    public class IndexPage : SampleExpressAppPage
    {
        private readonly string MORE_TEXT_BUTTON_SELECTOR;

        public IndexPage(SeleniumTestConfig config): base(config)
        {
            MORE_TEXT_BUTTON_SELECTOR = "#btnShowMoreText";
        }

        public IndexPage ClickMoreTextButton()
        {
            IWebElement moreTextButton = null;

            GetWaitForSeconds(5).Until(d =>
            {
                moreTextButton = d.FindElement(By.Id(MORE_TEXT_BUTTON_SELECTOR));

                return moreTextButton.Displayed && moreTextButton.Enabled;
            });

            moreTextButton.Click();

            return this;
        }
    }
}
