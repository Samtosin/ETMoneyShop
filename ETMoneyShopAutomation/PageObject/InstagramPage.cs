using ETMoneyShopAutomation.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETMoneyShopAutomation.PageObject
{
    internal class InstagramPage
    {
        public IWebDriver driver;

        public InstagramPage()
        {
            driver = WebHooks.driver;
        }


        public void ClickInstagram()
        {
            driver.FindElement(By.XPath("//*[@id=\"colophon\"]/div/div/section[1]/div/div[1]/div/div[2]/div/div/span[3]/a/i")).Click();
        }

        public bool ETMoneyShopInstagramPageShouldDisplayed()
        {
            return driver.Url.Contains("https://www.instagram.com/etmoneyshop/");
        }
    }
}
