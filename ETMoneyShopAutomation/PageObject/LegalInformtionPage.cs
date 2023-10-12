using ETMoneyShopAutomation.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETMoneyShopAutomation.PageObject
{
    public class LegalInformtionPage
    {
        public IWebDriver driver;

        public LegalInformtionPage()
        {
            driver = WebHooks.driver;
        }
        private By legal = By.LinkText("Legal Information");
        public void ClickLegalInformation()
        {
            driver.FindElement(legal).Click();
        }

        public bool LegalInformationPageShouldDisplayed()
        {
            return driver.Url.Contains("https://loans.reteicons.com/legal-information/");
        }
    }
}
