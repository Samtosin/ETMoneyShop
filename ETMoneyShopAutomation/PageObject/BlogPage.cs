using ETMoneyShopAutomation.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETMoneyShopAutomation.PageObject
{
    public class BlogPage
    {
        public IWebDriver driver;

        public BlogPage()
        {
            driver = WebHooks.driver;
        }
        public void ClickOnBlog()
        {
            driver.FindElement(By.XPath("//*[@id=\"menu-item-1475\"]/a")).Click();
        }

        public bool BlogPageShouldDisplayed()
        {
            return driver.Url.Contains("https://loans.reteicons.com/blog/");
        }

       
    }
}
