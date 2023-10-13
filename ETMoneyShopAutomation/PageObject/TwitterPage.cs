using ETMoneyShopAutomation.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETMoneyShopAutomation.PageObject
{
    public class TwitterPage
    {
      public IWebDriver driver;

        public TwitterPage()
        {
            driver = WebHooks.driver;
        }

        private By twitter = By.XPath("//*[@id=\"colophon\"]/div/div/section[1]/div/div[1]/div/div[2]/div/div/span[2]/a/i");

        public void AcceptCookies()
        {
            driver.FindElement(By.XPath("//*[@id=\"cn-accept-cookie\"]")).Click();
        }
        public void ClickTwitter()
        {
            //driver.FindElement(twitter).Click();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://twitter.com/ETMoneyShop";
            
        }

        public bool ClickTwitterPageShouldDisplayed()
        {
            
            return driver.Url.Contains("https://twitter.com/ETMoneyShop");
        }

        
    }
}
