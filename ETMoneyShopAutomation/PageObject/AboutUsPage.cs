using ETMoneyShopAutomation.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETMoneyShopAutomation.PageObject
{
    public class AboutUsPage
    {
        public IWebDriver driver;

        public AboutUsPage()
        {
            driver = WebHooks.driver;
        }

        private By AboutUs = By.XPath("//*[@id=\"menu-item-1484\"]/a");

        public bool AboutUsPageIsDisplayed()
        {
            return driver.Url.Contains("https://loans.reteicons.com/about-us/");
        }

        public void ClickTheAboutUs()
        {
            driver.FindElement(AboutUs).Click();
        }
    }
}

