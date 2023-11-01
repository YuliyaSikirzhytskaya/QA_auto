using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace CNNAutomation
{
    internal class CNNHomePage
    {
        IWebDriver _webDriver;
        const string HOME_URL = "https://edition.cnn.com/";

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

            IWebElement cookie = _webDriver.FindElement(By.Id("onetrust-accept-btn-handler"));
            cookie.Click();
        }

        public bool CheckPageLink(string menuPointName)
        {
            //string linkText = String.Empty;
            string keyWord = String.Empty;

            if (menuPointName == "Sports")
            {
                keyWord = "sport";
            }
            else
            {
                keyWord = menuPointName.ToLower();
            }

            //switch (menuPointName) 
            //{
            //    case "World":
            //        linkText = LINK_TEXT_WORLD;
            //        break;
            //    case "Travel":
            //        linkText = LINK_TEXT_TRAVEL;
            //        break;
            //    case "Style":
            //        linkText = LINK_TEXT_STYLE;
            //        break;
            //    case "Sport":
            //        linkText = LINK_TEXT_SPORTS;
            //        break;
            //    case "Video":
            //        linkText = LINK_TEXT_VIDEO;
            //        break;
            //    default:
            //        throw new ArgumentException("No menu point");
            //}

            //if (menuPointName == "World")
            //{
            //    linkText = LINK_TEXT_WORLD;
            //}
            //else if (menuPointName == "Travel")
            //{
            //    linkText = LINK_TEXT_TRAVEL;
            //}
            //else if (menuPointName == "Style")
            //{
            //    linkText = LINK_TEXT_STYLE;
            //}
            //else if (menuPointName == "Sport") 
            //{
            //    linkText = LINK_TEXT_SPORTS;
            //}
            //else if (menuPointName == "Video")
            //{
            //    linkText = LINK_TEXT_VIDEO;
            //}

            IWebElement menuItem = _webDriver.FindElement(By.LinkText(menuPointName));

            menuItem.Click();

            string title = _webDriver.Title;
            string url = _webDriver.Url;

            //return to homePage
            _webDriver.Url = HOME_URL;

            return title.ToLower().Contains(keyWord) && url.Contains(keyWord);
        }
    }
}
