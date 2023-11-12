
using ETMoneyShopAutomation.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETmoneyShop.PageObject
{
    internal class TermsAndConditionsPage
    {
        public IWebDriver driver;

        public TermsAndConditionsPage()
        {
            driver = WebHooks.driver;
        }

        private By terms = By.XPath("//*[@id=\"colophon\"]/div/div/section[1]/div/div[2]/div/div/div/p[2]/a[2]");

        public void ClickTermsAndConditions()
        {
            driver.FindElement(terms).Click();
        }

        internal bool? TermsAndConditionsPageIsDisplayed()
        {
            return driver.Url.Contains("https://loans.reteicons.com/terms-and-conditions/");
        }
    }
}
