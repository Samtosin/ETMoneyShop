using ETMoneyShopAutomation.Hooks;
using ETMoneyShopAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ETMoneyShopAutomation.StepDefinitions
{
    [Binding]
    public class ContactUsSteps
    {
        public IWebDriver driver = WebHooks.driver;
        ContactUsPage contactUsPage = new ContactUsPage();

        [Given(@"that i navigate to the website ""([^""]*)""")]
        public void GivenThatINavigateToTheWebsite(string p0)
        {
            driver.Navigate().GoToUrl(p0);
        }

        [When(@"i click contact us on the header")]
        public void WhenIClickContactUsOnTheHeader()
        {
            Thread.Sleep(2000);
            contactUsPage.ClickContactUs();
        }

        [Then(@"contact us page should displayed")]
        public void ThenContactUsPageShouldDisplayed()
        {
            Assert.IsTrue(contactUsPage.ContactUsPageShouldDisplayed());
        }


        //[When(@"i enter email")]
        //public void WhenIEnterEmail()
        //{
        //    Thread.Sleep(2000);
        //    contactUsPage.EnterEmail();
        //}

        //[When(@"i enter firstname ""([^""]*)""")]
        //public void WhenIEnterFirstname(string samson)
        //{
        //    Thread.Sleep(2000);
        //    contactUsPage.EnterFirstname(samson);
        //}


        //[When(@"i enter lastname ""([^""]*)""")]
        //public void WhenIEnterLastname(string gbenga)
        //{
        //    Thread.Sleep(2000); 
        //    contactUsPage.EnterLastname(gbenga);
        //}

        //[When(@"enter message ""([^""]*)""")]
        //public void WhenEnterMessage(string message)
        //{
        //    Thread.Sleep(2000); 
        //    contactUsPage.EnterMessage(message);
        //}


        //[When(@"i click submit")]
        //public void WhenIClickSubmit()
        //{
        //    Thread.Sleep(2000); 
        //    contactUsPage.ClickSubmit();
        //}

        //[Then(@"i should be able to contant ETmoney Shop")]
        //public void ThenIShouldBeAbleToContantETmoneyShop()
        //{

        //}
    }
}
