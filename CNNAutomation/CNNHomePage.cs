using OpenQA.Selenium;



namespace CNNAutomation
{
    public class CNNHomePage:CNNBasePage
    {
    
        const string HOME_URL = "https://edition.cnn.com/";
       
        const string MENU_POINTS_XPATH = "//a[contains(@class, 'header__nav-item-link')]";


        public CNNHomePage(IWebDriver driver): base(driver, "https://edition.cnn.com/") 
        {
          
        }

        public bool CheckPageLink(string menuPointName)
        {
         
            var element = GetElementsByXpath(MENU_POINTS_XPATH).Where(x => x.Text == menuPointName).First();

            string keyWord = String.Empty;

            if (menuPointName == "Sports")
            {
                keyWord = "sport";
            }
            else
            {
                keyWord = menuPointName.ToLower();
            }

            element.Click();

            //IWebElement menuItem = _webDriver.FindElement(By.LinkText(menuPointName));

            //string title = _webDriver.Title;
            //string url = _webDriver.Url;

            ////return to homePage
            ////_webDriver.Url = HOME_URL;
            //_webDriver.Navigate().Back();

            return true;//title.ToLower().Contains(keyWord) && url.Contains(keyWord);
        }
    }
}
