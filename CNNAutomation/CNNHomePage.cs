using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;



namespace CNNAutomation
{
    public class CNNHomePage
    {
        IWebDriver _webDriver;
        const string HOME_URL = "https://edition.cnn.com/";
        
        WebDriverWait _wait;


        const string MENU_POINTS_XPATH = "//a[contains(@class, 'header__nav-item-link')]";

        //const string LINK_TEXT_WORLD = "World";
        //const string LINK_TEXT_TRAVEL = "Travel";
        //const string LINK_TEXT_STYLE = "Style";
        //const string LINK_TEXT_SPORTS = "Sports";
        //const string LINK_TEXT_VIDEO = "Video";


        public CNNHomePage(IWebDriver driver) 
        {
            _webDriver = driver;
            _webDriver.Url = HOME_URL;
            _webDriver.Manage().Window.Maximize();

            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            IWebElement cookie = _webDriver.FindElement(By.Id("onetrust-accept-btn-handler"));
            cookie.Click();
        }

        public bool CheckPageLink(string menuPointName)
        {
            //string realXPath = "//div[contains(@class, 'header__nav-')]";
            var menuItem = _wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//a[contains(@class, 'header__nav-item-link')]"))).Where(x => x.Displayed && x.Enabled && x.Text == menuPointName).FirstOrDefault();

            string keyWord = String.Empty;

            if (menuPointName == "Sports")
            {
                keyWord = "sport";
            }
            else
            {
                keyWord = menuPointName.ToLower();
            }

            menuItem.Click();

            //IWebElement menuItem = _webDriver.FindElement(By.LinkText(menuPointName));

            string title = _webDriver.Title;
            string url = _webDriver.Url;

            //return to homePage
            //_webDriver.Url = HOME_URL;
            _webDriver.Navigate().Back();

            return title.ToLower().Contains(keyWord) && url.Contains(keyWord);
        }
    }
}
