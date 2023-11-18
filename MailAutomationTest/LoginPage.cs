using OpenQA.Selenium;

namespace MailAutomationTest
{
    public class LoginPage : MailBasePage
    {
        const string ACCOUNT_BUTTON = "//a[contains(@aria-label, \"Аккаунт Google:\")]";
        const string EXIT_LINK = "//a[@class='gb_d gb_Da gb_H']";
        const string CHANGE_ACCOUNT = "//div[contains(text(), 'Сменить аккаунт')]";
        const string SIGNOUT_BUTTON = "//*[@id='signout']";
        public LoginPage(IWebDriver driver,string  URL) : base(driver, URL)
        {

        }

        public void FieldUpdate(string infoText,string xpath)
        {
            
            var element = GetElementByXpath(xpath);
            Thread.Sleep(3000);
            element.SendKeys(infoText);
        }

        public void AccountExit() 
        {
            var element = GetElementByXpath(ACCOUNT_BUTTON);
            element.Click();
            
            var elm = GetElementByXpath(EXIT_LINK);
            WebDriver.Url = elm.GetAttribute("href");

            element = GetElementByXpath(SIGNOUT_BUTTON);
            element.Click();
        }

        public void ChangeAccount() 
        {
            var element = GetElementByXpath(CHANGE_ACCOUNT);
            element.Click();
        }
    }
}
