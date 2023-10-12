using ETMoneyShopAutomation.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ETMoneyShopAutomation.StepDefinitions
{
    [Binding]
    public class FAQSteps
    {
        public IWebDriver driver = WebHooks.driver;

        PageObject.FAQPage faqPage = new PageObject.FAQPage();

        [Given(@"am a user on the website ""([^""]*)""")]
        public void GivenAmAUserOnTheWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"I click on FAQ on the header")]
        public void WhenIClickOnFAQOnTheHeader()
        {
            faqPage.ClickFAQ();
        }

        [Then(@"FAQ search bar should popup")]
        public void ThenFAQSearchBarShouldPopup()
        {
            Assert.IsTrue(faqPage.FAQIsDisplayed());
        }
    }
}
