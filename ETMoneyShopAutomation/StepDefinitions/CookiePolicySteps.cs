using ETMoneyShopAutomation.Hooks;
using ETMoneyShopAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;


namespace ETMoneyShopAutomation.StepDefinitions
{
    [Binding]
    public class CookiePolicySteps
    {
        public IWebDriver driver = WebHooks.driver;
        CookiePolicyPage cookiePolicyPage = new CookiePolicyPage();

        [Given(@"user navigate to the website ""([^""]*)""")]
        public void GivenUserNavigateToTheWebsite(string p0)
        {
            driver.Navigate().GoToUrl(p0);
        }

        [When(@"user click cookie policy")]
        public void WhenUserClickCookiePolicy()
        {
            Thread.Sleep(3000); 
            cookiePolicyPage.ClickCookiesPolicy();
        }

        [Then(@"the cookie policy page should displayed")]
        public void ThenTheCookiePolicyPageShouldDisplayed()
        {
            Thread.Sleep(3000);
            Assert.IsTrue(cookiePolicyPage.CookiePolicyPageShouldDisplayed());
        }
    }
}
