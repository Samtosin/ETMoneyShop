using ETMoneyShopAutomation.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETMoneyShopAutomation.PageObject
{
    public class CookiePolicyPage
    {
        public IWebDriver driver;

        public CookiePolicyPage()
        {
            driver = WebHooks.driver;
        }
        private By cookie = By.XPath("//*[@id=\"colophon\"]/div/div/section[1]/div/div[2]/div/div/div/p[2]/a[3]");

        public void ClickCookiesPolicy()
        {
            driver.FindElement(cookie).Click();
        }

        public bool CookiePolicyPageShouldDisplayed()
        {
            return driver.Url.Contains("https://loans.reteicons.com/cookie-policy/");
        }
    }
}
