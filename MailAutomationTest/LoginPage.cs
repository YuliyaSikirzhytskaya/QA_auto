using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAutomationTest
{
    public class LoginPage : MailBasePage
    {
        public LoginPage(IWebDriver driver,string  URL) : base(driver, URL)
        {

        }

        public void FieldUpdate(string infoText,string xpath)
        {
            var element = GetElementByXpath(xpath);
            element.SendKeys(infoText);
            
        }
    }
}
