using ETMoneyShopAutomation.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETMoneyShopAutomation.PageObject
{
    public class ContactUsPage
    {
        public IWebDriver driver;

        public ContactUsPage()
        {
            driver = WebHooks.driver;
        }

        //private By email = By.Id("email-ed70b2f6-1922-482f-aac9-ad9d7c6c83be");
        //private By last = By.XPath("//*[@id=\"lastname-ed70b2f6-1922-482f-aac9-ad9d7c6c83be\"]");
        //private By first = By.XPath("//*[@id=\"firstname-ed70b2f6-1922-482f-aac9-ad9d7c6c83be\"]");
        //private By text = By.XPath("//*[@id=\"message-ed70b2f6-1922-482f-aac9-ad9d7c6c83be\"]");
        //private By submit = By.XPath("//*[@id=\"hsForm_ed70b2f6-1922-482f-aac9-ad9d7c6c83be\"]/div[5]/div[2]/input");
        private By contact = By.XPath("//*[@id=\"menu-item-2327\"]/a");

        public void ClickContactUs()
        {
            driver.FindElement(contact).Click();
        }

        public bool ContactUsPageShouldDisplayed()
        {
            return driver.Url.Contains("https://loans.reteicons.com/contact-us/");
        }
        //public void EnterEmail()
        //{
        //    Random randomGenerator = new Random();
        //    int randomInt = randomGenerator.Next(100);
        //    driver.FindElement(email).SendKeys("SamsonGbenga" + randomInt + "@gmail.com");
        //}
        //public void EnterFirstname(string samson)
        //{
        //    driver.FindElement(first).SendKeys(samson);
        //}
        //public void EnterLastname(string gbenga)
        //{
        //    driver.FindElement(last).SendKeys(gbenga);
        //}
        //public void EnterMessage(string message)
        //{
        //    driver.FindElement(text).SendKeys(message);
        //}

        //public void ClickSubmit()
        //{
        //    driver.FindElement(submit).Click();
        //}








    }
}
