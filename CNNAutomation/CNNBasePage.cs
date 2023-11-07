using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace CNNAutomation
{
    public abstract class CNNBasePage
    {
        IWebDriver _webDriver;
        ILogger _logger;

        WebDriverWait _wait;
        const string MENU_POINTS_XPATH = "//a[contains(@class, 'header__nav-item-link')]";

        public CNNBasePage(IWebDriver driver,string URL)
        {
            _webDriver = driver;
            _webDriver.Url = URL;
            _webDriver.Manage().Window.Maximize();
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            _logger = new TextLogger("D:\\QA_auto\\CNNAutomation\\logger.txt");
            IWebElement cookie = _webDriver.FindElement(By.Id("onetrust-accept-btn-handler"));
            cookie.Click();
        }

        public IReadOnlyCollection<IWebElement> GetElementsByXpath(string xpath) 
        {
            _logger.LogMessage($" { xpath} GetElementsByXpath were found");
            return _wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(xpath)))
                .Where(x => x.Displayed && x.Enabled).ToList();
        }

        public IWebElement GetElementByXpath(string xpath)
        {
            return _wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
        }

        public bool IsTitleContains(string partialTitle) 
        {
            return _wait.Until(ExpectedConditions.TitleContains(partialTitle));
        }

        public void ClickMenuPoint(string menuPoint) 
        {

            var element = GetElementsByXpath(MENU_POINTS_XPATH).Where(x => x.Text == menuPoint).First();

            string keyWord = String.Empty;

            if (menuPoint == "Sports")
            {
                keyWord = "sport";
            }
            else
            {
                keyWord = menuPoint.ToLower();
            }
            
            if (element == null) 
            {
                _logger.LogError($"Menu point {menuPoint} not found");         
            }
            else
            { 
                _logger.LogMessage($"Menu point {menuPoint} found");
                element.Click();
            }
            
        }


    }

}
