
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

        private By terms = By.CssSelector("#colophon > div > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-c952c9f.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div.elementor-column.elementor-col-66.elementor-top-column.elementor-element.elementor-element-7ca7a13 > div > div > div > p:nth-child(2) > a");

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
