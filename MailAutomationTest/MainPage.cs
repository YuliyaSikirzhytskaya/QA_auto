using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAutomationTest
{
    public class MainPage : MailBasePage
    {
        const string BODY_MESSAGE_REPLY = "Hello, Prumpkin. I'm ready.";
        public MainPage(IWebDriver driver) : base(driver, driver.Url)
        {

        }

        public bool CheckLetter(int retry = 0) 
        {
            if (retry > 20) { return false; }

            var element = WebDriver.FindElements(By.XPath("//tr[contains(@class, 'zA zE')]")).FirstOrDefault();

            if (element != null)
            {
                element.Click();
                var title = GetElementByXpath("//h2[contains(text(), 'Hello, Frumpkin')]").Text;
                var body = GetElementByXpath("//div[contains(text(), 'Hello dear friend! I have a proposition for you.')]").Text;
                if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(body)) 
                {
                    GetElementByXpath("//span[contains(@class, 'ams bkH')]").Click();
                    var replyMessage = WebDriver.FindElement(By.XPath("//div[contains(@aria-label, 'Текст письма')]"));
                    replyMessage.SendKeys(BODY_MESSAGE_REPLY);
                    replyMessage.Click();
                    GetElementByXpath("//div[contains(@role, 'button') and contains(@class, 'T-I J-J5-Ji aoO v7 T-I-atl L3')]").Click();
                    return true;
                }
                GetElementByXpath("//div[contains(@data-tooltip, 'Входящие')]").Click();
                CheckLetter();
            }

            Thread.Sleep(30000);

            GetElementByXpath("//div[contains(@data-tooltip, 'Входящие')]").Click();
            CheckLetter(++retry);

            return false;
        }
    }
}
