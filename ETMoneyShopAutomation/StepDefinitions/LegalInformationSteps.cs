using ETMoneyShopAutomation.Hooks;
using OpenQA.Selenium;
using ETMoneyShopAutomation.PageObject;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ETMoneyShopAutomation.StepDefinitions
{
    [Binding]
    public class LegalInformationSteps
    {
        public IWebDriver driver = WebHooks.driver;
        LegalInformtionPage legalInformtionPage = new LegalInformtionPage();

        [When(@"i click legal information")]
        public void WhenIClickLegalInformation()
        {
            Thread.Sleep(3000);
            legalInformtionPage.ClickLegalInformation();
        }

        [Then(@"legal information page should displayed")]
        public void ThenLegalInformationPageShouldDisplayed()
        {
            Thread.Sleep(3000); 
            Assert.IsTrue(legalInformtionPage.LegalInformationPageShouldDisplayed());
        }
    }
}
