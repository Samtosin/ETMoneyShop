using ETMoneyShopAutomation.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ETMoneyShopAutomation.StepDefinitions
{
    [Binding]
    public class TermsAndConditionsSteps
    {
        public IWebDriver driver = WebHooks.driver;
        ETmoneyShop.PageObject.TermsAndConditionsPage termsAndConditionsPage = new ETmoneyShop.PageObject.TermsAndConditionsPage();

        [Given(@"that i navigate to the ET money website ""([^""]*)""")]
        public void GivenThatINavigateToTheETMoneyWebsite(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        [When(@"i click on Terms and Conditions on the footer")]
        public void WhenIClickOnTermsAndConditionsOnTheFooter()
        {
            termsAndConditionsPage.ClickTermsAndConditions();
        }

        [Then(@"the Terms and Conditions page should displayed")]
        public void ThenTheTermsAndConditionsPageShouldDisplayed()
        {
            Assert.IsTrue(termsAndConditionsPage.TermsAndConditionsPageIsDisplayed());
        }
    }
}

