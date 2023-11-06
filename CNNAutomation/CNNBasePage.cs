using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace CNNAutomation
{
    public abstract class CNNBasePage
    {
        IWebDriver _webDriver;

        WebDriverWait _wait;

        public CNNBasePage(IWebDriver driver,string URL)
        {
            _webDriver = driver;
            _webDriver.Url = URL;
            _webDriver.Manage().Window.Maximize();
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            IWebElement cookie = _webDriver.FindElement(By.Id("onetrust-accept-btn-handler"));
            cookie.Click();
        }

        public IReadOnlyCollection<IWebElement> GetElementsByXpath(string xpath) 
        {
            return _wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(xpath)))
                .Where(x => x.Displayed && x.Enabled).ToList();
        }

        public IWebElement GetElementByXpath(string xpath)
        {
            return _wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
        }

    }

}
