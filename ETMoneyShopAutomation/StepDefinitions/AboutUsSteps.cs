using ETMoneyShopAutomation.Hooks;
using ETMoneyShopAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ETMoneyShopAutomation.StepDefinitions
{
    [Binding]
    public class AboutUsSteps
    {
        public IWebDriver driver = WebHooks.driver;

        AboutUsPage aboutUsPage = new AboutUsPage();
        [Given(@"that user navigate to the website ""([^""]*)""")]
        public void GivenThatUserNavigateToTheWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"user click the about us on the header")]
        public void WhenUserClickTheAboutUsOnTheHeader()
        {
            aboutUsPage.ClickTheAboutUs();
        }

        [Then(@"about us page is displayed")]
        public void ThenAboutUsPageIsDisplayed()
        {
            Assert.IsTrue(aboutUsPage.AboutUsPageIsDisplayed());
        }
    }
}

