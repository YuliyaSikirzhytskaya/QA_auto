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

        public MainPage(IWebDriver driver) : base(driver, driver.Url)
        {

        }

        public bool CheckLetter() 
        {
            var element = WebDriver.FindElements(By.XPath("//tr[contains(@class, 'zA zE')]")).FirstOrDefault();

            if (element != null)
            {
                element.Click();
                var title = GetElementByXpath("//h2[contains(text(), 'Hello, Frumpkin')]").Text;
                var body = GetElementByXpath("//div[contains(text(), 'Hello dear friend! I have a proposition for you.')]").Text;
                if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(body)) 
                {
                    return true;
                }
                // click входящие
                CheckLetter();
            }
            return false;
            //span[contains(@email,'prumpkintest1@gmail.com')]")
            

            
        }
    }
}
