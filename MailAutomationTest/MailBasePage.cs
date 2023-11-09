using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace MailAutomationTest
{
    public class MailBasePage
    {
        IWebDriver _webDriver;
        WebDriverWait _wait;

        const string BUTTON_LOGIN = "//a[contains(text(),'Войти')]";

        public MailBasePage(IWebDriver driver, string URL)
        {
            _webDriver = driver;
            _webDriver.Url = URL;
            _webDriver.Manage().Window.Maximize();
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //IWebElement cookie = _webDriver.FindElement(By.Id("glue-cookie-notification-bar-1"));
            //cookie.Click();

        }

        public IWebElement GetElementByXpath(string xpath)
        {
            return _wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
        }
        public void ClickButtonLogin()
        {

            var element = GetElementByXpath(BUTTON_LOGIN);
            element.Click();


        }
        public void ClickButtonLogin(string xpath)
        {

            var element = GetElementByXpath(xpath);
            element.Click();


        }
    }
}
