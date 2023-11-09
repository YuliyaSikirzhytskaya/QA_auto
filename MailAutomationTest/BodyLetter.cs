using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAutomationTest
{
    public class BodyLetter:MailBasePage
    {
        const string ADDRESS = "//form/div[2]";
        public BodyLetter(IWebDriver driver) : base(driver, driver.Url)
        {

        }

        public void PopulateAndSendLetter(string address, string title, string body) 
        {
            var element = GetElementByXpath(ADDRESS);
            
            element.SendKeys(address);
        }
    }
}
