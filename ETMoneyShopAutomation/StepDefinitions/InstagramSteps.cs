using ETMoneyShopAutomation.Hooks;
using ETMoneyShopAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ETMoneyShopAutomation.StepDefinitions
{
    [Binding]
    public class InstagramSteps
    {
        public IWebDriver driver = WebHooks.driver;
        InstagramPage instagramPage = new InstagramPage();

        [When(@"user click instagram on the footer")]
        public void WhenUserClickInstagramOnTheFooter()
        {
            Thread.Sleep(3000);
            instagramPage.ClickInstagram();
        }

        [Then(@"ET Money shop instagram page should displayed")]
        public void ThenETMoneyShopInstagramPageShouldDisplayed()
        {
            Thread.Sleep(3000); 
            Assert.IsTrue(instagramPage.ETMoneyShopInstagramPageShouldDisplayed());
        }
    }
}
