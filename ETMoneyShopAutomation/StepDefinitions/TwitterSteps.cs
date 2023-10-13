using ETMoneyShopAutomation.Hooks;
using ETMoneyShopAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ETMoneyShopAutomation.StepDefinitions
{
    [Binding]
    public class TwitterSteps
    {
        public IWebDriver driver = WebHooks.driver;
        TwitterPage twitterPage = new TwitterPage();

        [Given(@"that a user navigate to the website ""([^""]*)""")]
        public void GivenThatAUserNavigateToTheWebsite(string p0)
        {
           driver.Navigate().GoToUrl(p0);
        }

        [Given(@"i click ok to accept cookies")]
        public void GivenIClickOkToAcceptCookies()
        {
            Thread.Sleep(3000); 
            twitterPage.AcceptCookies();
        }


        [When(@"user click twitter on the footer")]
        public void WhenUserClickTwitterOnTheFooter()
        {
            Thread.Sleep(3000);
            twitterPage.ClickTwitter();
        }

        [Then(@"ET Money shop twitter page should displayed")]
        public void ThenETMoneyShopTwitterPageShouldDisplayed()
        {
            Assert.IsTrue(twitterPage.ClickTwitterPageShouldDisplayed());
        }
    }
}
