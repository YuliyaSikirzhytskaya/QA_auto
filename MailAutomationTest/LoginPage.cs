using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.Network;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAutomationTest
{
    public class LoginPage : MailBasePage
    {
        const string ACCOUNT_BUTTON = "//a[contains(@aria-label, \"Аккаунт Google:\")]";
        const string EXIT_BUTTON = "//div[contains(text(),'Выйти')]";
        const string CHANGE_ACCOUNT = "//div[contains(text(), 'Сменить аккаунт')]";
        public LoginPage(IWebDriver driver,string  URL) : base(driver, URL)
        {

        }

        public void FieldUpdate(string infoText,string xpath)
        {
            var element = GetElementByXpath(xpath);
            element.SendKeys(infoText);
            
        }

        public void AccountExit() 
        {
            var element = GetElementByXpath(ACCOUNT_BUTTON);
            element.Click();
            
            var elm = GetElementByXpath("//a[@class='gb_d gb_Da gb_H']");
            WebDriver.Url = elm.GetAttribute("href");

            element = GetElementByXpath("//*[@id='signout']");
            element.Click();
        }

        public void ChangeAccount() 
        {
            var element = GetElementByXpath(CHANGE_ACCOUNT);
            element.Click();
            
        }
    }
}
