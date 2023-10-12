using ETMoneyShopAutomation.Hooks;
using ETMoneyShopAutomation.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ETMoneyShopAutomation.StepDefinitions
{
    [Binding]
    public class BlogSteps
    {
        public IWebDriver driver = WebHooks.driver;
        BlogPage blogPage = new BlogPage();

        [Given(@"that I navigate to the ET money website ""([^""]*)""")]
        public void GivenThatINavigateToTheETMoneyWebsite(string p0)
        {
            driver.Navigate().GoToUrl(p0);
        }

        [When(@"I click on blog on the header")]
        public void WhenIClickOnBlogOnTheHeader()
        {
            Thread.Sleep(2000);
            blogPage.ClickOnBlog();
        }

        [Then(@"blog page should be displayed")]
        public void ThenBlogPageShouldBeDisplayed()
        {
            Thread.Sleep(2000); 
            Assert.IsTrue(blogPage.BlogPageShouldDisplayed());
        }
    }
}
