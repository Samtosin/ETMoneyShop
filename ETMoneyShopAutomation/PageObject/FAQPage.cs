using ETMoneyShopAutomation.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETMoneyShopAutomation.PageObject
{
    public class FAQPage
    {
        public IWebDriver driver;

        public FAQPage()
        {
            driver = WebHooks.driver;
        }

        private By faq = By.XPath("//*[@id=\"menu-item-1485\"]/a");

        public void ClickFAQ()
        {
            driver.FindElement(faq).Click();
        }

        public bool FAQIsDisplayed()
        {
            return driver.Url.Equals("https://loans.reteicons.com/faq/");
        }
    }
}
