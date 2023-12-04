using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;

namespace MailAutomationTest
{
    public abstract class MailBasePage
    {
        private IWebDriver _webDriver;
        private WebDriverWait _wait;
        ILogger _textLogger;
        ILogger _jsonLogger;


        public MailBasePage(IWebDriver driver, string URL)
        {
            _webDriver = driver;
            _webDriver.Url = URL;
            _webDriver.Manage().Window.Maximize();
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            _textLogger = new TextLogger("D:\\QA_auto\\MailAutomationTest\\TextFileLog.txt");
            _jsonLogger = new JsonLogger("D:\\QA_auto\\MailAutomationTest\\JsonFileLog.json");
        }
        public IWebElement GetElementByXpath(string xpath)
        {
            return _wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
        }
        
        public IWebElement FindElementByXpath(string xpath)
        {
            LogMessage($"MailBasePage {xpath} FindElementByXpath was found");
            return _webDriver.FindElement(By.XPath(xpath));
        }
        public IWebElement FindFirstElementsByXpath(string xpath)
        {
            LogMessage($"MailBasePage {xpath} FindFirstElementsByXpath was found");
            return _webDriver.FindElements(By.XPath(xpath)).FirstOrDefault();
        }
        public IWebElement FindElementByName(string name)
        {
            LogMessage($"MailBasePage {name} FindElementByName was found");
            return _webDriver.FindElement(By.Name(name));
        }
        public void WaitElementsLocatedByXpath(string xpath)
        {
            _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(xpath)));
        }
        public void WaitElementsLocatedByName(string name)
        {
            _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name(name)));
        }
        public void RedirectByUrl(string url) 
        {
            LogMessage($"MailBasePage Redirected to {url}");
            _webDriver.Url = url;
        }
        public void LogMessage(string logMessage)
        {
            _textLogger.LogMessage(logMessage);
            _jsonLogger.LogMessage(logMessage);
        }
    }
}
