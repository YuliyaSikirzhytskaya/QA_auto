using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;


namespace CNNAutomation
{
    public class CNNSearchPage
    {
        IWebDriver _webDriver;

        const string SEARCH_BOX_XPATH = "//input[@value]";
        const string SEARCH_BUTTON_XPATH = "//button[contains(@class, 'search__button icon icon--search')]";
        const string SEARCH_RESULTS_XPATH = "//*[@data-zjs-traits-search_term='Milan']";
        const string PAGE_URL = @"https://edition.cnn.com/search";



        WebDriverWait _wait;

        public CNNSearchPage(IWebDriver driver)
        {
            _webDriver = driver;
            _webDriver.Url = PAGE_URL;
            _webDriver.Manage().Window.Maximize();
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement cookie = _webDriver.FindElement(By.Id("onetrust-accept-btn-handler"));
            cookie.Click();
        }

        public List<string> GetSearchResults(string infoToSearch) 
        {
            var searchBox = _webDriver.FindElement(By.XPath(SEARCH_BOX_XPATH));
            searchBox.SendKeys(infoToSearch);
            var searchResults = _webDriver.FindElements(By.XPath(SEARCH_RESULTS_XPATH));
            return searchResults.Select(x => x.Text).ToList();
            
        }

    }
}
